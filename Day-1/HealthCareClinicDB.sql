CREATE DATABASE HealthCareCLinicDB
USE HealthCareCLinicDB

CREATE TABLE Doctors
(
	DoctorID INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(20),
	LastName VARCHAR(20),
	Specialization VARCHAR(20),
	ContactNumber VARCHAR(10),
	ContactEmail VARCHAR(50)
);

CREATE TABLE Patients
(
	PatientID INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(20),
	LastName VARCHAR(20),
	Gender CHAR(1),
	DateOfBirth VARCHAR(15),
	ContactNumber VARCHAR(10),
	ContactEmail VARCHAR(10),
	ResidenceAddress VARCHAR(100),
	MedicalDescription VARCHAR(500),
	Medication VARCHAR(500),
	DoctorID INT ,
	CONSTRAINT DoctorOfPatient
		FOREIGN KEY(DoctorID)
		REFERENCES Doctors(DoctorID)
);

CREATE TABLE Appointments
(
	AppointmentsID INT PRIMARY KEY IDENTITY(1,1),
	PatientID INT NOT NULL,
	DoctorID INT NOT NULL,
	AppointmentDate DATE NOT NULL,
	AppointmentTime TIME NOT NULL,
	CompletionStatus VARCHAR(20) NOT NULL,
	CONSTRAINT PatientOfAppointment
		FOREIGN KEY(PatientID)
		REFERENCES Patients(PatientID),

	CONSTRAINT DoctorOfAppointment
		FOREIGN KEY(DoctorID)
		REFERENCES Doctors(DoctorID)
);