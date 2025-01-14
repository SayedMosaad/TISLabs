using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TISLabs.Data.Data;
using TISLabs.Domain.Models;

namespace TISLabs.Areas.Admin.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ContactUsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var contactUs = await _db.ContactUs.ToListAsync();

            return View(contactUs);
        }
    }
}
