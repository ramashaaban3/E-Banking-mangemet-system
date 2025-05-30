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
        public static void InsertTransaction(int senderId, int receiverId, decimal amount, string description, DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankDBConnection"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Transactions (SenderId, ReceiverId, Amount, Description, Date) " +
                    "VALUES (@SenderId, @ReceiverId, @Amount, @Description, @Date)", conn);

                cmd.Parameters.AddWithValue("@SenderId", senderId);
                cmd.Parameters.AddWithValue("@ReceiverId", receiverId);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Date", date);

                cmd.ExecuteNonQuery();
            }
        }


        // Hesaba Ait Tüm İşlemleri Listeleme

        public static List<string> GetTransactionsByAccountID(int accountId)
        {
            List<string> transactions = new List<string>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"
            SELECT TransactionID, SenderId, ReceiverId, Amount, Description, Date
            FROM Transactions
            WHERE SenderId = @AccountID OR ReceiverId = @AccountID
            ORDER BY Date DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", accountId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int tid = (int)reader["TransactionID"];
                        int sender = (int)reader["SenderId"];
                        int receiver = (int)reader["ReceiverId"];
                        decimal amount = (decimal)reader["Amount"];
                        string description = reader["Description"].ToString();
                        DateTime date = (DateTime)reader["Date"];

                        transactions.Add($"ID: {tid}, {sender} ➝ {receiver}, Tutar: {amount} ₺, Açıklama: {description}, Tarih: {date}");
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
