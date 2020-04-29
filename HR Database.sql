create database HR_Database
create table Regions
(
Region_ID int not null,
Region_Name varchar(25),
primary key(Region_ID),
);
create table Countries
(
Country_ID char(2) not null,
Country_Name varchar(40),
Region_ID int,
primary key(Country_ID),
foreign key (Region_ID) references Regions(Region_ID),
);

create table Locations
(
Location_ID int not null,
Street_Address varchar(25),
Postal_Code varchar(12),
CITY varchar(30),
State_Province varchar(12),
Country_ID char(2),
primary key(Location_ID),
foreign key (Country_ID) references Countries(Country_ID),
);

create table Departments
(
Department_ID int not null,
Department_Name varchar(30),
Manager_ID int,
Location_ID int,
primary key(Department_ID),
foreign key (Location_ID) references Locations(Location_ID),
);

create table Jobs
(
Job_ID varchar(10) not null,
Job_Title varchar(35),
Min_Salary int,
Max_Salary int,
primary key(Job_ID),
);

create table Job_History
(
Employee_ID int,
StartDate date,
EndDate date,
Job_ID varchar(10),
Department_ID int,
primary key (Employee_ID),
foreign key (Department_ID) references Departments(Department_ID),
foreign key (Job_ID) references Jobs(Job_ID),
unique(StartDate),
);

create table Employees
(
Employee_ID int not null,
First_Name varchar(20),
Last_Name varchar(25),
EMAIL varchar(25),
Phone_Number varchar(20),
Hire_Date date,
Job_ID varchar(10),
Salary int,
Commission_PCT int,
Manager_ID int,
Department_ID int,
foreign key (Employee_ID) references Job_History(Employee_ID),
foreign key (Job_ID) references Jobs(Job_ID),
foreign key (Department_ID) references Departments(Department_ID),
);

create table Job_Grades
(
Grade_Level varchar(2),
Lowest_Sal int,
Highest_Sal int,
primary key (Grade_Level),
);

create database Customers
create table Customers
(
CustomerID int,
CustomerName nvarchar(30),
City nvarchar(25),
Gender varchar(25),
PostalCode nvarchar(10),
primary key(CustomerID),
);

CREATE PROCEDURE SelectAllCustomers @City nvarchar(30), @PostalCode nvarchar(10)
AS
SELECT * FROM Customers WHERE City = @City AND PostalCode = @PostalCode
GO
EXEC SelectAllCustomers @City = 'London', @PostalCode = 'WA1 1DP';

/*Insert Method*/
create procedure InsertIntoCustomers @CustomerID int, @CustomerName nvarchar(30), @Gender varchar(25)
as
insert into Customers values(@CustomerID,@CustomerName,@Gender)

exec dbo.InsertintoEmployees @EmpID=9931,@EmpName='Areesh',@EmpGender='Male'
exec dbo.SelectAllCustomer;

/*Update Method*/
create procedure UpdateCustomer @CustomerID int, @CustomerName nvarchar(30), @Gender varchar(25)
as
update Customers set CustomerName=@CustomerName, Gender=@Gender where CustomerID=@CustomerID

exec dbo.UpdateEmployee @EmpID=9911, @EmpName='BaateinKesiKarahahai', @EmpGender='Male'
exec dbo.SelectAllCustomer;

/*Delete Method*/
create procedure DeleteCustomer @CustomerID int
as
delete from Emplyee_info where CustomerID=@CustomerID

exec dbo.DeleteCustomer @CustomerID=9921
exec dbo.SelectAllCustomer;