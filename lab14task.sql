create database Labtask14

use LabTask14

create table EmployeeRecord(
	id int primary key identity(1,1),
	name varchar(50) not null,
	salary int not null,
	gender varchar(6) not null,
	DepartmentID int not null, 
)
insert EmployeeRecord values('Umair',1500,'male',30)

create table EmployeeAudit(
	audit_id int primary key identity(1,1),
	audit_details nchar(1000),
)

create trigger tr_GetEmployforInsert
on EmployeeRecord
for insert
as
Begin
declare @id int
select @id=id from inserted
select @id=id from deleted
insert into EmployeeAudit values
('New Record with id='+CAST(@id as nvarchar(6))+
'is inserted at'+ CAST(GETDATE()as nvarchar(50)))
end

update EmployeeRecord set name='shakil',DepartmentID=15 where id=6

select * from EmployeeAudit
select * from EmployeeRecord