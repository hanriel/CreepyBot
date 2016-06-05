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
        public String ver = "0.2 aplha";

        vTw vT = new vTw();
        Settings options = new Settings();

        public void about(){
            MessageBox.Show("Thank you for using CreepersBot ver " + ver);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            about();
        } 

        private void exitMB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutMB_Click(object sender, EventArgs e)
        {
            about();
        }

        private void N_MDC(object sender, MouseEventArgs e){}
        private void timer1_Tick(object sender, EventArgs e){}
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
    }

 
}
