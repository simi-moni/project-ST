CREATE TABLE [dbo].[Ticket_User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TicketID] INT NOT NULL, 
    [UserID] INT NOT NULL, 
    CONSTRAINT [FK_Ticket_User_Ticket] FOREIGN KEY ([TicketID]) REFERENCES [Ticket]([TicketId]), 
    CONSTRAINT [FK_Ticket_User_User] FOREIGN KEY ([UserID]) REFERENCES [User]([USerId])
    
)
