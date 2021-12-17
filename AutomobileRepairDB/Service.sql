CREATE TABLE [dbo].[Service]
(
	[ServiceId] INT NOT NULL PRIMARY KEY, 
    [ClientId] INT NOT NULL, 
    [VehicleId] INT NOT NULL, 
    [EmployeeId] INT NOT NULL, 
    [PartId] INT NOT NULL, 
    [ServiceStartDate] DATE NOT NULL, 
    [ServiceEndDate] DATE NULL, 
    [ServiceCost] DECIMAL NOT NULL, 
    CONSTRAINT [FK_ClientId_ToClients] FOREIGN KEY ([ClientId]) REFERENCES [Clients]([ClientId]),
	CONSTRAINT [FK_VehicleId_ToVehicles] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicles]([VehicleId]),
	CONSTRAINT [FK_EmployeeId_ToEmployees] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees]([EmployeeId]),
	CONSTRAINT [FK_PartId_ToSuppliers] FOREIGN KEY ([PartId]) REFERENCES [Inventories]([PartId]),
)
