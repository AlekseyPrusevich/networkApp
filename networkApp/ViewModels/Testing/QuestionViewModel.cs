using System.Collections.Generic;

namespace networkApp.ViewModels.Testing
{
    public class QuestionViewModel
    {
        public int Num { get; set; }
        public string Text { get; set; }
        public IList<int> CountAnswer { get; set; }
        public List<AnswerViewModel> AnswerList { get; set; }

        public QuestionViewModel()
        {
            CountAnswer = new List<int>();
            AnswerList = new List<AnswerViewModel>();
        }

        public void addAnswer(AnswerViewModel answer)
        {
            AnswerList.Add(answer);
        }
    }
}
