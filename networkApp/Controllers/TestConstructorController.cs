using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Xml.Linq;

namespace networkApp.Controllers
{
    [Authorize]
    public class TestConstructorController : Controller
    {
        [HttpGet]        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetTest(string testName, 
            Dictionary<string, string> nameQuestion,             
            Dictionary<string, List<string>> answer, 
            Dictionary<string, List<string>> isTrue,
            List<string> type)
        {
            XDocument xDoc = new XDocument();
            
            return Ok();
        }
    }
}
