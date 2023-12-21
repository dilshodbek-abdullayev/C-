using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptProject.Models.Students.Exceptions
{
    internal class MyException:Exception
    {
        public MyException(string message,Exception inner):base(message,inner)
        {
            
        }
    }
}
