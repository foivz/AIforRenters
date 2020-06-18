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
