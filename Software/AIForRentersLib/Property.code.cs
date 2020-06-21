using AIForRentersLib.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public partial class Property
    {
        /// <summary>
        /// Method for adding new property to the database
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="propertyLocation"></param>
        public void AddProperty(string propertyName, string propertyLocation)
        {
            if (propertyName == "")
            {
                throw new PropertyException("You have to input property name!");
            }
            if (propertyLocation == "")
            {
                throw new PropertyException("You have to input property location!");
            }

            using (var context = new SE20E01_DBEntities())
            {
                Property newProperty = new Property
                {
                    Name = propertyName,
                    Location = propertyLocation
                };

                context.Properties.Add(newProperty);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method for updating existing property in database.
        /// </summary>
        /// <param name="property"></param>
        /// <param name="propertyName"></param>
        /// <param name="propertyLocation"></param>
        public void EditProperty(Property property, string propertyName, string propertyLocation)
        {
            if (property == null)
            {
                throw new PropertyException("You have to select a property!");
            }
            if (propertyName == "")
            {
                throw new PropertyException("You have to input property name!");
            }
            if (propertyLocation == "")
            {
                throw new PropertyException("You have to input property location!");
            }

            using (var context = new SE20E01_DBEntities())
            {
                context.Properties.Attach(property);

                property.Name = propertyName;
                property.Location = propertyLocation;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method for deleting existing property from database.
        /// </summary>
        /// <param name="property"></param>
        public void DeleteProperty(Property property)
        {
            if (property == null)
            {
                throw new PropertyException("You have to select a property!");
            }

            using (var context = new SE20E01_DBEntities())
            {
                context.Properties.Attach(property);
                context.Properties.Remove(property);

                try
                {
                    context.SaveChanges();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    throw new PropertyException("You cannot delete this property because it contains units!");
                }
                
            }
        }

        /// <summary>
        /// Method for displaying properties.
        /// It gets all properties and stores them in the list.
        /// </summary>
        /// <returns>List of properties</returns>
        public List<Property> DisplayProperties()
        {
            List<Property> properties = new List<Property>();
            using (var context = new SE20E01_DBEntities())
            {
                var query = from property in context.Properties
                            select property;

                properties = query.ToList();
            }

            return properties;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
