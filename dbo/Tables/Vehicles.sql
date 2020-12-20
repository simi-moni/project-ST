CREATE TABLE [dbo].[Vehicles]
(
	[VehicleId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Type] NVARCHAR(MAX) NOT NULL, 
    [Number] INT NOT NULL
)
