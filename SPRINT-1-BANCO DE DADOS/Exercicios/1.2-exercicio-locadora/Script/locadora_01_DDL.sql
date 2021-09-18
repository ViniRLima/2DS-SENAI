create database LOCADORA;
GO

use LOCADORA;
GO

create table EMPRESA (
idEmpresa smallint primary key identity,
nomeEmpresa varchar(50) not null
);
GO

create table CLIENTE (
idCliente int primary key identity,
nomeCliente varchar(50) not null
);
GO

create table MARCA (
idMarca tinyint primary key identity,
nomeMarca varchar(50) not null
);
GO


create table VEICULO(
idVeiculo smallint primary key identity,
idEmpresa smallint foreign key references EMPRESA(idEmpresa),
idModelo smallint foreign key references MODELO(idModelo),
nomeVeiculo varchar(100) not null
);
GO


create table MODELO(
idModelo smallint primary key identity,
idMarca tinyint foreign key references MARCA(idMarca),
nomeModelo varchar(20) not null
);
GO

create table ALUGUEL(
idAluguel smallint primary key identity,
idVeiculo smallint foreign key references VEICULO(idVeiculo),
idCliente int foreign key references CLIENTE(idCliente),
aluguel int not null
);
GO


