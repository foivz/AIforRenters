using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public partial class Unit
    {
        public void AddUnit(Property chosenProperty, string unitName, int unitCapacity, double unitPrice)
        {
            using (var context = new SE20E01_DBEntities())
            {
                context.Properties.Attach(chosenProperty);

                Unit newUnit = new Unit
                {
                    Name = unitName,
                    Capacity = unitCapacity,
                    Price = unitPrice,
                    Property = chosenProperty
                    
                };

                context.Units.Add(newUnit);
                context.SaveChanges();
            }
        }

        public void EditUnit(Unit unit, string unitName, int unitCapacity, double unitPrice)
        {
            using (var context = new SE20E01_DBEntities())
            {
                context.Units.Attach(unit);

                unit.Name = unitName;
                unit.Capacity = unitCapacity;
                unit.Price = unitPrice;

                context.SaveChanges();
            }
        }

        public void DeleteUnit(Unit unit)
        {
            using (var context = new SE20E01_DBEntities())
            {
                context.Units.Attach(unit);
                context.Units.Remove(unit);

                context.SaveChanges();
            }
        }

        public List<Unit> DisplayUnits()
        {
            List<Unit> units = new List<Unit>();
            using (var context = new SE20E01_DBEntities())
            {
                var query = from unit in context.Units
                            select unit;

                units = query.ToList();
            }

            return units;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
