﻿using Microsoft.AspNetCore.Mvc;
using RookieShop.BackendAPI.Models;
using System.Diagnostics;

namespace RookieShop.BackendAPI.Controllers
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
            return Ok();
        }
    }
}