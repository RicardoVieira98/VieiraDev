﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VieiraDev.Controllers
{
    public class GameDevController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}