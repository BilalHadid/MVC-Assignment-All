use PracticeWorkstart
Create database PracticeWorkstart

alter database PracticeWorkstart modify name = MyPractice
sp_renamedb 'MyPractice', 'NewMyPractice'

Create table Employess
(
emp_id int not null primary key ,
emp_name varchar(30) not null,
emp_phone bigint not null unique,
emp_email varchar(30) not null unique,

)
alter table Employess Add emp_Department varchar(20)
alter table Employess drop column emp_Department

select emp_id, emp_name
from Employess
insert into Employess (emp_id,emp_name,emp_phone,emp_email) values
	(05,'Bilal',034025624,'bilalhadid595@gmail.com'),
	(02,'Qasim',03152492548,'Qasimkhan@gmail.com'),
	(03,'Suhaib',03245856422,'MianSuhaib@gmail.com'),
	(04,'Usama',255124564,'USamaAshraf@gmail.com')


update Employess set emp_name = 'QasimKhan' Where emp_id=02

select distinct emp_name from Employess
select count(emp_id),emp_name from Employess
group by emp_name having count(emp_id) < 5

select * from Employess