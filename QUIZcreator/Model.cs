using QUIZcreator.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Web.Script.Serialization;

namespace QUIZcreator
{
    class Model
    {
        private QuizQuestions _quizInstance;
        public Model()
        {
            _quizInstance = new QuizQuestions();
        }

        public uint TotalPoints
        {
            get
            {
                return _quizInstance.TotalPoints;
            }
        }

        #region Get Answers/Questions/Question Data
        public List<Tuple<string, uint, List<Tuple<string, bool>>>> GetQuestions
        {
            get
            {
                return _quizInstance.GetQuestions();
            }
        }

        public List<Tuple<string, bool>> GetAnswers(int givenQuestionIndex)
        {
            return _quizInstance.Questions[givenQuestionIndex].GetQuestion().Item3;
        }

        public Tuple<string, uint, List<Tuple<string, bool>>> GetQuestionData(int givenQuestionIndex)
        {
            return _quizInstance.Questions[givenQuestionIndex].GetQuestion();
        }
        #endregion

        #region Add/Delete/Edit Question
        public void AddQuestion(string questionText, uint questionPoints, List<Tuple<string, bool>> questionAnswers)
        {
            _quizInstance.Questions.Add(new Question(questionText, questionPoints, questionAnswers));
            _quizInstance.TotalPoints += questionPoints;
        }

        public void DeleteQuestion(int givenQuestionIndex)
        {
            if (givenQuestionIndex != -1)
            {
                _quizInstance.TotalPoints -= _quizInstance.Questions[givenQuestionIndex].GetQuestion().Item2;
                _quizInstance.Questions.RemoveAt(givenQuestionIndex);
            }
        }
        public void EditQuestion(int givenQuestionIndex, string QuestionText, uint QuestionPoits, List<Tuple<string, bool>> Answers)
        {
            if (givenQuestionIndex != -1)
            {
                _quizInstance.TotalPoints -= _quizInstance.Questions[givenQuestionIndex].GetQuestion().Item2;

                Question obj = new Question(QuestionText, QuestionPoits, Answers);
                _quizInstance.Questions[givenQuestionIndex] = obj;
                obj = null;

                _quizInstance.TotalPoints += _quizInstance.Questions[givenQuestionIndex].GetQuestion().Item2;
            }
        }
        #endregion

        #region Save/Load Quiz
        public void SaveQuiz(string fileName)
        {
            if (fileName.EndsWith(".json"))
            {
                string outputJson = new JavaScriptSerializer().Serialize(_quizInstance);
                Console.WriteLine(outputJson);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(fileName)))
                {
                    outputFile.Write(outputJson);
                }
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(QuizQuestions));
                using (TextWriter writer = new StreamWriter(Path.Combine(fileName)))
                {
                    serializer.Serialize(writer, _quizInstance);
                }
            }
        }

        public void LoadQuiz(string fileName)
        {
            if (fileName.EndsWith(".json"))
            {
                using (StreamReader inputFile = new StreamReader(Path.Combine(fileName)))
                {
                    string inputJson = inputFile.ReadToEnd();

                    try
                    {
                        _quizInstance = new JavaScriptSerializer().Deserialize<QuizQuestions>(inputJson);
                    }
                    catch (Exception)
                    {
                        throw new Exception("Failed to open file");
                    }
                }
            }
            else
            {
                Console.WriteLine(fileName);
                XmlSerializer deserializer = new XmlSerializer(typeof(QuizQuestions));
                TextReader reader = new StreamReader(Path.Combine(fileName));
                object obj = deserializer.Deserialize(reader);
                _quizInstance = (QuizQuestions)obj;
                reader.Close();
            }
        }
        #endregion
    }
}
