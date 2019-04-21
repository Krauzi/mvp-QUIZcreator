using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZcreator.Classes
{
    public class Question
    {

        public string QuestionText { get; set; }
        public uint QuestionPoints { get; set; }
        public List<Answer> Answers { get; set; }

        public Question() { }

        public Question(string QuestionText, uint QuestionPoints, List<Tuple<string, bool>> Answers)
        {
            this.QuestionText = QuestionText;
            this.QuestionPoints = QuestionPoints;

            this.Answers = new List<Answer>();
            foreach (var item in Answers)
            {
                this.Answers.Add(new Answer(item.Item1, item.Item2));
            }
        }

        //public override string ToString()
        //{
        //    return string.Format("{0};{1}", this.QuestionText, this.QuestionPoints);
        //}

        public Tuple<string, uint, List<Tuple<string, bool>>> GetQuestion()
        {
            List<Tuple<string, bool>> ans = (from n in Enumerable.Range(0, Answers.Count)
                                             select Answers[n].GetAnswer()).ToList();
            return new Tuple<string, uint, List<Tuple<string, bool>>>(QuestionText, QuestionPoints, ans);
        }
    }
}
