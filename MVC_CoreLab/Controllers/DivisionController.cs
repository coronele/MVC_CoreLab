using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_CoreLab.Models;

namespace MVC_CoreLab.Controllers
{
    public class DivisionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DivForm()
        {
            return View();
        }

        public IActionResult DivResults(Divide divide)
        {
            return View(divide);
        }
    }
}