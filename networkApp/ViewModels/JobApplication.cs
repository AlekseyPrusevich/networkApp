using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingValidation.Models
{
    public class JobApplication
    {
        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public string Sex { get; set; }

        public int Experience { get; set; }

        public bool TermsAccepted { get; set; }
    }
}
