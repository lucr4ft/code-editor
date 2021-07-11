using Lucraft.CodeEditor;
using Lucraft.CodeEditor.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_extension
{
    public class Entry : ExtensionEntry
    {
        public new void OnEnable()
        {
            Debug.WriteLine("[Extension:TestExtension][12/12/2003 14:23.56.0456/INFO]: Enabling TestExtension...");
            CodeEditor.RegisterEditor(null);
            Debug.WriteLine("[Extension:TestExtension][12/12/2003 14:23.56.0456/INFO]: Enabled TestExtension!");
        }

        public new void OnReload()
        {
            
        }

        public new void OnDisable()
        {

        }
    }
}
