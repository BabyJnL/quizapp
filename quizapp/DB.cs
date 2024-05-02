using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizapp
{
    public class DB
    {
        static string _connectionString = "server=localhost;user=root;password=password;database=quiz_dev";
        public static MySqlConnection Connection;
        public static void Connect ()
        {
            Connection = new MySqlConnection(_connectionString);
            
            try
            {
                Connection.Open();
                Console.WriteLine("[MySQL] Connection Estabilished");
            }
            catch (Exception e)
            {
                Dialog.Error($"[MySQL] {e.Message}");
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
