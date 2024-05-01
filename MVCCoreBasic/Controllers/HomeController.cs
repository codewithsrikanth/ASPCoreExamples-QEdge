using Microsoft.AspNetCore.Mvc;

namespace MVCCoreBasic.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is Index action from HomeController";

        }
        public string Blogs()
        {
            return "This is Blogs action from HomeController";
        }
        public string Contact()
        {
            return "This is Contact action from HomeController";
        }
    }
}
