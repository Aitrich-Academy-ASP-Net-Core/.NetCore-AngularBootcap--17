create table University(UID int primary key,Name varchar(20),Chancellor varchar(20));
create table College(CID int primary key,University int,foreign key(University) references University(UID) ,Dean int,foreign key(Dean) references Dean(DeanID),Name varchar(30));
create table Dean(DeanID int primary key,Name	varchar (20),DateOfBirth	DateTime);
create table Department(DID	int primary key,College int,foreign key(College) references College(CID), Name varchar (20));
create table Professor(PID int primary key,Department int,foreign key(Department) references Department(DID),	Name varchar (20));
create table Course(CourseID int primary key, Department int,foreign key(Department) references Department(DID),Name varchar (20));
create table Subject(SubjectID int primary key,	Course int,foreign key (Course) references Course (CourseID),Professor int,foreign key(professor) references professor(PID) ,Name varchar(20));
create table Student(StudentID int primary key,Department int,foreign key (Department) references Department(DID) ,Name	varchar (20),DateofEnrollment	smalldatetime,TelephoneNumber varchar(20));
create table Student_Registration(Student int,foreign key(Student) references Student(StudentID),Subject int,foreign key(Subject) references Subject(SubjectID));


INSERT INTO University VALUES (1, 'Cambridge University', 'John doe');


INSERT INTO Dean VALUES (101, 'rohit Sharma', '1970-05-20');


INSERT INTO College VALUES (201, 1, 101, 'Engineering College');

INSERT INTO Department VALUES (301, 201, 'Computer Science');
INSERT INTO Department VALUES (302, 201, 'MCA');

INSERT INTO Professor VALUES (401, 301, ' george Peter ');
INSERT INTO Professor VALUES (402, 302, 'leo messi');


INSERT INTO Course VALUES (501, 301, 'B.Tech Computer Science');
INSERT INTO Course VALUES (502, 302, 'MCA');


INSERT INTO Subject VALUES (601, 501, 401, 'Data Structures');
INSERT INTO Subject VALUES (602, 502, 402, 'Operating Systems');
INSERT INTO Subject VALUES (603, 501, 401, 'Computer application');

INSERT INTO Student VALUES (701, 301, 'neymar jr', '2022-07-01', '9876543210');
INSERT INTO Student VALUES (702, 302, 'trent arnold', '2023-01-15', '9000000001');


INSERT INTO Student_Registration VALUES (701, 601);
INSERT INTO Student_Registration VALUES (701, 603);
INSERT INTO Student_Registration VALUES (702, 602);


CREATE LOGIN uniUser WITH PASSWORD = 'Passwd@123';
CREATE USER uniUser FOR LOGIN uniUser;

CREATE DATABASE university_information;
GO

USE university_information;




UPDATE Dean
SET Name = 'rekha singh'
WHERE Name = 'kajol';


UPDATE Student
SET TelephoneNumber = '8105874639'
WHERE Name = 'irfan khan';


SELECT 
    St.Name AS StudentName,
    Col.Name AS CollegeName,
    Cou.Name AS CourseName,
    Prof.Name AS ProfessorName
FROM Student St
JOIN Department Dept ON St.Department = Dept.DID
JOIN College Col ON Dept.College = Col.CID
JOIN Course Cou ON Dept.DID = Cou.Department
JOIN Subject Sub ON Cou.CourseID = Sub.Course
JOIN Professor Prof ON Sub.Professor = Prof.PID;


SELECT P.Name
FROM Professor P
JOIN Department D ON P.Department = D.DID
WHERE D.Name = 'MCA';



SELECT DISTINCT C.Name
FROM Course C
JOIN Subject S ON C.CourseID = S.Course
JOIN Professor P ON S.Professor = P.PID
WHERE P.Name = 'george Peter';



SELECT D.Name AS DepartmentName, COUNT(S.StudentID) AS TotalStudents
FROM Student S
JOIN Department D ON S.Department = D.DID
GROUP BY D.Name;



SELECT Name FROM College
ORDER BY Name DESC;


SELECT S.Name
FROM Subject S
JOIN Course C ON S.Course = C.CourseID
WHERE C.Name = 'B.Tech Computer Science';




SELECT COUNT(DISTINCT C.CourseID) AS ComputerCoursesCount
FROM Course C
JOIN Subject S ON C.CourseID = S.Course
WHERE S.Name LIKE '%Computer%';




SELECT S.Name AS SubjectName, P.Name AS ProfessorName
FROM Subject S
JOIN Professor P ON S.Professor = P.PID
ORDER BY S.Name;


