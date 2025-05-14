using System;
using System.Collections.Generic;
using BankDataAccess2.DataAccess;

namespace BusinessLayer
{
    public class AccountManager : IAccountService
    {
        public void OpenAccount(int clientId, decimal initialBalance)
        {
            if (initialBalance < 0)
                throw new ArgumentException("Başlangıç bakiyesi negatif olamaz.");

            AccountDataAccess.InsertAccount(clientId, initialBalance);
            LogsDataAccess.InsertLog($"Hesap açıldı - Müşteri ID: {clientId}, Bakiye: {initialBalance}₺");
        }

        public void DepositMoney(int accountId, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Yatırılacak tutar pozitif olmalıdır.");

            AccountDataAccess.Deposit(accountId, amount);
            LogsDataAccess.InsertLog($"{accountId} nolu hesaba {amount}₺ yatırıldı.");
        }

        public bool WithdrawMoney(int accountId, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Çekilecek tutar pozitif olmalıdır.");

            // Bakiyeyi kontrol etmek için erişimin varsa ekle, şimdilik doğrudan çekiyoruz
            AccountDataAccess.Withdraw(accountId, amount);
            LogsDataAccess.InsertLog($"{accountId} nolu hesaptan {amount}₺ çekildi.");
            return true;
        }

        public void CloseAccount(int accountId)
        {
            AccountDataAccess.DeleteAccount(accountId);
            LogsDataAccess.InsertLog($"{accountId} nolu hesap kapatıldı.");
        }

        public List<string> GetAllAccounts()
        {
            return AccountDataAccess.GetAllAccounts();
        }
    }
}

