using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    }
}
