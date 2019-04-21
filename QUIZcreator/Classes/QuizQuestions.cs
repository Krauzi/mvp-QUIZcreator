using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZcreator.Classes
{
    public class QuizQuestions
    {
        public List<Question> Questions { get; set; }
        public uint TotalPoints { get; set; }

        public QuizQuestions()
        {
            Questions = new List<Question>();
        }
        public List<Tuple<string, uint, List<Tuple<string, bool>>>> GetQuestions()
        {
            return (from n in Enumerable.Range(0, Questions.Count) select Questions[n].GetQuestion()).ToList();
        }
    }
}
