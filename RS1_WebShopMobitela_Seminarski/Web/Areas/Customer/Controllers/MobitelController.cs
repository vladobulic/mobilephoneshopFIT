﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class MobitelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
