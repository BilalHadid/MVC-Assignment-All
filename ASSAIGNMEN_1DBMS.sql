use test_dbms

---------Task 1---------
select FIRST_NAME as Worker_Name from Worker

--------Task 2-------
select distinct DEPARTMENT from Worker
-------Task 3 --------
select * from Worker Order by FIRST_NAME ASC
--------Task 4 --------
select * from Worker order by FIRST_NAME ASC,DEPARTMENT Desc
--------Task 5 ---------
select * from Worker where FIRST_NAME='Vipul' or FIRST_NAME='Satish'
--------Task 6 ------
select * from Worker where FIRST_NAME not in ('Vipul','Satish')
--------Task 7-------
select * from Worker where SALARY BETWEEN 100000 AND 500000
--------Task 8------
select count(FIRST_NAME) as 'Total Employees Admin' from Worker Where DEPARTMENT='Admin'
--------Task 9------
select * from Worker order by DEPARTMENT DESc
--------Task 10 --------
select WORKER_ID,FIRST_NAME,LAST_NAME,SALARY,DEPARTMENT, count(*) from Worker group by WORKER_ID,FIRST_NAME,LAST_NAME,SALARY,DEPARTMENT having count(*) < 1
Select * from Worker