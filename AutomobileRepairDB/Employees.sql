CREATE TABLE [dbo].[Employees]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY, 
    [EmployeeFName] VARCHAR(50) NOT NULL, 
    [EmployeeLName] VARCHAR(50) NULL, 
    [EmployeePhone] VARCHAR(50) NULL, 
    [EmployeeAddress] VARCHAR(50) NULL
)