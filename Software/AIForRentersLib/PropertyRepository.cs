using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class PropertyRepository
    {
        public List<Property> GetProperties()
        {
            string sql = "SELECT * FROM Property";
            List<Property> properties = GetPropertiesData(sql);

            return properties;
        }

        private List<Property> GetPropertiesData(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            List<Property> properties = new List<Property>();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string name = dataReader["Name"].ToString();
                string location = dataReader["Location"].ToString();
                int idOwner = (int)dataReader["idOwner"];

                Property property = new Property()
                {
                    IdProperty = id,
                    Name = name,
                    Location = location
                };
                properties.Add(property);
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return properties;
        }

        public int Insert(Property property)
        {
            Database.Instance.Connect();
            string sql = $"INSERT INTO Property (Name, Location) VALUES ('{property.Name}', '{property.Location}')";

            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        public int Update(Property property)
        {
            Database.Instance.Connect();
            string sql = $"UPDATE Property SET Name = '{property.Name}', Location = '{property.Location}' WHERE Id={property.IdProperty}";

            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        public int Delete(Property property)
        {
            Database.Instance.Connect();
            string sql = $"DELETE FROM Property WHERE Id = {property.IdProperty}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }
    }
}
