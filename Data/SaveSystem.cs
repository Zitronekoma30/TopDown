using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Races.Entities;
using Races.Data;

namespace Races.Data
{
    static class SaveSystem
    {
        public static void SavePlayer(Player player)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = AppDomain.CurrentDomain.BaseDirectory + "/save.sav";
            FileStream stream = new FileStream(path, FileMode.Create);

            PlayerSave save = new PlayerSave(player);

            formatter.Serialize(stream, save);
            stream.Close();
        }

        public static PlayerSave LoadPlayer()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "/save.sav";
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                PlayerSave save = (PlayerSave) formatter.Deserialize(stream);
                stream.Close();

                return save;
            }
            else
            {
                return null;
            }
        }
    }
}
