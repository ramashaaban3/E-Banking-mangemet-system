CREATE TABLE Transactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    FromAccountID INT NOT NULL,
    ToAccountID INT NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    Timestamp DATETIME DEFAULT GETDATE()
);
