using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace networkApp.ViewModels
{
    public class Question
    {
        public int Num { get; set; }

        public string Text { get; set; }

        public IList<int> CountAnswer { get; set; }
        public List<Answer> AnswerList { get; set; }
        public Question()
        {
            CountAnswer = new List<int>();
            AnswerList = new List<Answer>();
        }

        public void addAnswer(Answer answer)
        {
            AnswerList.Add(answer);
        }
    }

    public class Answer
    {
        public int Num { get; set; }

        public string Text { get; set; }

        public string Type { get; set; }

        public string ValueAnswer { get; set; }

        public Answer(int num, string text, string type, string valueAnswer)
        {
            Num = num;
            Text = text;
            Type = type;
            ValueAnswer = valueAnswer;
        }
    }

    public class ReturnAnswers
    {
        public int NumQuestion { get; set; }
        public List<string> TrueAnswers { get; set; } = new List<string>();
        public int CountTrueAnswers { get; set; }
    }
    
}
