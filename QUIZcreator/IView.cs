using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZcreator
{
    interface IView
    {
        string QuestionText { get; set; }
        uint Points { get; set; }
        uint TotalPoints { set; }
        int SelectedQuestionIndex { get;  }

        List<Tuple<string, bool>> Answers { get; set; }
        List<Tuple<string, uint, List<Tuple<string, bool>>>> Questions { set; }

        void ShowMessage(string MessageText);
        void ClearForm();

        event Action SubmitQuestion;
        event Action<int> GetQuestion;
        event Action EditQuestion;
        event Action RemoveQuestion;

        event Action<string> SaveQuiz;
        event Action<string> LoadQuiz;
    }
}
