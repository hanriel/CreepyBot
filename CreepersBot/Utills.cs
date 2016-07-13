using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

/// <summary>
/// Utils class
/// </summary>

namespace CreepyBot
{
    class _1
    {

        public _1() { }

        public void Exit()
        {
            Application.Exit();
        }

        public bool SaveD()
        {
            MessageBox.Show("Save?", "CreepersBot", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            return true;
        }
        public bool ExitD()
        {
            MessageBox.Show("Exit?", "CreepersBot", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            return true;
        }

        public bool MBox(int type, string msg)
        {
            if (type == 1)
            {
                if (MessageBox.Show("Save?", "CreepersBot", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK) return true;
                else return false;
            }
            if (type == 2)
            {
                MessageBox.Show(msg, "Ошибка!?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                return true;
            }
            if (type == 3)
            {
                if (MessageBox.Show("Exit?", "CreepersBot", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK) return true;
                else return false;
            }
            else
                {
                    return false;
                }
        }
    }
}