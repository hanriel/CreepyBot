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

namespace CreepyBot_Installer
{
    public partial class Download : Form
    {
        string path;
        public Download(string a, string p)
        {
            path = p;
            
            InitializeComponent();
            label1.Text = a;
            WebClient wc = new WebClient();
            Uri uri = new Uri(a);

            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
            wc.DownloadDataCompleted += new DownloadDataCompletedEventHandler(client_DownloadDataCompleted);
            wc.DownloadFileAsync(uri, path);
        }

        void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            Close();
        }

        public void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            pb_1.Value = e.ProgressPercentage;
        }
    }
}
