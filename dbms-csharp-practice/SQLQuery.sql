create database students_db;
use students_db;
use master;
drop database training;
use students_db;
CREATE TABLE UniversityStudents(
	StudentID INT PRIMARY KEY,
	StudentName VARCHAR(10) NOT NULL,
	StudentYear INT NOT NULL
);
ALTER TABLE UniversityStudents ADD StudentAge INT;
DROP TABLE UniversityStudents;
CREATE TABLE StudentsDetails(
	StudentID INT IDENTITY(1,1) PRIMARY KEY,
	StudentName VARCHAR(40) NOT NULL,
	StudentYear INT NOT NULL,
	StudentAge INT NOT NULL
);
ALTER TABLE StudentDetails
ALTER COLUMN StudentName VARCHAR(30)
INSERT INTO StudentsDetails(StudentName, StudentYear,StudentAge) 
VALUES('Aman Gupta', 2020, 22);
SELECT * FROM StudentsDetails;
DROP TABLE StudentsDetails;
CREATE TABLE StudentsDetailsAudit(
AuditID INT IDENTITY(1,1) PRIMARY KEY,
StudentID INT,
AuditAction VARCHAR(10),
OldValue NVARCHAR(MAX),
NewValue NVARCHAR(MAX),
ChnagedBy VARCHAR(50),
ChangedDate DATETIME DEFAULT GETDATE()
);
DROP TABLE StudentsDetailsAudit;
SELECT * FROM StudentsDetailsAudit;
CREATE TRIGGER trgStudentsDetailsAudit
on StudentsDetails
AFTER UPDATE, INSERT, DELETE
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @ActionType VARCHAR(10);
	IF EXISTS (SELECT * FROM deleted) AND EXISTS (SELECT * FROM inserted)
		SET @ActionType = 'UPDATE';
	ELSE IF EXISTS (SELECT * FROM inserted)
		SET @ActionType = 'INSERT';
	ELSE IF EXISTS ( SELECT * FROM deleted)
		SET @ActionType = 'DELETE';
	ELSE
		RETURN;

	IF @ActionType = 'INSERT'
	BEGIN
		INSERT INTO StudentsDetailsAudit(StudentID, AuditAction, OldValue, NewValue, ChnagedBy, ChangedDate)
		SELECT StudentID, 'INSERT', NULL, (SELECT * FROM inserted i WHERE i.StudentID = inserted.StudentID FOR JSON AUTO),SYSTEM_USER, GETDATE()
		FROM inserted;
	END
	IF @ActionType = 'DELETE'
	BEGIN
		INSERT INTO StudentsDetailsAudit(StudentID, AuditAction, OldValue, NewValue, ChnagedBy, ChangedDate)
		SELECT StudentID, 'DELETE', (SELECT * FROM deleted d WHERE d.StudentID = deleted.StudentID FOR JSON AUTO),NULL, SYSTEM_USER, GETDATE()
		FROM deleted;
	END
	IF @ActionType = 'UPDATE'
	BEGIN
		INSERT INTO StudentsDetailsAudit(StudentID, AuditAction, OldValue, NewValue, ChnagedBy, ChangedDate)
		SELECT i.StudentID, 'UPDATE',
		(SELECT * FROM deleted d WHERE d.StudentID = i.StudentID FOR JSON AUTO),
		(SELECT * FROM inserted i2 WHERE i2.StudentID = i.StudentID FOR JSON AUTO), SYSTEM_USER,GETDATE()
		FROM inserted i;
	END
END;
INSERT INTO StudentsDetails(StudentName, StudentYear,StudentAge) 
VALUES('Aman Agarwal', 2020, 22);
SELECT * FROM StudentsDetailsAudit;
UPDATE StudentsDetails SET StudentAge = 21 WHERE StudentID = 3;
DELETE FROM StudentsDetails WHERE StudentID = 3;

CREATE PROCEDURE spAddStudents
	@Name VARCHAR(40),
	@Year INT,
	@Age INT
AS
BEGIN
	SET NOCOUNT ON;
	IF @NAME IS NULL OR @Name =''
	BEGIN
		PRINT 'Error : Student Name cannot be empty';
		RETURN;
	END
	INSERT INTO StudentsDetails(StudentName,StudentYear,StudentAge)
	VALUES(@Name,@Year,@Age);

END;
EXEC spAddStudents
	@Name = 'Aditya Singh',
	@Year = 2023,
	@Age = 21;


CREATE PROCEDURE spUpdateStudents
	@ID INT,
	@Name VARCHAR(40),
	@Year INT,
	@Age INT
AS
BEGIN
	SET NOCOUNT ON;
	IF NOT EXISTS ( SELECT 1 FROM StudentsDetails WHERE StudentID = @ID)
	BEGIN
		PRINT 'Error : Student ID Not Found';
		RETURN;
	END
	UPDATE StudentsDetails
	SET
		StudentName = @Name,
		StudentYear = @Year,
		StudentAge = @Age
	WHERE StudentID = @ID;
END;

EXEC spUpdateStudents
	@ID = 4,
	@Name = 'Aditya Sharma',
	@Year = 2024,
	@Age = 24;

