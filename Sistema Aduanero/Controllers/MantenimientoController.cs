﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema_Aduanero.Controllers
{
    public class MantenimientoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}