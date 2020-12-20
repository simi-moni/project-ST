CREATE TABLE [dbo].[Ticket]
(
	[TicketId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VehicleId] INT NOT NULL, 
    [CreatedOn] DATE NOT NULL, 
    [UsedOn] DATE NOT NULL, 
    [QrCode] INT NOT NULL, 
    [Type] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Ticket_Vehicle] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicles]([VehicleId])
)
