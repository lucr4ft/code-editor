using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lucraft.CodeEditor
{
    /// <summary>
    /// 
    /// </summary>
    public class Config
    {
        [JsonProperty("projects")]          public List<Project> Projects { get; set; }
        [JsonProperty("current_project")]   public string CurrentProjectPath { get; set; }
        [JsonProperty("extensions")]        public List<Extension> Extensions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static void Load()
        {
            string fileContent = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "lucraft", "code-editor", "config.json"));
            CodeEditor.Config = JsonConvert.DeserializeObject<Config>(fileContent);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            // TODO: implement saving
        }
    }
}
