using System;

namespace networkApp.Models
{
    public class Tests
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int TrueAnswersCount { get; set; } 
        
        public int CountAllQuestions { get; set; }

        public string Mark { get; set; }

        public DateTime DateTest { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
