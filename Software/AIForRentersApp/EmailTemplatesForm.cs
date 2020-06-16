using AIForRentersLib;
using AIForRentersLib.Exceptions;
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

            buttonDeleteTemplate.Enabled = false;
            buttonEditTemplate.Enabled = false;
            buttonSaveChanges.Enabled = false;

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

            try
            {
                chosenEmailTemplate.DeleteEmailTemplate(chosenEmailTemplate);
            }
            catch (EmailTemplateException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }
            
            DisplayEmailTemplates();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            EmailTemplate chosenEmailTemplate = GetSelectedEmailTemplate();

            string emailTemplateName = textBoxTemplateName.Text;
            string emailTemplateContent = richTextBoxEditEmailTemplate.Text;

            try
            {
                chosenEmailTemplate.EditEmailTemplate(chosenEmailTemplate, emailTemplateName, emailTemplateContent);
            }
            catch (EmailTemplateException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }

            DisplayEmailTemplates();
        }

        private void buttonEditTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                EmailTemplate chosenEmailTemplate = GetSelectedEmailTemplate();

                textBoxTemplateName.Text = chosenEmailTemplate.Name;
                richTextBoxEditEmailTemplate.Text = chosenEmailTemplate.TemplateContent;
            }
            catch (EmailTemplateException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }
        }

        private void buttonAddTemplate_Click(object sender, EventArgs e)
        {
            EmailTemplate chosenEmailTemplate = GetSelectedEmailTemplate();

            string emailTemplateName = textBoxTemplateName.Text;
            string emailTemplateContent = richTextBoxEditEmailTemplate.Text;

            try
            {
                chosenEmailTemplate.AddEmailTemplate(emailTemplateName, emailTemplateContent);
            }
            catch (EmailTemplateException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }

            DisplayEmailTemplates();
        }

        private void dataGridViewEmailTemplates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmailTemplates.CurrentRow != null)
            {
                buttonDeleteTemplate.Enabled = true;
                buttonEditTemplate.Enabled = true;
                buttonSaveChanges.Enabled = true;
            }
        }

        private void DisplayEmailTemplates()
        {
            EmailTemplate emailTemplate = new EmailTemplate();

            dataGridViewEmailTemplates.DataSource = emailTemplate.DisplayEmailTemplates();
            dataGridViewEmailTemplates.Columns["EmailTemplateID"].Visible = false;
        }

        private EmailTemplate GetSelectedEmailTemplate()
        {
            if (dataGridViewEmailTemplates.CurrentRow != null)
            {
                EmailTemplate chosenEmailTemplate = dataGridViewEmailTemplates.CurrentRow.DataBoundItem as EmailTemplate;
                return chosenEmailTemplate;
            }
            else
            {
                throw new EmailTemplateException("You have to select a template!");
            }
            
        }

        public override string ToString()
        {
            return "EmailTemplatesForm";
        }
    }
}
