using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Person
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int SSN { get; set; }
        public Enum Gender { get;set; } 


        public Person(string name,string surname,int ssn,Enum gender) 
        {   
            Name = name;
            Surname = surname;
            SSN = ssn;
            Gender = gender;
        }
    }
}
