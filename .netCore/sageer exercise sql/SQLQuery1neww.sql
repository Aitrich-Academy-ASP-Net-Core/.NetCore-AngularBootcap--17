create table University(UID int primary key,Name varchar(20),Chancellor varchar(20));
create table College(CID int primary key,University int,foreign key(University) references University(UID) ,Dean int,foreign key(Dean) references Dean(DeanID),Name varchar(30));
create table Dean(DeanID int primary key,Name	varchar (20),DateOfBirth	DateTime);
create table Department(DID	int primary key,College int,foreign key(College) references College(CID), Name varchar (20));
create table Professor(PID int primary key,Department int,foreign key(Department) references Department(DID),	Name varchar (20));
create table Course(CourseID int primary key, Department int,foreign key(Department) references Department(DID),Name varchar (20));
create table Subject(SubjectID int primary key,	Course int,foreign key (Course) references Course (CourseID),Professor int,foreign key(professor) references professor(PID) ,Name varchar(20));
create table Student(StudentID int primary key,Department int,foreign key (Department) references Department(DID) ,Name	varchar (20),DateofEnrollment	smalldatetime,TelephoneNumber varchar(20));
create table Student_Registration(Student int,foreign key(Student) references Student(StudentID),Subject int,foreign key(Subject) references Subject(SubjectID));


CREATE PROC InsertUnversity
	@UID int,
	@Name varchar(20),
	@Chancellor varchar(20)

AS
BEGIN
	INSERT INTO University (UID,Name,Chancellor) VALUES(@UID,@Name,@Chancellor);
END;
	

CREATE PROC UpdateUniversity
	@UID int,
	@Name varchar(20),
	@Chancellor varchar(20)
AS
BEGIN
	UPDATE University
	SET Name=@Name,Chancellor=@Chancellor
	WHERE UID=@UID;
END;


CREATE PROC DeletUniversity
	@UID int
AS
BEGIN
	DELETE FROM University
	WHERE UID=@UID;
END;


CREATE PROC GetCSStudents
AS
BEGIN
    SELECT S.StudentID, S.Name, S.DateofEnrollment, S.TelephoneNumber
    FROM Student S
    JOIN Department D ON S.Department = D.DID
    WHERE D.Name = 'Computer Science';
END;


CREATE FUNCTION GetDeanUnversity()
RETURNS TABLE
AS
RETURN
(
    SELECT C.Name AS CollegeName, D.Name AS DeanName, U.Name AS UniversityName
    FROM College C
    JOIN Dean D ON C.Dean = D.DeanID
    JOIN University U ON C.University = U.UID
);



CREATE FUNCTION GenCollegeCode()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @MaxID INT;
    DECLARE @Code VARCHAR(10);

    SELECT @MaxID = ISNULL(MAX(CID), 0) + 1 FROM College;
    SET @Code = 'COL' + RIGHT('00000' + CAST(@MaxID AS VARCHAR), 5);

    RETURN @Code;
END;


CREATE FUNCTION GetCambridge()
RETURNS TABLE
AS
RETURN
(
    SELECT C.Name AS CollegeName
    FROM College C
    JOIN University U ON C.University = U.UID
    WHERE U.Name = 'Cambridge University'
);
