using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TagHelpersInCoreMVC.Models;
using TagHelpersInCoreMVC.Repository;

namespace TagHelpersInCoreMVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IEmpRepository _repository;
		public HomeController(ILogger<HomeController> logger,IEmpRepository repository)
		{
			_logger = logger;
			_repository = repository;
		}

		public IActionResult Index()
		{
			List<Employee> emps = _repository.GetEmployees();
			return View(emps);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Employee emp)
		{
			_repository.InsertEmployee(emp);
			return RedirectToAction("Index");
		}

		public ActionResult Edit(int id)
		{
			Employee emp = _repository.GetEmployee(id);
			return View(emp);
		}

		[HttpPost]
		public ActionResult Edit(Employee emp)
		{
			_repository.UpdateEmployee(emp);
			return RedirectToAction("Index");
		}
		public ActionResult Details(int id)
		{
			Employee emp = _repository.GetEmployee(id);
			return View(emp);
		}

		public ActionResult Delete(int id)
		{
			Employee emp = _repository.GetEmployee(id);
			return View(emp);
		}
		[HttpPost]
		public ActionResult Delete(string id)
		{
			int eno = Convert.ToInt32(id);
			_repository.DeleteEmployee(eno);
			return RedirectToAction("Index");
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
	}
}
