CREATE TABLE [dbo].[Department] (
    [DepartmentID] INT           IDENTITY (1, 1) NOT NULL,
    [Title]    NVARCHAR (50) NULL,
    [Credits]  INT           NULL,
    PRIMARY KEY CLUSTERED ([DepartmentID] ASC)
)