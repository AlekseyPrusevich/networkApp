using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using networkApp.ViewModels.Testing;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace networkApp.Controllers
{
    [Authorize]
    public class TestConstructorController : Controller
    {
        
        [HttpGet]        
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(string fileName)
        {            
            var isFileExist = System.IO.File.Exists(@"Tests\" + fileName);
            if (isFileExist)
            {
                System.IO.File.Delete(@"Tests\" + fileName);
            }
            return View("Edit");
        }

        [HttpPost]
        public IActionResult GetTest(string testName,
           List<string> nameQuestion,
           Dictionary<string, List<string>> answer,
           Dictionary<string, List<string>> isTrue,
           List<string> type)
        {
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
