﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartiSitesi.Controllers
{
    public class OrganizationController : Controller
    {
        public IActionResult OrganizationPage()
        {
            return View();
        }
    }
}
