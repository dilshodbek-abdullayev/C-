using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptProject.Models.Students.Exceptions
{
    public class InvalidStudentAgeException : Exception
    {
        public InvalidStudentAgeException(string message)
            : base(message)
        { }
    }
}