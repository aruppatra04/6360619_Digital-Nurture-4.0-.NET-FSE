-- Modify sp_GetEmployeesByDepartment to Include Salary
ALTER PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO


-- queries ::

-- Get Employees bt Department Id:
EXEC sp_GetEmployeesByDepartment 3;
GO
EXEC sp_GetEmployeesByDepartment 2;
GO