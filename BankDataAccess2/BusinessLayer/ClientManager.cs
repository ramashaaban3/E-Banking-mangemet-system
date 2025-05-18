using System;
using System.Collections.Generic;
using BankDataAccess2.DataAccess;
using BankDataAccess2.Entities;

namespace BusinessLayer
{
    public class ClientManager : IClientService
    {
        public void AddClient(string fullName, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("İsim ve telefon numarası boş olamaz.");

            ClientDataAccess.InsertClient(fullName, phoneNumber);
            LogsDataAccess.InsertLog($"Müşteri eklendi: {fullName}, Tel: {phoneNumber}");
        }

        public List<string> GetAllClients()
        {
            return ClientDataAccess.GetAllClients();
        }

        public void UpdateClient(string originalName, string newName, string newPhone)
        {
            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newPhone))
                throw new ArgumentException("Yeni bilgiler boş olamaz.");

            ClientDataAccess.UpdateClientByFullName(originalName, newName, newPhone);
            LogsDataAccess.InsertLog($"Müşteri güncellendi: {originalName} → {newName}, Yeni Tel: {newPhone}");
        }


        public void DeleteClient(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Silinecek isim boş olamaz.");

            ClientDataAccess.DeleteClientByFullName(fullName);
            LogsDataAccess.InsertLog($"Müşteri silindi: {fullName}");
        }


        public Client GetClientByName(string fullName)
        {
            return ClientDataAccess.GetClientByName(fullName);
        }


    }
}
