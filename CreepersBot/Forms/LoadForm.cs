using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreepyBot.Forms
{
    public partial class f_Load : Form
    {
        f_Main f_Main = new f_Main();
        public f_Load() {
            InitializeComponent();
            la_Info.Text += " v." + Application.ProductVersion;
            la_Name.Left = Width / 2 - la_Name.Width / 2;
            la_Info.Left = Width / 2 - la_Info.Width / 2;
            la_Dev.Left = Width / 2 - la_Dev.Width / 2;
            ll_Medieval.Left = Width / 2 - ll_Medieval.Width / 2;
            ll_SAF.Left = Width / 2 - ll_SAF.Width / 2;
            pb_logo.Left = Width / 2 - pb_logo.Width / 2;
            b_Load.Left = Width / 2 - b_Load.Width / 2;
            b_Exit.Left = Width / 2 - b_Exit.Width / 2;
        }

        private void b_Load_Click(object sender, EventArgs e)
        {
            f_Main.Show();
            Hide();
        }

        private void b_Exit_Click(object sender, EventArgs e){Application.Exit();}
        private void ll_SAF_e(object sender, LinkLabelLinkClickedEventArgs e){System.Diagnostics.Process.Start("http://skyandforest.hol.es/");}
        private void ll_MedievalCraft(object sender, LinkLabelLinkClickedEventArgs e){System.Diagnostics.Process.Start("http://vk.com/craft_medieval");}
        
    }
}
