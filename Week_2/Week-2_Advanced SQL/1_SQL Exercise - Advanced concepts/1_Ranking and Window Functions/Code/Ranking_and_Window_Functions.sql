-- Drop the database if it already exists
IF EXISTS (SELECT 1 FROM sys.databases WHERE name = '1_Ranking_and_Window_Functions')
BEGIN
    ALTER DATABASE [1_Ranking_and_Window_Functions] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [1_Ranking_and_Window_Functions];
END;
GO

-- Create the database
CREATE DATABASE [1_Ranking_and_Window_Functions];
GO

-- Use the newly created database
USE [1_Ranking_and_Window_Functions];
GO

-- Drop the Products table if it already exists
IF OBJECT_ID('Products', 'U') IS NOT NULL
    DROP TABLE Products;
GO

-- Create the Products table
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);
GO

-- Insert sample data
INSERT INTO Products (ProductName, Category, Price)
VALUES 
    ('HP Laptop', 'Electronics', 1000),
    ('Lenovo Laptop', 'Electronics', 1000),
    ('Jeans', 'Clothing', 300),
    ('Samsung Phone', 'Electronics', 900),
    ('HP Tablet', 'Electronics', 800),
    ('Sofa', 'Furniture', 700),
    ('Chair', 'Furniture', 300),
    ('T-Shirt', 'Clothing', 100),
    ('Table', 'Furniture', 400),
    ('Jacket', 'Clothing', 300);
GO

-- Exercise 1: Ranking and Window Functions in a Single Query

-- Use ROW_NUMBER() to get top 3 per category
SELECT ProductID, ProductName, Category, Price, RowNum
FROM (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) AS Sub
WHERE RowNum <= 3;
GO

-- Use RANK() to compare tie handling
SELECT ProductID, ProductName, Category, Price, PriceRank
FROM (
    SELECT *,
           RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS PriceRank
    FROM Products
) AS Sub
WHERE PriceRank <= 3;
GO

-- Use DENSE_RANK() to compare tie handling
SELECT ProductID, ProductName, Category, Price, DensePriceRank
FROM (
    SELECT *,
           DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DensePriceRank
    FROM Products
) AS Sub
WHERE DensePriceRank <= 3;
GO