using MVCWebApp1.Models;

namespace MVCWebApp1.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
    }
}
