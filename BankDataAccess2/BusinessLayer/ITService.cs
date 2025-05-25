using System.Collections.Generic;

namespace BusinessLayer
{
    public interface ITransactionService
    {
        bool TransferMoney(int fromAccountId, int toAccountId, decimal amount, string description = "");
        List<string> GetTransactionHistory(int accountId);
    }

}