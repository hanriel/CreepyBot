using System;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Collections.Generic;

namespace CreepyBot
{
    public partial class f_Main : Form
    {
        _1 U = new _1();
        vTw vT = new vTw();
        Authors f_authors = new Authors();
        string AppName = Properties.Settings.Default.AppName;
        TcpClient tcpClient;
        StreamReader Reader;
        StreamWriter Writer;
        readonly string userName, password, channelName, chatCommandId, chatMessagePrefix;
        DateTime lastMessage;
        Queue<string> sendMessageQueue;

        public f_Main()
        {
            Text += AppName + " v." + Application.ProductVersion;
            sendMessageQueue = new Queue<string>();
            this.userName = Properties.Settings.Default.User.ToLower();
            this.channelName = Properties.Settings.Default.channel.ToLower();
            this.password = Properties.Settings.Default.oAuth;
            chatCommandId = "PRIVMSG";
            chatMessagePrefix = $":{userName}!{userName}@{userName}.tmi.twitch.tv {chatCommandId} #{channelName} :";
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) { U.Exit(); }

        private void mi_Authors_Click(object sender, EventArgs e) { f_authors.Show(); }

        private void mi_Options_Click(object sender, EventArgs e) { Settings f_settings = new Settings(); f_settings.Show(); }

        public void sConnect(object sender, EventArgs e)
        {
            mi_Connect.Enabled = false;
            mi_Disconnect.Enabled = true;
            b_SendMSG.Enabled = true;
            Reconnect();
            timer1.Enabled = true;
        }
        public void sDisconnect(object sender, EventArgs e)
        {
            mi_Connect.Enabled = true;
            mi_Disconnect.Enabled = false;
            b_SendMSG.Enabled = false;
            timer1.Enabled = false;
        }
        public void sSend()
        {
            MessageBox.Show(tb_Send.Text);
            SendMessage(tb_Send.Text);
        }
        /// <summary>
        /// Подключение
        /// </summary>
        public void Reconnect()
        {
            tcpClient = new TcpClient("irc.twitch.tv", 6667);
            Reader = new StreamReader(tcpClient.GetStream());
            Writer = new StreamWriter(tcpClient.GetStream());

            rtb_Chat.Text += $"\r\nConnect...";

            Writer.WriteLine("PASS " + password + Environment.NewLine
                + "NICK " + userName + Environment.NewLine
                + "USER " + userName + " 8 * :" + userName);
            Writer.WriteLine("JOIN #" + channelName);
            rtb_Chat.Text += $"\r\nJoining to {channelName} channel!";
            Writer.Flush();
            lastMessage = DateTime.Now;
            rtb_Chat.Text += $"\r\nConnected complite!";
        }

        /// <summary>
        /// Таймер чё тут не понятно?
        /// </summary>
        void Update(object sender, EventArgs e)
        {
            if (!tcpClient.Connected)
            {
                Reconnect();
            }
            TrySendingMessages();
            TryRecieveMessages();
        }
        void TrySendingMessages()
        {
            if (DateTime.Now - lastMessage > TimeSpan.FromSeconds(1))
                if (sendMessageQueue.Count > 0)
                {
                    var message = sendMessageQueue.Dequeue();
                    Writer.WriteLine($"{chatMessagePrefix}{message}");
                    Writer.Flush();
                    lastMessage = DateTime.Now;
                }
        }
        void TryRecieveMessages()
        {
            if (tcpClient.Available > 0 || Reader.Peek() >= 0)
            {
                var message = Reader.ReadLine();
                var iCollon = message.IndexOf(":", 1);
                if (iCollon > 0)
                {
                    var command = message.Substring(1, iCollon);
                    if (command.Contains(chatCommandId))
                    {
                        var iBang = command.IndexOf("!");
                        if (iBang > 0)
                        {
                            var speaker = command.Substring(0, iBang);
                            var chatMessage = message.Substring(iCollon + 1);

                            RecieveMessage(speaker, chatMessage);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Проверка на содержание команды
        /// </summary>
        /// <param name="speaker">Отправитель команды</param>
        /// <param name="message">Текст команды</param>
        void RecieveMessage(string speaker, string message)
        {
            var date = DateTime.Now.ToString("HH:mm:ss");
            rtb_Chat.Text += $"\r\n[{date}]{speaker}: {message}";
            if (message.StartsWith("!hi") && message.Length == 3) SendMessage($"Hello, {speaker}");
            if (message.StartsWith("!ip") && message.Length == 3) SendMessage($"IP:46.146.230.133:2900 | Версия: 1.8.X , {speaker}");
            if (message.StartsWith("!gg") && message.Length == 3) SendMessage($"GoogGame channel: http://goodgame.ru/channel/CreeperMenn/, {speaker}");

        }

        /// <summary>
        /// Отправка сообщения
        /// </summary>
        /// <param name="message">Сообщение для отправки</param>
        public void SendMessage(string message)
        {
            sendMessageQueue.Enqueue(message);
        }
    }
}
