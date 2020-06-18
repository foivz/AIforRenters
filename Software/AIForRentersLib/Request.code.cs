using AIForRentersLib.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public partial class Request
    {
        public List<Request> DisplayRequests()
        {
            List<Request> requests = new List<Request>();
            using (var context = new SE20E01_DBEntities()) 
            {
                var query = from request in context.Requests.Include("Client")
                            select request;

                requests = query.ToList();
            }

            return requests;
        }

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

        public void MarkAsSent(Request selectedRequest)
        {
            using (var context = new SE20E01_DBEntities())
            {
                context.Requests.Attach(selectedRequest);

                selectedRequest.Sent = true;

                context.SaveChanges();
            }
        }
    }
}
