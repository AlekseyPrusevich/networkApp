using System.Collections.Generic;

namespace networkApp.ViewModels.TestConstructor
{
    public class TestTC
    {
        public string TestName { get; set; }
        public List<QuestionTC> Questions { get; set; } = new List<QuestionTC>();
    }
}
