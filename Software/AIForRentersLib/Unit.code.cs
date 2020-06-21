using AIForRentersLib.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public partial class Unit
    {
        /// <summary>
        /// Method for adding new unit to the database
        /// </summary>
        /// <param name="chosenProperty"></param>
        /// <param name="unitName"></param>
        /// <param name="unitCapacity"></param>
        /// <param name="unitPrice"></param>
        public void AddUnit(Property chosenProperty, string unitName, int unitCapacity, double unitPrice)
        {
            if (chosenProperty == null)
            {
                throw new UnitException("There is no property assigned to this unit!");
            }
            if (unitName == "")
            {
                throw new UnitException("You have to input unit name!");
            }
            if (unitCapacity.ToString() == "")
            {
                throw new UnitException("You have to input unit capacity!");
            }
            if (unitPrice.ToString() == "")
            {
                throw new UnitException("You have to input unit price!");
            }

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

        /// <summary>
        /// Method for updating existing unit in database.
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="unitName"></param>
        /// <param name="unitCapacity"></param>
        /// <param name="unitPrice"></param>
        public void EditUnit(Unit unit, string unitName, int unitCapacity, double unitPrice)
        {
            if (unit == null)
            {
                throw new UnitException("You have to select a unit!");
            }
            if (unitName == "")
            {
                throw new UnitException("You have to input unit name!");
            }
            if (unitCapacity.ToString() == "")
            {
                throw new UnitException("You have to input unit capacity!");
            }
            if (unitPrice.ToString() == "")
            {
                throw new UnitException("You have to input unit price!");
            }

            using (var context = new SE20E01_DBEntities())
            {
                context.Units.Attach(unit);

                unit.Name = unitName;
                unit.Capacity = unitCapacity;
                unit.Price = unitPrice;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method for deleting existing unit from database.
        /// </summary>
        /// <param name="unit"></param>
        public void DeleteUnit(Unit unit)
        {
            if (unit == null)
            {
                throw new UnitException("You have to select a unit!");
            }

            using (var context = new SE20E01_DBEntities())
            {
                context.Units.Attach(unit);
                context.Units.Remove(unit);

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method for displaying units of a chosen property.
        /// It gets all units of a chosen property and stores them in the list.
        /// </summary>
        /// <param name="chosenProperty"></param>
        /// <returns>List of units</returns>
        public List<Unit> DisplayUnits(Property chosenProperty)
        {
            List<Unit> units = new List<Unit>();
            using (var context = new SE20E01_DBEntities())
            {
                var query = from unit in context.Units
                            where unit.Property.PropertyID == chosenProperty.PropertyID
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
