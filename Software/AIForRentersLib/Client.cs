using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public Client(int idClient, string name, string surname, string email)
        {
            IdClient = idClient;
            Name = name;
            Surname = surname;
            Email = email;
        }
    }
}
