using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CreepyBot.Utils;
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
        SaveOrLoad SOL = new SaveOrLoad();

        string path_main = Properties.Settings.Default.path;
        string path_cmds = $"{Properties.Settings.Default.path}\\cmds.cbot";

        public Settings()
        {
            InitializeComponent();
            
        }

        private void b_Save_Click(object sender, EventArgs e){ SaveAll(); }

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

            cmdlist = SOL.FromFile(path_cmds);

            lb_cmdList.Items.Clear();
            for (int o = 0; o < cmdlist.Count; o++)
            {
                lb_cmdList.Items.Add(cmdlist[o].name);
            }


            trackBar1.Value = Notify.Default.volume;
            numericUpDown3.Value = Notify.Default.volume;
            getFiles();

            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(Notify.Default.track);
        }

        /// <summary>
        /// Поучает файлы из папки /sounds
        /// </summary>
        private void getFiles()
        {
            string[] files = Directory.GetFiles($"{path_main}\\sounds\\");
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
            File.Copy(file, $"{path_main}\\sounds\\{Path.GetFileName(file)}", true);
            reloadCBox();
        }

        /// <summary>
        /// Удаляет трек из библиотеки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_removeTrack_Click(object sender, EventArgs e)
        {
            File.Delete($"{path_main}\\{comboBox1.GetItemText(comboBox1.SelectedItem)}");
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

        private void saveLoad(int m)
        {
            switch (m)
            {
                case 0:
                    //serialize
                    using (Stream stream = File.Open($"{Properties.Settings.Default.path}\\test.cbot", FileMode.Create))
                    {
                        var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                        bformatter.Serialize(stream, cmdlist);
                    }
                    break;
                case 1:
                    //deserialize
                    try { 
                    using (Stream stream = File.Open($"{Properties.Settings.Default.path}\\test.cbot", FileMode.OpenOrCreate))
                    {
                        if (File.Exists($"{Properties.Settings.Default.path}\\test.cbot")) {
                                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                                cmdlist.Clear();
                                cmdlist = (List<cmds>)bformatter.Deserialize(stream);
                                lb_cmdList.Items.Clear();
                                for (int i = 0; i < cmdlist.Count; i++)
                                {
                                    lb_cmdList.Items.Add(cmdlist[i].name);
                                }
                        }
                    }
                    }
                    catch{ }
                    break;
                default:
                    break;
                }

        }

        private void b_cmdAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Запоните поля!!!");
            }
            else
            {
                bool b = false;
                List<cmds> tmp = new List<cmds>();
                tmp = SOL.FromFile(path_cmds);
                for (int i = 0; i < tmp.Count; i++)
                {
                    if(tmp[i].name == textBox1.Text)
                    {
                        MessageBox.Show("Такая комманда уже существует!");
                        b = true;
                        break;
                    }
                }
                if(b != true)
                {
                    cmds t = new cmds();
                    t.name = textBox1.Text;
                    t.desk = richTextBox1.Text;
                    cmdlist.Add(t);

                    SOL.ToFile(path_cmds, cmdlist);
                    cmdlist = SOL.FromFile(path_cmds);

                    lb_cmdList.Items.Clear();
                    for (int o = 0; o < cmdlist.Count; o++)
                    {
                        lb_cmdList.Items.Add(cmdlist[o].name);
                    }
                }
                
            }
        }

        private void lb_cmdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = cmdlist[lb_cmdList.SelectedIndex].desk;
            textBox1.Text = cmdlist[lb_cmdList.SelectedIndex].name;
        }

        private void b_cmdRemove_Click(object sender, EventArgs e)
        {
            if(lb_cmdList.SelectedIndex != -1)
            {
                cmdlist.RemoveAt(lb_cmdList.SelectedIndex);
                SOL.ToFile(path_cmds, cmdlist);
                cmdlist = SOL.FromFile(path_cmds);

                lb_cmdList.Items.Clear();
                for (int o = 0; o < cmdlist.Count; o++)
                {
                    lb_cmdList.Items.Add(cmdlist[o].name);
                }
            }
            else
            {
                MessageBox.Show("Выберите команду");
            }
        }
    }
}