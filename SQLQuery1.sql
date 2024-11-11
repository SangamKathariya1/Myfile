create table Doctor
( 
id int primary key identity(1,1),
FullName nvarchar(100) not null,
Address nvarchar(200) not null,
Phone varchar(20) not null,
NDCNumber nvarchar(100) not null,
Qualification varchar(200),
Specialization varchar(200),
Gender int,
DOB DateTime2
);