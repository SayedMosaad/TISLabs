using Microsoft.AspNetCore.Mvc;

namespace TISLabs.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
