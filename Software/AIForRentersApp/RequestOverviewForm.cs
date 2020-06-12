using AIForRentersLib;
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
    public partial class FormRequests : Form
    {
        
        public FormRequests()
        {
            InitializeComponent();
        }
        
        private void FormRequests_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormRequests_KeyDown);

            DisplayRequests();
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            this.Hide();
            PropertiesForm formProperties = new PropertiesForm();
            formProperties.ShowDialog();
            this.Close();
        }

        private void buttonEmailTemplates_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmailTemplatesForm emailTemplatesForm = new EmailTemplatesForm();
            emailTemplatesForm.ShowDialog();
            this.Close();
        }

        private void buttonEditResponse_Click(object sender, EventArgs e)
        {
            richTextBoxResponse.Enabled = true;
            richTextBoxResponse.Focus();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //Method for sending email to client
        }

        private void FormRequests_KeyDown(object sender, KeyEventArgs e)
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

        private void DisplayRequests()
        {
            Request request = new Request();

            dataGridViewIncomingRequests.DataSource = request.DisplayRequests();
            dataGridViewIncomingRequests.Columns["RequestID"].Visible = false;
            dataGridViewIncomingRequests.Columns["PropertyID"].Visible = false;
            dataGridViewIncomingRequests.Columns["UnitID"].Visible = false;
            dataGridViewIncomingRequests.Columns["ClientID"].Visible = false;
            dataGridViewIncomingRequests.Columns["EmailTemplateID"].Visible = false;
        }

        public override string ToString()
        {
            return "RequestsForm";
        }
    }
}
