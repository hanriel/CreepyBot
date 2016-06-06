using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreepersBot
{
    public partial class f_Main : Form
    {
        vTw vT = new vTw();
        Settings f_settings = new Settings();
        Forms.About.Authors f_authors = new Forms.About.Authors();
        string path_;

        public f_Main()
        {
            InitializeComponent();
        }

        private void exitMB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void hell()
        {
            path_ = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path_ += "\\Assets\\sound\\IOSYS.wav";
            playSound(path_);
        }

        public void playSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

        private void opt_Click(object sender, EventArgs e)
        {
            f_settings.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mi_Authors_Click(object sender, EventArgs e)
        {
            f_authors.Show();
        }
    }

 
}
