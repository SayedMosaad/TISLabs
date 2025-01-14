using Microsoft.AspNetCore.Mvc;

namespace TISLabs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
