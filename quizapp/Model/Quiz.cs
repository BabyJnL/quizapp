using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizapp.Model
{
    public class Quiz: DB
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }

        public Quiz(string title, string type, string category)
        {
            if (type == "Multiple Choice")
                type = "multiple_choice";

            this.Title = title;
            this.Type = type;
            this.Category = category;
        }

        public void Save()
        {
            // Save quiz to database
            string sql = "INSERT INTO quizzes (title, type, category) VALUES (@title, @type, @category)";
            MySqlCommand insertCmd = new MySqlCommand(sql, Connection);

            insertCmd.Parameters.AddWithValue("@title", this.Title);
            insertCmd.Parameters.AddWithValue("@type", this.Type);
            insertCmd.Parameters.AddWithValue("@category", this.Category);

            try
            {
                Connection.Open();
                insertCmd.ExecuteNonQuery();
                Dialog.Info("New quiz has been added");
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Duplicate entry")) Dialog.Error($"Quiz with title {this.Title} already exists!");
                else Dialog.Bug($"{e.Message}");
            }
            finally
            {
                Connection.Close();
            }
        }

        public static List<Quiz> GetAll()
        {
            List<Quiz> quizzes = new List<Quiz>();

            string sql = "SELECT * FROM quizzes";
            MySqlCommand queryCommand = new MySqlCommand(sql, Connection);

            try
            {
                Connection.Open();
                using (MySqlDataReader reader = queryCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Quiz quiz = new Quiz(reader["title"].ToString(), reader["type"].ToString(), reader["category"].ToString());
                        quiz.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        quizzes.Add(quiz);
                    }
                }
            }
            catch (Exception e)
            {
                Dialog.Error(e.Message);
            }
            finally
            {
                Connection.Close();
            }
            return quizzes;
        }

        public static void Delete(int quizId)
        {
            string sql = "DELETE FROM quizzes WHERE id = @quizId";
            MySqlCommand deleteCmd = new MySqlCommand(sql, Connection);

            deleteCmd.Parameters.AddWithValue("@quizId", quizId);

            try
            {
                Connection.Open();
                deleteCmd.ExecuteNonQuery();
                Dialog.Info("Quiz successfully deleted");
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
    }
}
