using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreepyBot_Installer
{
    public partial class Main : Form
    {

        string IPath;

        public Main()
        {
            InitializeComponent();
        }
        void openFD(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            IPath = folderBrowserDialog1.SelectedPath;
            IPath += @"\CreepyBot";
            textBox1.Text = IPath;
        }
        void install(object sender, EventArgs e)
        {
            Download d = new Download("http://creeperman8922.hol.es/", textBox1.Text);
            d.Show();
        }
    }
}
