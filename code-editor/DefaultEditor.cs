using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucraft.CodeEditor
{
    public partial class DefaultEditor : EditorControl
    {
        public DefaultEditor()
        {
            InitializeComponent();

            Load += DefaultEditor_Load;
            Save += DefaultEditor_Save;

            richTextBox1.ModifiedChanged += RichTextBox1_ModifiedChanged;

        }

        private void DefaultEditor_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = System.IO.File.ReadAllText(File.FullName);
        }

        private void RichTextBox1_ModifiedChanged(object sender, EventArgs e)
        {
            //base.Modified?.Invoke();
            Debug.WriteLine("MODIFIED");
        }

        private void DefaultEditor_Save()
        {
            System.IO.File.WriteAllText(File.FullName, richTextBox1.Text);
        }
    }
}
