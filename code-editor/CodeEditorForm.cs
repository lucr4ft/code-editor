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
    internal partial class CodeEditorForm : Form
    {
        private readonly List<string> openFiles = new();
        private readonly List<EditorControl> openEditors = new();
        // private EditorControl CurrentEditor = null;

        public CodeEditorForm()
        {
            InitializeComponent();
            treeView.NodeMouseDoubleClick += TreeView_NodeMouseDoubleClick;
            treeView.NodeMouseClick += TreeView_NodeMouseClick;
            treeView.AfterLabelEdit += TreeView_AfterLabelEdit;
            treeView.MouseDown += TreeView_MouseDown;
        }

        private void TreeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(treeView, e.Location);
            }
        }

        private void TreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            // rename file in filesystem
            var parentDirectoryInfo = e.Node.Parent.Tag as DirectoryInfo;
            var directoryInfo = new DirectoryInfo(Path.Combine(parentDirectoryInfo.FullName, e.Node.Text));
            if (!directoryInfo.Exists)
            {
                // create folder
                directoryInfo.Create();
            }
            else
            {
                // rename folder
                Directory.Move((e.Node.Tag as DirectoryInfo).FullName, directoryInfo.FullName);
            }
            e.Node.Tag = directoryInfo;
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView.SelectedNode = e.Node;
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(treeView, e.Location);
            }
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
            //Debug.WriteLine(path);
            if (openFiles.Contains(path))
                return;
            openFiles.Add(path);
            

            EditorControl editor = CodeEditor.GetEditorForFile(new FileInfo(path));
            //editor.Code = File.ReadAllText(path);
            editor.Dock = DockStyle.Fill;

            openEditors.Add(editor);
            //CurrentEditor = editor;

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

        private void SaveAllToolStripMenuItem_Click(object sender, EventArgs e) => openEditors.ForEach(o => o.InvokeSave());

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CurrentEditor.Save();
            openEditors[tabControl1.SelectedIndex].InvokeSave();
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode.BeginEdit();
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            contextMenuStrip1.Hide();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentDir = CodeEditor.Current.Path;
            if (treeView.SelectedNode.Tag == null)
            {
                // its a file
                File.Delete(currentDir[..(currentDir.LastIndexOf("\\") + 1)] + treeView.SelectedNode.FullPath);
                treeView.SelectedNode.Remove();
            }
            else if (treeView.SelectedNode.Parent == null) { } // this is the project root which cannot be delete from here
            else
            {
                // its a folder
                // ask for confirmation to delete folder + all its contents
                if (MessageBox.Show("Do you want to delete this folder and all it's contents?", 
                                    $"Delete '{treeView.SelectedNode.FullPath[(treeView.SelectedNode.FullPath.IndexOf("\\") + 1)..]}'", 
                                    MessageBoxButtons.YesNoCancel, 
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Directory.Delete(currentDir[..(currentDir.LastIndexOf("\\") + 1)] + treeView.SelectedNode.FullPath, true);
                    treeView.SelectedNode.Remove();
                }
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode.Parent == null || treeView.SelectedNode.Tag != null)
            {
                // project root or folder
                var newNode = new TreeNode("New Folder");
                treeView.SelectedNode.Nodes.Add(newNode);
                treeView.SelectedNode.Expand();
                newNode.BeginEdit();
            }
        }
    }
}
