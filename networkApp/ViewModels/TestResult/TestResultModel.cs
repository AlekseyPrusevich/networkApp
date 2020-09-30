using System.Collections.Generic;

namespace networkApp.ViewModels.TestResult
{
    public class TestResultModel
    {
        public string FNpLN { get; set; }
        public int Group { get; set; }
        public List<DetailResult> Details { get; set; }

    }
}
