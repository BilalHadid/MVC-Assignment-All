use company
Create database company

Create table Employee
(
  id int not null,
  FirstName varchar(30),
  LastName varchar(20),
  CNIC nchar(14),
  Gender varchar(6),
  Department varchar(30),
  Salary int,
  Address varchar(30),
  Contact nchar(11)
)

-------Task 2 -------------

insert into Employee(id, FirstName, LastName, CNIC, Gender, Department, Salary, Address,Contact)
values(01,'Bilal','Hadid',4220138848267,'Male', 'HR',100,'karachi',03482091349),
	  (02,'John','Smith',4220138848267,'Male', 'HR',1000,'karachi',03482091349),
	  (03,'Bill','Gates',4220138848267,'Male', 'HR',2000,'karachi',03482091349),
	  (04,'Newton','Law',4220138848267,'Male', 'HR',3000,'karachi',03482091349),
	  (05,'Nabeel','Ahmed',4220138848267,'Male', 'HR',10000,'karachi',03482091349),
	  (06,'Daniyal','Ghouri',4220138848267,'Male', 'HR',4000,'karachi',03482091349),
	  (07,'Shahmeer','Rana',4220138848267,'Male', 'HR',5000,'karachi',03482091349),
	  (08,'Rana','Liaquat',4220138848267,'Male', 'HR',1500,'karachi',03482091349),
	  (09,'Zafar','khan',4220138848267,'Male', 'HR',6000,'karachi',03482091349),
	  (10,'Ahson','Javed',4220138848267,'Male', 'HR',3000,'karachi',03482091349),
	  (11,'khadija','mastoori',4220138848267,'Female', 'HR',8000,'karachi',03482091349),
	  (12,'Imran','khan',4220138848267,'Male', 'HR',2000,'karachi',03482091349),
	  (13,'javed','Iqbal',4220138848267,'Male', 'HR',1000,'karachi',03482091349),
	  (14,'imran','shah',4220138848267,'Male', 'HR',1000,'karachi',03482091349),
	  (15,'muhammad','Ali',4220138848267,'Male', 'HR',5000,'karachi',03482091349),
	  (16,'Abdullah','Hadid',4220138848267,'Male', 'HR',2000,'karachi',03482091349),
	  (18,'suhaib','Ahmed',4220138848267,'Male', 'HR',4000,'karachi',03482091349),
	  (19,'Minal','Rajpoot',4220138848267,'Female', 'HR',100,'karachi',03482091349),
	  (20,'feroz','Iqbal',4220138848267,'Male', 'HR',1500,'karachi',03482091349),
	  (21,'Mamnoon','Hussain',4220138848267,'Male', 'HR',4000,'karachi',03482091349),
	  (22,'Ahson','Khan',4220138848267,'Male', 'HR',1000,'karachi',03482091349),
	  (23,'Usman','Khalid',4220138848267,'Male', 'HR',1500,'karachi',03482091349),
	  (24,'sheroz','patel',4220138848267,'Male', 'HR',2000,'karachi',03482091349),
	  (25,'Hammad','Gull',4220138848267,'Male', 'HR',3000,'karachi',03482091349),
	  (26,'rana','Anas',4220138848267,'Male', 'HR',2500,'karachi',03482091349),
	  (27,'Uzaifa','Khan',4220138848267,'Male', 'HR',1500,'karachi',03482091349),
	  (28,'Usama','Hanif',4220138848267,'Male', 'HR',3000,'karachi',03482091349),
	  (29,'Khuzima','khan',4220138848267,'Male', 'HR',2000,'karachi',03482091349),
	  (30,'Babar','Ashraf',4220138848267,'Male', 'HR',1500,'karachi',03482091349)
	  
-----TASK 3 ------------
select * from Employee
WHERE Salary BETWEEN 2000 AND 5000


-----------Task 4----------------
select * from Employee
Where Salary in (2000, 3000, 4000, 1500)



------------Task 5---------------
update Employee Set FirstName='Martin'
WHERE FirstName = 'John'



------------Task 6 ----------
DELETE FROM Employee 
WHERE Salary > 4000


select * from Employee