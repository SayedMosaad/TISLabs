using Microsoft.AspNetCore.Mvc;

namespace TISLabs.Controllers
{
    public class PortofolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
