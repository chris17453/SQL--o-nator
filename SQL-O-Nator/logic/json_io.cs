using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace SQL_O_Nator.logic {
    //This guy does all the reading writing of objects to json... Just deal with it

    public class json_io<T> where T : new() {
        private const string DEFAULT_FILENAME = "settings.json";
        public string filename=null;

        public void Save(){
            if(string.IsNullOrWhiteSpace(filename)) filename=DEFAULT_FILENAME;
            File.WriteAllText(filename, JsonConvert.SerializeObject(this));
        }

        public static void Save(T pSettings, string fileName = DEFAULT_FILENAME) {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(pSettings));
        }

        public static T Load(string fileName = DEFAULT_FILENAME) {
            T t = new T();
            if(File.Exists(fileName)) {
                t = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
            }
            return t;
        }
    }
}
