using System;
using System.Windows.Forms;

namespace CreepyBot
{
    public partial class Settings : Form
    {
        _1 U = new _1();

        public Settings()
        {
            InitializeComponent();
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            if (U.MBox(1, ""))
            {
                Properties.Settings.Default.channel = tb_Channel.Text;
                Properties.Settings.Default.user = tb_User.Text;
                Properties.Settings.Default.password = tb_oAuth.Text;
                Properties.Settings.Default.msgMax = (int)numericUpDown1.Value;
                Properties.Settings.Default.msgDelay = (int)numericUpDown2.Value;
                Properties.Settings.Default.Save();

                Close();
            }

        }

        private void f_Settings_Load(object sender, EventArgs e){
            tb_Channel.Text = Properties.Settings.Default.channel;
            tb_User.Text = Properties.Settings.Default.user;
            tb_oAuth.Text = Properties.Settings.Default.password;
            numericUpDown1.Value = Properties.Settings.Default.msgMax;
            numericUpDown2.Value = Properties.Settings.Default.msgDelay;
        }

        private void b_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}