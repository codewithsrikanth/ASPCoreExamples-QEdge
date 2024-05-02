using Microsoft.AspNetCore.Mvc;
using MVCWebApp1.Repository;

namespace MVCWebApp1.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;

		}
        public ActionResult Index()
        {
            var students = _studentRepository.GetStudents();
            return View(students);
        }
        public JsonResult Details(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            return Json(student);
        }
    }
}
