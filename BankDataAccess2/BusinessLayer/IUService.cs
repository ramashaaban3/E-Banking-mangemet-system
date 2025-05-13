using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IUserService
    {
        void Register(string fullName, string username, string password);
        bool Login(string fullName, string username, string password);
        bool IsUsernameTaken(string username);
        bool IsFullNameTaken(string fullName);
        List<string> GetAllUsers();
    }
}
