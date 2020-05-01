use LabWork4

create table department
(
depart_id int primary key not null,
depart_name varchar(30) not null,

)
create table student
(
stu_id int primary key identity(1,1),
stu_name varchar(30),
stu_did int foreign key references department(depart_id)
)

insert into department (depart_id,depart_name) values
(05,'BBA'),(04,'Dr sarah')

insert into student (stu_id,stu_name,stu_did) values
('Bilal',01),
('Hadid',03)

delete from department where depart_id=01

set identity_insert student on

DBCC checkident (student,reseed,0)


select * from department