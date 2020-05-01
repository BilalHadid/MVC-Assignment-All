-----------------Task 1 ---------
use myDatabase
Create database myDatabase

--------------Task 3----------
Create table working
(
	id int not null,
	name varchar(30),

)
---------------Task 4-----------
----ADD---
alter table working
ADD Organization varchar(30)
-----Delete---
alter table working
DROP column Organization
------Modify name----
Alter database myDatabase modify name=NewmyDatabase
----------Update-------
ALTER table working
ALTER COLUMN Organization nvarchar(30)