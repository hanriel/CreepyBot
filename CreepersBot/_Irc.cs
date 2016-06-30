using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CreepyBot.Forms;

namespace CreepyBot
{
    class _Irc
    {

        _message cMsg = new _message();

        public TcpClient irc;
        public StreamReader Read;
        public StreamWriter Write;
        public Stream stream;
        public Queue<string> sendMessageQueue;

        string host, user, password, channel;
        int port, msgDelay, msgMax;

        /// <summary>
        /// Инилизация класса
        /// </summary>
        public _Irc() { }

        /// <summary>
        /// Подгрузить конфигурации
        /// </summary>
        private void LoadConf()
        {
            host = Properties.Settings.Default.ircHost.ToLower();
            port = Properties.Settings.Default.ircPort;
            user = Properties.Settings.Default.user.ToLower();
            password = Properties.Settings.Default.password.ToLower();
            channel = Properties.Settings.Default.channel.ToLower();
            msgDelay = Properties.Settings.Default.msgDelay;
            msgMax = Properties.Settings.Default.msgMax;
        }

        /// <summary>
        /// Подключение к серверу
        /// </summary>
        private void Connect()
        {
            LoadConf();
            irc = new TcpClient(host, port);
            Read = new StreamReader(irc.GetStream());
            Write = new StreamWriter(irc.GetStream());
            stream = irc.GetStream();

        }

        /// <summary>
        /// Проверка на текущее подключение
        /// </summary>
        /// <returns>Подключено\Не подключено</returns>
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

        /// <summary>
        /// Отключение от сервера
        /// </summary>
        void Disconnect()
        {

        }

        /// <summary>
        /// Отключение от сервера
        /// </summary>
        void LeaveC()
        {
            Write.WriteLine("PART");
        }

        /// <summary>
        /// Отправка сообщения в "консолью"
        /// </summary>
        private void SendC()
        {

        }

        /// <summary>
        /// Отправка сообщения на сервер
        /// </summary>
        private void Send()
        {

        }

        //:name!name@name.tmi.twitch.tv PRIVMSG #channelName :String

        public void msgHand(string msgRaw)
        {
            cMsg.ParseToString(msgRaw);
            cmdList(cMsg.cmd);
        }

        void cmdList(string cmd) {
            switch (cmd)
            {
                case "PRIVMSG":
                    //!shop мячик 1000
                    //!<команда> <товар> [кол-во]
                    rtb_Chat.Text += $"\r\n{cMsg.name}: {cMsg.msg}";

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
                    break;
                case "ACTION":
                    break;
                default:
                    break;
            }
        }
    }
}
class _message
{
    public string name, cmd, channel, msg;
    public _message()
    {

    }
    public void ParseToString(string msg)
    {
        name = Regex.Match(msg, @"(?:[:](\S+)\!)").Groups[1].Value;
        cmd = Regex.Match(msg, @"(PRIVMSG|NOTICE|JOIN|NICK|QUIT|PART|KICK|MODE|PING|ACTION)").Groups[1].Value;
        channel = Regex.Match(msg, @"\#(\S+)").Groups[1].Value;
        msg = Regex.Match(msg, @"(?: [:](.+)) ?$").Groups[1].Value;
    }
}
