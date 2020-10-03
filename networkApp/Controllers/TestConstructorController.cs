using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using networkApp.ViewModels.Testing;
using System.Collections.Generic;
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
        [HttpGet]
        public IActionResult Create()
        {
            FileName fileName = new FileName();

            fileName.oldName = string.Empty;
            fileName.oldNameFull = string.Empty;

            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        private async Task deleteTestAsync(string fileName)
        {
            await Task.Run(() => deleteTest(fileName));
        }

        private void deleteTest(string fileName)
        {
            var isFileExist = System.IO.File.Exists(@"Tests\" + fileName);

            if (isFileExist)
            {
                System.IO.File.Delete(@"Tests\" + fileName);
            }    
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string fileName)
        {
            await deleteTestAsync(fileName);

            return View("Edit");
        }

        private async Task createTestAsync(string testName,
               List<string> nameQuestion,
               Dictionary<string, List<string>> answer,
               Dictionary<string, List<string>> isTrue,
               List<string> type)
        {
            await Task.Run(() => createTest(testName, nameQuestion, answer, isTrue, type));
        }

        private void createTest(string testName,
               List<string> nameQuestion,
               Dictionary<string, List<string>> answer,
               Dictionary<string, List<string>> isTrue,
               List<string> type)
        {
            FileName fileName = new FileName();

            var isCreated = System.IO.File.Exists(@"Tests\" + fileName.oldNameFull);

            if (fileName.oldName != testName && isCreated)
            {
                System.IO.File.Delete(@"Tests\" + fileName.oldNameFull);
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
        }


        [HttpPost]
        public async Task<IActionResult> GetTest(string testName,
               List<string> nameQuestion,
               Dictionary<string, List<string>> answer,
               Dictionary<string, List<string>> isTrue,
               List<string> type)
        {
            await createTestAsync(testName, nameQuestion, answer, isTrue, type);
           
            return RedirectToAction("Index", "Home");
        }
        

        [HttpPost]
        public ActionResult EditConstructor(string fileName)
        {
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
    }
}
