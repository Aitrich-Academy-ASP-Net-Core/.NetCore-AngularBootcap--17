CREATE LOGIN tests WITH PASSWORD = 'root2';
CREATE USER test FOR LOGIN tests; 
CREATE DATABASE HireMeNowDB;
GO
USE HireMeNowDB
GO
CREATE TABLE Company (
	 Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	[Name] [varchar](100) NULL,
	[Email] [varchar](50) NOT NULL UNIQUE,
	[Website] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Logo] [varchar](50) NULL,
	[About] [varchar](100) NULL,
	[Vision] [varchar](100) NULL,
	[Mission] [varchar](100) NULL,
	[Place] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
) 
EXEC sp_rename 'Company', 'Companies' ;
ALTER TABLE Companies ALTER COLUMN About varchar(300);
EXEC sp_rename 'Companies.Place', 'Location', 'COLUMN';
CREATE TABLE [dbo].[Users](
	 Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NULL,
	[Location] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Role] [varchar](50) NULL,
	[About] [varchar](50) NULL,
	[Designation] [varchar](50) NULL,
	[CompanyId] [uniqueidentifier] NULL,
	[Status] [varchar](50) NULL,
	[Image] [varchar](50) NULL,
	FOREIGN KEY (CompanyId) REFERENCES Companies (Id)
 )
 ALTER TABLE Users ADD CONSTRAINT email_unique UNIQUE (Email);
  INSERT INTO Companies
 ( Id,Name, Email, Website, Phone, Logo,About, Vision, Mission, Location, Address, Status)      
VALUES 
('ab5f391e-d83e-4eae-87cd-bca23175cf22','Aitrich Academy ', 'aitrich.academy@aitrich.com', 'https://aitrichacademy.com/', '0487012312', NULL,'About us ', ' Our Vision ', 'Our Mission', 'thrissur', '', 'A')
SELECT*FROM Companies;
UPDATE Companies SET Name = 'Aitrich Academy', Address='Aitrich Academy , Thrissur'  WHERE Email = 'aitrich.academy@aitrich.com';
DELETE FROM Companies WHERE email = 'aitrich.academy@aitrich.com';
INSERT INTO Companies
(Id, Name, Email, Website, Phone, Logo, About, Vision, Mission, Location, Address, Status)
VALUES
('ab5f391e-d83e-4eae-87cd-bca23175cf22', 'Aitrich Academy', 'aitrich.academy@aitrich.com',
'https://aitrichacademy.com/', '0487012312', NULL, 'About us', 'Our Vision', 'Our Mission',
'Thrissur', '', 'A');
SELECT*FROM Companies;
INSERT  INTO users
(Id,FirstName, LastName, Email, Gender, Location, Phone, Password, Role, About,Designation, CompanyId, Status, Image)
 VALUES
 ( '9b80c5d4-5de6-4f16-acd5-26f7d392b8b9' , 'Soudha', 'AM', 'soudha.aitrich@gmail.com','Female', 'Thrissur', NULL, '123', 'Jobprovider', NULL, NULL, NULL, 'Active', NULL)
GO
INSERT  INTO users
(Id,FirstName, LastName, Email, Gender, Location, Phone, Password, Role, About,Designation, CompanyId, Status, Image)
 VALUES
 ('6fa50404-3754-4062-a4b0-ca333468e69a', 'yadhu', 'krishna', 'yadhu.aitrich@gmail.com', NULL, 'Thrissur', NULL, '123', 'Jobseeker', NULL, NULL, NULL, 'Active', NULL)
GO
INSERT INTO Users
(Id, FirstName, LastName, Email, Gender, Location, Phone, Password, Role, About, Designation, CompanyId, Status, Image)
VALUES
('08569e5d-b488-4c09-a7d1-e60fe4e5a512', 'Shini', 'Parameswaran', 'shini.aitrich@gmail.com',
NULL, 'Thrissur', NULL, '123', 'CompanyMember', NULL, NULL, 'ab5f391e-d83e-4eae-87cd-bca23175cf22', 'Active', NULL);
SELECT*FROM Users;

ALTER TABLE Users ALTER COLUMN About VARCHAR(300);
UPDATE Users SET  Phone = '8085499250', Location='Kochi',
About='Experienced .NET developer with 5+ years of experience in building Enterprise applications'   WHERE email = 'yadhu.aitrich@gmail.com';
UPDATE Users SET  CompanyId= 'ab5f391e-d83e-4eae-87cd-bca23175cf22'   WHERE email = 'soudha.aitrich@gmail.com';
Select * from Users where Role='Jobseeker';
Select * from Users where Role='Jobseeker' and Email='yadhu.aitrich@gmail.com';
SELECT u.FirstName, u.LastName, u.Email, u.Phone, c.Name FROM users u
INNER JOIN Companies c ON u.CompanyId = c.Id;
select u.FirstName , u.LastName , u.Email , u.Phone , c.Name  from users u, Companies c where  u.CompanyId=c.Id and c.Name='Aitrich Academy' ;















