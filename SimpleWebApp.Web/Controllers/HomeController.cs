using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
