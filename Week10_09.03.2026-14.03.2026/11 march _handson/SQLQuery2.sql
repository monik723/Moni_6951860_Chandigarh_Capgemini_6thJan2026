CREATE DATABASE HospitalDB;
USE HospitalDB;
CREATE TABLE Patients (
    PatientId INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE,
    ContactNumber NVARCHAR(15)
);

CREATE TABLE Doctors (
    DoctorId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    Specialization NVARCHAR(100) NOT NULL
);

CREATE TABLE Appointments (
    AppointmentId INT PRIMARY KEY IDENTITY,
    PatientId INT,
    DoctorId INT,
    AppointmentDate DATETIME,
    Remarks NVARCHAR(200),

    FOREIGN KEY (PatientId) REFERENCES Patients(PatientId),
    FOREIGN KEY (DoctorId) REFERENCES Doctors(DoctorId)
);

