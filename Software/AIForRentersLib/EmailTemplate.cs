using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class EmailTemplate
    {
        public int IdEmailTemplate { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public EmailTemplate(int idEmailTemplate, string name, string content)
        {
            IdEmailTemplate = idEmailTemplate;
            Name = name;
            Content = content;
        }

        public EmailTemplate()
        {
        }

        public void EditEmailTemplate(EmailTemplate emailTemplate)
        {

        }

        public void DeleteEmailTemplate(EmailTemplate emailTemplate)
        {

        }
    }
}
