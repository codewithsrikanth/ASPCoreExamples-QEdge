using DataSharingMVCCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataSharingMVCCoreApp.Controllers
{
	public class StudentController : Controller
	{
		public ViewResult Details()
		{
			Student std = new Student()
			{
				StudentId = 101,
				Branch = "CSE",
				Gender = "Male",
				Name = "Srikanth",
				Section = "B"
			};
			Address address = new Address()
			{
				StudentId = 101,
				City = "Hyderabad",
				Country="India",
				State="TS",
				Pin = "500038"
			};

			StudentDetailViewModel model = new StudentDetailViewModel()
			{
				Student = std,
				Address = address,
				Header = "Student Info",
				Title = "Student Detail View Page"
			};

			return View(model);
		}
	}
}
