namespace networkApp.ViewModels.Testing
{
    public class AnswerViewModel
    {
        public int Num { get; set; }

        public string Text { get; set; }

        public string Type { get; set; }

        public string ValueAnswer { get; set; }

        public AnswerViewModel(int num, string text, string type, string valueAnswer)
        {
            Num = num;
            Text = text;
            Type = type;
            ValueAnswer = valueAnswer;
        }
    }
}
