using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucraft.Editor
{
    public class Config
    {
        public IList<Project> Projects { get; set; }
        public Project Current { get; set; }

        public string Version { get; set; }

        public string Theme { get; set; }
        public string Language { get; set; }
        public Font FontGeneral { get; set; }
        public Font FontEditor { get; set; }

        public static void Load()
        {
            string fileContent = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "lucraft\\code-editor\\config.json"));
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(fileContent);
            // TODO: set values of {config}
        }

        public static void Save()
        {
            // TODO: implement saving
        }
    }
}
