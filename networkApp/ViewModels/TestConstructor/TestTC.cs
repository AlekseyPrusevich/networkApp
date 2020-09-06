using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.ViewModels.TestConstructor
{
    public class TestTC
    {
        public string TestName { get; set; }
        public List<QuestionTC> Questions { get; set; } = new List<QuestionTC>();
    }
}
