using Lucraft.Extensions.Editor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucraft.Editor
{
    public class Startup
    {
        public static Config Configuration { get; private set; }

        private static List<StartupTask> StartupTasks { get; } = new List<StartupTask>() 
        {
            new StartupTask(() => Config.Load(), "Loading Config..."),
            new StartupTask(() => ExtensionManager.LoadExtensions(), "Loading Extensions..."),
        };

        private delegate void Update();

        public static void Start(ProgressBar progressBar)
        {
            Update updateMaximum = delegate { progressBar.Maximum = StartupTasks.Count; };
            Update updateValue = delegate { progressBar.Value += 1; };

            progressBar?.Invoke(updateMaximum);

            for (int i = 0; i < StartupTasks.Count; i++)
            {
                Task.Run(() => StartupTasks[i]).Wait();
                progressBar?.Invoke(updateValue);
            }
        }
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
