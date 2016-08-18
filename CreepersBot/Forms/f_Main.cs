using System;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using WMPLib;
using System.Net;
using Newtonsoft.Json;
using CreepyBot.Utils;

namespace CreepyBot
{
    public partial class f_Main : Form
    {
        #region Irs Vars

        _1 U = new _1();
        string AppName = Properties.Settings.Default.AppName;

        string path_cmds = $"{Properties.Settings.Default.path}\\cmds.cbot";

        string path = Properties.Settings.Default.path;

        SaveOrLoad SOL = new SaveOrLoad();
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

        private void mi_Exit_e(object sender, EventArgs e)
        {
            Close();
        }

        private void f_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (U.MBox(3, "Exit?"))
            {
                if (con == true) onDisconnect();
            }
            else e.Cancel = true;
        }

        private void mi_Authors_Click(object sender, EventArgs e) { Authors f_authors = new Authors(); f_authors.Show(); }

        private void mi_Settings_Click(object sender, EventArgs e) { Settings f_settings = new Settings(); f_settings.ShowDialog(); }

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
            rtb_Chat.Text += "Conneting...";
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
            rtb_Chat.ScrollToCaret();
            DeleteLine();
            TrySendingMessages();
            TryRecieveMessages();
        }

        void Disconnect(object sender, EventArgs e){onDisconnect();}

        void cmdList(string cmd)
        {
            string msg = cMsg.msg;
            string sender = cMsg.name;
            switch (cmd)
            {
                case "PRIVMSG":
                    #region PRIVMSG
                    SendC($"{sender} : {msg}");
                    path += $"\\sounds\\{Notify.Default.track}";
                    if (Notify.Default.track != "")
                    {
                        U.PlayFile(path);
                    }

                    List<Settings.cmds> tmp = new List<Settings.cmds>();
                    tmp = SOL.FromFile(path_cmds);
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        if (tmp[i].name == msg)
                        {
                            msgQueq(tmp[i].desk); 
                            break;
                        }
                    }

                    if (msg.StartsWith("!bot") && msg.Length == 4) msgQueq($"{AppName} v.{Application.ProductVersion} Alpha VoHiYo , CreeperMenn © 2016");
                    //if (msg.StartsWith("!steam") && msg.Length == 6) msgQueq($"{sender}, http://goo.gl/aAXyDT");
                    //if (msg.StartsWith("!vk") && msg.Length == 3) msgQueq($"{sender}, https://goo.gl/QB5aia");
                    //if (msg.StartsWith("!donate") && msg.Length == 7) msgQueq($"{sender}, https://goo.gl/it1u3g");
                    //if (msg.StartsWith("!osu") && msg.Length == 4) msgQueq($"{sender}, https://goo.gl/R43ALu");

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
                    int Count = rtb_Chat.Lines[1].Length;
                    int start_index = rtb_Chat.GetFirstCharIndexFromLine(0);
                    rtb_Chat.Text = rtb_Chat.Text.Remove(start_index, Count);
                }
                else break;
            }
        }

        #endregion Interface

        private void aUpdate(object sender, EventArgs e)
        {
            using (WebClient c = new WebClient())
            {
                var s = c.DownloadString("http://creeperman8922.hol.es/ver.cbt");
                if(s != Application.ProductVersion)
                {
                    if (MessageBox.Show("Available New Update!\n\rWould you like to download it ?", "CreepersBot", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start($"{path}\\Updater.exe");
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                }
            }
        }

        #endregion Irc
    }

    #region msg

    public class _message
    {
        public string name, cmd, channel, msg;
        public _message(){}
        public void ParseToString(string msgRaw)
        {
            name = Regex.Match(msgRaw, @"(?:[:](\S+)\!)").Groups[1].Value;
            cmd = Regex.Match(msgRaw, @"(PRIVMSG|NOTICE|JOIN|NICK|QUIT|PART|KICK|MODE|PING|ACTION)").Groups[1].Value;
            channel = Regex.Match(msgRaw, @"\#(\S+)").Groups[1].Value;
            msg = Regex.Match(msgRaw, @"(?: [:](.+)) ?$").Groups[1].Value;
        }
    }
    #endregion msg
}