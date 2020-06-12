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
            using (var context = new SE20E01_DBEntities())
            {
                context.Properties.Attach(property);

                property.Name = propertyName;
                property.Location = propertyName;

                context.SaveChanges();
            }
        }

        public void DeleteProperty(Property property)
        {
            using (var context = new SE20E01_DBEntities())
            {
                context.Properties.Attach(property);
                context.Properties.Remove(property);

                context.SaveChanges();
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
