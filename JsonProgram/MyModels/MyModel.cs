using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProgram.MyModels
{
    public class MyModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public Company Company { get; set; }
        public Location Location { get; set; }
    }

    public class MyModel2
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
    }
}
