create database bankdb;
use bankdb;


create table Employeetb(
EmpId int,EmpName varchar(20),EmpDesg varchar(50),
EmpDOJ datetime,EmpSal int,EmpDept int
)

insert into Employeetb values(101,'krishna','ProjManger',
7-8-2010,45000,10)
insert into Employeetb values(102,'kumari','Manger',
6-8-2010,50000,20)
insert into Employeetb values(103,'Amit','Manger',
7-9-2010,44000,30)
insert into Employeetb values(101,'krishna','ProjManger',
7-5-2010,55000,20)

-- Drop procedure if it already exists
IF OBJECT_ID('SP_DelRec') IS NOT NULL
DROP PROCEDURE SP_DelRec;
GO

-- Create procedure
CREATE PROCEDURE SP_DelRec
AS
BEGIN
    DELETE FROM Employeetb
    WHERE EmpId = 105;
END;
GO
-- =========================================
-- DELETE USING PARAMETER
-- =========================================
IF OBJECT_ID('sp_DelRecP') IS NOT NULL
DROP PROCEDURE sp_DelRecP;
GO

CREATE PROCEDURE sp_DelRecP
    @PEmpId INT
AS
BEGIN
    DELETE FROM Employeetb 
    WHERE EmpId = @PEmpId;
END;
GO


-- =========================================
-- INSERT PROCEDURE
-- =========================================
IF OBJECT_ID('SPEmp_Insert') IS NOT NULL
DROP PROCEDURE SPEmp_Insert;
GO

CREATE PROCEDURE SPEmp_Insert
(
    @PEmpId INT,
    @PEmpName VARCHAR(20),
    @PEmpDesg VARCHAR(50),
    @PEmpDOJ DATETIME,
    @PEmpSal INT,
    @PEmpDept INT
)
AS
BEGIN
    INSERT INTO Employeetb
    (EmpId, EmpName, EmpDesg, EmpDOJ, EmpSal, EmpDept)
    VALUES
    (@PEmpId, @PEmpName, @PEmpDesg, @PEmpDOJ, @PEmpSal, @PEmpDept);
END;
GO


-- =========================================
-- UPDATE PROCEDURE
-- =========================================
IF OBJECT_ID('SPEmp_Update') IS NOT NULL
DROP PROCEDURE SPEmp_Update;
GO

CREATE PROCEDURE SPEmp_Update
(
    @PEmpId INT,
    @PEmpName VARCHAR(20),
    @PEmpDesg VARCHAR(50),
    @PEmpDOJ DATETIME,
    @PEmpSal INT,
    @PEmpDept INT
)
AS
BEGIN
    UPDATE Employeetb 
    SET EmpName = @PEmpName,
        EmpDesg = @PEmpDesg,
        EmpDOJ = @PEmpDOJ,
        EmpSal = @PEmpSal,
        EmpDept = @PEmpDept
    WHERE EmpId = @PEmpId;
END;
GO


-- =========================================
-- DELETE PROCEDURE
-- =========================================
IF OBJECT_ID('SPEmp_Del') IS NOT NULL
DROP PROCEDURE SPEmp_Del;
GO

CREATE PROCEDURE SPEmp_Del
    @PEmpId INT
AS
BEGIN
    DELETE FROM Employeetb 
    WHERE EmpId = @PEmpId;
END;
GO


-- =========================================
-- GET SALARY (OUTPUT PARAMETER)
-- =========================================
IF OBJECT_ID('SPGetSal') IS NOT NULL
DROP PROCEDURE SPGetSal;
GO

CREATE PROCEDURE SPGetSal
(
    @PEmpId INT,
    @PEmpSal INT OUTPUT
)
AS
BEGIN
    SELECT @PEmpSal = EmpSal 
    FROM Employeetb 
    WHERE EmpId = @PEmpId;
END;
GO


-- =========================================
-- GET FULL EMPLOYEE DATA (OUTPUT PARAMETERS)
-- =========================================
IF OBJECT_ID('SPGetData') IS NOT NULL
DROP PROCEDURE SPGetData;
GO

CREATE PROCEDURE SPGetData
(
    @PEmpId INT,
    @PEmpName VARCHAR(50) OUTPUT,
    @PEmpDesg VARCHAR(50) OUTPUT,
    @PEmpDOJ DATETIME OUTPUT,
    @PEmpSal INT OUTPUT,
    @PEmpDept INT OUTPUT
)
AS
BEGIN
    SELECT 
        @PEmpName = EmpName,
        @PEmpDesg = EmpDesg,
        @PEmpDOJ = EmpDOJ,
        @PEmpSal = EmpSal,
        @PEmpDept = EmpDept
    FROM Employeetb 
    WHERE EmpId = @PEmpId;
END;
GO