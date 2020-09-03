using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.ViewModels.Testing
{
    public class ReturnAnswerViewModel
    {
        public int NumQuestion { get; set; }
        public List<string> TrueAnswers { get; set; } = new List<string>();
        public int CountTrueAnswers { get; set; }
    }
}
