create database Lab11

use lab11

create table department(
	dep_id int primary key identity(1,1),
	dep_name varchar(50) not null,
	
)
insert department values('cocis')
select * from department