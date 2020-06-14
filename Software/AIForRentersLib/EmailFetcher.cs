using MailKit.Net.Smtp;
using MimeKit;
using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public static class EmailFetcher
    {
        public static List<ReceivedData> ShapeReceivedData()
        {
            List<ReceivedData> listOfReceivedData = new List<ReceivedData>();

            using (Pop3Client client = new Pop3Client())
            {
                string username = Sender.Email.Remove(Sender.Email.IndexOf("@"), 10);

                // Connect to the server
                client.Connect("pop.gmail.com", 995, true);

                // Authenticate ourselves towards the server
                client.Authenticate(username, Sender.Password);

                // Get the number of messages in the inbox
                int messageCount = client.GetMessageCount();

                // Messages are numbered in the interval: [1, messageCount]
                // Ergo: message numbers are 1-based.
                // Most servers give the latest message the highest number
                for (int i = messageCount; i > 0; i--)
                {
                    string clientAddress = client.GetMessage(i).Headers.From.Address;
                    string emailSubject = client.GetMessage(i).Headers.Subject;
                    string emailBody = client.GetMessage(i).MessagePart.GetBodyAsText();

                    ReceivedData newReceivedData = new ReceivedData
                    {
                        EmailAddress = clientAddress,
                        EmailSubject = emailSubject,
                        EmailBody = emailBody
                    };

                    listOfReceivedData.Add(newReceivedData);
                }
            }
            return listOfReceivedData;
        }
    }
}
