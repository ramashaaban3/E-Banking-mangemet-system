CREATE TABLE Transactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    AccountID INT NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    Type NVARCHAR(10) NOT NULL,  -- "Deposit" / "Withdraw" gibi
    Date DATETIME DEFAULT GETDATE()
);