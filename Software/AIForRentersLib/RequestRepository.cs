//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AIForRentersLib
//{
//    public class RequestRepository
//    {
//        public List<Request> GetRequests()
//        {
//            string sql = "SELECT * FROM Request";
//            List<Request> requests = GetRequestsData(sql);

//            return requests;
//        }

//        private List<Request> GetRequestsData(string sql)
//        {
//            Database.Instance.Connect();

//            IDataReader dataReader = Database.Instance.GetDataReader(sql);

//            List<Request> requests = new List<Request>();
//            while (dataReader.Read())
//            {
//                int id = (int)dataReader["id"];
//                DateTime fromDate = DateTime.Parse(dataReader["FromDate"].ToString());
//                DateTime toDate = DateTime.Parse(dataReader["ToDate"].ToString());
//                bool confirmed = (bool)dataReader["Confirmed"];

//                WebFormRequest request = new WebFormRequest()
//                {
//                    IdRequest = id,
//                    FromDate = fromDate,
//                    ToDate = toDate,
//                    Confirmed = confirmed

//                };
//                requests.Add(request);
//            }

//            dataReader.Close();
//            Database.Instance.Disconnect();

//            return requests;
//        }

//        public int Insert(Task task)
//        {
//            Database.Instance.Connect();
//            string sql = $"INSERT INTO Tasks (Text, Importance, Category, Assignee, Status, Deadline) " +
//                $"VALUES ('{task.Text}', {task.Importance}, '{task.Category}', '{task.Assignee}', '{task.Status}', '{task.Deadline.ToString("yyyyMMdd")}')";

//            int i = Database.Instance.ExecuteCommand(sql);
//            Database.Instance.Disconnect();
//            return i;
//        }

//        public int Update(Task task)
//        {
//            Database.Instance.Connect();
//            string sql = $"UPDATE Tasks " +
//                $"SET Text = '{task.Text}', Importance = {task.Importance}, Category = '{task.Category}', Assignee = '{task.Assignee}', Status = '{task.Status}', Deadline = '{task.Deadline.ToString("yyyyMMdd")}'  WHERE Id={task.Id}";

//            int i = Database.Instance.ExecuteCommand(sql);
//            Database.Instance.Disconnect();
//            return i;
//        }

//        public int Delete(Task task)
//        {
//            Database.Instance.Connect();
//            string sql = $"DELETE FROM Tasks WHERE Id = {task.Id}";
//            int i = Database.Instance.ExecuteCommand(sql);
//            Database.Instance.Disconnect();
//            return i;
//        }
//    }
//}
