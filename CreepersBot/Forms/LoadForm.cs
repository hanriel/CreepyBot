using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreepersBot.Forms
{
    public partial class LoadForm : Form
    {
        MainForm mF = new MainForm();
        public LoadForm() {
            InitializeComponent();
            label2.Text += Application.ProductVersion;
        }
        private void loadB_Click(object sender, EventArgs e){mF.Show();Hide();}
        private void eB_Click(object sender, EventArgs e){Application.Exit();}

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://skyandforest.hol.es/");
        }
    }
}
