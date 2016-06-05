using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace CreepersBot
{
    public partial class vTw : Form
    {
        public vTw()
        {
            InitializeComponent();
        }
        string ch;
        private void vTw_Load(object sender, EventArgs e)
        {
            string path;
            path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path += "\\Assets\\doc\\111.conf";
            try
            {
                BinaryFormatter bin = new BinaryFormatter();
                using (FileStream fs = File.OpenRead(path))
                {
                    ch = (string)bin.Deserialize(fs);
                    MessageBox.Show(ch);
                }
            }
            catch(IOException) { MessageBox.Show("Ніхуя не працює", "Ремонтуй сучка!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand); }
 
            //if (ch == null)
            //{
            //    MessageBox.Show("The Channel Name is not specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Close();
            //}
            //else {
                Uri myUri = new Uri("https://player.twitch.tv/?channel=" + ch);
                MessageBox.Show(myUri.ToString());
                webBrowser1.Url = myUri;
            //}
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
    }
}
