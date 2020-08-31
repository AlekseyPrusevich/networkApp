using System.Collections.Generic;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using networkApp.ViewModels;

namespace networkApp.Controllers
{
    public class QuestionController : Controller
    {
        public int countAnswer;
        public string textAnswer;

        public bool firstTry = true;
        
        public IActionResult Accepted()
        {
            return View();
        }

        public void fillQuestions()
        {
            List<Question> questions = new List<Question>();

            XDocument xdoc = XDocument.Load("Data/Этот_тест_я_использую_как_тестовый.xml");

            foreach (var _root in xdoc.Element("questions").Elements("question"))
            {
                var question = new Question();

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

                    var answer = new Answer(num, text, type, valueAnswer);
                    question.AnswerList.Add(answer);
                    question.CountAnswer.Add(countAnswer);
                }
                questions.Add(question);
            }

            ViewBag.Questions = questions;
        }

        [HttpGet]
        public IActionResult Index()
        {
            fillQuestions();

            return View();
        }


        [HttpPost]
        public IActionResult Result(Dictionary<string, List<string>> answers)
        {
            fillQuestions();

            List<ReturnAnswers> listAnswers = new List<ReturnAnswers>();

            int result = 0;
            var isNull = answers.ContainsKey("__RequestVerificationToken");

            if (!isNull)
            {
                XDocument xdoc = XDocument.Load("Data/Этот_тест_я_использую_как_тестовый.xml");

                foreach (var _root in xdoc.Element("questions").Elements("question"))
                {
                    var numQuestion = _root.Attribute("num").Value;

                    int countTrueAnswers = 0;
                    var XAnswer = new ReturnAnswers();
                    foreach (var _answer in _root.Element("answers").Elements("answer"))
                    {
                        string textAnswer = _answer.Element("textAnswer").Value;
                        string isTrueAnswer = _answer.Element("true-answer").Value;

                        if (isTrueAnswer == "true")
                        {
                            countTrueAnswers++;

                            XAnswer.NumQuestion = int.Parse(numQuestion);
                            XAnswer.TrueAnswers.Add(textAnswer);
                        }

                    }
                    XAnswer.CountTrueAnswers = countTrueAnswers;
                    listAnswers.Add(XAnswer);
                }

                foreach (var RAnswer in answers)
                {
                    foreach (var XAnswer in listAnswers)
                    {
                        bool isDouble = false;
                        if (int.Parse(RAnswer.Key) == XAnswer.NumQuestion && XAnswer.CountTrueAnswers == RAnswer.Value.Count)
                        {
                            bool WhileTrue = true;
                            for (int i = 0; i < XAnswer.CountTrueAnswers; i++)
                            {
                                if (WhileTrue)
                                {
                                    if (RAnswer.Value[i] == XAnswer.TrueAnswers[i])
                                    {
                                        if (!isDouble)
                                        {
                                            result++;
                                            isDouble = true;
                                        }
                                    }
                                    else if (isDouble)
                                    {
                                        result--;
                                    }
                                    else
                                    {
                                        WhileTrue = false;
                                    }

                                }
                            }
                        }
                    }
                }
            }

            ViewBag.Ball = result;
            ViewBag.ResultAnswers = answers;

            return View();
        }
    }
           
}