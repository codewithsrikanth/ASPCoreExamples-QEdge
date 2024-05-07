using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using StateManagementCoreApp.Models;
using StateManagementCoreApp.Services;
using System.Diagnostics;

namespace StateManagementCoreApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		const string CookieUserId = "UserID";
		const string CookieUsername = "Username";
		MyCookieService _myCookieService;
		public HomeController(ILogger<HomeController> logger, MyCookieService _myCookieService)
		{
			_logger = logger;
			this._myCookieService = _myCookieService;
		}

		public IActionResult Index()
		{
			//Storing the data into cookie
			//CookieOptions options = new CookieOptions();
			//options.Expires = DateTime.Now.AddDays(7);
			var options = new CookieOptions
			{
				HttpOnly = true,
				Secure = true,
				SameSite = SameSiteMode.Strict,
				Expires = DateTime.Now.AddDays(7)
			};
			string encUserId = _myCookieService.Protect("123456");
			string encUsername = _myCookieService.Protect("sri@gmail.com");
			Response.Cookies.Append(CookieUserId, encUserId, options);
			Response.Cookies.Append(CookieUsername, encUsername, options);

			ViewBag.UserID = _myCookieService.UnProtect(encUserId);
			ViewBag.UserName = _myCookieService.UnProtect(encUsername);
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public string DeleteCookie()
		{
			Response.Cookies.Delete(CookieUserId);
			Response.Cookies.Delete(CookieUsername);
			return "Cookies are Deleted";
		}

		public string About()
		{
			//access the cookie data
			string? username = Request.Cookies[CookieUsername];
			int? userId =Convert.ToInt32(Request.Cookies[CookieUserId]);
			string msg = $"Username is: {username} and UserID is: {userId}";
			return msg;
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
