use Lab4

create table Department
(
Department_ID int primary key not null,
Department_Name varchar(30) not null,
)
create table Employees
(
Employee_ID int primary key not null,
Employee_Name varchar(30) not null,
DepartmentId int foreign key references Department(Department_ID)
)
--------2------
insert into Department(Department_ID,Department_Name) Values
	(01,'bscs'),
	(02,'Inter'),
	(03,'BBA'),
	(04,'BEEE'),
	(05,'BA')

insert into Employees(Employee_ID,Employee_Name,DepartmentId) Values
	(21,'Affan',03),
	(22,'Furqan',03),
	(23,'Nadeem',03),
	(24,'Nabeel',03),
	(25,'Arshad',03),
	(26,'Faizan',02),
	(27,'Suhaib Ahmed',01),
	(28,'Ahmed',05),
	(29,'Nabeel',02),
	(30,'Usama',03),
	(31,'Ashraf',04),
	(32,'Zain',01),
	(33,'Saleem',02),
	(34,'Daniyal',05),
	(35,'Hamza abbasi',03),
	(36,'Ahad',01),
	(37,'Shan Haider',04),
	(38,'Salman',03),
	(39,'Haris',02),
	(40,'Nawaz',05)

-----task 3 part 1-------------
delete from Department where Department_ID = 01
---------------task 3 part 2-----
delete From Department where Department_ID = 05

---------------task 4 part 3----------

delete From Department where Department_ID = 01


select * from Department
select * from Employees