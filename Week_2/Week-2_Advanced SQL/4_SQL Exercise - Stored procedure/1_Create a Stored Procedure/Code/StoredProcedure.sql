-- Drop procedures if they already exist
IF OBJECT_ID('sp_GetEmployeesByDepartment', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetEmployeesByDepartment;
GO

IF OBJECT_ID('sp_InsertEmployee', 'P') IS NOT NULL
    DROP PROCEDURE sp_InsertEmployee;
GO

-- Create procedure to retrieve employee details by DepartmentID
CREATE PROCEDURE sp_GetEmployeesByDepartment
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

-- Create procedure to insert a new employee
IF OBJECT_ID('sp_InsertEmployee', 'P') IS NOT NULL
    DROP PROCEDURE sp_InsertEmployee;
GO

CREATE PROCEDURE sp_InsertEmployee
    @EmployeeID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@EmployeeID, @FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
GO




-- queries ::

-- Insert a New Employee:
EXEC sp_InsertEmployee 1, 'John', 'Doe', 1, 5000.00, '2020-01-15';
GO
EXEC sp_InsertEmployee 2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22';
GO
EXEC sp_InsertEmployee 3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30';
GO
EXEC sp_InsertEmployee 4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05';
GO


-- Get Employees bt Department Id:
EXEC sp_GetEmployeesByDepartment 3;
GO
EXEC sp_GetEmployeesByDepartment 2;
GO
