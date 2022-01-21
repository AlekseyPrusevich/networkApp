using ClosedXML.Excel;
using FastMember;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using networkApp.Models;
using networkApp.ViewModels.TestResult;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.Controllers
{
    public class NewTest
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
    public class ExportTable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupName { get; set; }
        public string TestName { get; set; }
        public string CountAllQuestions { get; set; }
        public string Result { get; set; }
        public string TestDate { get; set; }
    }

    [Authorize(Roles = "admin, teacher")]
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
                if (result.Count != 0)
                {
                    ViewBag.EmptyQuery = result.Count;
                    return View("Index", result);
                }
                else
                {
                    ViewBag.EmptyQuery = 0;
                    return View("Index");
                }

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
                if (result.Count != 0)
                {
                    ViewBag.EmptyQuery = result.Count;
                    return View("Index", result);
                }
                else
                {
                    ViewBag.EmptyQuery = 0;
                    return View("Index");
                }
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
                if (result.Count != 0)
                {
                    ViewBag.EmptyQuery = result.Count;
                    return View("Index", result);
                }
                else
                {
                    ViewBag.EmptyQuery = 0;
                    return View("Index");
                }
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
                if (result.Count != 0)
                {
                    ViewBag.EmptyQuery = result.Count;
                    return View("Index", result);
                }
                else
                {
                    ViewBag.EmptyQuery = 0;
                    return View("Index");
                }
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
                if (result.Count != 0)
                {
                    ViewBag.EmptyQuery = result.Count;
                    return View("Index", result);
                }
                else
                {
                    ViewBag.EmptyQuery = 0;
                    return View("Index");
                }
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
                if (result.Count != 0)
                {
                    ViewBag.EmptyQuery = result.Count;
                    return View("Index", result);
                }
                else
                {
                    ViewBag.EmptyQuery = 0;
                    return View("Index");
                }
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

                if (result.Count != 0)
                {
                    ViewBag.EmptyQuery = result.Count;
                    return View("Index", result);
                }
                else
                {
                    ViewBag.EmptyQuery = 0;
                    return View("Index");
                }
            }
        }

        [HttpPost]
        public async Task<ActionResult> ExcelExport(string fi, int? group, string testName)
        {
            List<TestResultModel> result;

            //full
            if (!string.IsNullOrEmpty(fi) && group != null && !string.IsNullOrEmpty(testName))
            {
                result = await context.Tests.Include(t => t.User)
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
            }// 1 i 2
            else if (!string.IsNullOrEmpty(fi) && group != null && string.IsNullOrEmpty(testName))
            {
                result = await context.Tests.Include(t => t.User)
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
            }// 1 i 3
            else if (!string.IsNullOrEmpty(fi) && group == null && !string.IsNullOrEmpty(testName))
            {
                result = await context.Tests.Include(t => t.User)
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
            }//2 i 3
            else if (string.IsNullOrEmpty(fi) && group != null && !string.IsNullOrEmpty(testName))
            {
                result = await context.Tests.Include(t => t.User)
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
            }//1 only
            else if (!string.IsNullOrEmpty(fi) && group == null && string.IsNullOrEmpty(testName))
            {
                result = await context.Tests.Include(t => t.User)
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
            }//2 only
            else if (string.IsNullOrEmpty(fi) && group != null && string.IsNullOrEmpty(testName))
            {
                result = await context.Tests.Include(t => t.User)
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
            }//3 only 
            else if (string.IsNullOrEmpty(fi) && group == null && !string.IsNullOrEmpty(testName))
            {
                result = await context.Tests.Include(t => t.User)
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
            }// all empty
            else
            {
                result = await context.Tests.Include(t => t.User).Select(t =>
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
            }

            if (result.Count != 0)
            {
                List<ExportTable> tables = new List<ExportTable>();

                string firstName;
                string lastName;

                foreach (var res in result)
                {
                    if (res.FNpLN == null)
                    {
                        firstName = "Администратор";
                        lastName = " ";
                    }
                    else if (res.FNpLN.IndexOf(" ") == -1)
                    {
                        firstName = res.FNpLN;
                        lastName = " ";
                    }
                    else
                    {
                        firstName = res.FNpLN.Substring(res.FNpLN.IndexOf(" ") + 1);
                        lastName = res.FNpLN.Substring(0, res.FNpLN.IndexOf(" ") + 1);
                    }

                    foreach (var detail in res.Details)
                    {
                        ExportTable tableRow = new ExportTable()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            GroupName = res.Group.ToString(),
                            TestName = detail.TestName,
                            CountAllQuestions = detail.CountAllQuestions.ToString(),
                            Result = detail.Result,
                            TestDate = detail.TestDate.ToString()
                        };

                        tables.Add(tableRow);
                    }
                }

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Результаты");

                    worksheet.Columns("A:A").Width = 7;
                    worksheet.Columns("B:B").Width = 20;
                    worksheet.Columns("C:C").Width = 16;
                    worksheet.Columns("D:D").Width = 8;
                    worksheet.Columns("E:E").Width = 70;
                    worksheet.Columns("F:F").Width = 12;
                    worksheet.Columns("G:G").Width = 12;
                    worksheet.Columns("H:H").Width = 24;

                    var currentRow = 1;
                    worksheet.Cell(currentRow, 1).Value = "№ п/п";
                    worksheet.Cell(currentRow, 2).Value = "Фамилия";
                    worksheet.Cell(currentRow, 3).Value = "Имя";
                    worksheet.Cell(currentRow, 4).Value = "Группа";
                    worksheet.Cell(currentRow, 5).Value = "Название теста";
                    worksheet.Cell(currentRow, 6).Value = "Количество вопросов";
                    worksheet.Cell(currentRow, 7).Value = "Результат выполнения";
                    worksheet.Cell(currentRow, 8).Value = "Время и дата сдачи теста";

                    foreach (var table in tables)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = (currentRow - 1);
                        worksheet.Cell(currentRow, 2).Value = table.FirstName;
                        worksheet.Cell(currentRow, 3).Value = table.LastName;
                        worksheet.Cell(currentRow, 4).Value = table.GroupName;
                        worksheet.Cell(currentRow, 5).Value = table.TestName;
                        worksheet.Cell(currentRow, 6).Value = Convert.ToInt32(table.CountAllQuestions);
                        worksheet.Cell(currentRow, 7).Value = Convert.ToDouble(table.Result) / 100;
                        worksheet.Cell(currentRow, 8).Value = table.TestDate;
                    }

                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        var content = stream.ToArray();

                        return File(
                            content,
                            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                            "Результаты.xlsx");
                    }
                }

                ViewBag.EmptyQuery = result.Count;
                return View("Index", result);
            }
            else
            {
                ViewBag.EmptyQuery = 0;
                return View("Index");
            }
        }
    }
}
