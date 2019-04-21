using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZcreator
{
    class Presenter
    {
        IView view;
        Model model;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.SubmitQuestion += View_SubmitQuestion;
            this.view.RemoveQuestion += View_RemoveQuestion;
            this.view.GetQuestion += View_GetQuestion;
            this.view.EditQuestion += View_EditQuestion;

            this.view.SaveQuiz += View_SaveQuiz;
            this.view.LoadQuiz += View_LoadQuiz;
        }

        private void RefreshTreeView()
        {
            // Get and refresh questions in TreeView
            this.view.Questions = model.GetQuestions;
            this.view.TotalPoints = model.TotalPoints;
        }

        private void View_SubmitQuestion()
        {
            model.AddQuestion(this.view.QuestionText, this.view.Points, this.view.Answers);
            RefreshTreeView();
        }

        private void View_RemoveQuestion()
        {
            model.DeleteQuestion(this.view.SelectedQuestionIndex);
            RefreshTreeView();
        }

        private void View_GetQuestion(int givenQuestionIndex)
        {
            this.view.QuestionText = model.GetQuestionData(givenQuestionIndex).Item1;
            this.view.Points = model.GetQuestionData(givenQuestionIndex).Item2;
            this.view.Answers = model.GetAnswers(givenQuestionIndex);
        }

        private void View_EditQuestion()
        {
            model.EditQuestion(this.view.SelectedQuestionIndex, this.view.QuestionText, this.view.Points, this.view.Answers);
            RefreshTreeView();
        }

        private void View_SaveQuiz(string fileName)
        {
            model.SaveQuiz(fileName);
        }

        private void View_LoadQuiz(string fileName)
        {
            try
            {
                model.LoadQuiz(fileName);
                RefreshTreeView();
            }
            catch (Exception)
            {
                view.ShowMessage("Problem with opening file");
            }
        }
    }
}
