using System;
using BankDataAccess2.DataAccess;

namespace BusinessLayer
{
    public static class AccountManager
    {
        public static void OpenAccount(int clientId, decimal initialBalance)
        {
            if (initialBalance < 0)
                throw new ArgumentException("Başlangıç bakiyesi negatif olamaz.");

            AccountDataAccess.InsertAccount(clientId, initialBalance);
        }

        public static void DepositMoney(int accountId, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Yatırılacak tutar pozitif olmalıdır.");

            AccountDataAccess.Deposit(accountId, amount);
        }

        public static bool WithdrawMoney(int accountId, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Çekilecek tutar pozitif olmalıdır.");

            // Bakiyeyi kontrol etmek için erişimin varsa ekle, şimdilik doğrudan çekiyoruz
            AccountDataAccess.Withdraw(accountId, amount);
            return true;
        }

        public static void CloseAccount(int accountId)
        {
            AccountDataAccess.DeleteAccount(accountId);
        }
    }
}
