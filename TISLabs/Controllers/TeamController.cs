﻿using Microsoft.AspNetCore.Mvc;

namespace TISLabs.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
