﻿using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SbcCapstone.Data;
using SbcCapstone.Models;

namespace SbcCapstone.Controllers
{
    public class HomeController : BaseController
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}