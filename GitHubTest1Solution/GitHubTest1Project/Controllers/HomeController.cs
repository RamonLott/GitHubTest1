﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GitHubTest1Project.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(new string[] { "C#", "Language", "Features" });
        }
    }
}