using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using networkApp.Models;
using networkApp.ViewModels.Testing;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace networkApp.Controllers
{
    public class FileName
    {
        public string oldName { get; set; }
        public string oldNameFull { get; set; }
    }

    [Authorize(Roles = "admin, teacher")]
    public class TestConstructorController : Controller
    {
        private static Dictionary<string, string> DictFileNames = new Dictionary<string, string>();

        //DB
        public ApplicationContext Context { get; }

        public TestConstructorController(ApplicationContext context)
        {
            Context = context;
        }

        //Create Test
        [HttpGet]
        public IActionResult Create()
        {
            FileName fileName = new FileName();

            fileName.oldName = string.Empty;
            fileName.oldNameFull = string.Empty;
           
            return View();
        }

        //Edit Test
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AccessControl()
        {
            return View();
        }

        //Delte Test
        [HttpPost]
        public async Task<ActionResult> Delete(string fileName)
        {
            await deleteTestAsync(fileName);

            return View("Edit");
        }
               

        [HttpPost]
        public async Task<IActionResult> GetTest(string testName,
               List<string> nameQuestion,
               Dictionary<string, List<string>> answer,
               Dictionary<string, List<string>> isTrue,
               List<string> type)
        {
            var getUserName = HttpContext.User.Identity.Name;
            await createTestAsync(testName, nameQuestion, answer, isTrue, type, getUserName);
           
            return RedirectToAction("Index", "Home");
        }
        
        [HttpPost]
        public ActionResult EditConstructor(string fileName)
        {
            var getUserName = HttpContext.User.Identity.Name;

            if (!DictFileNames.ContainsKey(getUserName))
            {
                DictFileNames.Add(getUserName, fileName);
            }

            ViewBag.FileName = fileName.Replace("_", " ").Replace(".xml", "");
            fillQuestions(fileName);
            
            return View();
        }

        private void fillQuestions(string fileName_)
        {
            FileName fileName = new FileName();

            fileName.oldNameFull = fileName_;
            fileName.oldName = fileName_.Replace("_", " ").Replace(".xml", "");

            List<QuestionViewModel> questions = new List<QuestionViewModel>();
            double countQuestions;
            XDocument xdoc = XDocument.Load(@"Tests\" + fileName_);
            var counterQuestions = 0;
            foreach (var _root in xdoc.Element("questions").Elements("question"))
            {
                counterQuestions++;
                var question = new QuestionViewModel();

                var questionNumber = _root.Attribute("num").Value;
                var questionText = _root.Element("textQuestion").Value;
                question.Num = int.Parse(questionNumber);
                question.Text = questionText;

                int countAnswer = 0;

                foreach (var _answer in _root.Element("answers").Elements("answer"))
                {
                    countAnswer++;
                    int num = int.Parse(_answer.Element("numAnswer").Value);
                    string text = _answer.Element("textAnswer").Value;
                    string type = _answer.Element("type").Value;
                    string valueAnswer = _answer.Element("true-answer").Value;

                    var answer = new AnswerViewModel(num, text, type, valueAnswer);
                    question.AnswerList.Add(answer);
                    question.CountAnswer.Add(countAnswer);
                }
                countQuestions = counterQuestions;
                questions.Add(question);
            }

            ViewBag.Questions = questions;
        }

        private async Task deleteTestAsync(string fileName)
        {
            var isFileExist = System.IO.File.Exists(@"Tests\" + fileName);

            if (isFileExist)
            {
                System.IO.File.Delete(@"Tests\" + fileName);
            }

            var testprop = await Context.TestProp.FirstOrDefaultAsync(t => t.FilePath == @"Tests\" + fileName);
            if (testprop == null)
            {
                return;
            }
            Context.TestProp.Remove(testprop);
            await Context.SaveChangesAsync();
        }


        private async Task createTestAsync(string testName,
               List<string> nameQuestion,
               Dictionary<string, List<string>> answer,
               Dictionary<string, List<string>> isTrue,
               List<string> type,
               string keyDict)
        {
            string oldFile = "";
            var isCreated = System.IO.File.Exists(@"Tests\" + testName);

            if (!string.IsNullOrEmpty(testName) && !isCreated && DictFileNames.ContainsKey(keyDict))
            {
                DictFileNames.TryGetValue(keyDict, out oldFile);
                System.IO.File.Delete(@"Tests\" + oldFile);
                DictFileNames.Remove(keyDict);
            }

            XDocument xDoc = new XDocument();
            XElement questions = new XElement("questions");
            int counterTextQuestion = 0;
            foreach (var key in answer.Keys)
            {
                int counter = 0;
                XElement question = new XElement("question");
                question.SetAttributeValue("num", counterTextQuestion + 1);
                XElement textQuestion = new XElement("textQuestion", nameQuestion[counterTextQuestion]);
                question.Add(textQuestion);
                XElement answers = new XElement("answers");

                foreach (var value in answer[key])
                {
                    counter++;
                    XElement ans = new XElement("answer");
                    XElement numAnswer = new XElement("numAnswer", counter);
                    ans.Add(numAnswer);
                    XElement textAnswer = new XElement("textAnswer", value);
                    ans.Add(textAnswer);
                    XElement mType = new XElement("type", type[counterTextQuestion]);
                    ans.Add(mType);
                    XElement trueAnswer = new XElement("true-answer", isTrue[key].Contains(value));
                    ans.Add(trueAnswer);
                    answers.Add(ans);
                }
                counterTextQuestion++;
                question.Add(answers);
                questions.Add(question);
            }

            xDoc.Add(questions);
            xDoc.Save(@"Tests\" + testName.Replace(" ", "_") + ".xml");

            if (oldFile != "")
            {
                var testprop = await Context.TestProp.FirstOrDefaultAsync(t => t.FilePath == @"Tests\" + oldFile);

                if (testprop == null)
                {
                    Context.TestProp.Add(new TestProp { FilePath = @"Tests\" + testName.Replace(" ", "_") + ".xml" });
                }

                testprop.FilePath = @"Tests\" + testName.Replace(" ", "_") + ".xml";
                Context.TestProp.Update(testprop);
            }
            else
            {
                Context.TestProp.Add(new TestProp { FilePath = @"Tests\" + testName.Replace(" ", "_") + ".xml" });
            }

            await Context.SaveChangesAsync();
        }
    }
}
