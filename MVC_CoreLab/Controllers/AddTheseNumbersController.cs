using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_CoreLab.Models;

namespace MVC_CoreLab.Controllers
{
    public class AddTheseNumbersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FormSum()
        {
            return View();
        }

        public IActionResult ResultSum(AddNumbers addNumbers)
        {
            return View(addNumbers);
        }
    }
}