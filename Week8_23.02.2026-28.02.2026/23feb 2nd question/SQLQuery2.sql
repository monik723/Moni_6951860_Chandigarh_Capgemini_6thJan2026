create database Monidb;
use Monidb;
GO

-- =========================================
-- SCALAR FUNCTIONS
-- =========================================

-- Sum of two fixed numbers
IF OBJECT_ID('dbo.fnSum') IS NOT NULL DROP FUNCTION dbo.fnSum;
GO
CREATE FUNCTION dbo.fnSum()
RETURNS INT
AS
BEGIN
    RETURN 10 + 20;
END;
GO
SELECT dbo.fnSum();
GO

-- Function with parameters
IF OBJECT_ID('dbo.Total') IS NOT NULL DROP FUNCTION dbo.Total;
GO
CREATE FUNCTION dbo.Total(@A INT,@B INT,@C INT)
RETURNS INT
AS
BEGIN
    RETURN @A+@B+@C;
END;
GO
SELECT dbo.Total(3,5,4);
GO

-- Multiply function
IF OBJECT_ID('dbo.Multiply') IS NOT NULL DROP FUNCTION dbo.Multiply;
GO
CREATE FUNCTION dbo.Multiply(@num1 INT,@num2 INT)
RETURNS INT
AS
BEGIN
    RETURN @num1*@num2;
END;
GO
SELECT dbo.Multiply(3,4);
GO

-- =========================================
-- STORED PROCEDURES
-- =========================================

-- MySum Procedure
IF OBJECT_ID('MySum') IS NOT NULL DROP PROCEDURE MySum;
GO
CREATE PROCEDURE MySum
(
 @A INT,@B INT,@C INT=0,@D INT=0,@E INT=0
)
AS
BEGIN
    PRINT @A+@B+@C+@D+@E;
END;
GO
EXEC MySum 10,20;
EXEC MySum 10,20,30;
GO

-- Swap Procedure
IF OBJECT_ID('Swap') IS NOT NULL DROP PROCEDURE Swap;
GO
CREATE PROCEDURE Swap
(
 @X INT OUTPUT,
 @Y INT OUTPUT
)
AS
BEGIN
    DECLARE @T INT;
    SET @T=@X;
    SET @X=@Y;
    SET @Y=@T;
END;
GO

DECLARE @A INT=10,@B INT=20;
EXEC Swap @A OUTPUT,@B OUTPUT;
PRINT @A;
PRINT @B;
GO

-- =========================================
-- EMPLOYEE TABLE
-- =========================================
IF OBJECT_ID('Employee') IS NOT NULL DROP TABLE Employee;
GO
CREATE TABLE Employee
(
 EmpID INT PRIMARY KEY,
 FirstName VARCHAR(50),
 LastName VARCHAR(50),
 Salary INT,
 Address VARCHAR(100)
);
GO

INSERT INTO Employee VALUES
(1,'Mohan','Chauhan',22000,'Delhi'),
(2,'Asif','Khan',15000,'Delhi'),
(3,'Bhuvnesh','Shakya',19000,'Noida'),
(4,'Deepak','Kumar',19000,'Noida'),
(5,'Deepika','Kumari',25000,'Noida');
GO

-- Full Name Function
IF OBJECT_ID('dbo.fnGetEmpFullName') IS NOT NULL DROP FUNCTION dbo.fnGetEmpFullName;
GO
CREATE FUNCTION dbo.fnGetEmpFullName
(
 @FirstName VARCHAR(50),
 @LastName VARCHAR(50)
)
RETURNS VARCHAR(101)
AS
BEGIN
 RETURN @FirstName+' '+@LastName;
END;
GO

SELECT dbo.fnGetEmpFullName(FirstName,LastName) AS Name,Salary FROM Employee;
GO

-- =========================================
-- INLINE TABLE VALUED FUNCTION
-- =========================================
IF OBJECT_ID('dbo.fnGetEmployee') IS NOT NULL DROP FUNCTION dbo.fnGetEmployee;
GO
CREATE FUNCTION dbo.fnGetEmployee()
RETURNS TABLE
AS
RETURN (SELECT * FROM Employee);
GO

SELECT * FROM dbo.fnGetEmployee();
GO

-- =========================================
-- MULTI STATEMENT TABLE VALUED FUNCTION
-- =========================================
IF OBJECT_ID('dbo.fnGetMulEmployee') IS NOT NULL DROP FUNCTION dbo.fnGetMulEmployee;
GO
CREATE FUNCTION dbo.fnGetMulEmployee()
RETURNS @Emp TABLE
(
 EmpID INT,
 FirstName VARCHAR(50),
 Salary INT
)
AS
BEGIN
 INSERT INTO @Emp
 SELECT EmpID,FirstName,Salary FROM Employee;

 UPDATE @Emp SET Salary=25000 WHERE EmpID=1;

 RETURN;
END;
GO

SELECT * FROM dbo.fnGetMulEmployee();
GO

-- =========================================
-- CURSOR EXAMPLE
-- =========================================
IF OBJECT_ID('EmployeeCursor') IS NOT NULL DROP TABLE EmployeeCursor;
GO
CREATE TABLE EmployeeCursor
(
 EmpID INT PRIMARY KEY,
 EmpName VARCHAR(50),
 Salary INT,
 Address VARCHAR(200)
);
GO

INSERT INTO EmployeeCursor VALUES
(1,'Mohan',12000,'Noida'),
(2,'Pavan',25000,'Delhi'),
(3,'Amit',22000,'Dehradun'),
(4,'Sonu',22000,'Noida'),
(5,'Deepak',28000,'Gurgaon');
GO

DECLARE @Id INT,@Name VARCHAR(50),@Salary INT;

DECLARE cur_emp CURSOR FOR
SELECT EmpID,EmpName,Salary FROM EmployeeCursor;

OPEN cur_emp;
FETCH NEXT FROM cur_emp INTO @Id,@Name,@Salary;

WHILE @@FETCH_STATUS=0
BEGIN
 PRINT 'ID:'+CAST(@Id AS VARCHAR)+' Name:'+@Name;
 FETCH NEXT FROM cur_emp INTO @Id,@Name,@Salary;
END

CLOSE cur_emp;
DEALLOCATE cur_emp;
GO

-- =========================================
-- TRIGGER EXAMPLE
-- =========================================
IF OBJECT_ID('Employee_Demo') IS NOT NULL DROP TABLE Employee_Demo;
IF OBJECT_ID('Employee_Demo_Audit') IS NOT NULL DROP TABLE Employee_Demo_Audit;
GO

CREATE TABLE Employee_Demo
(
 Emp_ID INT IDENTITY,
 Emp_Name VARCHAR(55),
 Emp_Sal DECIMAL(10,2)
);
GO

CREATE TABLE Employee_Demo_Audit
(
 Emp_ID INT,
 Emp_Name VARCHAR(55),
 Emp_Sal DECIMAL(10,2),
 Audit_Action VARCHAR(100),
 Audit_Timestamp DATETIME
);
GO

-- AFTER INSERT TRIGGER
IF OBJECT_ID('trgAfterInsert') IS NOT NULL DROP TRIGGER trgAfterInsert;
GO
CREATE TRIGGER trgAfterInsert
ON Employee_Demo
AFTER INSERT
AS
BEGIN
 INSERT INTO Employee_Demo_Audit
 SELECT Emp_ID,Emp_Name,Emp_Sal,
 'Inserted Record',GETDATE()
 FROM inserted;
END;
GO

INSERT INTO Employee_Demo VALUES ('Amit',1000);
SELECT * FROM Employee_Demo_Audit;
GO
