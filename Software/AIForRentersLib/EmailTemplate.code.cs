﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public partial class EmailTemplate
    {
        public void AddEmailTemplate(string emailTemplateName, string emailTemplateContent)
        {
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

        public void EditEmailTemplate(EmailTemplate emailTemplate, string emailTemplateName, string emailTemplateContent)
        {
            using (var context = new SE20E01_DBEntities())
            {
                context.EmailTemplates.Attach(emailTemplate);

                emailTemplate.Name = emailTemplateName;
                emailTemplate.TemplateContent = emailTemplateContent;

                context.SaveChanges();
            }
        }

        public void DeleteEmailTemplate(EmailTemplate emailTemplate)
        {
            using (var context = new SE20E01_DBEntities())
            {
                context.EmailTemplates.Attach(emailTemplate);
                context.EmailTemplates.Remove(emailTemplate);

                context.SaveChanges();
            }
        }

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