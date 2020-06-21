using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public static class EmailSender
    {
        public static bool SendEmail(Request request)
        {
            SmtpClient smtpClient = new SmtpClient();

            Uri uri = new Uri("smtps://smtp.gmail.com:465");

            smtpClient.Connect(uri);

            smtpClient.Authenticate(Sender.Email, Sender.Password);

            MimeMessage generatedEmail = GenerateEmail(request);

            smtpClient.Send(generatedEmail);

            smtpClient.Disconnect(true);

            return true;
        }

        private static MimeMessage GenerateEmail(Request request)
        {
            string senderAddress = Sender.Email;
            string clientAddress = request.Client.Email;
            string clientNameAndSurname = request.Client.Name + " " + request.Client.Surname;

            string messageSubject = request.ResponseSubject;
            string messageBody = request.ResponseBody;

            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress("AIForRenters", senderAddress));
            message.To.Add(new MailboxAddress(clientNameAndSurname, clientAddress));
            message.Subject = messageSubject;

            BodyBuilder body = new BodyBuilder();
            body.TextBody = messageBody;

            message.Body = body.ToMessageBody();

            return message;
        }

        public static bool SendEmail(string subject, string body, string address)
        {
            SmtpClient smtpClient = new SmtpClient();

            Uri uri = new Uri("smtps://smtp.gmail.com:465");

            smtpClient.Connect(uri);

            smtpClient.Authenticate(Sender.Email, Sender.Password);

            MimeMessage generatedEmail = GenerateEmail(subject, body, address);

            smtpClient.Send(generatedEmail);

            smtpClient.Disconnect(true);

            return true;
        }

        private static MimeMessage GenerateEmail(string subject, string emailBody, string address)
        {
            string senderAddress = Sender.Email;
            string clientAddress = address;

            string messageSubject = subject;
            string messageBody = emailBody;

            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress("AIForRenters", senderAddress));
            message.To.Add(new MailboxAddress("Client", clientAddress));
            message.Subject = messageSubject;

            BodyBuilder body = new BodyBuilder();
            body.TextBody = messageBody;

            message.Body = body.ToMessageBody();

            return message;
        }
    }
}
