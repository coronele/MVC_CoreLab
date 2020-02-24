using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_CoreLab.Models;

namespace MVC_CoreLab.Controllers
{
    public class MileageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MileageForm()
        {
            return View();
        }

        public IActionResult MileageResult(Mileage mileage)
        {
            return View(mileage);
        }
    }
}