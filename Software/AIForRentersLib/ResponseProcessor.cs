using Microsoft.Recognizers.Text;
using Microsoft.Recognizers.Text.DateTime;
using Microsoft.Recognizers.Text.Number;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public static class ResponseProcessor
    {
        /// <summary>
        /// Receives instance (object) of ReceivedData class and doing semantic analysis on body of received email as a string.
        /// This method is using Microsoft.Recognizers.Text library for semantic analysis.
        /// </summary>
        /// <param name="receivedData"></param>
        /// <returns>
        /// New request object of class Request with its attributes.
        /// </returns>
        public static void ProcessData(List<ReceivedData> receivedData)
        {
            List<Request> newRequests = new List<Request>();

            foreach (ReceivedData receivedDataItem in receivedData)
            {
                // Client e-mail adress
                string emailAdress  = receivedDataItem.EmailAddress;

                // Client e-mail subject
                string emailSubject = receivedDataItem.EmailSubject;

                // Client name and surname
                string emailSenderNameAndSurname = receivedDataItem.ClientNameSurname;
                var nameAndSurnameSplitted = emailSenderNameAndSurname.Split(' ');
                string name = nameAndSurnameSplitted[0];
                string surname = nameAndSurnameSplitted[1];

                //Email body
                string emailBody = receivedDataItem.EmailBody;

                // Processed email body data (Date and number of people)
                DateTime dateFrom = DateTime.Parse(ExtractDateFrom(emailBody));
                DateTime dateTo = DateTime.Parse(ExtractDateTo(emailBody));
                int numberOfPeople = ExtractNumberOfPeople(emailBody);

                Property selectedProperty = GetProperty(emailSubject);
                Unit selectedUnit = GetUnit(emailSubject);
                Client newClient = new Client()
                {
                    Name = name,
                    Surname = surname,
                    Email = emailAdress
                };
                EmailTemplate newTemplate = new EmailTemplate()
                {
                    Name = "",
                    TemplateContent = ""
                };

                Request newRequest = new Request()
                {
                    Property = selectedProperty,
                    Unit = selectedUnit,
                    FromDate = dateFrom,
                    ToDate = dateTo,
                    NumberOfPeople = numberOfPeople,
                    Client = newClient,
                    Confirmed = false,
                    EmailTemplate = newTemplate
                };

                using (var context = new SE20E01_DBEntities())
                {
                    context.Properties.Attach(selectedProperty);
                    context.Units.Attach(selectedUnit);
                    context.EmailTemplates.Add(newTemplate);

                    context.Clients.Add(newClient);

                    context.Requests.Add(newRequest);

                    context.SaveChanges();
                }
            }
        }

        private static Property GetProperty(string emailSubject)
        {
            Property selectedProperty;

            using (var context = new SE20E01_DBEntities())
            {
                selectedProperty = context.Properties.First(p => p.Units.Any(u => u.Name == emailSubject));
                /*
                selectedProperty = (from p in context.Properties
                                   where p.Units.Any(u => u.Name == emailSubject)
                                   select p) as Property;
                */
            }
            return selectedProperty;
        }

        private static Unit GetUnit(string emailSubject)
        {
            Unit selectedUnit;

            using (var context = new SE20E01_DBEntities())
            {
                var queryUnit = from unit in context.Units
                                where unit.Name == emailSubject
                                select unit;

                selectedUnit = queryUnit.Single();
            }
            return selectedUnit;
        }

        private static int ExtractNumberOfPeople(string testEmailString)
        {
            var result = NumberRecognizer.RecognizeNumber(testEmailString, Culture.English);
            int.TryParse(result.First().Resolution["value"].ToString(), out int value);
            return value;
        }

        public static string ExtractDateFrom(string emailBody)
        {
            string dateFrom = ExtractDates(emailBody).ToList<string>().ToArray()[2];
            return dateFrom;
        }

        public static string ExtractDateTo(string emailBody)
        {
            string dateTo = ExtractDates(emailBody).ToList<string>().ToArray()[3];
            return dateTo;
        }

        public static Dictionary<string, string>.ValueCollection ExtractDates(string emailBody)
        {
            var result = DateTimeRecognizer.RecognizeDateTime(emailBody, Culture.English);
            var extractFirstLayer = result.First().Resolution.Values.First() as List<Dictionary<string, string>>;
            var dictionaryAsValueCollection = extractFirstLayer.First().Values;
            return dictionaryAsValueCollection;
        }
    }
}
