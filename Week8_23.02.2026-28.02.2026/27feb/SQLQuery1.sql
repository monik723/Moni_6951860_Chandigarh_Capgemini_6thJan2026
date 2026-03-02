-- ===============================
-- 1. CREATE DATABASE
-- ===============================
CREATE DATABASE UniversityDB;
GO

USE UniversityDB;
GO

-- ===============================
-- 2. CREATE TABLES
-- ===============================

CREATE TABLE Departments (
    DeptId INT PRIMARY KEY IDENTITY(1,1),
    DeptName NVARCHAR(100) NOT NULL
);

CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    DeptId INT FOREIGN KEY REFERENCES Departments(DeptId)
);

CREATE TABLE Courses (
    CourseId INT PRIMARY KEY IDENTITY(1,1),
    CourseName NVARCHAR(100),
    DeptId INT FOREIGN KEY REFERENCES Departments(DeptId)
);

CREATE TABLE Enrollments (
    EnrollmentId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT FOREIGN KEY REFERENCES Students(StudentId),
    CourseId INT FOREIGN KEY REFERENCES Courses(CourseId),
    Grade CHAR(2)
);

-- ===============================
-- 3. INSERT SAMPLE DATA
-- ===============================

INSERT INTO Departments (DeptName)
VALUES ('Computer Science'), ('Mathematics'), ('Physics');

INSERT INTO Students (FirstName, LastName, Email, DeptId)
VALUES 
('Alice','Johnson','alice@uni.com',1),
('Bob','Smith','bob@uni.com',2);

-- ===============================
-- 4. STORED PROCEDURES (CRUD)
-- ===============================

-- INSERT
CREATE PROCEDURE sp_AddStudent
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(100),
    @DeptId INT
AS
BEGIN
    INSERT INTO Students (FirstName, LastName, Email, DeptId)
    VALUES (@FirstName, @LastName, @Email, @DeptId);
END
GO

-- SELECT
CREATE PROCEDURE sp_GetAllStudents
AS
BEGIN
    SELECT s.StudentId, s.FirstName, s.LastName, s.Email, d.DeptName
    FROM Students s
    INNER JOIN Departments d ON s.DeptId = d.DeptId;
END
GO

-- UPDATE
CREATE PROCEDURE sp_UpdateStudent
    @StudentId INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(100),
    @DeptId INT
AS
BEGIN
    UPDATE Students
    SET FirstName=@FirstName,
        LastName=@LastName,
        Email=@Email,
        DeptId=@DeptId
    WHERE StudentId=@StudentId;
END
GO

-- DELETE
CREATE PROCEDURE sp_DeleteStudent
    @StudentId INT
AS
BEGIN
    DELETE FROM Students WHERE StudentId=@StudentId;
END
GO

USE UniversityDB;
GO

EXEC sp_AddStudent
    @FirstName = 'Moni',
    @LastName  = 'Dahiya',
    @Email     = 'moni@uni.com',
    @DeptId    = 1;

    EXEC sp_GetAllStudents;

    EXEC sp_UpdateStudent
    @StudentId = 1,
    @FirstName = 'AliceUpdated',
    @LastName  = 'Johnson',
    @Email     = 'aliceupdated@uni.com',
    @DeptId    = 1;

    EXEC sp_DeleteStudent
    @StudentId = 2;