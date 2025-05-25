using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace BankDataAccess2.DataAccess
{
    internal class AccountDataAccess
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["BankDBConnection"].ConnectionString;

        // Hesap Ekleme
        public static void InsertAccount(int clientID, decimal initialBalance)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Accounts (ClientID, Balance) VALUES (@ClientID, @Balance)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClientID", clientID);
                cmd.Parameters.AddWithValue("@Balance", initialBalance);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hesap eklenemedi: " + ex.Message);
                }
            }
        }

        // Tüm Hespları Listele
        public static List<string> GetAllAccounts()
        {
            List<string> accounts = new List<string>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT AccountID, ClientID, Balance FROM Accounts";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string row = $"ID: {reader["AccountID"]}, Müşteri: {reader["ClientID"]}, Bakiye: {reader["Balance"]}";
                        accounts.Add(row);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hesap listesi alınamadı: " + ex.Message);
                }
            }

            return accounts;
        }

        // Para Ekle
        public static void Deposit(int accountID, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Accounts SET Balance = Balance + @Amount WHERE AccountID = @AccountID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@AccountID", accountID);

                try
                {
                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();

                    if (affected == 0)
                        throw new Exception("Hesap bulunamadı."); // EKLENDİ
                }
                catch (Exception ex)
                {
                    throw new Exception("Para yatırma işlemi başarısız: " + ex.Message);
                }
            }
        }

        // Para Çekme
        public static void Withdraw(int accountID, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string checkQuery = "SELECT Balance FROM Accounts WHERE AccountID = @AccountID";
                string updateQuery = "UPDATE Accounts SET Balance = Balance - @Amount WHERE AccountID = @AccountID";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@AccountID", accountID);

                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@AccountID", accountID);
                updateCmd.Parameters.AddWithValue("@Amount", amount);

                try
                {
                    conn.Open();

                    object result = checkCmd.ExecuteScalar();

                    if (result == null)
                        throw new Exception("Hesap bulunamadı.");

                    decimal currentBalance = Convert.ToDecimal(result);

                    if (currentBalance < amount)
                        throw new Exception("Yetersiz bakiye.");

                    int affected = updateCmd.ExecuteNonQuery();

                    if (affected == 0)
                        throw new Exception("Bilinmeyen hata oluştu.");
                }
                catch (Exception ex)
                {
                    throw new Exception("Para çekme işlemi başarısız: " + ex.Message);
                }
            }
        }


        // Hesap Silme 
        public static void DeleteAccount(int accountID)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM Accounts WHERE AccountID = @AccountID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", accountID);

                try
                {
                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();

                    if (affected == 0)
                        throw new Exception("Hesap bulunamadı."); // EKLENDİ
                }
                catch (Exception ex)
                {
                    throw new Exception("Hesap silinemedi: " + ex.Message);
                }
            }
        }




    }
}
