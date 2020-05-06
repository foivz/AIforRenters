using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public interface IRequest
    {
        int IdRequest { get; set; }
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }
        string Unit { get; set; }
        bool Confirmed { get; set; }
        string ClientName { get; set; }
        string ClientSurname { get; set; }
        string Property { get; set; }
        int NumberOfPeople { get; set; }
        string Email { get; set; }
    }
}
