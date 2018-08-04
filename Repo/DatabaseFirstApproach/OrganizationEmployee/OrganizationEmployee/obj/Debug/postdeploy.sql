MERGE INTO Department AS Target 
USING (VALUES 
        (1, 'Microsoft', 3), 
        (2, 'Java', 3), 
        (3, 'Php', 4)
) 
AS Source (DepartmentID, Title, Credits) 
ON Target.DepartmentID = Source.DepartmentID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Title, Credits) 
VALUES (Title, Credits);


MERGE INTO Employee AS Target
USING (VALUES 
        (1, 'Ark', 'Roop', '2013-09-01'), 
        (2, 'Akash', 'Gupta', '2012-01-13'), 
	(3, 'Saurabh', 'Gupta', '2011-09-03')
)
AS Source (EmployeeID, LastName, FirstName, JoiningDate)
ON Target.EmployeeID = Source.EmployeeID
WHEN NOT MATCHED BY TARGET THEN
INSERT (LastName, FirstName, JoiningDate)
VALUES (LastName, FirstName, JoiningDate);


MERGE INTO Enrollment AS Target
USING (VALUES 
	(1, 2.00, 1, 1),
	(2, 3.50, 1, 2),
	(3, 4.00, 2, 3),
	(4, 1.80, 2, 1),
	(5, 3.20, 3, 1),
	(6, 4.00, 3, 2)
)
AS Source (EnrollmentID, Band, DepartmentID, EmployeeID)
ON Target.EnrollmentID = Source.EnrollmentID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Band, DepartmentID, EmployeeID)
VALUES (Band, DepartmentID, EmployeeID);
GO
