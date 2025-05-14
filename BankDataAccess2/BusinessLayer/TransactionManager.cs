using System;
using System.Collections.Generic;
using BankDataAccess2.DataAccess;

namespace BusinessLayer
{
    public class TransactionManager : ITransactionService
    {
        public bool TransferMoney(int fromAccountId, int toAccountId, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Transfer edilecek miktar pozitif olmalıdır.");

            try
            {
                // Önce gönderici hesaptan para çek
                AccountDataAccess.Withdraw(fromAccountId, amount);

                // Sonra alıcı hesaba para yatır
                AccountDataAccess.Deposit(toAccountId, amount);

                // Log kaydı
                TransactionsDataAccess.InsertTransaction(fromAccountId, amount, "Transfer");
                LogsDataAccess.InsertLog($"Hesap {fromAccountId} → {toAccountId} {amount} ₺ transfer edildi.");

                return true;
            }
            catch (Exception ex)
            {
                LogsDataAccess.InsertLog($"Transfer hatası: {ex.Message}");
                return false;
            }
        }

        public List<string> GetTransactionHistory(int accountId)
        {
            return TransactionsDataAccess.GetTransactionsByAccountID(accountId);
        }
    }
}
