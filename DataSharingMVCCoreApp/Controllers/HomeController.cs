using DataSharingMVCCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataSharingMVCCoreApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public ViewResult Details()
		{
			ViewData["Title"] = "Student Details Page";
			ViewData["Header"] = "Student Info";
			Student std = new Student()
			{
				StudentId = 101,
				Name = "Srikanth",
				Branch = "CSE",
				Gender = "Male",
				Section = "B"
			};
			ViewData["student"] = std;
			return View();
		}
	}
}
