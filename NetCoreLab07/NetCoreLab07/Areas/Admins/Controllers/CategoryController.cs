﻿using Microsoft.AspNetCore.Mvc;

namespace NetCoreLab07.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
