using System;
using System.Collections.Generic;
using System.IO;

namespace CreepyBot.Utils
{
    public class SaveOrLoad
    {
        public SaveOrLoad()
        {
        }
        /// <summary>
        /// Сохраняет переданный обьект в бинарный файл
        /// </summary>
        /// <param name="p">Патч сохранения</param>
        /// <param name="a">Элемент для сохранения</param>
        /// <returns></returns>
        public bool ToFile(string p, object i)
        {
            try
            {
                using (Stream stream = File.Open(p, FileMode.Create))
                {
                    var bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bf.Serialize(stream, i);
                    return true;
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Ошибка записи файла:" + p); }
            return false;
        }

        /// <summary>
        /// Загружает лист из файла
        /// </summary>
        /// <param name="p">Путь к файлу</param>
        /// <returns></returns>
        public List<Settings.cmds> ListFromFile(string p)
        {
            List<Settings.cmds> cmdlist = new List<Settings.cmds>();
            try
            {
                using (Stream s = File.Open(p, FileMode.OpenOrCreate))
                {
                    var bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    cmdlist = (List<Settings.cmds>)bf.Deserialize(s);
                }
            }
            catch { }
            return cmdlist;
        }
    }
}
