CREATE DATABASE COMPANYMASTER
CREATE TABLE COMPANYMASTER
(
ID INT ,
NAME VARCHAR(50),
REMARKS VARCHAR(250),

)
SELECT * FROM COMPANYMASTER;
GO

CREATE proc CompanyMaster_Insert
(
@v_name as varchar(50),
@v_remarks as varchar(250)
)
as
declare @v_id as int
begin
select @v_id= (select isnull(max(id),0)+1 from CompanyMaster)
insert into CompanyMaster(id,name,remarks)
values (@v_id,@v_name,@v_remarks)
end
GO

exec CompanyMaster_Insert 'vishnu','GOOD'

go


CREATE proc CompanyMaster_Update
(
@v_id as int,
@v_name as varchar(50),
@v_remarks as varchar(250)
)
as
begin
update CompanyMaster set name = @v_name,remarks = @v_remarks where id = @v_id
end
GO

exec COMPANYMASTER_update 3,'manu','good'


SELECT * FROM COMPANYMASTER;
GO

CREATE PROC  deleteProc
(
	@v_id int
	
) AS

BEGIN
		EXEC ('delete from '+'COMPANYMASTER' + ' where '  +'id'+ '=' +@v_id)
END


exec deleteProc 2



create proc SelectProc2
(
@v_id int
)
AS

BEGIN
exec('Select * from COMPANYMASTER where id=' + @v_id)
END

exec SelectProc2  3





CREATE proc SelectProc4
(
@v_name varchar(50)
)
AS

BEGIN 
 exec('Select * From companymaster ' +@v_name)
END


EXEC SelectProc4 'where name=''neema'''