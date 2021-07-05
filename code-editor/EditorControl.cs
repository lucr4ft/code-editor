using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucraft.CodeEditor
{
    public abstract class EditorControl : UserControl
    {
        public string Code { get; set; }
        public FileInfo File { get; init; }

        public EditorControl()
        {
        }

        public void LoadCode()
        {
            Code = System.IO.File.ReadAllText(File.FullName);
        }

        public void Save()
        {
            System.IO.File.WriteAllText(File.FullName, Code);
        }
    }
}
