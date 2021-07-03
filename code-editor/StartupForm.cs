using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucraft.Editor
{
    public partial class StartupForm : Form
    {
        private delegate void LoadCompletedEventHandler();
        private event LoadCompletedEventHandler LoadCompleted;

        public StartupForm()
        {
            InitializeComponent();
            //LoadCompleted += StartupForm_LoadCompleted;
        }

        private void StartupForm_LoadCompleted()
        {
            
        }

        private void Startup_Shown(object sender, EventArgs e)
        {
            //Application.DoEvents();
            //Refresh();
            //LoadCompleted?.Invoke();
        }
    }
}
