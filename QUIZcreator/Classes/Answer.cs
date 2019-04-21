using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZcreator.Classes
{
    public class Answer
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }

        public Answer() { }

        public Answer(string AnswerText, bool IsCorrect)
        {
            this.AnswerText = AnswerText;
            this.IsCorrect = IsCorrect;
        }

        //public override string ToString()
        //{
        //    return string.Format("{0};{1}", this.AnswerText, this.IsCorrect);
        //}

        public Tuple<string, bool> GetAnswer()
        {
            return new Tuple<string, bool>(AnswerText, IsCorrect);
        }
    }
}
