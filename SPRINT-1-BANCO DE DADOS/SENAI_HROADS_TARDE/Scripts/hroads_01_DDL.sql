create database SENAI_HROADS_TARDE;
go

use SENAI_HROADS_TARDE;
GO

create table Personagem
(
idPersonagem int primary key identity,
idClasses int foreign key references Classes(idClasses),
nomePersonagem varchar(30) not null,
dataDeAtualizacao date not null,
dataDeCriacao date not null
);
GO

create table Classes
(
idClasses int primary key identity,
classes varchar(50) not null,
capacidadeMaximaVida int ,
capacidadeMaximaMana int 
);
GO

create table ClasseHabilidades
(
idClasseHabilidades int primary key identity,
idHabilidades int foreign key references Habilidades(idHabilidades),
idClasses int foreign key references Classes(idClasses)
);
GO

create table Habilidades
(
idHabilidades int primary key identity,
idTipoDeHabilidades int foreign key references TipoDeHabilidades(idTipoDeHabilidades),
habilidades varchar(30) not null
);
GO

create table TipoDeHabilidades
(
idTipoDeHabilidades int primary key identity,
tipoDeHabilidades varchar(20) not null
);
GO