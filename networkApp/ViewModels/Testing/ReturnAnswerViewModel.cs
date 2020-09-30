using System.Collections.Generic;

namespace networkApp.ViewModels.Testing
{
    public class ReturnAnswerViewModel
    {
        public int NumQuestion { get; set; }
        public List<string> TrueAnswers { get; set; } = new List<string>();
        public int CountTrueAnswers { get; set; }
    }
}
