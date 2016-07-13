using System;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CreepyBot
{
    public partial class f_Main : Form
    {
        _1 U = new _1();
        string AppName = Properties.Settings.Default.AppName;

        #region Irs Vars

        bool Bshop;
        _message cMsg = new _message();
        private TcpClient irc;
        public StreamReader Read;
        public StreamWriter Write;
        private Stream stream;
        Queue<string> msgQueue;
        DateTime msgLast;
        string host, user, password, channel, msgJoin;
        int port, msgDelay, msgMax;
        bool con;
        #endregion Irs Vars

        #region Main

        public f_Main()
        {
            con = false;
            Text += AppName + " v." + Application.ProductVersion;
            msgQueue = new Queue<string>();
            LoadConf();
            InitializeComponent();
            rtb_Chat.ScrollToCaret();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            U.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void f_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (U.MBox(3, "Save?"))
            {
                if (con == true) onDisconnect();
            }
            else e.Cancel = true;
        }

        private void mi_Authors_Click(object sender, EventArgs e) { Authors f_authors = new Authors(); f_authors.Show(); }

        private void mi_Options_Click(object sender, EventArgs e) { Settings f_settings = new Settings(); f_settings.Show(); }

        #endregion Main

        #region Irc

        private void LoadConf()
        {
            host = Properties.Settings.Default.ircHost.ToLower();
            port = Properties.Settings.Default.ircPort;
            user = Properties.Settings.Default.user.ToLower();
            password = Properties.Settings.Default.password.ToLower();
            channel = Properties.Settings.Default.channel.ToLower();
            msgDelay = Properties.Settings.Default.msgDelay;
            msgMax = Properties.Settings.Default.msgMax;
            msgJoin = Properties.Settings.Default.JoinMessage;
            Bshop = Properties.Settings.Default.shop;
        }

        private bool checkConf()
        {
            if (channel != "")
            {
                if (user != "")
                {
                    if (password != "")
                    {
                        return true;
                    }
                    else { U.MBox(2, "Укажите oAuth токен!"); return false; }
                }
                else { U.MBox(2, "Укажите ваш никнеим!"); return false; }
            }
            else { U.MBox(2, "Укажите имя канала!"); return false; }
        }

        private void b_connact(object sender, EventArgs e)
        {
            LoadConf();
            if (checkConf()) Connect(); else U.MBox(2, "Ошибка подключения!");
        }

        private void Connect()
        {
                SendC("[BOT] : Conneting...");

                irc = new TcpClient(host, port);
                Read = new StreamReader(irc.GetStream());
                Write = new StreamWriter(irc.GetStream());
                stream = irc.GetStream();

                Write.WriteLine("PASS " + password + Environment.NewLine
                + "NICK " + user + Environment.NewLine
                + "USER " + user + " 8 * :" + user);
                if (ifConncect())
                {
                    SendC("[BOT] : Successfully connected!");
                }
                else
                {
                    SendC("[BOT] : Connection Error!!!");
                }
                SendC($"[BOT] : Join to the channel : {channel.ToUpper()}");
                Write.WriteLine("JOIN #" + channel);
                Write.Flush();
                msgLast = DateTime.Now;
                msgSend(msgJoin);
                onConnect();
        }

        private void Timer(object sender, EventArgs e)
        {
            DeleteLine();
            if (!ifConncect())
            {
                onDisconnect();
                U.MBox(2, "Подключение прервано!");
            }
            TrySendingMessages();
            TryRecieveMessages();
        }

        void Disconnect(object sender, EventArgs e)
        {
            onDisconnect();
        }

        void LeaveC()
        {
            Write.WriteLine("PART");
        }

        void cmdList(string cmd)
        {
            string msg = cMsg.msg;
            string sender = cMsg.name;
            switch (cmd)
            {
                case "PRIVMSG":
                    #region PRIVMSG
                    //!shop мячик 1000
                    //!<команда> <товар> [кол-во]

                    Notifications.ShowBalloonTip(3000, sender, msg, ToolTipIcon.Info);

                    SendC($"{sender} : {msg}");
                    if (msg.StartsWith("!shop") && msg.Length == 5) msgQueq("Закрыто ^_^ "+sender);
                        else
                            if (msg.StartsWith("!shop ")) msgQueq("КУПЛЕНО!");
                                else
                                    if(msg.StartsWith("!shop")&&msg.Length > 5) msgQueq("Команда не найдена! Напишите '!help' для получения списка команд.");
                    if (msg.StartsWith("!bot") && msg.Length == 4) msgQueq($"{AppName} v.{Application.ProductVersion} Alpha VoHiYo , {sender}");
                    if (msg.StartsWith("!ip") && msg.Length == 3) msgQueq($"IP:82.193.125.32:2900 SSSsss Version: 1.8.x , {sender}");
                    if (msg.StartsWith("!vk") && msg.Length == 3) msgQueq($"Group: https://vk.com/skyandforest , {sender}");
                    if (msg.StartsWith("!steam") && msg.Length == 6) msgQueq($"http://steamcommunity.com/id/creepermenn/ , {sender}");
                    if (msg.StartsWith("!request") && msg.Length == 8) msgQueq($"https://vk.com/topic-64685487_35498756 , {sender}");
                    #endregion PRIVMSG
                    break;
                case "NOTICE":
                    break;
                case "JOIN":
                    break;
                case "NICK":
                    break;
                case "QUIT":
                    break;
                case "PART":
                    break;
                case "KICK":
                    break;
                case "MODE":
                    break;
                case "PING":
                    pingSend();
                    break;
                case "ACTION":
                    break;
                case "":
                    SendC(cMsg.msg);
                    break;
                default:
                    break;
            }
        }

        #region Sending

        private void msgQueq(string message)
        {
            msgQueue.Enqueue(message);
        }

        private void msgSend(string message)
        {
            string prefix = $":{user}!{user}@{user}.tmi.twitch.tv PRIVMSG #{channel} :";
            Write.WriteLine($"{prefix}{message}");
            Write.Flush();
            SendC($"[BOT] : {message}");
            msgLast = DateTime.Now;
        }
        private void pingSend()
        {
            Write.WriteLine($"PING :tmi.twitch.tv");
            Write.Flush();
            msgLast = DateTime.Now;
        }

        #endregion Sending

        #region Msg

        public void TryRecieveMessages()
        {
            if (irc.Available > 0 || Read.Peek() >= 0)
            {
                var msgRaw = Read.ReadLine();
                cMsg.ParseToString(msgRaw);
                cmdList(cMsg.cmd);
            }
        }

        bool ifConncect()
        {
            if (irc.Connected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void TrySendingMessages()
        {
            if (DateTime.Now - msgLast > TimeSpan.FromSeconds(msgDelay))
                if (msgQueue.Count > 0)
                    msgSend(msgQueue.Dequeue());
        }

        #endregion Msg

        #region Interface

        private void eSend(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                msgSend(tb_Send.Text);
                tb_Send.Clear();
            }
        }

        private void bSend(object sender, EventArgs e)
        {
            msgSend(tb_Send.Text);
            tb_Send.Clear();
        }

        private void SendC(string msg)
        {
            var date = DateTime.Now.ToString("HH:mm:ss");
            rtb_Chat.Text += $"\r\n[{date}] {msg}";
        }
        
        private void onConnect()
        {
            tb_Send.Enabled = true;
            mi_Connect.Enabled = false;
            mi_Disconnect.Enabled = true;
            b_Send.Enabled = true;
            ircTimer.Enabled = true;
            con = true;
        }

        private void onDisconnect()
        {
            msgSend("I'll be back.. WutFace ");
            msgSend("bb");
            mi_Connect.Enabled = true;
            mi_Disconnect.Enabled = false;
            b_Send.Enabled = false;
            tb_Send.Enabled = false;
            ircTimer.Enabled = false;
            con = false;
        }

        private void DeleteLine()
        {
            for (;;)
            {
                if (rtb_Chat.Lines.Count() > Properties.Settings.Default.msgMax)
                {
                    int Count = rtb_Chat.Lines.Count();
                    int start_index = rtb_Chat.GetFirstCharIndexFromLine(0);
                    rtb_Chat.Text = rtb_Chat.Text.Remove(start_index, Count);
                }
                else break;
            }
        }

        #endregion Interface

        #endregion Irc
    }

    #region msg

public class _message
{
    public string name, cmd, channel, msg;

    public _message()
    {

    }
    public void ParseToString(string msgRaw)
    {
        name = Regex.Match(msgRaw, @"(?:[:](\S+)\!)").Groups[1].Value;
        cmd = Regex.Match(msgRaw, @"(PRIVMSG|NOTICE|JOIN|NICK|QUIT|PART|KICK|MODE|PING|ACTION)").Groups[1].Value;
        channel = Regex.Match(msgRaw, @"\#(\S+)").Groups[1].Value;
        msg = Regex.Match(msgRaw, @"(?: [:](.+)) ?$").Groups[1].Value;
    }
    public void setCTT(_message _1)
    {

    }
}
}
    #endregion msg