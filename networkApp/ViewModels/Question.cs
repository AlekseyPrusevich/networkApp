using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.ViewModels
{
    public class Question
    {
        public int NumQuestion { get; set; }

        public string TextQuestion { get; set; }

        public string TrueAnswer { get; set; }

        public IList<int> NumAnswer { get; set; }
        public IList<string> TextAnswer { get; set; }
        public Question()
        {
            NumAnswer = new List<int>();
            TextAnswer = new List<string>();
        }
    }
}
