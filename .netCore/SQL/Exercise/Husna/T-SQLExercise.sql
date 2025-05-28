CREATE DATABASE UniversitySystem;
USE UniversitySystem;

CREATE TABLE University (
    UID INT PRIMARY KEY,
    Name VARCHAR(20),
    Chancellor VARCHAR(20)
);
CREATE TABLE Dean (
    DeanID INT PRIMARY KEY,
    Name VARCHAR(20),
    DateOfBirth DATETIME
);

CREATE TABLE College (
    CID INT PRIMARY KEY,
    University INT FOREIGN KEY REFERENCES University(UID),
    Dean INT FOREIGN KEY REFERENCES Dean(DeanID),
    Name VARCHAR(20)
);

CREATE TABLE Department (
    DID INT PRIMARY KEY,
    College INT FOREIGN KEY REFERENCES College(CID),
    Name VARCHAR(20)
);

CREATE TABLE Professor (
    PID INT PRIMARY KEY,
    Department INT FOREIGN KEY REFERENCES Department(DID),
    Name VARCHAR(20)
);
CREATE TABLE Course (
    CourseID INT PRIMARY KEY,
    Department INT FOREIGN KEY REFERENCES Department(DID),
    Name VARCHAR(20)
);
CREATE TABLE Subject (
    SubjectID INT PRIMARY KEY,
    Course INT FOREIGN KEY REFERENCES Course(CourseID),
    Professor INT FOREIGN KEY REFERENCES Professor(PID),
    Name VARCHAR(20)
);
CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    Department INT FOREIGN KEY REFERENCES Department(DID),
    Name VARCHAR(20),
    DateofEnrollment SMALLDATETIME,
    TelephoneNumber VARCHAR(20)
);
CREATE TABLE Student_Registration (
    Student INT FOREIGN KEY REFERENCES Student(StudentID),
    Subject INT FOREIGN KEY REFERENCES Subject(SubjectID),
    PRIMARY KEY (Student, Subject)
);

--Stored procedure for university-Insert
CREATE PROCEDURE InsertUniversity
    @UID INT,
    @Name VARCHAR(20),
    @Chancellor VARCHAR(20)
AS
BEGIN
    INSERT INTO University (UID, Name, Chancellor)
    VALUES (@UID, @Name, @Chancellor);
END;

--Update
CREATE PROCEDURE UpdateUniversity
    @UID INT,
    @Name VARCHAR(20),
    @Chancellor VARCHAR(20)
AS
BEGIN
    UPDATE University
    SET Name = @Name,
        Chancellor = @Chancellor
    WHERE UID = @UID;
END;

--Delete
CREATE PROCEDURE DeleteUniversity
    @UID INT
AS
BEGIN
    DELETE FROM University
    WHERE UID = @UID;
END;


--Insert for Dean Table
CREATE PROCEDURE InsertDean
    @DeanID INT,
    @Name VARCHAR(20),
    @DateOfBirth DATETIME
AS
BEGIN
    INSERT INTO Dean (DeanID, Name, DateOfBirth)
    VALUES (@DeanID, @Name, @DateOfBirth);
END;


CREATE PROCEDURE UpdateDean
    @DeanID INT,
    @Name VARCHAR(20),
    @DateOfBirth DATETIME
AS
BEGIN
    UPDATE Dean
    SET Name = @Name,
        DateOfBirth = @DateOfBirth
    WHERE DeanID = @DeanID;
END;


CREATE PROCEDURE DeleteDean
    @DeanID INT
AS
BEGIN
    DELETE FROM Dean
    WHERE DeanID = @DeanID;
END;


--Insert for College Table

CREATE PROCEDURE InsertCollege
    @CID INT,
    @University INT,
    @Dean INT,
    @Name VARCHAR(20)
AS
BEGIN
    INSERT INTO College (CID, University, Dean, Name)
    VALUES (@CID, @University, @Dean, @Name);
END;


CREATE PROCEDURE UpdateCollege
    @CID INT,
    @University INT,
    @Dean INT,
    @Name VARCHAR(20)
AS
BEGIN
    UPDATE College
    SET University = @University,
        Dean = @Dean,
        Name = @Name
    WHERE CID = @CID;
END;

CREATE PROCEDURE DeleteCollege
    @CID INT
AS
BEGIN
    DELETE FROM College
    WHERE CID = @CID;
END;


--Department Table
CREATE PROCEDURE InsertDepartment
    @DID INT,
    @College INT,
    @Name VARCHAR(20)
AS
BEGIN
    INSERT INTO Department (DID, College, Name)
    VALUES (@DID, @College, @Name);
END;

CREATE PROCEDURE UpdateDepartment
    @DID INT,
    @College INT,
    @Name VARCHAR(20)
AS
BEGIN
    UPDATE Department
    SET College = @College,
        Name = @Name
    WHERE DID = @DID;
END;


CREATE PROCEDURE DeleteDepartment
    @DID INT
AS
BEGIN
    DELETE FROM Department
    WHERE DID = @DID;
END;


EXEC InsertUniversity @UID = 1, @Name = 'ABC University', @Chancellor = 'Dr. Smith';
EXEC InsertUniversity @UID = 2, @Name = 'DEF University', @Chancellor = 'RONA';
INSERT INTO University (UID, Name, Chancellor)
VALUES (3, 'Cambridge University', 'Kith');

EXEC UpdateUniversity @UID = 1, @Name = 'ABC University Updated', @Chancellor = 'Dr. John Smith';
EXEC DeleteUniversity @UID = 1;
SELECT * FROM University;

EXEC InsertDepartment 
    @DID = 1, 
    @College = 101,  
    @Name = 'Computer Science';

	EXEC UpdateDepartment 
    @DID = 1, 
    @College = 101, 
    @Name = 'Information Technology';
EXEC DeleteDepartment 
    @DID = 1;

	EXEC InsertCollege
    @CID = 101,
    @University = 1,
    @Dean = 10,      
    @Name = 'Engineering College';
	EXEC InsertCollege
    @CID = 104,
    @University = 3,
    @Dean = 11,      
    @Name = 'Software College';
	EXEC InsertCollege
    @CID = 102,
    @University = 1,
    @Dean = 10,      
    @Name = 'Engineering College';
	EXEC InsertCollege
    @CID = 103,
    @University = 2,
    @Dean = 11,      
    @Name = 'CE College';
EXEC InsertDean 
    @DeanID = 10, 
    @Name = 'Prof. John Doe', 
    @DateOfBirth = '1970-05-15';
	EXEC InsertDean 
    @DeanID = 11, 
    @Name = 'Doe', 
    @DateOfBirth = '1970-05-16';






--Write stored procedures for retrieve details of students of computer science department.

	CREATE PROCEDURE GetStudentsByDepartment
    @DepartmentName VARCHAR(20)
AS
BEGIN
    SELECT 
        S.StudentID,
        S.Name AS StudentName,
        S.DateofEnrollment,
        S.TelephoneNumber,
        D.Name AS DepartmentName
    FROM 
        Student S
        INNER JOIN Department D ON S.Department = D.DID
    WHERE 
        D.Name = @DepartmentName;
END;

EXEC GetStudentsByDepartment @DepartmentName = 'Computer Science';

SELECT * FROM Department WHERE Name = 'Computer Science';
SELECT * FROM Student WHERE Department = (SELECT DID FROM Department WHERE Name = 'Computer Science');
INSERT INTO Department (DID, College, Name) VALUES (2, 103, 'Computer Science');
SELECT *FROM College;
INSERT INTO Student (StudentID, Department, Name, DateofEnrollment, TelephoneNumber)
VALUES (5001, 2, 'Alice Johnson', '2023-08-01', '123-456-7890');

--3.	Write user defined function to implement auto increment of id fields of all the tables.

CREATE TABLE AutoIncrement (
    UID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(20),
    Chancellor VARCHAR(20)
);

--Write userdefined function to list  Dean and University of various colleges

CREATE FUNCTION fn_GetDeanAndUniversityOfColleges()
RETURNS TABLE
AS
RETURN
(
    SELECT 
        C.Name AS CollegeName,
        D.Name AS DeanName,
        U.Name AS UniversityName
    FROM 
        College C
        INNER JOIN Dean D ON C.Dean = D.DeanID
        INNER JOIN University U ON C.University = U.UID
);

SELECT * FROM fn_GetDeanAndUniversityOfColleges();

--Write userdefined function to generate automatic code for college 
--eg:For college,CID will start from COL 00001 

CREATE FUNCTION fn_FormatCollegeID (@Id INT)
RETURNS VARCHAR(10)
AS
BEGIN
    RETURN 'COL' + RIGHT('00000' + CAST(@Id AS VARCHAR(5)), 5)
END;

SELECT dbo.fn_FormatCollegeID(1);    
SELECT dbo.fn_FormatCollegeID(25);   
SELECT dbo.fn_FormatCollegeID(1234);  

--Write userdefined function to list colleges under ‘cambridge university’

CREATE FUNCTION fn_GetCollegesUnderCambridge()
RETURNS TABLE
AS
RETURN
(
    SELECT 
        C.CID,
        C.Name AS CollegeName,
        U.Name AS UniversityName
    FROM 
        College C
        INNER JOIN University U ON C.University = U.UID
    WHERE 
        U.Name = 'Cambridge University'
);
SELECT * FROM fn_GetCollegesUnderCambridge();

SELECT * FROM University WHERE Name = 'Cambridge University';














