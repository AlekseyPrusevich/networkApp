using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using networkApp.Models;
using networkApp.ViewModels.TestResult;
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
        

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var result = await context.Tests.Include(t => t.User).Where(t => t.User.Id == t.UserId).Select(t =>
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
                }).ToListAsync();
            
            return View("Index", result);
            
        }

        [HttpPost]
        public async Task<ActionResult> Index(string fi, int? group, string testName)
        {

            //full
            if (!string.IsNullOrEmpty(fi) && group != null && !string.IsNullOrEmpty(testName))
            {
                var result = await context.Tests.Include(t => t.User)
                    .Where(t =>
                    t.User.Group == group &&
                    (t.User.FirstName + " " + t.User.LastName) == fi &&
                    t.Name == testName)
                    .Select(
                    t =>
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
                        }).ToListAsync();
                return View("Index", result);
            }// 1 i 2
            else if (!string.IsNullOrEmpty(fi) && group != null && string.IsNullOrEmpty(testName))
            {
                var result = await context.Tests.Include(t => t.User)
                   .Where(t =>
                   t.User.Group == group &&
                   (t.User.FirstName + " " + t.User.LastName) == fi)
                   .Select(
                   t =>
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
                       }).ToListAsync();
                return View("Index", result);
            }// 1 i 3
            else if (!string.IsNullOrEmpty(fi) && group == null && !string.IsNullOrEmpty(testName))
            {
                var result = await context.Tests.Include(t => t.User)
                    .Where(t =>
                    (t.User.FirstName + " " + t.User.LastName) == fi &&
                    t.Name == testName)
                    .Select(
                    t =>
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
                        }).ToListAsync();
                return View("Index", result);
            }//2 i 3
            else if (string.IsNullOrEmpty(fi) && group != null && !string.IsNullOrEmpty(testName))
            {
                var result = await context.Tests.Include(t => t.User)
                   .Where(t =>
                   t.User.Group == group &&
                   t.Name == testName)
                   .Select(
                   t =>
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
                       }).ToListAsync();
                return View("Index", result);
            }//1 only
            else if (!string.IsNullOrEmpty(fi) && group == null && string.IsNullOrEmpty(testName))
            {
                var result = await context.Tests.Include(t => t.User)
                    .Where(t => (t.User.FirstName + " " + t.User.LastName) == fi)
                    .Select(
                    t =>
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
                        }).ToListAsync();
                return View("Index", result);
            }//2 only
            else if (string.IsNullOrEmpty(fi) && group != null && string.IsNullOrEmpty(testName))
            {
                var result = await context.Tests.Include(t => t.User)
                    .Where(t => t.User.Group == group)
                    .Select(
                    t =>
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
                        }).ToListAsync();
                return View("Index", result);
            }//3 only 
            else if (string.IsNullOrEmpty(fi) && group == null && !string.IsNullOrEmpty(testName))
            {
                var result = await context.Tests.Include(t => t.User)
                    .Where(t => t.Name == testName)
                    .Select(
                    t =>
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
                        }).ToListAsync();
                return View("Index", result);
            }// all empty
            else
            {
                var result = await context.Tests.Include(t => t.User).Select(t =>
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
                    }).ToListAsync();

                return View("Index", result);
            }
        }
    }
}
