using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BankDataAccess2.DataAccess
{
    internal class ClientDataAccess
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["BankDBConnection"].ConnectionString;

        public static void InsertClient(string fullName, string phone)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Clients (FullName, Phone) VALUES (@FullName, @Phone)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Phone", phone);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşteri eklenemedi: " + ex.Message);
                }
            }
        }

        public static List<string> GetAllClients()
        {
            List<string> clients = new List<string>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT FullName FROM Clients";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clients.Add(reader["FullName"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşteri listesi alınamadı: " + ex.Message);
                }
            }

            return clients;
        }

        public static void UpdateClientByFullName(string originalFullName, string newFullName, string newPhone)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Clients SET FullName = @NewFullName, Phone = @NewPhone WHERE FullName = @OriginalFullName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewFullName", newFullName);
                cmd.Parameters.AddWithValue("@NewPhone", newPhone);
                cmd.Parameters.AddWithValue("@OriginalFullName", originalFullName);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşteri güncellenemedi: " + ex.Message);
                }
            }
        }
        public static void DeleteClientByFullName(string fullName)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM Clients WHERE FullName = @FullName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", fullName);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşteri silinemedi: " + ex.Message);
                }
            }
        }


    }
}
