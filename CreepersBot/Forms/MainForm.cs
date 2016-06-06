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
    public partial class MainForm : Form
    {
        vTw vT = new vTw();
        Settings options = new Settings();

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitMB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void playSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();      
        }

        public void hell()
        {
            string path;
            path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path += "\\Assets\\sound\\IOSYS.wav";
            playSound(path);
        }

        private void vTw_Click(object sender, EventArgs e)
        {
            vT.Show();
        }

        private void mlg_Click(object sender, EventArgs e)
        {
            hell();
        }

        private void opt_Click(object sender, EventArgs e)
        {
            options.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

 
}
