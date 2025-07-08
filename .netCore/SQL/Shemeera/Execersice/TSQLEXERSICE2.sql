create database TSQLEXCERSIZE2

CREATE TABLE University (
    UID INT PRIMARY KEY,
    Name VARCHAR(20),
    Chancellor VARCHAR(20)
);
GO

CREATE TABLE Dean (
    DeanID INT PRIMARY KEY,
    Name VARCHAR(20),
    DateOfBirth DATETIME
);
GO

CREATE TABLE College (
    CID INT PRIMARY KEY,
    University INT FOREIGN KEY REFERENCES University(UID),
    Dean INT FOREIGN KEY REFERENCES Dean(DeanID),
    Name VARCHAR(20)
);
GO

CREATE TABLE Department (
    DID INT PRIMARY KEY,
    College INT FOREIGN KEY REFERENCES College(CID),
    Name VARCHAR(20)
);
GO

CREATE TABLE Professor (
    PID INT PRIMARY KEY,
    Department INT FOREIGN KEY REFERENCES Department(DID),
    Name VARCHAR(20)
);
GO

CREATE TABLE Course (
    CourseID INT PRIMARY KEY,
    Department INT FOREIGN KEY REFERENCES Department(DID),
    Name VARCHAR(20)
);
GO

CREATE TABLE Subject (
    SubjectID INT PRIMARY KEY,
    Course INT FOREIGN KEY REFERENCES Course(CourseID),
    Professor INT FOREIGN KEY REFERENCES Professor(PID),
    Name VARCHAR(20)
);
GO

CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    Department INT FOREIGN KEY REFERENCES Department(DID),
    Name VARCHAR(20),
    DateOfEnrollment SMALLDATETIME,
    TelephoneNumber VARCHAR(20)
);
GO
INSERT INTO University VALUES (1, 'Cambridge University', 'Dr. John Smith');
INSERT INTO Dean VALUES (1, 'Dr. Alice Brown', '1965-05-10');
INSERT INTO College VALUES (1001, 1, 1, 'Engineering College');
INSERT INTO Department VALUES (2001, 1001, 'Computer Science');
INSERT INTO Professor VALUES (3001, 2001, 'Dr. Alan Turing');
INSERT INTO Course VALUES (4001, 2001, 'Algorithms');
INSERT INTO Subject VALUES (5001, 4001, 3001, 'Algorithm Analysis');
INSERT INTO Student VALUES (6001, 2001, 'Mark Henry', '2023-01-10', '1234567890');






-- 1.	Write stored procedures for insert,update, delete data to the above tables --
CREATE PROCEDURE InsertUniversity
    @UID INT,
    @Name VARCHAR(20),
    @Chancellor VARCHAR(20)
AS
BEGIN
    INSERT INTO University (UID, Name, Chancellor)
    VALUES (@UID, @Name, @Chancellor);
END;
GO


EXEC InsertUniversity 
    @UID = 2, 
    @Name = 'Oxford University', 
    @Chancellor = 'Dr. Jane Doe';

EXEC InsertUniversity 
    @UID = 3, 
    @Name = 'MG University', 
    @Chancellor = 'Dr. MANU';



	SELECT * FROM University;

--UPDATE--
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
GO
EXEC UpdateUniversity
    @UID = 1,
    @Name = 'Cambridge University Updated',
    @Chancellor = 'Dr. Alan Turing';

	--DELETE--

	CREATE PROCEDURE DeleteUniversity
    @UID INT
AS
BEGIN
    DELETE FROM University WHERE UID = @UID;
END;
GO
EXEC DeleteUniversity @UID = 2;



-- 2.	Write stored procedures for retrieve details of students of computer science department. --
CREATE PROCEDURE GetComputerScienceStudents
AS
BEGIN
    SELECT 
        s.StudentID,
        s.Name AS StudentName,
        d.Name AS DepartmentName,
        c.Name AS CollegeName,
        u.Name AS UniversityName,
        s.DateOfEnrollment,
        s.TelephoneNumber
    FROM Student s
    INNER JOIN Department d ON s.Department = d.DID
    INNER JOIN College c ON d.College = c.CID
    INNER JOIN University u ON c.University = u.UID
    WHERE d.Name = 'Computer Science';
END;
GO
EXEC GetComputerScienceStudents;


---3.	Write user defined function to implement auto increment of id fields of all the tables.---

CREATE FUNCTION dbo.GetNextProfessorID()
RETURNS INT
AS
BEGIN
    DECLARE @NextID INT;
    SELECT @NextID = ISNULL(MAX(PID), 400) + 1 FROM Professor;
    RETURN @NextID;
END;
GO

-- Create function for Course ID
CREATE FUNCTION dbo.GetNextCourseID()
RETURNS INT
AS
BEGIN
    DECLARE @NextID INT;
    SELECT @NextID = ISNULL(MAX(CourseID), 500) + 1 FROM Course;
    RETURN @NextID;
END;
GO

-- Insert example using the function
INSERT INTO Professor (PID, Name, Department)
VALUES (dbo.GetNextProfessorID(), 'Dr. Smith', 2001);

INSERT INTO Professor (PID, Name, Department)
VALUES (dbo.GetNextProfessorID(), 'Dr. VARUN', 2001);


SELECT * FROM Professor





-- 4.	Write userdefined function to list Dean and University of various colleges --




CREATE FUNCTION dbo.fn_ListDeanAndUniversity()
RETURNS TABLE
AS
RETURN
(
    SELECT 
        c.Name AS CollegeName,
        d.Name AS DeanName,
        u.Name AS UniversityName
    FROM College c
    INNER JOIN Dean d ON c.Dean = d.DeanID
    INNER JOIN University u ON c.University = u.UID
);
SELECT * FROM dbo.fn_ListDeanAndUniversity();





--5.	Write userdefinedfunction to generate automatic code for college eg:Forcollege,CID will start from COL 00001 --


CREATE FUNCTION GenerateCollegeCode()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @MaxID INT;
    DECLARE @Code VARCHAR(10);

    -- Get the next CID value
    SELECT @MaxID = ISNULL(MAX(CID), 0) + 1 FROM College;

    -- Format it as COL + padded number
    SET @Code = 'COL' + RIGHT('00000' + CAST(@MaxID AS VARCHAR), 5);

    RETURN @Code;
END;
SELECT dbo.GenerateCollegeCode() AS NewCollegeID;




--	Write userdefinedfunction to list colleges under ‘cambridge university’--

CREATE FUNCTION GetCollegesByUniversity
(
    @UniversityName VARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        c.CID,
        c.Name AS CollegeName
    FROM College c
    JOIN University u ON c.University = u.UID
    WHERE u.Name = @UniversityName
);