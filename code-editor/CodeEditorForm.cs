using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucraft.CodeEditor
{
    public partial class CodeEditorForm : Form
    {
        private readonly List<string> openFiles = new();
        private readonly List<EditorControl> openEditors = new();
        private EditorControl CurrentEditor = null;

        public CodeEditorForm()
        {
            InitializeComponent();
            treeView.NodeMouseDoubleClick += TreeView_NodeMouseDoubleClick;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
        private void RestartToolStripMenuItem_Click(object sender, EventArgs e) => Application.Restart();

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // build project
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // run project
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// https://stackoverflow.com/questions/6239544/populate-treeview-with-file-system-directory-structure/6239644#6239644
        /// </summary>
        /// <param name="path"></param>
        public void ListDirectory(string path)
        {
            treeView.Nodes.Clear();

            var stack = new Stack<TreeNode>();
            var rootDirectory = new DirectoryInfo(path);
            var node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
            stack.Push(node);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                var directoryInfo = (DirectoryInfo)currentNode.Tag;
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    var childDirectoryNode = new TreeNode(directory.Name) { Tag = directory };
                    currentNode.Nodes.Add(childDirectoryNode);
                    stack.Push(childDirectoryNode);
                }
                foreach (var file in directoryInfo.GetFiles())
                    currentNode.Nodes.Add(new TreeNode(file.Name));
            }

            // expand the root node
            node.Expand();
            // prevent the root node from being collapsed
            treeView.BeforeCollapse += (object sender, TreeViewCancelEventArgs e) =>
            {
                if (e.Node.Tag == rootDirectory)
                    e.Cancel = true;
            };
            treeView.Nodes.Add(node);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public void OpenFile(string path)
        {
            Debug.WriteLine(path);
            if (openFiles.Contains(path))
                return;
            openFiles.Add(path);
            

            EditorControl editor = CodeEditor.GetEditorForFile(new FileInfo(path));
            editor.Code = File.ReadAllText(path);
            editor.Dock = DockStyle.Fill;

            openEditors.Add(editor);
            CurrentEditor = editor;

            var tabPage = new TabPage
            {
                Dock = DockStyle.Fill,
                Text = path[(path.LastIndexOf("\\")+1)..]
            };
            tabPage.Controls.Add(editor);

            tabControl1.Controls.Add(tabPage);
            tabControl1.SelectedTab = tabPage;
        }

        #region EventHandler
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // when populating the TreeView, the root directory
            // and subdirectories, their DirectoryInfo is assigned
            // to the nodes Tag object
            // only for files nothing is assigned to Node.Tag, so 
            // we know the Node represents a file, if the Tag is null
            if (e.Node.Tag == null)
            {
                // open file
                OpenFile(CodeEditor.Current.Path + e.Node.FullPath[e.Node.FullPath.IndexOf("\\")..]);
            }
        }
        #endregion

        private void SaveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openEditors.ForEach(o => o.Save());
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEditor.Save();
        }
    }
}
