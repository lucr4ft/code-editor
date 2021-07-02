
namespace Lucraft.Editor
{
    partial class EditorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sdfsdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.extensionsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.recentProjectsToolStripMenuItem,
            this.toolStripSeparator2,
            this.refreshF5ToolStripMenuItem,
            this.toolStripSeparator3,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.toolStripSeparator1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.projectToolStripMenuItem.Text = "Project...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open Project...";
            // 
            // recentProjectsToolStripMenuItem
            // 
            this.recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
            this.recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.recentProjectsToolStripMenuItem.Text = "Recent Projects";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // refreshF5ToolStripMenuItem
            // 
            this.refreshF5ToolStripMenuItem.Name = "refreshF5ToolStripMenuItem";
            this.refreshF5ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.refreshF5ToolStripMenuItem.Text = "Refresh (F5)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(152, 6);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit (Alt+F4)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildProjectToolStripMenuItem,
            this.rebuildProjectToolStripMenuItem,
            this.cleanProjectToolStripMenuItem});
            this.buildToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // buildProjectToolStripMenuItem
            // 
            this.buildProjectToolStripMenuItem.Name = "buildProjectToolStripMenuItem";
            this.buildProjectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.buildProjectToolStripMenuItem.Text = "Build Project";
            // 
            // rebuildProjectToolStripMenuItem
            // 
            this.rebuildProjectToolStripMenuItem.Name = "rebuildProjectToolStripMenuItem";
            this.rebuildProjectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.rebuildProjectToolStripMenuItem.Text = "Rebuild Project";
            // 
            // cleanProjectToolStripMenuItem
            // 
            this.cleanProjectToolStripMenuItem.Name = "cleanProjectToolStripMenuItem";
            this.cleanProjectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cleanProjectToolStripMenuItem.Text = "Clean Project";
            // 
            // extensionsToolStripMenuItem
            // 
            this.extensionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.extensionsToolStripMenuItem.Name = "extensionsToolStripMenuItem";
            this.extensionsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.extensionsToolStripMenuItem.Text = "Extensions";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfsdfToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // sdfsdfToolStripMenuItem
            // 
            this.sdfsdfToolStripMenuItem.Name = "sdfsdfToolStripMenuItem";
            this.sdfsdfToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.sdfsdfToolStripMenuItem.Text = "sdfsdf";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(957, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImage = global::Lucraft.Editor.Properties.Resources.hammer;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Lucraft.Editor.Properties.Resources.hammer;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Build";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(957, 482);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(325, 482);
            this.treeView1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(628, 482);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(957, 531);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditorForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sdfsdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem refreshF5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebuildProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

