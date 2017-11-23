using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using WMPLib;

/// <summary>
/// Utils class
/// </summary>

namespace CreepyBot
{
    class _1
    {
        WMPLib.WindowsMediaPlayer Player;
        public _1()
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.MediaError += new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
        }

        
        
        public void PlayFile(string p){Player.URL = p; Player.settings.volume = Notify.Default.volume; Player.controls.play();}

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Exit()
        {
            Application.Exit();
        }

        public bool SaveD()
        {
            if (MessageBox.Show("Save?", "CreepersBot", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK) return true;
            else return false;
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