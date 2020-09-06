using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.ViewModels.TestConstructor
{
    public class AnswerTC
    {
        public List<string> Answers { get; set; } = new List<string>();
        public Dictionary<string, string> TrueAnswers { get; set; } = new Dictionary<string, string>();
    }
}
