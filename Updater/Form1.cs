using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class f_Main : Form
    {
        public f_Main()
        {
            InitializeComponent();
            Download("http://creeperman8922.hol.es/bot/latest/CreepyBot.exe", $"{Application.StartupPath}\\CreepyBot.exe");
        }
        public void Download(string a, string p)
        {
            InitializeComponent();
            WebClient wc = new WebClient();
            Uri uri = new Uri(a);
            label1.Text = a;
            wc.DownloadFileCompleted += client_DownloadDataCompleted;
            wc.DownloadFile(uri, p);
            Console.WriteLine("Download");
        }
        
        void client_DownloadDataCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Complite Download");
            var info = new FileInfo($"{Application.StartupPath}\\CreepyBot.exe");
            System.Diagnostics.Process.Start($"{Application.StartupPath}\\CreepyBot.exe");
            Close();
        }
    }
}
