ALTER TABLE Transactions ADD SenderId INT;
GO

ALTER TABLE Transactions ADD ReceiverId INT;
GO

ALTER TABLE Transactions ADD Description NVARCHAR(250);
GO
