using ExceptProject.Models.Students.Exceptions;

namespace ExceptProject.Models.Students
{
    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public Student(string name, int age)
        {
            // Validation logic
            if (name.Length < 5)
            {
                throw new InvalidStudentNameException(
                  message: "Student name's length " +
                  "must be at least 5.");
            }

            // Validation logic
            if (age < 18)
            {
                throw new InvalidStudentAgeException(
                  message: "You are too young for that.");
            }

            this.Name = name;
            this.Age = age;
        }
    }
}
