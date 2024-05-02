using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizapp.Model
{
    public class Quiz: DB
    {
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

            // Save quiz to database
            string sql = "INSERT INTO quizzes (title, type, category) VALUES (@title, @type, @category)";
            MySqlCommand insertCmd = new MySqlCommand(sql, Connection);

            insertCmd.Parameters.AddWithValue("@title", title);
            insertCmd.Parameters.AddWithValue("@type", type);
            insertCmd.Parameters.AddWithValue("@category", category);

            try
            {
                Connection.Open();
                insertCmd.ExecuteNonQuery();
                Dialog.Info("New quiz has been added");
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

        public static List<string> GetAll()
        {
            List<string> quizzes = new List<string>();

            string sql = "SELECT title FROM quizzes";
            MySqlCommand queryCommand = new MySqlCommand(sql, Connection);

            try
            {
                Connection.Open();
                using (MySqlDataReader reader = queryCommand.ExecuteReader())
                {
                    while (reader.Read()) quizzes.Add(reader["title"].ToString());
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
    }
}
