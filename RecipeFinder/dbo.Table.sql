CREATE TABLE [dbo].UserTable

(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Username] NCHAR(10) NOT NULL, 
    [password] NCHAR(10) NOT NULL, 
    [dietary restriction] NCHAR(10) NULL, 
    [email address] NCHAR(10) NOT NULL
);

