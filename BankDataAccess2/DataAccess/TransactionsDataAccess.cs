using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BankDataAccess2.DataAccess
{
    internal class TransactionsDataAccess
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["BankDBConnection"].ConnectionString;

        // İşlem Ekleme
        public static void InsertTransaction(int accountID, decimal amount, string type)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Transactions (AccountID, Amount, Type) VALUES (@AccountID, @Amount, @Type)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", accountID);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Type", type);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("İşlem eklenemedi: " + ex.Message);
                }
            }
        }
        // Hesaba Ait Tüm İşlemleri Listeleme

        public static List<string> GetTransactionsByAccountID(int accountID)
        {
            List<string> transactions = new List<string>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT Amount, Type, Date FROM Transactions WHERE AccountID = @AccountID ORDER BY Date DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", accountID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string row = $"{reader["Date"]}: {reader["Type"]} - {reader["Amount"]}₺";
                        transactions.Add(row);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("İşlem geçmişi alınamadı: " + ex.Message);
                }
            }

            return transactions;
        }


    }
}
