﻿using Microsoft.AspNetCore.Mvc;

namespace Lesson09.Lab.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class DashboardController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }


    }
}
