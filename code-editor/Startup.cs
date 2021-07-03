using Lucraft.Extensions.Editor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucraft.Editor
{
    public class Startup
    {
        public static Config Configuration { get; private set; }

        public List<StartupTask> StartupTasks { get; } = new List<StartupTask>() 
        {
            new StartupTask(() => LoadConfig(), "Loading Config..."),
            new StartupTask(() => ExtensionManager.LoadExtensions(), "Loading Extensions..."),
        };

        #region StartupTasks Methods

        public static Config LoadConfig()
        {
            var config = new Config();
            string fileContent = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "lucraft\\code-editor\\config.json"));
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(fileContent);
            // TODO: set values of {config}
            return config;
        }

        #endregion
    }

    public class StartupTask : Task
    {
        public string Description { get; private init; }

        public StartupTask(Action action, string description) : base (action) 
        {
            Description = description;
        }
    }
}
