using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace BankDataAccess2.DataAccess
{
    internal class UserDataAccess
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["BankDBConnection"].ConnectionString;
        //private static string connStr = ConfigurationManager.ConnectionStrings["BankDBConnection"]?.ConnectionString ?? "BAGLANTI BULUNAMADI";


        public static void InsertUser(string fullName, string username, string password)
        {
          //  MessageBox.Show(connStr);

           

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Users (FullName, Username, Password) VALUES (@FullName, @Username, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Kullanıcı eklenemedi: " + ex.Message);
                }
            }
        }

        public static List<string> GetAllUsers()
        {
            List<string> userList = new List<string>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT FullName FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        userList.Add(reader["FullName"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Kullanıcılar alınamadı: " + ex.Message);
                }
            }

            return userList;
        }
        public static (string FullName, string Username, string Password) GetUserByFullName(string fullName)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT FullName, Username, Password FROM Users WHERE FullName = @FullName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", fullName);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string fName = reader["FullName"].ToString();
                        string username = reader["Username"].ToString();
                        string password = reader["Password"].ToString();
                        return (fName, username, password);
                    }

                    reader.Close();
                    return (null, null, null); // Kayıt bulunamadı
                }
                catch (Exception ex)
                {
                    throw new Exception("Kullanıcı detayı alınamadı: " + ex.Message);
                }
            }

            

        }

        public static void UpdateUserByFullName(string originalFullName, string newFullName, string newUsername, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"UPDATE Users 
                         SET FullName = @NewFullName, Username = @NewUsername, Password = @NewPassword 
                         WHERE FullName = @OriginalFullName";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewFullName", newFullName);
                cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@OriginalFullName", originalFullName);

                try
                {
                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();

                    if (affected == 0)
                        throw new Exception("Hiçbir kayıt güncellenmedi.");
                }
                catch (Exception ex)
                {
                    throw new Exception("Güncelleme hatası: " + ex.Message);
                }
            }
        }

        public static void DeleteUserByFullName(string fullName)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM Users WHERE FullName = @FullName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", fullName);

                try
                {
                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();

                    if (affected == 0)
                        throw new Exception("Kullanıcı bulunamadı veya silinemedi.");
                }
                catch (Exception ex)
                {
                    throw new Exception("Silme hatası: " + ex.Message);
                }
            }
        }


        //////
        /////
        ///
        public static (string FullName, string Username, string Password) GetUserByUsername(string username)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT FullName, Username, Password FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string fullName = reader["FullName"].ToString();
                        string userName = reader["Username"].ToString();
                        string password = reader["Password"].ToString();
                        return (fullName, userName, password);
                    }

                    reader.Close();
                    return (null, null, null); // kullanıcı bulunamadı
                }
                catch (Exception ex)
                {
                    throw new Exception("Kullanıcı adı ile arama hatası: " + ex.Message);
                }
            }
        }



        ///////
        /////
        ///

    }
}
