CREATE TABLE [dbo].[Employee] (
    [EmployeeID]      INT           IDENTITY (1, 1) NOT NULL,
    [LastName]       NVARCHAR (50) NULL,
    [FirstName]      NVARCHAR (50) NULL,	
    [JoiningDate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC))