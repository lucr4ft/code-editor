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

namespace Lucraft.CodeEditor
{
    public partial class StartupForm : Form
    {
        private delegate void LoadCompletedEventHandler();
        private event LoadCompletedEventHandler LoadCompleted;

        public StartupForm()
        {
            InitializeComponent();
            LoadCompleted += StartupForm_LoadCompleted;
        }

        private delegate void InvokeMethod();

        private void StartupForm_LoadCompleted()
        {
            Task startup = Task.Run(() => Startup.Start(progressBar1));
            Application.DoEvents();
            Refresh();
            Task.Run(() =>
            {
                startup.Wait();
                InvokeMethod close = delegate { Close(); };
                Invoke(close);
            });
        }

        private void Startup_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            Refresh();
            LoadCompleted?.Invoke();
        }
    }
}
