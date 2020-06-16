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
    }
}
