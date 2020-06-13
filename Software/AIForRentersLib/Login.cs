using MailKit.Net.Smtp;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class LoginException : ApplicationException
    {
        public string Poruka { get; set; }

        public LoginException(string poruka)
        {
            Poruka = poruka;
        }
    }

    public static class Login
    {
        public static void Authentication(string emailAddress, string password)
        {
            SmtpClient smtpClient = new SmtpClient();

            Uri uri = GetUri(emailAddress);

            smtpClient.Connect(uri);

            try
            {
                smtpClient.Authenticate(emailAddress, password);
            }
            catch (AuthenticationException)
            {
                if (!smtpClient.IsAuthenticated)
                {
                    throw new LoginException("Login unsuccessful!");
                }
            }

            smtpClient.Disconnect(true);
        }

        private static Uri GetUri(string emailAddress)
        {
            if (emailAddress.EndsWith("gmail.com"))
            {
                return new Uri("smtps://smtp.gmail.com:465");
            }
            else if (emailAddress.EndsWith("hotmail.com"))
            {
                return new Uri("smtps://smtp-mail.outlook.com:587");
            }
            else if (emailAddress.EndsWith("yahoo.com"))
            {
                return new Uri("smtps://smtp.mail.yahoo.com:465");
            }
            else
            {
                return null;
            }
        }
    }
}
