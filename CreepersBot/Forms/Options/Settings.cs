using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace CreepersBot
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        string path_;

        private void b_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Save?", "CreepersBot", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                if (path_ != "")
                {
                    try
                    {
                        BinaryFormatter i = new BinaryFormatter();
                        using (Stream writer = new FileStream(path_, FileMode.Create))
                        {
                            i.Serialize(writer, tb_Channel.Text);
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Пошло всё нахуй!", "Какого хуя?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                    }
                }
                Close();
            }

        }

        private void f_Settings_Load(object sender, EventArgs e){}

        private void b_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}