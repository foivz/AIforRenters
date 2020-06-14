using Microsoft.Recognizers.Text;
using Microsoft.Recognizers.Text.DateTime;
using Microsoft.Recognizers.Text.Number;
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
        public static Request ProcessData(ReceivedData receivedData)
        {
            string emailBody = "I need a reservation for eleven people from 20. June until 27. June Best regards!"; // = receivedData.EmailBody;

            DateTime dateFrom = DateTime.Parse(ExtractDateFrom(emailBody));
            DateTime dateTo = DateTime.Parse(ExtractDateTo(emailBody));
            int numberOfPeople = ExtractNumberOfPeople(emailBody);

            Request newRequest = new Request()
            {
                FromDate = dateFrom,
                ToDate = dateTo,
                NumberOfPeople = numberOfPeople
            };

            return newRequest;
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
