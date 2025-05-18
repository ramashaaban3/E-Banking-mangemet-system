ALTER TABLE Users ADD FullName NVARCHAR(100) NULL;

INSERT INTO Users (FullName, Username, Password)
VALUES ('Anonim Admin', 'admin', '1234');

