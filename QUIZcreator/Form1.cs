using QUIZcreator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZcreator
{
    public partial class Form1 : Form, IView
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            ClearForm();
        }
        #endregion

        #region IView
        public string QuestionText
        {
            get
            {
                return textBoxQuestion.Text;
            }
            set
            {
                textBoxQuestion.Text = value;
            }
        }

        public List<Tuple<string, bool>> Answers
        {
            get
            {
                List<Tuple<string, bool>> answers = new List<Tuple<string, bool>>();
                foreach (AnswerObject obj in flowLayoutPanel.Controls)
                {
                    if (obj.AnswerText != "")
                    {
                        Answer answer = new Answer(obj.AnswerText, obj.AnswerChecked);
                        answers.Add(answer.GetAnswer());
                    }
                }
                return answers;
            }
            set
            {
                flowLayoutPanel.Controls.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    AnswerObject answer = new AnswerObject();
                    answer.AnswerText = value[i].Item1;
                    answer.AnswerChecked = value[i].Item2;
                    flowLayoutPanel.Controls.Add(answer);
                }
            }
        }

        public List<Tuple<string, uint, List<Tuple<string, bool>>>> Questions
        {
            set
            {
                int ind = 0;
                treeViewQuestions.Nodes.Clear();
                foreach (var Question in value)
                {
                    treeViewQuestions.Nodes.Add($"{Question.Item1} / Points: {Question.Item2}");
                    for (int i = 0; i < Question.Item3.Count; i++)
                    {
                        treeViewQuestions.Nodes[ind].Nodes.Add($"{Question.Item3[i].Item1}; {Question.Item3[i].Item2}");
                    }
                    ind++;
                }
                treeViewQuestions.CollapseAll();
                if (ind != 0) treeViewQuestions.Nodes[ind - 1].Expand();
            }
        }

        public uint Points
        {
            get
            {
                return (uint)numericUDpoints.Value;
            }
            set
            {
                numericUDpoints.Value = (decimal)value;
            }
        }

        public uint TotalPoints
        {
            set
            {
                labelTotalPoints.Text = value.ToString();
            }
        }

        public void ShowMessage(string MessageText)
        {
            MessageBox.Show(MessageText);
        }
        public void ClearForm()
        {
            flowLayoutPanel.Controls.Clear();
            for (int i = 0; i < 4; i++)
            {
                AnswerObject answer = new AnswerObject();
                flowLayoutPanel.Controls.Add(answer);
            }
            QuestionText = "";
            Points = 1;
        }

        public int SelectedQuestionIndex
        {
            get
            {
                try
                {
                    return treeViewQuestions.SelectedNode.Index;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
        #endregion

        #region Private functions and variables/controls
        private bool Validate()
        {
            if (QuestionText == "")
            {
                ShowMessage("Insert question");
                return false;
            } else if (Answers.Count < 2)
            {
                ShowMessage("Give at least two answers");
                return false;
            }
            int CountAnswersPositive = 0, CountAnswersNegative = 0;
            for (int i = 0; i < Answers.Count; i++)
            {
                if (Answers[i].Item2) CountAnswersPositive++;
                else CountAnswersNegative++;
            }

            if (CountAnswersPositive == Answers.Count || CountAnswersNegative == Answers.Count)
            {
                ShowMessage("All answers marked as true/false");
                return false;
            } else return true;
        }

        private bool Editing = false;
        #endregion

        #region EventHandlers
        public event Action SubmitQuestion;
        public event Action<int> GetQuestion;
        public event Action EditQuestion;
        public event Action RemoveQuestion;

        public event Action<string> SaveQuiz;
        public event Action<string> LoadQuiz;
        #endregion

        #region Events
        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel.Controls.Count < 8)
            {
                AnswerObject answer = new AnswerObject();
                flowLayoutPanel.Controls.Add(answer);
            }
        }

        private void buttonRmAnswer_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel.Controls.Count > 0)
            {
                flowLayoutPanel.Controls.RemoveAt(flowLayoutPanel.Controls.Count - 1);
            }
        }

        private void buttonSubmitQuestion_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (SubmitQuestion != null)
                {
                    if (Editing == false)
                    {
                        SubmitQuestion();
                        ClearForm();
                    } else
                    {
                        EditQuestion();
                        Editing = false;
                        ClearForm();
                    }
                }
            }
        }
        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void treeViewQuestions_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Parent != null && e.Node.Parent.GetType() == typeof(TreeNode))
                {
                    // CHILD
                    treeViewQuestions.SelectedNode = e.Node.Parent;
                    contextMenuStrip1.Show(Cursor.Position);
                }
                else
                {
                    // PARENT
                    treeViewQuestions.SelectedNode = e.Node;
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetQuestion != null)
            {
                Editing = true;
                GetQuestion(SelectedQuestionIndex);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RemoveQuestion != null)
            {
                RemoveQuestion();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "XML (*.xml)|*.xml|JSON (*.json)|*.json";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(saveFileDialog1.FileName);
                if (SaveQuiz != null)
                {
                    SaveQuiz(saveFileDialog1.FileName);
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).FullName;
                openFileDialog1.Filter = "XML (*.xml)|*.xml|JSON (*.json)|*.json";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (LoadQuiz != null)
                        LoadQuiz(openFileDialog1.FileName);
                }
            }
        }
        #endregion
    }
}
