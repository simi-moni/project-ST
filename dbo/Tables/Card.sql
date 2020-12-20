CREATE TABLE [dbo].[Card]
(
	[CardId] INT NOT NULL PRIMARY KEY, 
    [Type] NVARCHAR(50) NOT NULL, 
    [Duration] DATETIME NOT NULL, 
    [Price] MONEY NOT NULL, 
    [UserId] INT NOT NULL, 
    [CreatedOn] DATE NOT NULL, 
    [Modified] DATE NOT NULL, 
    [isValid] UNIQUEIDENTIFIER NOT NULL, 
    [QRcore] INT NOT NULL, 
    CONSTRAINT [FK_Card_UserId] FOREIGN KEY ([UserId]) REFERENCES [User]([UserId])
)
