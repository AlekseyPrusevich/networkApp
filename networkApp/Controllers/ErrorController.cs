using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace networkApp.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}
