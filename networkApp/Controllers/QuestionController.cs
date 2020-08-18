using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using networkApp.ViewModels;

namespace networkApp.Controllers
{
    public class QuestionController : Controller
    {
        public int numAnswer;
        public string textAnswer;

        public IActionResult Index()
        {
            List<Question> questions = new List<Question>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Data/question.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                Question question = new Question();
                Answer answer = new Answer();

                XmlNode attr = xnode.Attributes.GetNamedItem("num");
                if (attr != null)
                    question.NumQuestion = Int32.Parse(attr.Value);

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "textQuestion")
                        question.TextQuestion = childnode.InnerText;

                    if (childnode.Name == "trueAnswer")
                        question.TrueAnswer = childnode.InnerText;

                    if (childnode.Name == "answers")
                    {
                        numAnswer = 0;

                        foreach (XmlNode answernode in childnode.ChildNodes)
                        {
                            numAnswer++;
                            question.NumAnswer.Add(numAnswer);

                            if (answernode.Name == "answer")
                                question.TextAnswer.Add(answernode.InnerText);
                        }
                    }
                }
                questions.Add(question);
            }

            return View(questions);
        }
    }
}
