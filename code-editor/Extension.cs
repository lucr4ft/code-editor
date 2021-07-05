using Lucraft.CodeEditor.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lucraft.CodeEditor
{
    public class Extension
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Version { get; set; }
        [JsonProperty("assembly")]
        public string AssemblyName { get; set; }
        [JsonProperty("entry")]
        public string EntryPoint { get; set; }
        public ExtensionEntry Entry { get; set; }
    }
}
