CREATE DATABASE university_information;
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
    Name VARCHAR(20),
   
    
);


CREATE TABLE Department (
    DID INT PRIMARY KEY,
    College INT FOREIGN KEY REFERENCES College(CID),
    Name VARCHAR(20),
    
);

CREATE TABLE Professor (
    PID INT PRIMARY KEY,
    Department INT FOREIGN KEY REFERENCES Department(DID),
    Name VARCHAR(20),
    
);

CREATE TABLE Course (
    CourseID INT PRIMARY KEY,
    Department INT FOREIGN KEY (Department) REFERENCES Department(DID),
    Name VARCHAR(20),
    
);
CREATE TABLE Subject (
    SubjectID INT PRIMARY KEY,
    Course INT  FOREIGN KEY REFERENCES Course(CourseID),
    Professor INT FOREIGN KEY REFERENCES Professor(PID),
    Name VARCHAR(20),
   
    
);

CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    Department INT FOREIGN KEY REFERENCES Department(DID),
    Name VARCHAR(20),
    DateOfEnrollment SMALLDATETIME,
    TelephoneNumber VARCHAR(20),
    
);
CREATE TABLE Student_Registration (
    Student INT FOREIGN KEY REFERENCES Student(StudentID),
    Subject INT  FOREIGN KEY REFERENCES Subject(SubjectID),
    PRIMARY KEY (Student, Subject),
    
   
);




INSERT INTO University (UID, Name, Chancellor)
VALUES (1, 'Oxford', 'John Smith');
INSERT INTO University (UID, Name, Chancellor)
VALUES (2, 'Harvard', 'Emily Johnson');

INSERT INTO Dean (DeanID, Name, DateOfBirth)
VALUES (1, 'Alice Brown', '1975-06-15');

INSERT INTO Dean (DeanID, Name, DateOfBirth)
VALUES (2, 'Robert Green', '1968-11-23');

INSERT INTO College (CID, University, Dean, Name)
VALUES (1, 1, 1, 'Engineering');
INSERT INTO College (CID, University, Dean, Name)
VALUES (2, 2, 2, 'Mechanical');
INSERT INTO Department (DID, College, Name)
VALUES (2, 1, 'Mechanical');
INSERT INTO Department (DID, College, Name)
VALUES (3, 1, 'Civil');
INSERT INTO Department (DID, College, Name)
VALUES (4, 2, 'MCA');
INSERT INTO Professor (PID, Department, Name)
VALUES (1, 2, 'Dr. Alan Turing');
INSERT INTO Professor (PID, Department, Name)
VALUES (2, 3, ' Turing');
INSERT INTO Professor (PID, Department, Name)
VALUES (4, 3, 'George Peter');
INSERT INTO Course (CourseID, Department, Name)
VALUES (5, 2, 'Algorithms');

INSERT INTO Course (CourseID, Department, Name)
VALUES (6, 2, 'Thermodynamics');
INSERT INTO Course (CourseID, Department, Name)
VALUES (7, 2, 'Computer Science');


INSERT INTO Subject (SubjectID, Course, Professor, Name)
VALUES (1, 2, 4, 'Intro to C#');
SELECT * FROM Professor;


INSERT INTO Subject (SubjectID, Course, Professor, Name)
VALUES (2, 5, 2, 'Advanced Algorithms');
INSERT INTO Subject (SubjectID, Course, Professor, Name)
VALUES (3, 6, 4, 'OS');
INSERT INTO Subject (SubjectID, Course, Professor, Name)
VALUES (4, 7, 4, 'Software');

INSERT INTO Student (StudentID, Department, Name, DateofEnrollment, TelephoneNumber)
VALUES (1, 2, 'Alice Johnson', '2023-08-15', '123-456-7890');

INSERT INTO Student (StudentID, Department, Name, DateofEnrollment, TelephoneNumber)
VALUES (2, 2, 'Bob Smith', '2023-08-20', '234-567-8901');

INSERT INTO Student_Registration (Student, Subject)
VALUES (1, 1);

INSERT INTO Student_Registration (Student, Subject)
VALUES (1, 2);

INSERT INTO Student_Registration (Student, Subject)
VALUES (2, 1);

 
CREATE LOGIN test WITH PASSWORD = 'root';

USE university_information;


CREATE USER test FOR LOGIN test;


GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.University TO test;

USE university_information;
GO


--Update the name of the Dean ‘Renuka Sharma’ to Renuka Mukerjee’.

UPDATE dbo.Dean
SET Name = 'Renuka Mukerjee'
WHERE Name = 'Alice Brown';
SELECT * FROM Dean
--Update the phone number of student ‘Bob Smith’ to ‘8105874639’

UPDATE dbo.Student
SET TelephoneNumber = '8105874639'
WHERE Name = 'Bob Smith';
SELECT * FROM Student;

--To list all students, colleges, courses and professors

SELECT 
    st.StudentID,
    st.Name AS StudentName,
    cl.CID AS CollegeID,
    cl.Name AS CollegeName,
    c.CourseID,
    c.Name AS CourseName,
    p.PID AS ProfessorID,
    p.Name AS ProfessorName
FROM 
    Student st
JOIN 
    Department d ON st.Department = d.DID
JOIN 
    College cl ON d.College = cl.CID
JOIN 
    Student_Registration sr ON st.StudentID = sr.Student
JOIN 
    Subject sb ON sr.Subject = sb.SubjectID
JOIN 
    Course c ON sb.Course = c.CourseID
JOIN 
    Professor p ON sb.Professor = p.PID;


	SELECT * FROM Student;
SELECT * FROM College;
SELECT * FROM Course;
SELECT * FROM Professor;


--Create a view for listing the students and their courses.
CREATE VIEW StudentCourseView AS
SELECT 
    st.StudentID,
    st.Name AS StudentName,
    c.CourseID,
    c.Name AS CourseName
FROM 
    Student st
JOIN 
    Student_Registration sr ON st.StudentID = sr.Student
JOIN 
    Subject sb ON sr.Subject = sb.SubjectID
JOIN 
    Course c ON sb.Course = c.CourseID;

	SELECT * FROM StudentCourseView;
	SELECT * FROM Student;
SELECT * FROM Student_Registration;
SELECT * FROM Subject;
SELECT * FROM Course;


	--To list all professors of MCA department.

	SELECT 
    p.PID,
    p.Name AS ProfessorName,
    d.Name AS DepartmentName
FROM 
    Professor p
JOIN 
    Department d ON p.Department = d.DID
WHERE 
    d.Name = 'Mechanical';
	SELECT * FROM Department;
	SELECT * 
FROM Professor
WHERE Department IN (SELECT DID FROM Department WHERE Name LIKE '%MCA%');
SELECT DID FROM Department WHERE Name = 'MCA';
SELECT * FROM Professor WHERE Department = 4;
INSERT INTO Professor (PID, Department, Name)
VALUES (3, 4, 'Dr. Jane Smith');


--To list all courses taught by Professor ‘George Peter’.
SELECT 
    c.CourseID,
    c.Name AS CourseName,
    p.Name AS ProfessorName
FROM 
    Course c
JOIN 
    Subject sb ON c.CourseID = sb.Course
JOIN 
    Professor p ON sb.Professor = p.PID
WHERE 
    p.Name = 'George Peter';
	SELECT * FROM Professor;

	SELECT * FROM Subject WHERE Professor = (SELECT PID FROM Professor WHERE Name = 'George Peter');

	SELECT * FROM Course;

	--To list all students group by department

	SELECT 
    d.Name AS DepartmentName,
    COUNT(st.StudentID) AS NumberOfStudents
FROM 
    Department d
LEFT JOIN 
    Student st ON d.DID = st.Department
GROUP BY 
    d.Name;
	--To list all colleges in descending order of their names

	SELECT *
FROM College
ORDER BY Name DESC;

--To list all Subjects under course “Computer Science”
SELECT 
    sb.SubjectID,
    sb.Name AS SubjectName,
    c.Name AS CourseName
FROM 
    Subject sb
JOIN 
    Course c ON sb.Course = c.CourseID
WHERE 
    c.Name = 'Computer Science';

	SELECT * FROM Course;
	SELECT * FROM Subject WHERE Course = 3;

	 --To count the number of courses has computer subject.
	 SELECT 
    COUNT(DISTINCT c.CourseID) AS NumberOfCoursesWithComputerSubject
FROM 
    Course c
JOIN 
    Subject sb ON c.CourseID = sb.Course
WHERE 
    sb.Name LIKE '%computer%';
	SELECT Name FROM Subject;







     --To list all teachers group by subjects.
	 SELECT 
    sb.Name AS SubjectName,
    p.PID,
    p.Name AS ProfessorName
FROM 
    Subject sb
JOIN 
    Professor p ON sb.Professor = p.PID
ORDER BY 
    sb.Name, p.Name;


























