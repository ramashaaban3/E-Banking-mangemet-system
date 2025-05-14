using System.Collections.Generic;

namespace BusinessLayer
{
    public interface ITransactionService
    {
        bool TransferMoney(int fromAccountId, int toAccountId, decimal amount);
        List<string> GetTransactionHistory(int accountId);
    }
}