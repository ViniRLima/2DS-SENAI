create database Rental_T;
GO

use Rental_T;
GO

create table EMPRESA (
idEmpresa int primary key identity,
nomeEmpresa varchar(50) not null
);
GO

create table CLIENTE (
idCliente int primary key identity,
nomeCliente varchar(50) not null
sobrenomeCliente varchar(50) not null,
cnh char(11) not null
);
GO

create table MARCA (
idMarca int primary key identity,
nomeMarca varchar(50) not null
);
GO


create table VEICULO(
idVeiculo int primary key identity,
idEmpresa int foreign key references EMPRESA(idEmpresa),
idModelo int foreign key references MODELO(idModelo),
nomeVeiculo varchar(100) not null
);
GO


create table MODELO(
idModelo int primary key identity,
idMarca int foreign key references MARCA(idMarca),
nomeModelo varchar(20) not null
);
GO

create table ALUGUEL(
idAluguel int primary key identity,
idVeiculo int foreign key references VEICULO(idVeiculo),
idCliente int foreign key references CLIENTE(idCliente),
aluguel int not null,
datainicio date not null,
datafim date not null
);
GO