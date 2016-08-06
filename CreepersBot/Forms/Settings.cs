using System;
using System.IO;
using System.Windows.Forms;

namespace CreepyBot
{
    public partial class Settings : Form
    {
        _1 U = new _1();

        string _path = Properties.Settings.Default.path;

        public Settings()
        {
            InitializeComponent();
        }

        private void b_Save_Click(object sender, EventArgs e){Close();}

        private void f_Settings_Load(object sender, EventArgs e)
        {
            tb_Channel.Text = Properties.Settings.Default.channel;
            tb_User.Text = Properties.Settings.Default.user;
            tb_oAuth.Text = Properties.Settings.Default.password;
            numericUpDown1.Value = Properties.Settings.Default.msgMax;
            numericUpDown2.Value = Properties.Settings.Default.msgDelay;

            trackBar1.Value = Notify.Default.volume;
            numericUpDown3.Value = Notify.Default.volume;
            getFiles();

            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(Notify.Default.track);
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (U.MBox(1, "Save?")) SaveAll();
            else e.Cancel = true;
        }

        private void getFiles()
        {
            string[] files = Directory.GetFiles($"{_path}\\sounds\\");
            for (int i = 0; i < files.Length; i++)
            {
                comboBox1.Items.Add(Path.GetFileName(files[i]));
            }
        }

        //Volume syns
        private void trackBar1_Scroll(object sender, EventArgs e){numericUpDown3.Value = trackBar1.Value;}
        private void numericUpDown3_ValueChanged(object sender, EventArgs e){trackBar1.Value = Convert.ToInt32(numericUpDown3.Value);}

        private void SaveAll()
        {
            Properties.Settings.Default.channel = tb_Channel.Text;
            Properties.Settings.Default.user = tb_User.Text;
            Properties.Settings.Default.password = tb_oAuth.Text;
            Properties.Settings.Default.msgMax = (int)numericUpDown1.Value;
            Properties.Settings.Default.msgDelay = (int)numericUpDown2.Value;

            //Notify settins
            Notify.Default.volume = trackBar1.Value;
            Notify.Default.track = comboBox1.GetItemText(comboBox1.SelectedItem);

            Notify.Default.Save();
            Properties.Settings.Default.Save();
        }

        private void b_sAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            File.Copy(file, $"{_path}\\sounds\\{Path.GetFileName(file)}", true);
            comboBox1.Items.Clear();
            getFiles();
        }

        private void la_Volume_Click(object sender, EventArgs e)
        {

        }
    }
}