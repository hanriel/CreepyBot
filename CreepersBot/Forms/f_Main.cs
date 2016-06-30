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
        #region Old Varibles

        _1 U = new _1();
        vTw vT = new vTw();

        string AppName = Properties.Settings.Default.AppName;

        //public TcpClient irc;
        //public StreamReader Reader;
        //public StreamWriter Writer;
        //public string userName, password, channelName, chatCommandId, chatMessagePrefix;
        //public int messageDelay, lineCount;
        //public DateTime lastMessage;
        //public Queue<string> sendMessageQueue;

        #endregion Old Varibles

        #region Irs Vars

        _message cMsg = new _message();
        private TcpClient irc;
        public StreamReader Read;
        public StreamWriter Write;
        private Stream stream;
        Queue<string> msgQueue;
        DateTime msgLast;

        string host, user, password, channel, msgJoin;
        int port, msgDelay, msgMax;

        #endregion Irs Vars

        public f_Main()
        {
            Text += AppName + " v." + Application.ProductVersion;
            msgQueue = new Queue<string>();
            LoadConf();
            InitializeComponent();
            rtb_Chat.ScrollToCaret();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) { U.Exit(); }

        private void mi_Authors_Click(object sender, EventArgs e) { Authors f_authors = new Authors(); f_authors.Show(); }

        private void mi_Options_Click(object sender, EventArgs e) { Settings f_settings = new Settings(); f_settings.Show(); }

        #region OldIrc

        //public void Reconnect()
        //{
        //    mi_Connect.Enabled = false;
        //    mi_Disconnect.Enabled = true;
        //    rtb_Chat.Text += $"\r\nConnect...";
        //    irc = new TcpClient("irc.twitch.tv", 6667);
        //    Reader = new StreamReader(irc.GetStream());
        //    Writer = new StreamWriter(irc.GetStream());

        //    Writer.WriteLine("PASS " + password + Environment.NewLine
        //        + "NICK " + userName + Environment.NewLine
        //        + "USER " + userName + " 8 * :" + userName);
        //    Writer.WriteLine("JOIN #" + channelName);
        //    rtb_Chat.Text += $"\r\nJoining to {channelName} channel!";
        //    Writer.Flush();
        //    lastMessage = DateTime.Now;
        //    if (irc.Connected)
        //    {
        //        rtb_Chat.Text += $"\r\nConnected complite!\a";
        //        SendMessage(Properties.Settings.Default.JoinMessage);
        //    }
        //    else
        //    {
        //        rtb_Chat.Text += $"\r\nError connected!!";
        //    }
        //    tb_Send.Enabled = true;
        //    mi_Connect.Enabled = false;
        //    mi_Disconnect.Enabled = true;
        //    b_SendMSG.Enabled = true;
        //    timer1.Enabled = true;
        //}

        ///// <summary>
        ///// Таймер чё тут не понятно?
        ///// </summary>
        //void Update(object sender, EventArgs e)
        //{
        //    DeleteLine();
        //    if (!irc.Connected)
        //    {
        //        Reconnect();
        //    }
        //    TrySendingMessages();
        //    TryRecieveMessages();
        //    //rtb_Chat.Text += "\r\n" + Reader.ReadLine();
        //}
        //public void sSend(object sender, EventArgs e)
        //{
        //    send(tb_Send.Text);
        //    tb_Send.Clear();
        //}

        //public void button1_Click(object sender, EventArgs e)
        //{
        //    _Irc irc = new _Irc();
        //    irc.msgHand(":CreeperMenn!CreeperMenn@CreeperMenn.tmi.twitch.tv PRIVMSG #skyandforest :Hello, world!");
        //}

        //private void tb_Send_KeyPress(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        send(tb_Send.Text);
        //        tb_Send.Clear();
        //    }
        //}

        //void TrySendingMessages()
        //{
        //    if (DateTime.Now - lastMessage > TimeSpan.FromSeconds(messageDelay))
        //        if (sendMessageQueue.Count > 0)
        //        {
        //            var message = sendMessageQueue.Dequeue();
        //            send(message);
        //        }
        //}
        //void TryRecieveMessages()
        //{
        //    if (irc.Available > 0 || Reader.Peek() >= 0)
        //    {
        //        var message = Reader.ReadLine();
        //        var iCollon = message.IndexOf(":", 1);
        //        if (iCollon > 0)
        //        {
        //            string chatCommandId = "PRIVMSG";
        //            var command = message.Substring(1, iCollon);
        //            if (command.Contains(chatCommandId))
        //            {
        //                var iBang = command.IndexOf("!");
        //                if (iBang > 0)
        //                {
        //                    var speaker = command.Substring(0, iBang);
        //                    var chatMessage = message.Substring(iCollon + 1);
        //                    RecieveMessage(speaker, chatMessage);
        //                }
        //            }
        //        }
        //    }
        //}
        ///// <summary>
        ///// Выборка
        ///// </summary>
        ///// <param name="speaker">Отправитель команды</param>
        ///// <param name="message">Текст команды</param>
        //void RecieveMessage(string speaker, string message)
        //{
        //    var date = DateTime.Now.ToString("HH:mm:ss");
        //    rtb_Chat.Text += $"\r\n[{date}] {speaker}: {message}";
        //    if (message.StartsWith("HOOK") && message.Length == 4) SendMessage($"HOOK, {speaker}");
        //    if (message.StartsWith("!ip") && message.Length == 3) SendMessage($"IP: 82.193.125.32:2900 | Версия: 1.8.X , {speaker}");
        //    if (message.StartsWith("!gg") && message.Length == 3) SendMessage($"http://goodgame.ru/channel/CreeperMenn/ , {speaker}");
        //    if (message.StartsWith("DendiFace")) SendMessage($"HOOK, {speaker}");
        //}
        ///// <summary>
        ///// Отправка сообщения
        ///// </summary>
        ///// <param name="message">Сообщение для отправки</param>
        //public void SendMessage(string message) { sendMessageQueue.Enqueue(message); }
        //void send(string message)
        //{
        //    var date = DateTime.Now.ToString("HH:mm:ss");
        //    rtb_Chat.Text += $"\r\n [{date}] [BOT] {message}";
        //    Writer.WriteLine($"{chatMessagePrefix}{message}");
        //    Writer.Flush();
        //    lastMessage = DateTime.Now;
        //}

        #endregion OldIrc

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

        private void Connect(object sender, EventArgs e)
        {
            LoadConf();
            if (checkConf())
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
            else
            {
                U.MBox(2, "Ошибка подключения!");
            }

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

        private void msgSend(string message)
        {
            string prefix = $":{user}!{user}@{user}.tmi.twitch.tv PRIVMSG #{channel} :";
            Write.WriteLine($"{prefix}{message}");
            Write.Flush();
            msgLast = DateTime.Now;
        }

        void cmdList(string cmd)
        {
            string msg = cMsg.msg;
            string sender = cMsg.name;
            switch (cmd)
            {
                case "PRIVMSG":
                    
                    //!shop мячик 1000
                    //!<команда> <товар> [кол-во]
                    SendC($"{sender} : {msg}");
                    if (msg.Substring(0, 1) == "!")
                    {
                        msgSend(sender + ", привет!");
                    }
                    break;
                case "NOTICE":
                    break;
                case "JOIN":
                    U.MBox(2, sender);
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
        }

        private void onDisconnect()
        {
            mi_Connect.Enabled = true;
            mi_Disconnect.Enabled = false;
            b_Send.Enabled = false;
            tb_Send.Enabled = false;
            ircTimer.Enabled = false;
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