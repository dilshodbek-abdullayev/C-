using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptProject.Models.Students.Exceptions
{
    public class StudentValidationException : Exception
    {
        public StudentValidationException(
            string message,
            Exception innerException)
        {

        }
    }
}