using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class Unit
    {
        public int IdUnit { get; set; }
        public string  Name { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public List<Availability> AvailabilityList { get; set; }

        public Unit(int idUnit, string name, int capacity, double price)
        {
            IdUnit = idUnit;
            Name = name;
            Capacity = capacity;
            Price = price;
        }

        public Unit()
        {
        }

        public void DeleteUnit(Unit unit)
        {

        }

        public void DisplayUnits()
        {

        }

        public bool CheckAvailability(DateTime fromDate, DateTime toDate)
        {
            return true;
        }

        public void EditUnit(Unit unit)
        {

        }
    }
}
