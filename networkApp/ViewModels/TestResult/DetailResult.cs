using System;

namespace networkApp.ViewModels.TestResult
{
    public class DetailResult
    {        
        public string TestName { get; set; }
        public string Result { get; set; }
        public int CountAllQuestions { get; set; }
        public DateTime TestDate { get; set; }
    }
}
