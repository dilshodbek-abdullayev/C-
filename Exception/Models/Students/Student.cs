using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Model.Students
{
    public class Student
    {
        public string Name { get; set; } = default!;

        public Student(string name) 
        {
            if (name.Length < 5)
            {

            }
        }
    }
}
