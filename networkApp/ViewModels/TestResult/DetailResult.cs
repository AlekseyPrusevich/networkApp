using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
