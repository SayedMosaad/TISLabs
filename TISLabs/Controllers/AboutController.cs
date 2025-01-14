using Microsoft.AspNetCore.Mvc;

namespace TISLabs.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
