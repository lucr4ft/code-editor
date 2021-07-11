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
        #region Fields
        private readonly List<string> openFiles = new();
        private readonly List<EditorControl> openEditors = new();
        #endregion

        public CodeEditorForm()
        {
            InitializeComponent();
            treeView.NodeMouseDoubleClick += TreeView_NodeMouseDoubleClick;
            treeView.NodeMouseClick += TreeView_NodeMouseClick;
            treeView.AfterLabelEdit += TreeView_AfterLabelEdit;
            treeView.MouseDown += TreeView_MouseDown;
        }

        #region TreeView EventHandler
        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is FileInfo) Open(e.Node);
        }
        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView.SelectedNode = e.Node;
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(treeView, e.Location);
            }
        }
        private void TreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            // rename file in filesystem
            var parentDirectoryInfo = e.Node.Parent.Tag as DirectoryInfo;
            var directoryInfo = new DirectoryInfo(Path.Combine(parentDirectoryInfo.FullName, e.Label ?? CodeEditor.DefaultFolderName));
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
        private void TreeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(treeView, e.Location);
            }
        }
        #endregion

        #region MenuStrip OnClick Methods

        #region MenuItem File

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
        private void RestartToolStripMenuItem_Click(object sender, EventArgs e) => Application.Restart();
        private void SaveAllToolStripMenuItem_Click(object sender, EventArgs e) => openEditors.ForEach(o => o.InvokeSave());
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => openEditors[tabControl.SelectedIndex].InvokeSave();

        #endregion

        #endregion

        #region TreeView ContextMenuStrip EventHandler

        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e) => NewFile();
        private void NewFolderToolStripMenuItem_Click(object sender, EventArgs e) => NewFolder();
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e) => Open(treeView.SelectedNode);
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) => Delete(treeView.SelectedNode);
        private void RenameToolStripMenuItem_Click(object sender, EventArgs e) => treeView.SelectedNode.BeginEdit();

        #endregion

        #region Methods

        public void NewFile()
        {
            // TODO
        }
        public void NewFolder()
        {
            if (treeView.SelectedNode.Tag is DirectoryInfo)
            {
                // project root or folder
                var newNode = new TreeNode(CodeEditor.DefaultFolderName);
                treeView.SelectedNode.Nodes.Add(newNode);
                treeView.SelectedNode.Expand();
                newNode.BeginEdit();
            }
        }

        public void Open(TreeNode file)
        {
            string path = (file.Tag as FileInfo).FullName;

            if (openFiles.Contains(path))
            {
                tabControl.SelectedIndex = openFiles.IndexOf(path);
                return;
            }
            
            EditorControl editor = CodeEditor.GetEditorForFile(file.Tag as FileInfo);

            openFiles.Add(path);
            openEditors.Add(editor);

            var tabPage = new TabPage
            {
                Dock = DockStyle.Fill,
                Text = path[(path.LastIndexOf("\\") + 1)..]
            };
            tabPage.Controls.Add(editor);

            tabControl.Controls.Add(tabPage);
            tabControl.SelectedTab = tabPage;
        }

        public void Copy(TreeNode node) { }
        public void CopyFile() { }
        public void CopyFolder() { }

        public void CutFile() { }
        public void CutFolder() { }

        public void Delete(TreeNode node)
        {
            if (node.Tag is FileInfo)           DeleteFile(node);
            else if (node.Tag is DirectoryInfo) DeleteFolder(node);
        }
        private void DeleteFile(TreeNode file)
        {
            (file.Tag as FileInfo).Delete();
            file.Remove();
        }
        private void DeleteFolder(TreeNode folder)
        {
            if (MessageBox.Show("Do you want to delete this folder and all it's contents?",
                                    $"Delete '{folder.Text}'",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                (folder.Tag as DirectoryInfo).Delete();
                folder.Remove();
            }
        }

        public void RenameFileOrFolder() { }


        #endregion

        #region Load, Open, List Methods

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
                    currentNode.Nodes.Add(new TreeNode(file.Name) { Tag = file });
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

        #endregion

        
    }
}
