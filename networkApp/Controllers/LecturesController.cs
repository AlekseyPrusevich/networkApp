using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace networkApp.Controllers
{
    public class LecturesController : Controller
    {
        public IActionResult Motherboard()
        {
            return View();
        }

        public IActionResult Processors()
        {
            return View();
        }

        public IActionResult Memory()
        {
            return View();
        }
    }
}
