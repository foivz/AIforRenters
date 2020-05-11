using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class EmailTemplateRepository
    {
        public List<EmailTemplate> GetEmailTemplates()
        {
            string sql = "SELECT * FROM EmailTemplate";
            List<EmailTemplate> emailTemplates = GetEmailTemplatesData(sql);

            return emailTemplates;
        }

        public List<EmailTemplate> GetEmailTemplates(string category)
        {
            string sql = $"SELECT * FROM EmailTemplate WHERE Category='{category}'";
            List<EmailTemplate> emailTemplates = GetEmailTemplatesData(sql);

            return emailTemplates;
        }

        private List<EmailTemplate> GetEmailTemplatesData(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            List<EmailTemplate> emailTemplates = new List<EmailTemplate>();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string name = dataReader["Name"].ToString();
                string templateContentText = dataReader["TemplateContent"].ToString();

                EmailTemplate emailTemplate = new EmailTemplate()
                {
                    IdEmailTemplate = id,
                    Name = name,
                    Content = templateContentText
                };
                emailTemplates.Add(emailTemplate);
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return emailTemplates;
        }

        public int Insert(EmailTemplate emailTemplate)
        {
            Database.Instance.Connect();
            string sql = $"INSERT INTO EmailTemplate (Name, TemplateContent) VALUES ('{emailTemplate.Name}', '{emailTemplate.Content}')";

            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        public int Update(EmailTemplate emailTemplate)
        {
            Database.Instance.Connect();
            string sql = $"UPDATE EmailTemplate SET Name = '{emailTemplate.Name}', TemplateContent = '{emailTemplate.Content}' WHERE Id={emailTemplate.IdEmailTemplate}";

            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        public int Delete(EmailTemplate emailTemplate)
        {
            Database.Instance.Connect();
            string sql = $"DELETE FROM EmailTemplate WHERE Id = {emailTemplate.IdEmailTemplate}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }
    }
}
