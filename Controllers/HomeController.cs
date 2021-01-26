﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using G8InstaDev.Models;

namespace G8InstaDev.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Feed feedModel = new Feed();
            ViewBag.Feeds = feedModel.ReadAll();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
