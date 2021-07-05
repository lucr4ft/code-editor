using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucraft.CodeEditor
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class CodeEditor
    {
        private static CodeEditorForm codeEditorForm;
        public static Config Config { get; set; }

        public static Project Current { get; private set; }

        public static bool RegisterEditor(object editor) => false;

        public static EditorControl GetEditorForFile(string file) => new DefaultEditor();

        /// <summary>
        /// 
        /// </summary>
        public static void Start()
        {
            codeEditorForm = new CodeEditorForm();
            var project = new Project() { Path = Config.CurrentProjectPath };
            OpenProject(project);
            Application.Run(codeEditorForm);
        }

        private static void OpenProject(Project project)
        {
            if (Current != null)
                CloseProject(Current);
            Current = project;
            codeEditorForm.ListDirectory(project.Path);
        }

        private static void CloseProject(Project project)
        {
            // do something
            // - save files
            // - cleanup
        }
    }
}
