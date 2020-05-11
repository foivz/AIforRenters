using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class UnitRepository
    {
        public List<Unit> GetUnits()
        {
            string sql = "SELECT * FROM Unit";
            List<Unit> units = GetUnitsData(sql);

            return units;
        }

        public List<Unit> GetUnits(string category)
        {
            string sql = $"SELECT * FROM Unit WHERE Category='{category}'";
            List<Unit> units = GetUnitsData(sql);

            return units;
        }

        private List<Unit> GetUnitsData(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            List<Unit> units = new List<Unit>();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string name = dataReader["Name"].ToString();
                int capacity = (int)dataReader["Capacity"];
                double price = (double)dataReader["Price"];

                Unit unit = new Unit()
                {
                    IdUnit = id,
                    Name = name,
                    Capacity = capacity,
                    Price = price
                };
                units.Add(unit);
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return units;
        }

        public int Insert(Unit unit)
        {
            Database.Instance.Connect();
            string sql = $"INSERT INTO Unit (Name, Capacity, Price) VALUES ('{unit.Name}', {unit.Capacity}, {unit.Price})";

            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        public int Update(Unit unit)
        {
            Database.Instance.Connect();
            string sql = $"UPDATE Unit SET Name = '{unit.Name}', Capacity = {unit.Capacity}, Price = {unit.Price} WHERE id={unit.IdUnit}";

            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        public int Delete(Unit unit)
        {
            Database.Instance.Connect();
            string sql = $"DELETE FROM Unit WHERE Id = {unit.IdUnit}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }
    }
}
