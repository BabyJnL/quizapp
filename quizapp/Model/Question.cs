using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizapp.Model
{
    // Polymorphism Concept & Override method

    public class Question : DB
    {
        public int QuizId { get; set; }
        public string Name { get; set; }

        public Question(int QuizId, string Name)
        {
            this.QuizId = QuizId;
            this.Name = Name;
        }

        public virtual void Save()
        {
            string sql = "INSERT INTO question_lists (quizId, name) VALUES (@quizId, @name)";
            MySqlCommand insertCmd = new MySqlCommand(sql, Connection);

            insertCmd.Parameters.AddWithValue("@quizId", this.QuizId);
            insertCmd.Parameters.AddWithValue("@name", this.Name);

            try
            {
                Connection.Open();
                insertCmd.ExecuteNonQuery();
                Dialog.Info("Question successfully added");
            }
            catch (Exception e)
            {
                Dialog.Bug($"{e.Message}");
            }
            finally
            {
                Connection.Close();
            }
        }

        public static List<object> GetByQuizId (int quizId)
        {
            List<object> questions = new List<object>();

            string sql = "SELECT * FROM question_lists WHERE quizId = @quizId";

            MySqlCommand queryCmd = new MySqlCommand(sql, Connection);

            queryCmd.Parameters.AddWithValue("@quizId", quizId);

            try
            {
                Connection.Open();

                using (MySqlDataReader reader = queryCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var question = new
                        {
                            Question = reader["name"]
                        };
                        questions.Add(question);
                    }
                }
            }
            catch (Exception e)
            {
                Dialog.Bug($"{e.Message}");
            }
            finally
            {
                Connection.Close();
            }

            return questions;
        }

    }

    public class MultipleChoiceQuestion: Question
    {
        private string _correctAnswer;
        private List<string> _choices = new List<string>();
        public MultipleChoiceQuestion(int QuizId, string Name, List<string> choices, string correctAnswer) : base(QuizId, Name)
        {
            choices.ForEach(choice => this._choices.Add(choice));
            this._correctAnswer = correctAnswer;
        }

        public override void Save()
        {
            string questionSQL = "INSERT INTO question_lists (quizId, name, correct_answer) VALUES (@quizId, @name, @correctAnswer)";

            MySqlCommand insertQuestion = new MySqlCommand(questionSQL, Connection);

            insertQuestion.Parameters.AddWithValue("@quizId", this.QuizId);
            insertQuestion.Parameters.AddWithValue("@name", this.Name);
            insertQuestion.Parameters.AddWithValue("@correctAnswer", this._correctAnswer);

            try
            {
                Connection.Open();
                insertQuestion.ExecuteNonQuery();

                int questionId = (int)insertQuestion.LastInsertedId;

                _choices.ForEach(choice =>
                {
                    string answerSQL = "INSERT INTO answer_lists (questionId, answer) VALUES (@questionId, @answer)";
                    MySqlCommand insertAnswer = new MySqlCommand(answerSQL, Connection);
                    insertAnswer.Parameters.AddWithValue("@questionId", questionId);
                    insertAnswer.Parameters.AddWithValue("@answer", choice);
                    insertAnswer.ExecuteNonQuery();
                });

                Dialog.Info("Question successfully added");
            }
            catch (Exception e)
            {
                Dialog.Bug($"{e.Message}");
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool CheckAnswer(string answer)
        {
            return (_correctAnswer == answer);
        }

        public static List<object> GetByQuizId(int quizId)
        {
            List<object> questions = new List<object>();

            string sql = "SELECT question_lists.name AS question, question_lists.correct_answer, GROUP_CONCAT(answer_lists.answer) AS answer_lists FROM question_lists JOIN answer_lists ON question_lists.id = answer_lists.questionId WHERE question_lists.quizId = @quizId GROUP BY question_lists.name, question_lists.correct_answer;";
            MySqlCommand queryCmd = new MySqlCommand(sql, Connection);

            queryCmd.Parameters.AddWithValue("@quizId", quizId);

            try
            {
                Connection.Open();
                using (MySqlDataReader reader = queryCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var question = new
                        {
                            Question = reader["question"],
                            CorrectAnswer = reader["correct_answer"],
                            AnswerLists = ((string)reader["answer_lists"]).Split(',').ToList()
                        };
                        questions.Add(question);
                    }
                }
            }
            catch (Exception e)
            {
                Dialog.Bug($"{e.Message}");
            }
            finally
            {
                Connection.Close();
            }

            return questions;
        }
    }
}
