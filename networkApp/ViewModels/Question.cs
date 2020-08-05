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

        public int numAnswer { get; set; }

        public string TextAnswer { get; set; }

        public string TrueAnswer { get; set; }
    }
}
