
namespace ExceptProject.Models.Students.Exceptions
{
        public class InvalidStudentNameException : Exception
        {
            // parameterless constructor
            public InvalidStudentNameException()
              : base()
            { }

            // message parameterli constructor
            public InvalidStudentNameException(string message)
          : base(message)
            { }
        }
    

}
