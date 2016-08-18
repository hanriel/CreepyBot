using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreepyBot
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = Application.StartupPath;
            Properties.Settings.Default.path = path;
            if (!Directory.Exists($"{path}\\sounds"))
            {
                Directory.CreateDirectory($"{path}\\sounds");
            }
            Application.Run(new Forms.f_Load());
        }
    }
}
