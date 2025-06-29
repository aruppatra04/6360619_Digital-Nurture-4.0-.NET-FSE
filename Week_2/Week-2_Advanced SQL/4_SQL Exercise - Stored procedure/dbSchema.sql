-- Employee Management System SQL Exercises

-- Drop the database if it already exists
IF EXISTS (SELECT 1 FROM sys.databases WHERE name = '4_Employee_Management_System')
BEGIN
    ALTER DATABASE [4_Employee_Management_System] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [4_Employee_Management_System];
END;
GO

-- Create the database
CREATE DATABASE [4_Employee_Management_System];
GO

-- Use the newly created database
USE [4_Employee_Management_System];
GO

-- Drop tables if they already exist
IF OBJECT_ID('Departments', 'U') IS NOT NULL
    DROP TABLE Departments;
GO

IF OBJECT_ID('Employees', 'U') IS NOT NULL
    DROP TABLE Employees;
GO


-- Create Departments table
CREATE TABLE Departments ( 
    DepartmentID INT PRIMARY KEY, 
    DepartmentName VARCHAR(100) 
);
GO

-- Create Employees table
CREATE TABLE Employees ( 
    EmployeeID INT PRIMARY KEY, 
    FirstName VARCHAR(50), 
    LastName VARCHAR(50), 
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID), 
    Salary DECIMAL(10,2), 
    JoinDate DATE 
);
GO


-- Insert Departments sample data
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES 
(1, 'HR'), 
(2, 'Finance'), 
(3, 'IT'), 
(4, 'Marketing');
GO

-- Insert Employees sample data
INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES 
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'), 
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'), 
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'), 
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05');
GO
