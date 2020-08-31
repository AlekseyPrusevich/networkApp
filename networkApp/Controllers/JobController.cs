using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingValidation.Models;

namespace ModelBindingValidation.Comtrollers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(JobApplication jobApplication)
        {
            return View("Accepted", jobApplication);
        }
    }
}
