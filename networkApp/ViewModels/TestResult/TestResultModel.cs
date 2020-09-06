using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.ViewModels.TestResult
{
    public class TestResultModel
    {
        public string FNpLN { get; set; }
        public int Group { get; set; }
        public List<DetailResult> Details { get; set; }

    }
}
