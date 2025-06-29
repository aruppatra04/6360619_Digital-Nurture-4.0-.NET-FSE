-- if exit then drop 
IF OBJECT_ID('sp_CountEmployeesByDepartment', 'P') IS NOT NULL
    DROP PROCEDURE sp_CountEmployeesByDepartment;
GO

-- create new procedure
CREATE PROCEDURE sp_CountEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

-- quries:

EXEC sp_CountEmployeesByDepartment 1;
GO
EXEC sp_CountEmployeesByDepartment 3;
GO
EXEC sp_CountEmployeesByDepartment 4;
GO
