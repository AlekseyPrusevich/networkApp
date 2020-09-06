using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using networkApp.Models;
using networkApp.ViewModels.TestResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.Controllers
{
    [Authorize]
    public class TestResultController : Controller
    {
        ApplicationContext context;
        public TestResultController(ApplicationContext context)
        {
            this.context = context;
        }
        //[HttpGet]
        //public ActionResult Index()
        //{
        //    var userMail = User.Identity.Name;
        //    var userId = context.Users.Where(u => u.Email == userMail).Select(u => u.Id).FirstOrDefault();
        //    var result = context.Tests.Include(t => t.User).Where(t => t.User.Id == userId).Select(t =>
        //        new TestResultModel
        //        {
        //            NameSurname = t.User.FirstName + " " + t.User.LastName,
        //            Group = t.User.Group,
        //            TestName = t.Name,
        //            Result = t.Mark,
        //            CountAllQuestions = t.CountAllQuestions
        //        });
        //    return View(result);
        //}

        [HttpGet]
        public ActionResult Index()
        {
            var result = context.Tests.Include(t => t.User).Where(t => t.User.Id == t.UserId).Select(t =>
                new TestResultModel 
                { 
                    FNpLN = t.User.FirstName + " " + t.User.LastName,
                    Group = t.User.Group,
                    Details = new List<DetailResult>()
                    {
                        new DetailResult
                        {
                            CountAllQuestions = t.CountAllQuestions,
                            Result = t.Mark,
                            TestName = t.Name,
                            TestDate = t.DateTest                            
                        }
                    }
                }).ToList();
            
            return View("Index", result);
            
        }
    }
}
