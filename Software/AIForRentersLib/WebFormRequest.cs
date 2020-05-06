using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class WebFormRequest: Request
    {
        public string Comment { get; set; }
        public WebFormRequest(int idRequest, DateTime fromDate, DateTime toDate, string unit, bool confirmed, string clientName, string clientSurname, string property, int numberOfPeople, string email, string comment)
            : base(idRequest, fromDate, toDate, unit, confirmed, clientName, clientSurname, property, numberOfPeople, email)
        {
            Comment = comment;
        }
    }
}
