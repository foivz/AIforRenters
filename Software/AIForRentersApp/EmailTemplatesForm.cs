using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIForRentersApp
{
    public partial class EmailTemplatesForm : Form
    {
        public EmailTemplatesForm()
        {
            InitializeComponent();
        }

        private void EmailTemplatesForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(EmailTemplatesForm_KeyDown);
        }

        private void buttonRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRequests formRequests = new FormRequests();
            formRequests.ShowDialog();
            this.Close();
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            this.Hide();
            PropertiesForm formProperties = new PropertiesForm();
            formProperties.ShowDialog();
            this.Close();
        }

        private void EmailTemplatesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (e.Handled)
                {
                    return;
                }
                HelpForm helpForm = new HelpForm();
                helpForm.ShowDialog();
                e.Handled = true;
            }
        }

        public override string ToString()
        {
            return "EmailTemplatesForm";
        }
    }
}
