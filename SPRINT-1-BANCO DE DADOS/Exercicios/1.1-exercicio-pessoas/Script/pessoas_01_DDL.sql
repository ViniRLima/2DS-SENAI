create database EMPRESA;
go

use EMPRESA;
go



create table PESSOA (
idPessoa smallint primary key identity,
nomePessoa varchar(20) not null
);
GO

create table TELEFONE(
idTelefone smallint primary key identity,
idPessoa smallint foreign key references PESSOA(idPessoa),
telefone char(15) not null
);
GO


create table EMAIL(
idEmail int primary key identity,
idPessoa smallint foreign key references PESSOA(idPessoa),
email varchar(256) not null
);
GO


create table CNH(
idCNH smallint primary key identity,
idPessoa smallint foreign key references PESSOA(idPessoa),
CNH char(11) not null unique
);
GO
