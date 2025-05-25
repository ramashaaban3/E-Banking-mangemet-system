using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BankDataAccess2.DataAccess;

namespace BusinessLayer
{
    public class TransactionManager : ITransactionService
    {
        public bool TransferMoney(int fromAccountId, int toAccountId, decimal amount, string description = "")
        {
            if (amount <= 0)
                throw new ArgumentException("Transfer edilecek miktar pozitif olmalıdır.");

            try
            {
                // 1. Para göndericiden çekilir
                AccountDataAccess.Withdraw(fromAccountId, amount);

                // 2. Alıcıya aktarılır
                AccountDataAccess.Deposit(toAccountId, amount);

                // 3. Transaction kaydı
                TransactionsDataAccess.InsertTransaction(fromAccountId, toAccountId, amount, description, DateTime.Now);

                // 4. Log kaydı
                LogsDataAccess.InsertLog($"Hesap {fromAccountId} → {toAccountId} arasında {amount} ₺ transfer edildi. Açıklama: {description}");

                return true;
            }
            catch (Exception ex)
            {
                LogsDataAccess.InsertLog($"Transfer hatası: {ex.Message}");
                MessageBox.Show("Gerçek hata: " + ex.Message);  // ← Bunu ekle
                return false;
            }

        }



        public List<string> GetTransactionHistory(int accountId)
        {
            return TransactionsDataAccess.GetTransactionsByAccountID(accountId);
        }
    }
}
