use lab3
Create database lab3

Create table Department
(
 Department_ID int not null primary key,
 Department_name varchar(30) not null,
 Department_Head varchar(30) not null,
)

-----task 2-----
Create table Employee
(
 EmployeeID int not null,
 Employee_Name varchar(30) not null,
 Employee_Age int not null,
 Employee_Gender varchar(20) not null,
 DepartmentID int foreign key references Department(Department_ID),
)

--------------task 3---------
Alter table Employee
ADD constraint Employee_Age CHECK(Employee_Age != 0 AND Employee_Age !< 0)

------------------Task 4-----------

ALTER table [dbo].[Employee] 
Add constraint [df_Employee_EmployeeID]
DEFAULT ((2)) FOR [EmployeeID];

select * From Employee




