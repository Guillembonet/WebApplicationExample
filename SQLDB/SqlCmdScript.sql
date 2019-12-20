create database capgemini;
GO
use capgemini;
create table Alumno (AlumnoId int Primary Key, Name nvarchar(50));
insert into Alumno values (1,'Guillem');
insert into Alumno values (2,'Pepito');
select * from Alumno;