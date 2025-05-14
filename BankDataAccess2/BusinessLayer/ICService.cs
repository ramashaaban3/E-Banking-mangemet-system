using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IClientService
    {
        void AddClient(string clientName, string phone);
        void UpdateClient(string originalName, string newName, string newPhone);
        void DeleteClient(string clientName);
        List<string> GetAllClients();
    }
}
