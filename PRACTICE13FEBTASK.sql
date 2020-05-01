use PRACTICETASk
CREATE TABLE Worker (
	WORKER_ID INT NOT NULL PRIMARY KEY identity(001,1),
	FIRST_NAME varCHAR(25),
	LAST_NAME varCHAR(25),
	SALARY INT,
	JOINING_DATE varchar(30),
	DEPARTMENT varCHAR(25)
);
----1---
Select First_Name AS Worker_Name
From Worker
---2-----
select distinct DEPARTMENT from Worker
----3---
select * from Worker 
ORDER BY FIRST_NAME ASC,DEPARTMENT DESC

select * from Worker
Where FIRST_NAME IN ('Vipul','Satish')


INSERT INTO Worker 
	(FIRST_NAME, LAST_NAME, SALARY, JOINING_DATE, DEPARTMENT) VALUES
		('Monika', 'Arora', 100000, '14-02-20 09.00.00', 'HR'),
		('Niharika', 'Verma', 80000, '14-06-11 09.00.00', 'Admin'),
		('Vishal', 'Singhal', 300000, '14-02-20 09.00.00', 'HR'),
		('Amitabh', 'Singh', 500000, '14-02-20 09.00.00', 'Admin'),
		('Vivek', 'Bhati', 500000, '14-06-11 09.00.00', 'Admin'),
		('Vipul', 'Diwan', 200000, '14-06-11 09.00.00', 'Account'),
		('Satish', 'Kumar', 75000, '14-01-20 09.00.00', 'Account'),
		('Geetika', 'Chauhan', 90000, '14-04-11 09.00.00', 'Admin');

CREATE TABLE Bonus (
	WORKER_REF_ID INT,
	BONUS_AMOUNT INT,
	BONUS_DATE varchar(30),
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);





INSERT INTO Bonus 
	(WORKER_REF_ID, BONUS_AMOUNT, BONUS_DATE) VALUES
		(001, 5000, '16-02-20'),
		(002, 3000, '16-06-11'),
		(003, 4000, '16-02-20'),
		(001, 4500, '16-02-20'),
		(002, 3500, '16-06-11');
		
CREATE TABLE Title (
	WORKER_REF_ID INT,
	WORKER_TITLE varCHAR(25),
	AFFECTED_FROM varchar(30),
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);

INSERT INTO Title 
	(WORKER_REF_ID, WORKER_TITLE, AFFECTED_FROM) VALUES
 (001, 'Manager', '2016-02-20 00:00:00'),
 (002, 'Executive', '2016-06-11 00:00:00'),
 (008, 'Executive', '2016-06-11 00:00:00'),
 (005, 'Manager', '2016-06-11 00:00:00'),
 (004, 'Asst. Manager', '2016-06-11 00:00:00'),
 (007, 'Executive', '2016-06-11 00:00:00'),
 (006, 'Lead', '2016-06-11 00:00:00'),
 (003, 'Lead', '2016-06-11 00:00:00');
 
 select * from Worker
 select * from Bonus
 select * from Title
 