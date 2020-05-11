     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class EmailRequest: Request
    {
        public EmailRequest(int idRequest, DateTime fromDate, DateTime toDate, string unit, bool confirmed, string clientName, string clientSurname, string property, int numberOfPeople, string email)
            : base(idRequest, fromDate, toDate, unit, confirmed, clientName, clientSurname, property, numberOfPeople, email)
        {
            
        }

        public EmailRequest()
        {
        }
    }
}
