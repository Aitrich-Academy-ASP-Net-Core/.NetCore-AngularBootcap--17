CREATE LOGIN university_user WITH PASSWORD = '12345678';
CREATE USER university_user FOR LOGIN university_user;
GO
CREATE DATABASE university_informations;
GO
USE university_informations;
CREATE TABLE Universitys (
    UID INT PRIMARY KEY,
    Name VARCHAR(20),
    Chancellor VARCHAR(20)
);

CREATE TABLE Deans (
    DeanID INT PRIMARY KEY,
    Name VARCHAR(20),
    DateOfBirth DATETIME
);

CREATE TABLE Colleges (
    CID INT PRIMARY KEY,
    Universitys INT FOREIGN KEY REFERENCES Universitys(UID),
    Deans INT FOREIGN KEY REFERENCES Deans(DeanID),
    Name VARCHAR(50)
);

CREATE TABLE Departments (
    DID INT PRIMARY KEY,
    Colleges INT FOREIGN KEY REFERENCES Colleges(CID),
    Name VARCHAR(100)
);

CREATE TABLE Professors (
    PID INT PRIMARY KEY,
    Departments INT FOREIGN KEY REFERENCES Departments(DID),
    Name VARCHAR(50)
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    Departments INT FOREIGN KEY REFERENCES Departments(DID),
    Name VARCHAR(50)
);

CREATE TABLE Subjects (
    SubjectID INT PRIMARY KEY,
    Courses INT FOREIGN KEY REFERENCES Courses(CourseID),
    Professors INT FOREIGN KEY REFERENCES Professors(PID),
    Name VARCHAR(50)
);

CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    Departments INT FOREIGN KEY REFERENCES Departments(DID),
    Name VARCHAR(50),
    DateOfEnrollment SMALLDATETIME,
    TelephoneNumber VARCHAR(20)
);

CREATE TABLE Student_Registrations (
    Students INT FOREIGN KEY REFERENCES Students(StudentID),
    Subjects INT FOREIGN KEY REFERENCES Subjects(SubjectID),
    PRIMARY KEY (Students, Subjects)
);
ALTER TABLE Departments
ALTER COLUMN Name VARCHAR(100);
INSERT INTO Universitys VALUES (1,'Calicut University','Aravind Kumar');
INSERT INTO Deans VALUES(1,'Dr.Padma','1972-10-23');
INSERT INTO Colleges VALUES(1,1,1,'ST.Marys College');

INSERT INTO Departments VALUES(1,1,'Computer Science Engineering');
DELETE FROM Departments WHERE DID = 1;

INSERT INTO Departments VALUES (1, 1, 'Computer Science Engineering');
INSERT INTO Departments VALUES(2,1,'Data Science');
INSERT INTO Departments VALUES(3,1,'IT');
INSERT INTO Professors VALUES(1,1,'Dr.Arun Varghese');
INSERT INTO Professors VALUES(2,2,'Dr.Anupama');
INSERT INTO Professors VALUES(3,3,'Amrutha P.S');

INSERT INTO Courses VALUES(1,1,'B.Tech in CS');
INSERT INTO Courses VALUES(3,2,'BSc Datascience');
INSERT INTO Courses VALUES(4,3,'B.Tech in IT');
INSERT INTO Subjects VALUES(1,1,1,'Data Structure and Algorithms');

INSERT INTO Subjects VALUES(2,2,1,'Machine learning');
INSERT INTO Subjects VALUES(3,3,2,'Python Programming');
DELETE FROM Courses WHERE CourseID=2;
INSERT INTO Courses VALUES(2,1,'M.Tech in CS');
INSERT INTO Subjects VALUES(4,4,3,'Database Management System');
INSERT INTO Students VALUES(1,1,'Neha c.j','2024-03-23','9778589802');
INSERT INTO Students VALUES(2,1,'Avani','2024-04-23','9773545800');
INSERT INTO Students VALUES(3,2,'Nidhin ','2025-04-22','9479370702');
INSERT INTO Students VALUES(4,3,'Arjun Raj','2024-04-19','9526781510');

INSERT INTO Student_Registrations VALUES (1, 1); 
INSERT INTO Student_Registrations VALUES (2, 2);  
INSERT INTO Student_Registrations VALUES (3, 3);  
INSERT INTO Student_Registrations VALUES (4, 4);  
SELECT * FROM Universitys;
SELECT * FROM Deans;
SELECT * FROM Colleges;
SELECT * FROM Departments;
SELECT * FROM Professors;
SELECT * FROM Courses;
SELECT * FROM Subjects;
SELECT * FROM Students;
SELECT * FROM Student_Registrations;
CREATE VIEW StudentCoursesView AS
SELECT 
    s.StudentID,
    s.Name AS StudentName,
    d.Name AS Department,
    c.Name AS Course,
    sub.Name AS Subject
FROM Students s
JOIN Departments d ON s.Departments = d.DID
JOIN Courses c ON c.Departments = d.DID
JOIN Subjects sub ON sub.Courses = c.CourseID
JOIN Student_Registrations sr ON sr.Students = s.StudentID
WHERE sr.Subjects = sub.SubjectID;
UPDATE Deans
SET Name = 'Renuka Mukerjee'
WHERE Name = 'Dr.Padma';
UPDATE Students
SET TelephoneNumber = '8105874639'
WHERE Name = 'Neha c.j';
SELECT 
    s.Name AS Student,
    col.Name AS College,
    c.Name AS Course,
    p.Name AS Professor
FROM Students s
JOIN Departments d ON s.Departments = d.DID
JOIN Colleges col ON d.Colleges = col.CID
JOIN Courses c ON c.Departments = d.DID
JOIN Subjects sub ON sub.Courses = c.CourseID
JOIN Professors p ON sub.Professors = p.PID;

SELECT p.Name AS Professor
FROM Professors p
JOIN Departments d ON p.Departments = d.DID
WHERE d.Name = 'Computer Science Engineering';
SELECT DISTINCT c.Name AS Course
FROM Courses c
JOIN Subjects sub ON c.CourseID = sub.Courses
JOIN Professors p ON sub.Professors = p.PID
WHERE p.Name = 'Dr.Arun Varghese';
SELECT d.Name AS Department, COUNT(*) AS StudentCount
FROM Students s
JOIN Departments d ON s.Departments = d.DID
GROUP BY d.Name;
SELECT * FROM Colleges
ORDER BY Name DESC;
SELECT sub.Name AS Subject, p.Name AS Professor
FROM Subjects sub
JOIN Professors p ON sub.Professors = p.PID
ORDER BY sub.Name;

























