using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yshot_bydjeta
{
    internal class desir
    {
        public static string desktop = Environment.GetFolderPath((Environment.SpecialFolder.Desktop));
        public static void MySerialeze<T>(T pers)
        {
            string json = JsonConvert.SerializeObject(pers);
            File.WriteAllText(desktop + "\\ychot.json", json);
        }

        public static T MyDesirialize<T>()
        {
            string json = File.ReadAllText(desktop + "\\ychot.json");
            T type = JsonConvert.DeserializeObject<T>(json);
            return type;
        }
    }
}
