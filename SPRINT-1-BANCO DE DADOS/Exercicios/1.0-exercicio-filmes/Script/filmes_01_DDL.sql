create database CATALOGO;
go

use catalogo;


alter table GENERO
DROP COLUMN nomeGenero

alter table GENERO
add nomeGenero varchar(20) not null

create table GENERO (
idGenero tinyint primary key identity(1,1), 
nomeGenero varchar(20)
);
GO


CREATE TABLE FILME(
idFilme smallint primary key identity(1,1),
idGenero tinyint foreign key references GENERO(idGenero),
tituloFilme varchar(50) not null
);