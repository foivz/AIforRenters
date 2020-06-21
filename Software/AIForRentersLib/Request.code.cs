using AIForRentersLib.Exceptions;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public partial class Request
    {
        /// <summary>
        /// Method for displaying requests.
        /// It gets all requests and stores them in the list.
        /// </summary>
        /// <returns>List of requests</returns>
        public List<Request> DisplayRequests()
        {
            List<Request> requests = new List<Request>();
            using (var context = new SE20E01_DBEntities()) 
            {
                var query = from request in context.Requests.Include("Client")
                            orderby request.RequestID descending
                            select request;

                requests = query.ToList();
            }

            return requests;
        }

        /// <summary>
        /// Method for updating existing request in database.
        /// It updates response body in database.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="responseBody"></param>
        public void EditRequest(Request request, string responseBody)
        {
            if (request == null)
            {
                throw new RequestException("You have to select a request!");
            }
            if (responseBody == "")
            {
                throw new RequestException("You have to input response content!");
            }

            using (var context = new SE20E01_DBEntities())
            {
                context.Requests.Attach(request);

                request.ResponseBody = responseBody;

                context.SaveChanges();
            }
        }
        /// <summary>
        /// Method for updating existing request in database.
        /// It updates response body and response subject in the database.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="content"></param>
        /// <param name="subject"></param>
        public void UpdateRequest(Request request, string content, string subject)
        {
            using (var context = new SE20E01_DBEntities())
            {
                context.Requests.Attach(request);

                request.Processed = true;
                request.Confirmed = false;
                request.ResponseBody = content;
                request.ResponseSubject = subject;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method for updating the Sent prop of the request object in database.
        /// </summary>
        /// <param name="selectedRequest"></param>
        public void MarkAsSent(Request selectedRequest)
        {
            using (var context = new SE20E01_DBEntities())
            {
                context.Requests.Attach(selectedRequest);

                selectedRequest.Sent = true;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method for updating the Confirmed prop of the request object in database.
        /// </summary>
        /// <param name="requestForConfirmation"></param>
        public void UpdateConfirmation(Request requestForConfirmation)
        {
            if (requestForConfirmation.ResponseSubject == "Available unit" && requestForConfirmation.Sent)
            {
                using (var context = new SE20E01_DBEntities())
                {
                    context.Requests.Attach(requestForConfirmation);

                    requestForConfirmation.Confirmed = true;

                    context.SaveChanges();

                    EmailSender.SendEmail("Confirmation", $"Dear {requestForConfirmation.Client.Name}, \n\nYour confirmation is successfully noted! \nWe are looking forward to your arrival! \n\nSincerely, \nAIForRenters", requestForConfirmation.Client.Email);
                }
            }
        }
    }
}
