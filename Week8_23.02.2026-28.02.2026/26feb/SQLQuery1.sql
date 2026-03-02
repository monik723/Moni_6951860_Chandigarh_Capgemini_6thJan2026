Create database EmployeeDB;
use EmployeeDB;

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create table Address(
AddressID int primary key not null,
street varchar(255)  null,
city varchar(109) null,
state varchar(109)null,
postalcode varchar(20) null,
)

create table dbo.Employee(
EmployeeID int primary key not null,
FirstName varchar(100),
LastName varchar(100),
Email varchar(100),
AddressID int references Address (AddressID)
)

insert into Address values(1,'123 elm street','springfield','abc',2345);
insert into Address values(2,'123 oak street','albama','cdf',2346);
insert into Address values(3,'123 patia street','india','adr',2347);
insert into Address values(4,'342 patia street','india','rot',2348);

insert into Employee values (1,'john','doe','johndoe@gmail.com',1);
insert into Employee values (2,'jane','doe','janedoe@gmail.com',2);
insert into Employee values (3,'raj','sharma','rajsharma@gmail.com',3);
insert into Employee values (4,'rahul','singh','rahulsingh@gmail.com',4);

CREATE PROCEDURE dbo.CreateEmployeeWithAddress
@FirstName varchar(100),
@LastName varchar(100),
@Email varchar(100),
@Street varchar(255),
@City varchar(100),
@State varchar(100),
@PostalCode varchar(20)
AS
BEGIN
    DECLARE @AddressID INT;

    INSERT INTO Address(Street, City, State, PostalCode)
    VALUES(@Street, @City, @State, @PostalCode);

    SET @AddressID = SCOPE_IDENTITY();

    INSERT INTO Employee(FirstName, LastName, Email, AddressID)
    VALUES(@FirstName, @LastName, @Email, @AddressID);
END;


--second
CREATE PROCEDURE dbo.GetAllEmployees
AS
BEGIN
    SELECT 
        e.EmployeeID,
        e.FirstName,
        e.LastName,
        e.Email,
        a.Street,
        a.City,
        a.State,
        a.PostalCode
    FROM Employee e
    INNER JOIN Address a 
        ON e.AddressID = a.AddressID;
END;

--third

CREATE PROCEDURE dbo.GetEmployeeByID
    @EmployeeID INT
AS
BEGIN
    SELECT 
        e.EmployeeID,
        e.FirstName,
        e.LastName,
        e.Email,
        a.Street,
        a.City,
        a.State,
        a.PostalCode
    FROM Employee e
    INNER JOIN Address a 
        ON e.AddressID = a.AddressID
    WHERE e.EmployeeID = @EmployeeID;
END;

--fourth

CREATE PROCEDURE dbo.UpdateEmployee
    @EmployeeID INT,
    @FirstName VARCHAR(100),
    @LastName VARCHAR(100),
    @Email VARCHAR(100),
    @Street VARCHAR(255),
    @City VARCHAR(100),
    @State VARCHAR(100),
    @PostalCode VARCHAR(20)
AS
BEGIN
    UPDATE Employee
    SET 
        FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email
    WHERE EmployeeID = @EmployeeID;

    UPDATE Address
    SET 
        Street = @Street,
        City = @City,
        State = @State,
        PostalCode = @PostalCode
    WHERE AddressID = (
        SELECT AddressID 
        FROM Employee 
        WHERE EmployeeID = @EmployeeID
    );
END;

--fifth

CREATE PROCEDURE dbo.DeleteEmployee
    @EmployeeID INT
AS
BEGIN
    DECLARE @AddressID INT;

    SELECT @AddressID = AddressID 
    FROM Employee 
    WHERE EmployeeID = @EmployeeID;

    DELETE FROM Employee 
    WHERE EmployeeID = @EmployeeID;

    DELETE FROM Address 
    WHERE AddressID = @AddressID;
END;
---executed
EXEC dbo.GetAllEmployees;
EXEC dbo.GetEmployeeByID
    @EmployeeID = 1;
    EXEC dbo.UpdateEmployee
    @EmployeeID = 1,
    @FirstName = 'Monika',
    @LastName = 'Dahiya',
    @Email = 'monika@gmail.com',
    @Street = 'Ring Road',
    @City = 'Delhi',
    @State = 'Delhi',
    @PostalCode = '110002';

    EXEC dbo.DeleteEmployee
    @EmployeeID = 1;

    EXEC dbo.CreateEmployeeWithAddress
    @FirstName = 'Moni',
    @LastName = 'Dahiya',
    @Email = 'moni@gmail.com',
    @Street = 'MG Road',
    @City = 'Delhi',
    @State = 'Delhi',
    @PostalCode = '110001';
