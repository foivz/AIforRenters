using AIForRentersLib.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public partial class EmailTemplate
    {
        /// <summary>
        /// Method for adding new email template to the database
        /// </summary>
        /// <param name="emailTemplateName"></param>
        /// <param name="emailTemplateContent"></param>
        public void AddEmailTemplate(string emailTemplateName, string emailTemplateContent)
        {
            if (emailTemplateName == "")
            {
                throw new EmailTemplateException("You have to input template name!");
            }
            if (emailTemplateContent == "")
            {
                throw new EmailTemplateException("You have to input template content!");
            }

            using (var context = new SE20E01_DBEntities())
            {
                EmailTemplate newEmailTemplate = new EmailTemplate
                {
                    Name = emailTemplateName,
                    TemplateContent = emailTemplateContent
                };

                context.EmailTemplates.Add(newEmailTemplate);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method for updating existing email template in database.
        /// </summary>
        /// <param name="emailTemplate"></param>
        /// <param name="emailTemplateName"></param>
        /// <param name="emailTemplateContent"></param>
        public void EditEmailTemplate(EmailTemplate emailTemplate, string emailTemplateName, string emailTemplateContent)
        {
            if (emailTemplate == null)
            {
                throw new EmailTemplateException("You have to select a template!");
            }
            if (emailTemplateName == "")
            {
                throw new EmailTemplateException("You have to input template name!");
            }
            if (emailTemplateContent == "")
            {
                throw new EmailTemplateException("You have to input template content!");
            }

            using (var context = new SE20E01_DBEntities())
            {
                context.EmailTemplates.Attach(emailTemplate);

                emailTemplate.Name = emailTemplateName;
                emailTemplate.TemplateContent = emailTemplateContent;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method for deleting existing email template from database.
        /// </summary>
        /// <param name="emailTemplate"></param>
        public void DeleteEmailTemplate(EmailTemplate emailTemplate)
        {
            if (emailTemplate == null)
            {
                throw new EmailTemplateException("You have to select a template!");
            }

            using (var context = new SE20E01_DBEntities())
            {
                context.EmailTemplates.Attach(emailTemplate);
                context.EmailTemplates.Remove(emailTemplate);

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method for displaying email templates.
        /// It gets all email templates and stores them in the list.
        /// </summary>
        /// <returns>List of email templates</returns>
        public List<EmailTemplate> DisplayEmailTemplates()
        {
            List<EmailTemplate> emailTemplates = new List<EmailTemplate>();
            using (var context = new SE20E01_DBEntities())
            {
                var query = from emailTemplate in context.EmailTemplates
                            select emailTemplate;

                emailTemplates = query.ToList();
            }

            return emailTemplates;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
