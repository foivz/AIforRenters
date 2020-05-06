using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class Property
    {
        public int IdProperty { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Unit> ListOfUnits { get; set; }

        public Property(int idProperty, string name, string location)
        {
            IdProperty = idProperty;
            Name = name;
            Location = location;
        }

        public void DeleteProperty(Property property)
        {

        }

        public void DisplayProperties()
        {

        }

        public void EditProperty(Property property)
        {

        }
    }
}
