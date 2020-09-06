using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.ViewModels.TestConstructor
{
    public class QuestionTC
    {
        public List<string> QuestionText { get; set; } = new List<string>();
        public List<string> Type { get; set; } = new List<string>();
        public List<AnswerTC> Answers { get; set; } = new List<AnswerTC>();
    }
}
