using System;
using System.Collections.Generic;
using BankDataAccess2.DataAccess;

namespace BusinessLayer
{
    public static class ClientManager
    {
        public static void AddClient(string fullName, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("İsim ve telefon numarası boş olamaz.");

            ClientDataAccess.InsertClient(fullName, phoneNumber);
        }

        public static List<string> GetAllClients()
        {
            return ClientDataAccess.GetAllClients();
        }

        public static void UpdateClient(string originalName, string newName, string newPhone)
        {
            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newPhone))
                throw new ArgumentException("Yeni bilgiler boş olamaz.");

            ClientDataAccess.UpdateClientByFullName(originalName, newName, newPhone);
        }

        public static void DeleteClient(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Silinecek isim boş olamaz.");

            ClientDataAccess.DeleteClientByFullName(fullName);
        }
    }
}
