using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucraft.CodeEditor
{
    public class Project
    {
        public string Name { get; init; }
        [JsonProperty("current_project")]
        public string Path { get; init; }
        public string Type { get; init; }
    }
}
