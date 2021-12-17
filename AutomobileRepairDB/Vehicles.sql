CREATE TABLE [dbo].[Vehicles]
(
	[VehicleId] INT NOT NULL PRIMARY KEY, 
    [VehiclePlateNumber] VARCHAR(50) NOT NULL, 
    [VehicleStatus] VARCHAR(50) NOT NULL, 
    [VehicleModel] VARCHAR(50) NOT NULL, 
    [VehicleMake] VARCHAR(50) NOT NULL
)
