using System.Collections.Generic;

public interface IAccountService
{
    void OpenAccount(int clientID, decimal initialBalance);
    void DepositMoney(int accountID, decimal amount);
    void CloseAccount(int accountId);
    bool WithdrawMoney(int accountID, decimal amount);
    List<string> GetAllAccounts();
}

