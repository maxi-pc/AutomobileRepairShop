CREATE TABLE [dbo].[Clients]
(
	[ClientId] INT NOT NULL PRIMARY KEY, 
    [ClientFName] VARCHAR(50) NOT NULL, 
    [ClientLName] VARCHAR(50) NULL, 
    [ClientPhone] VARCHAR(50) NULL, 
    [ClientAddress] VARCHAR(50) NULL
)
