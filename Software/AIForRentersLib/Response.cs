using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib
{
    public class Response
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public Response(string name, string content, DateTime created)
        {
            Name = name;
            Content = content;
            Created = DateTime.Now;
        }
    }
}
