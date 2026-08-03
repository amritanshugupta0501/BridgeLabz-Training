-- DAY 1
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

-- DAY 2
-- QUERY 1

CREATE TABLE AllotedRooms
(
	RoomNumber INT PRIMARY KEY,
	FloorOfTheRoom INT 
);

ALTER TABLE Doctors
ADD RoomNumber INT;

ALTER TABLE Doctors
ADD CONSTRAINT DoctorsRoom
FOREIGN KEY(RoomNumber)
REFERENCES AllotedRooms(RoomNumber);

-- QUERY 2
-- NO INDEX 'SELECT' QUERY
SELECT * FROM Appointments WHERE CompletionStatus LIKE 'Completed';

-- SINGLE COLUMN INDEX
CREATE INDEX IN_Status
ON Appointments(CompletionStatus);

SELECT * FROM Appointments WHERE CompletionStatus LIKE 'Completed';

-- COMPOSITE COLUMN INDEX
CREATE INDEX IN_Status_AppointmentDate
ON Appointments(CompletionStatus, AppointmentDate);

SELECT * FROM Appointments WHERE CompletionStatus LIKE 'Completed' AND AppointmentDate = '2026-08-03';

-- QUERY 3
CREATE TABLE PatientContactDetails
(
	PatientID INT,
	ContactDetail VARCHAR(10),
	PRIMARY KEY(PatientID,ContactDetail),
	FOREIGN KEY(PatientID)
	REFERENCES Patients(PatientID)
);
-- 1NF State : Every row stores a single phone number of the patient.
-- 2NF State : Normalized in 1NF state and no column PatientID.
-- 3NF State : Normalized in 2NF state and no non-key attribute depends on another non-key attribute.

-- QUERY 4
CREATE INDEX IN_AppointmentReport
ON Appointments
(
	DoctorID,
	AppointmentDate,
	CompletionStatus
);

SELECT DoctorID, AppointmentDate, CompletionStatus	FROM Appointments;