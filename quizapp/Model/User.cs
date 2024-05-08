using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizapp
{
    public class User: DB
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Constructor
        public User (string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public void Save()
        {
            // Save to database
            string sql = "INSERT INTO users (username, password) VALUES (@username, @password)";
            MySqlCommand insertCommand = new MySqlCommand(sql, Connection);

            insertCommand.Parameters.AddWithValue("@username", this.Username);
            insertCommand.Parameters.AddWithValue("@password", this.Password.GetHashCode());

            try
            {
                Connection.Open();
                insertCommand.ExecuteNonQuery();
                Dialog.Info("A new user has been added");
            }
            catch (Exception e)
            {
                Dialog.Error($"{e.Message}");
            }
            finally
            {
                Connection.Close();
            }
        }

        // Static method for authenticate user by matching their username and password
        public static bool Auth (string username, string password)
        {
            string sql = "SELECT * FROM users WHERE username = @username AND password = @password";
            MySqlCommand query = new MySqlCommand(sql, Connection);

            query.Parameters.AddWithValue("@username", username);
            query.Parameters.AddWithValue("@password", password.GetHashCode());

            try
            {
                Connection.Open();
                using (MySqlDataReader result = query.ExecuteReader())
                {
                    if (result.Read()) return true;
                }
            }
            catch (Exception e)
            {
                Dialog.Error($"{e.Message}");
            }
            finally
            {
                Connection.Close();
            }

            return false;
        }

        // Static method for retreive all users's data
        public static List<User> GetAll ()
        {
            List<User> users = new List<User>();

            string sql = "SELECT * FROM users";
            MySqlCommand queryCmd = new MySqlCommand(sql, Connection);

            try
            {
                Connection.Open();
                queryCmd.ExecuteNonQuery();
                using (MySqlDataReader reader = queryCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User(reader["username"].ToString(), reader["password"].ToString());
                        user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        users.Add(user);
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

            return users;
        }

        // Static method for remove user's data from database by user's id
        public static void Remove (int id)
        {
            string sql = "DELETE FROM users WHERE id = @id";
            MySqlCommand removeCommand = new MySqlCommand(sql, Connection);

            removeCommand.Parameters.AddWithValue("@id", id);

            try
            {
                Connection.Open();

                int rowsAffected = removeCommand.ExecuteNonQuery();
                if (rowsAffected == 0) throw new Exception("User is not founded");

                Dialog.Info($"User has been removed");
            }
            catch (Exception e)
            {
                Dialog.Error($"{e.Message}");
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
