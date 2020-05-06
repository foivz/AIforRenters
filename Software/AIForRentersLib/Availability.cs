using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class Availability
    {
        public int IdAvailability { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool Available { get; set; }

        public Availability(int idAvailability, DateTime fromDate, DateTime toDate, bool available)
        {
            IdAvailability = idAvailability;
            FromDate = fromDate;
            ToDate = toDate;
            Available = available;
        }
    }
}
