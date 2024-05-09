using Microsoft.AspNetCore.Mvc;
using SessionsInMVCCore.Models;
using System.Diagnostics;

namespace SessionsInMVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        const string SessionUserId = "_UserId";
        const string SessionUserName = "_UserName";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString(SessionUserId, "9399932996");
            HttpContext.Session.SetString(SessionUserName, "codewithsrikanth@gmail.com");

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
    }
}
