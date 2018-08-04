CREATE TABLE [dbo].[Enrollment] (
    [EnrollmentID] INT IDENTITY (1, 1) NOT NULL,
    [Band]        DECIMAL(3, 2) NULL,
    [DepartmentID]     INT NOT NULL,
    [EmployeeID]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([EnrollmentID] ASC),
    CONSTRAINT [FK_dbo.Enrollment_dbo.Department_DepartmentID] FOREIGN KEY ([DepartmentID]) 
        REFERENCES [dbo].[Department] ([DepartmentID]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Enrollment_dbo.Employee_EmployeeID] FOREIGN KEY ([EmployeeID]) 
        REFERENCES [dbo].[Employee] ([EmployeeID]) ON DELETE CASCADE 
)