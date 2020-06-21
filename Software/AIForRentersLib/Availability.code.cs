using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public partial class Availability
    {
        public override string ToString()
        {
            return Available.ToString();
        }
        /// <summary>
        /// Method for adding new availability to the database
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void AddAvailability(Unit unit, DateTime fromDate, DateTime toDate)
        {
            using (var context = new SE20E01_DBEntities())
            {
                context.Units.Attach(unit);
                Availability newAvailability = new Availability
                {
                    Unit = unit,
                    FromDate = fromDate,
                    ToDate = toDate,
                    Available = false
                };

                context.Availabilities.Add(newAvailability);
                context.SaveChanges();
            }
        }
    }
}
