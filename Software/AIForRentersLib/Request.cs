using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public abstract class Request: IRequest
    {
        public int IdRequest { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Unit { get; set; }
        public bool Confirmed { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string Property { get; set; }
        public int NumberOfPeople { get; set; }
        public string Email { get; set; }

        protected Request(int idRequest, DateTime fromDate, DateTime toDate, string unit, bool confirmed, string clientName, string clientSurname, string property, int numberOfPeople, string email)
        {
            IdRequest = idRequest;
            FromDate = fromDate;
            ToDate = toDate;
            Unit = unit;
            Confirmed = confirmed;
            ClientName = clientName;
            ClientSurname = clientSurname;
            Property = property;
            NumberOfPeople = numberOfPeople;
            Email = email;
        }
    }
}
