using AIForRentersLib.Exceptions;
using MailKit.Net.Smtp;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public static class Login
    {
        /// <summary>
        /// Method for user authentication on smtp server
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="password"></param>
        public static void Authentication(string emailAddress, string password)
        {

            if (emailAddress == "")
            {
                throw new LoginException("Enter your credentials!");
            }

            SmtpClient smtpClient = new SmtpClient();

            //gets uri from email address
            Uri uri = GetUri(emailAddress);

            //connection to the server
            smtpClient.Connect(uri);

            try
            {
                //authentication towards the server
                smtpClient.Authenticate(emailAddress, password);
            }
            catch (AuthenticationException)
            {
                if (!smtpClient.IsAuthenticated)
                {
                    throw new LoginException("Login unsuccessful!");
                }
            }

            //closing the connection
            smtpClient.Disconnect(true);
        }

        /// <summary>
        /// Method to get uri of a server depending on email ending
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <returns>Uri object</returns>
        private static Uri GetUri(string emailAddress)
        {
            //gmail server
            if (emailAddress.EndsWith("gmail.com"))
            {
                return new Uri("smtps://smtp.gmail.com:465");
            }
            //outlook server
            else if (emailAddress.EndsWith("hotmail.com"))
            {
                return new Uri("smtps://smtp-mail.outlook.com:587");
            }
            //yahoo server
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
