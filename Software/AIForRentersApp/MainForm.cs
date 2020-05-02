using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIForRentersApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormRequests requestsForm = new FormRequests();
            requestsForm.MdiParent = this;
            requestsForm.Show();
        }

        private void requestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRequests requestsForm = new FormRequests();
            requestsForm.MdiParent = this;
            requestsForm.Show();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm();
            propertiesForm.MdiParent = this;
            propertiesForm.Show();
        }

        private void emailTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailTemplatesForm emailTemplatesForm = new EmailTemplatesForm();
            emailTemplatesForm.MdiParent = this;
            emailTemplatesForm.Show();
        }
    }
}
