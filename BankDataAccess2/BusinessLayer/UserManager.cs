using System;
using System.Collections.Generic;
using BankDataAccess2.DataAccess;
using BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BusinessLayer
{
    public class UserManager : IUserService
    {
        public bool Login(string fullName, string username, string password)
        {
            var user = UserDataAccess.GetUserByFullName(fullName);

            if (user.FullName == null)
            {
                LogsDataAccess.InsertLog($"Giriş başarısız (kullanıcı bulunamadı): {username}");
                return false;
            }

            if (user.FullName == fullName && user.Username == username && user.Password == password)
            {
                LogsDataAccess.InsertLog($"Giriş başarılı: {username}");
                return true;
            }

            LogsDataAccess.InsertLog($"Giriş başarısız (şifre hatalı): {username}");
            return false;
        }

        public void Register(string fullName, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Kullanıcı adı ve şifre boş olamaz.");

            if (password.Length < 6)
                throw new ArgumentException("Şifre en az 6 karakter olmalıdır.");

            if (IsUsernameTaken(username))
                throw new ArgumentException("Bu kullanıcı adı zaten kullanılıyor.");

            UserDataAccess.InsertUser(fullName, username, password);
            LogsDataAccess.InsertLog($"Yeni kullanıcı kaydı: {fullName} ({username})");
        }


        public bool IsUsernameTaken(string username)
        {
            var user = UserDataAccess.GetUserByUsername(username); // ✅ Doğru metot
            return user.Username != null;
        }


        public bool IsFullNameTaken(string fullName)
        {
            var user = UserDataAccess.GetUserByFullName(fullName);
            return user.FullName != null;
        }

        public List<string> GetAllUsers()
        {
            return UserDataAccess.GetAllUsers();
        }
    }
}
