CREATE TABLE [dbo].[EmployeeInfo] (
    [EmpNo]       INT          IDENTITY (1, 1) NOT NULL,
    [EmpName]     VARCHAR (50) NOT NULL,
    [Salary]      INT          NOT NULL,
    [DeptName]    VARCHAR (50) NOT NULL,
    [Designation] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([EmpNo] ASC)
)