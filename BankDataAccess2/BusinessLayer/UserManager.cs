using System;
using System.Collections.Generic;
using BankDataAccess2.DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BusinessLayer
{
    public static class UserManager
    {
        public static bool Login(string fullName, string username, string password)
        {
            var user = UserDataAccess.GetUserByFullName(fullName);

            if (user.FullName == null) return false; // kullanıcı bulunamadıysa

            if (user.FullName == fullName && user.Username == username && user.Password == password)
            {
                return true;
            }

            return false;
        }

        public static void Register(string fullName, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Kullanıcı adı ve şifre boş olamaz.");

            UserDataAccess.InsertUser(fullName, username, password);
        }

        public static bool IsUsernameTaken(string username)
        {
            var user = UserDataAccess.GetUserByUsername(username); // ✅ Doğru metot
            return user.Username != null;
        }


        public static bool IsFullNameTaken(string fullName)
        {
            var user = UserDataAccess.GetUserByFullName(fullName);
            return user.FullName != null;
        }

        public static List<string> GetAllUsers()
        {
            return UserDataAccess.GetAllUsers();
        }
    }
}
