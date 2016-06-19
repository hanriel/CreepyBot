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
            if (U.MBox("1"))
            {
                Properties.Settings.Default.channel = tb_Channel.Text;
                Properties.Settings.Default.User = tb_User.Text;
                Properties.Settings.Default.oAuth = tb_oAuth.Text;
                Properties.Settings.Default.Save();
                Close();
            }

        }

        private void f_Settings_Load(object sender, EventArgs e){
            tb_Channel.Text = Properties.Settings.Default.channel;
            tb_User.Text = Properties.Settings.Default.User;
            tb_oAuth.Text = Properties.Settings.Default.oAuth;
        }

        private void b_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}