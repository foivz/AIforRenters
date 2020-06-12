using AIForRentersLib;
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

            DisplayEmailTemplates();
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

        private void buttonDeleteTemplate_Click(object sender, EventArgs e)
        {
            EmailTemplate chosenEmailTemplate = GetSelectedEmailTemplate();

            chosenEmailTemplate.DeleteEmailTemplate(chosenEmailTemplate);

            DisplayEmailTemplates();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            EmailTemplate chosenEmailTemplate = GetSelectedEmailTemplate();

            string emailTemplateName = textBoxTemplateName.Text;
            string emailTemplateContent = richTextBoxEditEmailTemplate.Text;

            chosenEmailTemplate.EditEmailTemplate(chosenEmailTemplate, emailTemplateName, emailTemplateContent);

            DisplayEmailTemplates();
        }

        private void buttonEditTemplate_Click(object sender, EventArgs e)
        {
            EmailTemplate chosenEmailTemplate = GetSelectedEmailTemplate();

            textBoxTemplateName.Text = chosenEmailTemplate.Name;
            richTextBoxEditEmailTemplate.Text = chosenEmailTemplate.TemplateContent;
        }

        private void buttonAddTemplate_Click(object sender, EventArgs e)
        {
            EmailTemplate chosenEmailTemplate = GetSelectedEmailTemplate();

            string emailTemplateName = textBoxTemplateName.Text;
            string emailTemplateContent = richTextBoxEditEmailTemplate.Text;

            chosenEmailTemplate.AddEmailTemplate(emailTemplateName, emailTemplateContent);

            DisplayEmailTemplates();
        }

        private void DisplayEmailTemplates()
        {
            EmailTemplate emailTemplate = new EmailTemplate();

            dataGridViewEmailTemplates.DataSource = emailTemplate.DisplayEmailTemplates();
            dataGridViewEmailTemplates.Columns["EmailTemplateID"].Visible = false;
            dataGridViewEmailTemplates.Columns["Requests"].Visible = false;
        }

        private EmailTemplate GetSelectedEmailTemplate()
        {
            if (dataGridViewEmailTemplates.CurrentRow != null)
            {
                EmailTemplate chosenEmailTemplate = dataGridViewEmailTemplates.CurrentRow.DataBoundItem as EmailTemplate;
                return chosenEmailTemplate;
            }
            return null;
        }

        public override string ToString()
        {
            return "EmailTemplatesForm";
        }
    }
}
