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
ALTER TABLE Patients
ALTER COLUMN ContactEmail VARCHAR(50);
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


-- Audit table
CREATE TABLE AuditLogs
(
	AuditID INT PRIMARY KEY IDENTITY(1,1),
	TableAudited VARCHAR(15),
	OldRecord VARCHAR(MAX),
	NewRecord VARCHAR(MAX),
	ActionPerformed VARCHAR(10),
	ActionDate DATETIME DEFAULT GETDATE()
);

CREATE TRIGGER trg_Patients_Audit
ON Doctors
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT * FROM inserted) AND NOT EXISTS(SELECT * FROM deleted)
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Patients',
        NULL,
        CONCAT('PatientID=',PatientID,
               ', Name=',FirstName,' ',LastName,
               ', Specialization=',Specialization,
               ', Contact=',ContactNumber),
        'INSERT'
        FROM inserted;
    END
    ELSE IF EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted)
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Doctors',
        CONCAT('DoctorID=',d.DoctorID,
               ', Name=',d.FirstName,' ',d.LastName,
               ', Specialization=',d.Specialization,
               ', Contact=',d.ContactNumber),
        CONCAT('DoctorID=',i.DoctorID,
               ', Name=',i.FirstName,' ',i.LastName,
               ', Specialization=',i.Specialization,
               ', Contact=',i.ContactNumber),
        'UPDATE'
        FROM inserted i
        INNER JOIN deleted d
        ON i.DoctorID=d.DoctorID;
    END
    ELSE
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Doctors',
        CONCAT('DoctorID=',DoctorID,
               ', Name=',FirstName,' ',LastName,
               ', Specialization=',Specialization,
               ', Contact=',ContactNumber),
        NULL,
        'DELETE'
        FROM deleted;
    END
END;
 
-- Trigger for Doctors table
CREATE TRIGGER trg_Doctors_Audit
ON Doctors
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT * FROM inserted) AND NOT EXISTS(SELECT * FROM deleted)
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Doctors',
        NULL,
        CONCAT('DoctorID=',DoctorID,
               ', Name=',FirstName,' ',LastName,
               ', Specialization=',Specialization,
               ', Contact=',ContactNumber),
        'INSERT'
        FROM inserted;
    END
    ELSE IF EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted)
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Doctors',
        CONCAT('DoctorID=',d.DoctorID,
               ', Name=',d.FirstName,' ',d.LastName,
               ', Specialization=',d.Specialization,
               ', Contact=',d.ContactNumber),
        CONCAT('DoctorID=',i.DoctorID,
               ', Name=',i.FirstName,' ',i.LastName,
               ', Specialization=',i.Specialization,
               ', Contact=',i.ContactNumber),
        'UPDATE'
        FROM inserted i
        INNER JOIN deleted d
        ON i.DoctorID=d.DoctorID;
    END
    ELSE
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Doctors',
        CONCAT('DoctorID=',DoctorID,
               ', Name=',FirstName,' ',LastName,
               ', Specialization=',Specialization,
               ', Contact=',ContactNumber),
        NULL,
        'DELETE'
        FROM deleted;
    END
END;

-- Trigger for Patients table
CREATE TRIGGER trg_Patients_Audit
ON Patients
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT * FROM inserted) AND NOT EXISTS(SELECT * FROM deleted)
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Patients',
        NULL,
        CONCAT('PatientID=',PatientID,
               ', Name=',FirstName,' ',LastName,
               ', Gender=',Gender,
			   ', ContactDetails= ',ContactNumber,
			   ', Medical Description= ',MedicalDescription,
			   ', DoctorID=',DoctorID),
        'INSERT'
        FROM inserted;
    END
    ELSE IF EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted)
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Patients',
        CONCAT('PatientID=',d.PatientID,
               ', Name=',d.FirstName,' ',d.LastName,
               ', Gender=',d.Gender,
			   ', ContactDetails= ',d.ContactNumber,
			   ', Medical Description= ',d.MedicalDescription,
               ', DoctorID=',d.DoctorID),
        CONCAT('PatientID=',i.PatientID,
               ', Name=',i.FirstName,' ',i.LastName,
               ', Gender=',i.Gender,
			   ', ContactDetails= ',i.ContactNumber,
			   ', Medical Description= ',i.MedicalDescription,
               ', DoctorID=',i.DoctorID),
        'UPDATE'
        FROM inserted i
        INNER JOIN deleted d
        ON i.PatientID=d.PatientID;
    END
    ELSE
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Patients',
        CONCAT('PatientID=',PatientID,
               ', Name=',FirstName,' ',LastName,
               ', Gender=',Gender,
			   ', ContactDetails= ',ContactNumber,
			   ', Medical Description= ',MedicalDescription,
               ', DoctorID=',DoctorID),
        NULL,
        'DELETE'
        FROM deleted;
    END
END;

-- Trigger for Appointments table
CREATE TRIGGER trg_Appointments_Audit
ON Appointments
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT * FROM inserted) AND NOT EXISTS(SELECT * FROM deleted)
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Appointments', NULL,
        CONCAT('AppointmentID=',AppointmentsID,
               ', PatientID=',PatientID,
               ', DoctorID=',DoctorID,
               ', Date=',AppointmentDate,
               ', Time=',AppointmentTime,
               ', Status=',CompletionStatus),
        'INSERT'
        FROM inserted;
    END
    ELSE IF EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted)
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Appointments',
        CONCAT('AppointmentID=',d.AppointmentsID,
               ', PatientID=',d.PatientID,
               ', DoctorID=',d.DoctorID,
               ', Date=',d.AppointmentDate,
               ', Time=',d.AppointmentTime,
               ', Status=',d.CompletionStatus),
        CONCAT('AppointmentID=',i.AppointmentsID,
               ', PatientID=',i.PatientID,
               ', DoctorID=',i.DoctorID,
               ', Date=',i.AppointmentDate,
               ', Time=',i.AppointmentTime,
               ', Status=',i.CompletionStatus),
        'UPDATE'
        FROM inserted i
        INNER JOIN deleted d
        ON i.AppointmentsID=d.AppointmentsID;
    END
    ELSE
    BEGIN
        INSERT INTO AuditLogs(TableAudited,OldRecord,NewRecord,ActionPerformed)
        SELECT 'Appointments',
        CONCAT('AppointmentID=',AppointmentsID,
               ', PatientID=',PatientID,
               ', DoctorID=',DoctorID,
               ', Date=',AppointmentDate,
               ', Time=',AppointmentTime,
               ', Status=',CompletionStatus),
        NULL,
        'DELETE'
        FROM deleted;
    END
END;


-- Stored Procedures
-- Doctors' Table
-- Inserting a new Doctor
CREATE PROCEDURE sp_AddDoctor
(
    @FirstName VARCHAR(20),
    @LastName VARCHAR(20),
    @Specialization VARCHAR(20),
    @ContactNumber VARCHAR(10),
    @ContactEmail VARCHAR(50),
    @RoomNumber INT
)
AS
BEGIN
    IF EXISTS(SELECT * FROM AllotedRooms WHERE RoomNumber = @RoomNumber)
    BEGIN
        PRINT 'Room is occupied';
        RETURN;
    END
    INSERT INTO Doctors(FirstName,LastName,Specialization,ContactNumber,ContactEmail,RoomNumber)
    VALUES(@FirstName,@LastName, @Specialization, @ContactNumber, @ContactEmail, @RoomNumber)
END;

-- Display all Doctors
CREATE PROCEDURE sp_GetDoctors
AS
BEGIN
    SELECT * FROM Doctors;
END;

-- Display a Doctor by DoctorID
CREATE PROCEDURE sp_GetDoctorById
(
    @DoctorID INT
)
AS
BEGIN
    SELECT * FROM Doctors WHERE DoctorID = @DoctorID;
END;

-- Update Doctor details
CREATE PROCEDURE sp_UpdateDoctor
(
    @DoctorID INT,
    @FirstName VARCHAR(20) = NULL,
    @LastName VARCHAR(20) = NULL,
    @Specialization VARCHAR(20) = NULL,
    @ContactNumber VARCHAR(10) = NULL,
    @ContactEmail VARCHAR(50) = NULL,
    @RoomNumber INT = NULL
)
AS
BEGIN
    UPDATE Doctors
    SET
        FirstName = ISNULL(@FirstName, FirstName),
        LastName = ISNULL(@LastName, LastName),
        Specialization = ISNULL(@Specialization, Specialization),
        ContactNumber = ISNULL(@ContactNumber, ContactNumber),
        ContactEmail = ISNULL(@ContactEmail, ContactEmail),
        RoomNumber = ISNULL(@RoomNumber, RoomNumber)
    WHERE DoctorID = @DoctorID;
END;

-- Remove a Doctor
CREATE PROCEDURE sp_DeleteDoctor
(
    @DoctorID INT
)
AS
BEGIN
    DELETE FROM Doctors WHERE DoctorID = @DoctorID;
END;

-- Patients Table
-- Admitting a new Patient
CREATE PROCEDURE sp_AddPatient
(
    @FirstName VARCHAR(20),
    @LastName VARCHAR(20),
    @Gender CHAR(1),
    @DateOfBirth VARCHAR(15),
    @ContactNumber VARCHAR(10),
    @ContactEmail VARCHAR(50),
    @ResidenceAddress VARCHAR(100),
    @MedicalDescription VARCHAR(500),
    @Medication VARCHAR(500),
    @DoctorID INT
)
AS
BEGIN
    INSERT INTO Patients(FirstName,LastName,Gender,DateOfBirth,ContactNumber,ContactEmail,ResidenceAddress,MedicalDescription,Medication,DoctorID)
    VALUES(@FirstName, @LastName, @Gender, @DateOfBirth, @ContactNumber, @ContactEmail, @ResidenceAddress, @MedicalDescription, @Medication, @DoctorID)
END;

-- Display all Patients
CREATE PROCEDURE sp_GetPatients
AS
BEGIN
    SELECT * FROM Patients;
END;

--Display a Patient by PatientID
CREATE PROCEDURE sp_GetPatientById
(
    @PatientID INT
)
AS
BEGIN
    SELECT * FROM Patients WHERE PatientID = @PatientID;
END;

-- Update a Patient's Details
CREATE PROCEDURE sp_UpdatePatient
(
    @PatientID INT,
    @FirstName VARCHAR(20) = NULL,
    @LastName VARCHAR(20) = NULL,
    @Gender CHAR(1) = NULL,
    @DateOfBirth VARCHAR(15) = NULL,
    @ContactNumber VARCHAR(10) = NULL,
    @ContactEmail VARCHAR(50) = NULL,
    @ResidenceAddress VARCHAR(100) = NULL,
    @MedicalDescription VARCHAR(500) = NULL,
    @Medication VARCHAR(500) = NULL,
    @DoctorID INT = NULL
)
AS
BEGIN
    IF @DoctorID IS NOT NULL
    BEGIN
        IF NOT EXISTS
        (
            SELECT *
            FROM Doctors
            WHERE DoctorID = @DoctorID
        )
        BEGIN
            PRINT 'Doctor does not exist.';
            RETURN;
        END
    END
    UPDATE Patients
    SET
        FirstName = ISNULL(@FirstName, FirstName),
        LastName = ISNULL(@LastName, LastName),
        Gender = ISNULL(@Gender, Gender),
        DateOfBirth = ISNULL(@DateOfBirth, DateOfBirth),
        ContactNumber = ISNULL(@ContactNumber, ContactNumber),
        ContactEmail = ISNULL(@ContactEmail, ContactEmail),
        ResidenceAddress = ISNULL(@ResidenceAddress, ResidenceAddress),
        MedicalDescription = ISNULL(@MedicalDescription, MedicalDescription),
        Medication = ISNULL(@Medication, Medication),
        DoctorID = ISNULL(@DoctorID, DoctorID)
    WHERE PatientID = @PatientID;;
END;
GO

-- Delete a Patient
CREATE PROCEDURE sp_DeletePatient
(
    @PatientID INT
)
AS
BEGIN
    DELETE FROM Patients WHERE PatientID = @PatientID;
END;

-- Appointments Table
-- Book an Appointment
CREATE PROCEDURE sp_AddAppointment
(
    @PatientID INT,
    @DoctorID INT,
    @AppointmentDate DATE,
    @AppointmentTime TIME,
    @CompletionStatus VARCHAR(20)
)
AS
BEGIN
    INSERT INTO Appointments(PatientID,DoctorID,AppointmentDate,AppointmentTime,CompletionStatus)
    VALUES(@PatientID, @DoctorID, @AppointmentDate, @AppointmentTime, @CompletionStatus)
END;

-- Display all Appointments
CREATE PROCEDURE sp_GetAppointments
AS
BEGIN
    SELECT * FROM Appointments;
END;

-- Display an Appointment by AppointmentID, DoctorID or PatientID
CREATE PROCEDURE sp_GetAppointmentById
(
    @PatientID INT = NULL,
    @DoctorID INT = NULL,
    @AppointmentsID INT = NULL
)
AS
BEGIN
    SELECT * FROM Appointments WHERE PatientID = @PatientID OR DoctorID = @DoctorID OR AppointmentsID = @AppointmentsID;
END;

-- Update an Appointment
CREATE PROCEDURE sp_UpdateAppointment
(
    @AppointmentsID INT,
    @PatientID INT = NULL,
    @DoctorID INT = NULL,
    @AppointmentDate DATE = NULL,
    @AppointmentTime TIME = NULL,
    @CompletionStatus VARCHAR(20) = NULL
)
AS
BEGIN
    IF @PatientID IS NOT NULL
    BEGIN
        IF NOT EXISTS
        (
            SELECT *
            FROM Patients
            WHERE PatientID = @PatientID
        )
        BEGIN
            RETURN;
        END
    END
    IF @DoctorID IS NOT NULL
    BEGIN
        IF NOT EXISTS
        (
            SELECT *
            FROM Doctors
            WHERE DoctorID = @DoctorID
        )
        BEGIN
            RETURN;
        END
    END
    UPDATE Appointments
    SET
        PatientID = ISNULL(@PatientID, PatientID),
        DoctorID = ISNULL(@DoctorID, DoctorID),
        AppointmentDate = ISNULL(@AppointmentDate, AppointmentDate),
        AppointmentTime = ISNULL(@AppointmentTime, AppointmentTime),
        CompletionStatus = ISNULL(@CompletionStatus, CompletionStatus)
    WHERE AppointmentsID = @AppointmentsID;
END;

-- Delete an Appointment
CREATE PROCEDURE sp_DeleteAppointment
(
    @AppointmentID INT
)
AS
BEGIN
    DELETE FROM Appointments WHERE AppointmentsID = @AppointmentID;
END;

-- Check if the room is already occupied by any doctor
CREATE TRIGGER  trg_CheckRoomOccupancy
ON Doctors AFTER INSERT,UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Doctors d INNER JOIN inserted i ON d.RoomNumber = i.RoomNumber WHERE d.DoctorID <> i.DoctorID)
    BEGIN
        THROW 5001, 'This Room is already occupied',1;
        ROLLBACK TRANSACTION;
    END
END;