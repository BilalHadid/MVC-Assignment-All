use BilalQadri
Create database BilalQadri

Create table Department
(
Dep_No int not null primary key,
Dep_Name varchar(30) not null,
Dep_Loca varchar(30) not null
)

insert into Department (Dep_No,Dep_Name,Dep_Loca) values
   (10, 'Accounting','Newyork'),
   (20,'Reserch','DALLAS'),
   (30,'Sales','Chicago'),
   (40,'Operation','Boston')


Create table Employee
(
Emp_No int not null ,
EName varchar(30) not null,
Emp_Job varchar(30) not null,
Emp_MGR int ,
Emp_HireDate date not null,
Emp_SAL int not null,
Emp_COMM int ,
Emp_Depart int foreign key references Department(Dep_No)
)
select Emp_MGR from Employee where Emp_MGR IS not null
insert into Employee (Emp_No,EName,Emp_Job,Emp_MGR,Emp_HireDate,Emp_SAL,Emp_COMM,Emp_Depart) values
	(7369,'Smith','Clerk',7902,'17-Dec-80',800,null,20),
	(7499,'Allen','SalesMan',7698,'20-Feb-81',1600,null,30),
	(7521,'Ward','SalesMan',7698,'22-Feb-81',1250,null,30),
	(7566,'Jones','Manager',7839,'02-Apr-81',2975,null,20),
	(7654,'Martin','SalesMan',7698,'28-Sep-81',1250,null,30),
	(7698,'Black','Manager',7839,'01-May-81',2850,null,30),
	(7782,'Clark','Manager',7839,'09-Jun-81',2450,null,10),
	(7788,'Scott','Analyst',7566,'09-Dec-82',3000,null,20),
	(7839,'King','President',null,'17-Nov-81',5000,null,10),
	(7844,'Turner','SalesMan',7698,'08-Sep-81',1500,null,30),
	(7876,'Adams','Clerk',7788,'12-Jan-83',1100,null,20),
	(7900,'James','Clerk',7698,'03-Dec-81',950,null,30),
	(7902,'Ford','Analyst',7566,'03-Dec-81',3000,null,20),
	(7934,'Miller','Clerk',7782,'23-Jan-82',1300,null,10)

------------40---------
select Emp_SAL*12 as anualSalary from Employee ORDER BY Emp_SAL Desc
----------41---------
select EName,(Emp_SAL/100)*15 as hra, (Emp_SAL/100)*10 as da,
		(Emp_SAL/100)*5 as pf,
		(Emp_SAL+((Emp_SAL/100)*15)+(Emp_SAL/100)*10)-(Emp_SAL/100)*5 as total_Salary
		 from Employee 
---TAsk No. 42---
select Dep_No from Department
select distinct Emp_Depart as total from Employee
-----------43------
-----------44------
select Emp_Depart, (Emp_SAL+((Emp_SAL/100)*15)+(Emp_SAL/100)*10)-(Emp_SAL/100)*5 as total_Salary from Employee
-----------45--------









select * from Department
select EName, Emp_Job from Employee  