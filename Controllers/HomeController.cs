﻿using Microsoft.AspNetCore.Mvc;

namespace MVC01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privcy()
        {
            return View();
        }
    }
}
