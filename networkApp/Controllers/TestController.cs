using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using networkApp.Models;
using networkApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace networkApp.Controllers
{
    
    public class TestController: Controller
    {
        ApplicationContext _context;
        public TestController(ApplicationContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> AddResult(AddTestResultModel model)
        {
            var userMail = User.Identity.Name;
            var userId = _context.Users.Where(u => u.Email == userMail).Select(u => u.Id).FirstOrDefault();
            var test = new Tests
            {
                //Mark = model.Murk,
                Name = model.TestName,
                UserId = userId
            };
            _context.Tests.Add(test);
            await _context.SaveChangesAsync();
            return Created(nameof(this.AddResult), test);
        }
    }
}
