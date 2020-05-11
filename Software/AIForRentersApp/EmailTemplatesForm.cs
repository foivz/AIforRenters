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
        private EmailTemplateRepository emailTemplateRepository = new EmailTemplateRepository();
        public EmailTemplatesForm()
        {
            InitializeComponent();
        }

        private void EmailTemplatesForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(EmailTemplatesForm_KeyDown);

            DisplayEmailTemplates(emailTemplateRepository.GetEmailTemplates());
        }

        private void buttonRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRequests formRequests = new FormRequests();
            formRequests.ShowDialog();
            this.Close();

            DisplayEmailTemplates(emailTemplateRepository.GetEmailTemplates());
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            this.Hide();
            PropertiesForm formProperties = new PropertiesForm();
            formProperties.ShowDialog();
            this.Close();

            DisplayEmailTemplates(emailTemplateRepository.GetEmailTemplates());
        }

        private void buttonDeleteTemplate_Click(object sender, EventArgs e)
        {
            EmailTemplate selectedEmailTemplate = GetSelectedEmailTemplate();
            emailTemplateRepository.Delete(selectedEmailTemplate);

            DisplayEmailTemplates(emailTemplateRepository.GetEmailTemplates());
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            EmailTemplate selectedEmailTemplate = GetSelectedEmailTemplate();

            selectedEmailTemplate.Name = textBoxTemplateName.Text;
            selectedEmailTemplate.Content = richTextBoxEditEmailTemplate.Text;

            emailTemplateRepository.Update(selectedEmailTemplate);

            DisplayEmailTemplates(emailTemplateRepository.GetEmailTemplates());
        }

        private void buttonEditTemplate_Click(object sender, EventArgs e)
        {
            EmailTemplate selectedEmailTemplate = GetSelectedEmailTemplate();

            textBoxTemplateName.Text = selectedEmailTemplate.Name;
            richTextBoxEditEmailTemplate.Text = selectedEmailTemplate.Content;
        }

        private void buttonAddTemplate_Click(object sender, EventArgs e)
        {
            EmailTemplate newEmailTemplate = new EmailTemplate
            {
                Name = textBoxTemplateName.Text,
                Content = richTextBoxEditEmailTemplate.Text,
            };

            emailTemplateRepository.Insert(newEmailTemplate);

            DisplayEmailTemplates(emailTemplateRepository.GetEmailTemplates());
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
        
        private void DisplayEmailTemplates(List<EmailTemplate> emailTemplates)
        {
            dataGridViewEmailTemplates.DataSource = emailTemplates.ToList();
        }

        private EmailTemplate GetSelectedEmailTemplate()
        {
            if (dataGridViewEmailTemplates.CurrentRow != null)
            {
                return dataGridViewEmailTemplates.CurrentRow.DataBoundItem as EmailTemplate;
            }
            return null;
        }

        public override string ToString()
        {
            return "EmailTemplatesForm";
        }
    }
}
