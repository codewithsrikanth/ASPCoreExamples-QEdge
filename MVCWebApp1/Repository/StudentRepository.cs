using MVCWebApp1.Models;

namespace MVCWebApp1.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> StudentsInfo()
        {
            return new List<Student>()
            {
                new Student(){StudentId=101,Name="James",Branch="CSE",Section="A",Gender="Male"},
                new Student(){StudentId=102,Name="Smith",Branch="ECE",Section="B",Gender="Male"},
                new Student(){StudentId=103,Name="Haritha",Branch="CSE",Section="A",Gender="Female"},
                new Student(){StudentId=104,Name="Sara",Branch="EEE",Section="A",Gender="Female"},
                new Student(){StudentId=105,Name="Pam",Branch="ECE",Section="B",Gender="Female"},
                new Student(){StudentId=106,Name="Ramesh",Branch="IT",Section="A",Gender="Male"}
            };
        }

        public Student GetStudentById(int id)
        {
            //var student = StudentsInfo().FirstOrDefault(std => std.StudentId == id);
            var student = (from std in StudentsInfo() where std.StudentId == id select std).FirstOrDefault();
            return student;
        }

        public List<Student> GetStudents()
        {
            return StudentsInfo();
        }
    }
}
