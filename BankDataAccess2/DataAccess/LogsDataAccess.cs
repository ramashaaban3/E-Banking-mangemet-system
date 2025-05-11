using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BankDataAccess2.DataAccess
{
    internal class LogsDataAccess
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["BankDBConnection"].ConnectionString;

        // Log Ekleme 
        public static void InsertLog(string message)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Logs (Message) VALUES (@Message)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Message", message);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Log eklenemedi: " + ex.Message);
                }
            }
        }

        // Tüm Logları Listeleme
        public static List<string> GetAllLogs()
        {
            List<string> logs = new List<string>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT Date, Message FROM Logs ORDER BY Date DESC";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string row = $"{reader["Date"]}: {reader["Message"]}";
                        logs.Add(row);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Log listesi alınamadı: " + ex.Message);
                }
            }

            return logs;
        }

        


    }
}
