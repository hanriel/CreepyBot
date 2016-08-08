using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CreepyBot
{
    
    public partial class Settings : Form
    {
[Serializable]
        public class cmds
        {
            public string name, desk;
            public cmds()
            {

            }
        }
        List<cmds> cmdlist = new List<cmds>();

        _1 U = new _1();

        string _path = Properties.Settings.Default.path;

        public Settings()
        {
            InitializeComponent();
        }

        private void b_Save_Click(object sender, EventArgs e){Close();}

        /// <summary>
        /// Загружает конфигурации из файлов настроек и устанавливает их на позиции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_Settings_Load(object sender, EventArgs e)
        {
            tb_Channel.Text = Properties.Settings.Default.channel;
            tb_User.Text = Properties.Settings.Default.user;
            tb_oAuth.Text = Properties.Settings.Default.password;
            numericUpDown1.Value = Properties.Settings.Default.msgMax;
            numericUpDown2.Value = Properties.Settings.Default.msgDelay;

            saveLoad(1);


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

        /// <summary>
        /// Поучает файлы из папки /sounds
        /// </summary>
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

        /// <summary>
        /// Сохраняет все изминения в файлы настроек
        /// </summary>
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

        /// <summary>
        /// Добавляет трек в библиотеку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_sAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            File.Copy(file, $"{_path}\\sounds\\{Path.GetFileName(file)}", true);
            reloadCBox();
        }

        /// <summary>
        /// Удаляет трек из библиотеки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_removeTrack_Click(object sender, EventArgs e)
        {
            File.Delete($"{_path}\\{comboBox1.GetItemText(comboBox1.SelectedItem)}");
            reloadCBox();
        }

        /// <summary>
        /// Перезагружает треки из библиотеки
        /// </summary>
        private void reloadCBox()
        {
            comboBox1.Items.Clear();
            getFiles();
        }

        public void messag(int i)
        {
            cmds k = new cmds();
            k.name = $"Name{i}";
            k.desk = $"Detsk{i}";
            cmdlist.Add(k);
        }

        private void saveLoad(int m)
        {
            switch (m)
            {
                case 0:
                    //serialize
                    using (Stream stream = File.Open("F:\\test.cbot", FileMode.Create))
                    {
                        var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                        bformatter.Serialize(stream, cmdlist);
                    }
                    break;
                case 1:
                    //deserialize
                    using (Stream stream = File.Open("F:\\test.cbot", FileMode.Open))
                    {
                        var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        cmdlist.Clear();
                        cmdlist = (List<cmds>)bformatter.Deserialize(stream);
                        lb_cmdList.Items.Clear();
                        for (int i = 0; i < cmdlist.Count; i++)
                        {
                            lb_cmdList.Items.Add(cmdlist[i].name);
                        }
                        richTextBox1.Clear();
                        textBox1.Clear();
                    }
                    break;
                default:
                    break;
                }

        }

        private void b_cmdAdd_Click(object sender, EventArgs e)
        {
            cmds tmp = new cmds();
            
            tmp.name = textBox1.Text;
            //cmdlist.Find(tmp.name);
            tmp.desk = richTextBox1.Text;
            cmdlist.Add(tmp);
            saveLoad(0);
            saveLoad(1);
        }

        private void lb_cmdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = cmdlist[lb_cmdList.SelectedIndex].desk;
            textBox1.Text = cmdlist[lb_cmdList.SelectedIndex].name;
        }
    }
}