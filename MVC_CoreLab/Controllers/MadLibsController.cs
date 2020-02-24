using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_CoreLab.Models;

namespace MVC_CoreLab.Controllers
{
    public class MadLibsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MLForm()
        {
            return View();
        }

        public IActionResult MLComplete(Madlib madlib)
        {
            return View(madlib);
        }
    }

}