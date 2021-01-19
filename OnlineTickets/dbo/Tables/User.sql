CREATE TABLE [dbo].[User]
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProfilePicture] IMAGE NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(MAX) NOT NULL, 
    [CreatedOn] DATE NOT NULL, 
    [DeletedOn] DATE NOT NULL, 
    [Modified] DATE NOT NULL, 
    [Password] NVARCHAR(MAX) NOT NULL, 
    [Acc_Type] NCHAR(10) NOT NULL, 
    [User_Type] NCHAR(10) NOT NULL, 
    [CreditCard] BIGINT NOT NULL
)
