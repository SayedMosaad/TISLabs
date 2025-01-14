using Microsoft.AspNetCore.Mvc;

namespace TISLabs.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
