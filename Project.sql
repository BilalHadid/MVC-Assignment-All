create database OnlineChating
use OnlineChating

create table Signup
(
  sig_id int primary key identity(1,1),
  sig_username nvarchar(50) unique,
  sig_Name nvarchar(50) not null,
  sig_fname nvarchar(50) not null,
  sig_Gender varchar(10) not null,
  sig_Email nvarchar(50) not null,
)
create table Mesages
(
	msg_id int primary key identity(1,1),
	msg_Signup int foreign key references Signup(sig_id),
	msg_Text nvarchar(100) not null,

)