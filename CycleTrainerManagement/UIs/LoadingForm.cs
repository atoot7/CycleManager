using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleTrainerManagement.UIs
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }
        // instance member to keep a reference to main form
        private Form MainForm;

        // flag to indicate if the form has been closed
        private bool IsClosed = false;
        public LoadingForm(Form mainForm):this() {
            // Store the reference to parent form
            MainForm = mainForm;

            // Attach to parent form events
            //MainForm.Deactivate += new EventHandler(this.MainForm.Deactivate);
            //MainForm.Activated += new System.EventHandler(this.MainForm_Activated);
            //MainForm.Move += new System.EventHandler(this.MainForm_Move);

            // Adjust appearance
            this.ShowInTaskbar = false; // do not show form in task bar
            this.TopMost = true; // show splash form on top of main form
            this.StartPosition = FormStartPosition.Manual;
            this.Visible = false;

            // Adjust location
            //AdjustLocation();
        }

        private void LoadingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.IsClosed = true;
        }
    }
}
