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
            List<string> nameQuestion,             
            Dictionary<string, List<string>> answer, 
            Dictionary<string, List<string>> isTrue,
            List<string> type)
        {
            XDocument xDoc = new XDocument();
            XElement questions= new XElement("questions");
            
            foreach (var key in answer.Keys)
            {
                int counter = 0;
                XElement question = new XElement("question");
                question.SetAttributeValue("num", key);
                XElement textQuestion = new XElement("textQuestion", nameQuestion[int.Parse(key) - 1]);
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
                    XElement mType = new XElement("type", type[int.Parse(key) - 1]);
                    ans.Add(mType);
                    XElement trueAnswer = new XElement("true-answer", isTrue[key].Contains(value));
                    ans.Add(trueAnswer);
                    answers.Add(ans);
                }              

                question.Add(answers);
                questions.Add(question);
            }

            xDoc.Add(questions);
            xDoc.Save(@"wwwroot\tests\" + testName.Replace(" ", "_") + ".xml");

            return RedirectToAction("Index", "Home");
        }      
    }
}
