drop database if exists Prototipo;
create database Prototipo;
use Prototipo;

create table Ficha
(
Codigo_f int primary key,
Nombre varchar(40),
Ambiente int(3),
N_aprendices int
);

create table Tipo_usuario
(
Codigo_tipo int primary key,
Nombre_tipo varchar(50),
Descripcion varchar(50)
);


create table Usuario
(
Codigo_usuario int  primary key,
Contrasena_u varchar(15),
Nombre_usuario varchar(50),
Apellido varchar(50),
Cedula  int ,
Subsidio varchar(2),
Estado varchar(10),
N_poliza varchar(10),
codigo_tipou int,
foreign key (codigo_tipou) references Tipo_usuario(codigo_tipo),
codigo_ficha int,
foreign key (codigo_ficha) references Ficha(codigo_f)
);

create table Registro
(
Codigo_u int,
Fecha varchar(50),
foreign key (codigo_u) references Usuario(codigo_usuario)
);
select * from Usuario;
insert into ficha values
(1835173,'Jorgenitales','210',25);
insert into Tipo_usuario values
(2,'Vigilante','xd');

insert into Tipo_usuario values
(3,'Instructor','xv');
insert into Tipo_Usuario values
(1,'Aprendiz','xc');
insert into Usuario values
(789,' ','Herculito','Gomez','109765433','No','Activo','1098326',1,1835173);
insert into Usuario values
(567,'125','Armando','Paredes','109769888','si','Activo','123443',2,1835173);
insert into Usuario values
(1234,'123','Penelope','Hernandez','109765568','No','Activo','1098756',3,1835173);
insert into Registro values
(789,'08-07-2020');
select * from Usuario where codigo_tipou=3;
Select Codigo_u,Fecha from Registro join Usuario on Usuario.codigo_usuario=Registro.Codigo_u join Ficha on Usuario.Codigo_ficha=Ficha.Codigo_f where Codigo_ficha =1835173;


