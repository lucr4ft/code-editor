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
        public FileInfo File { get; init; }

        public bool IsModified { get; protected set; }

        public delegate void ModifiedDelegate();
        public delegate void SaveDelegate();

        public event ModifiedDelegate Modified;
        public event SaveDelegate Save;

        public EditorControl()
        {
        }

        public void InvokeSave()
        {
            Save?.Invoke();
        }
    }
}
