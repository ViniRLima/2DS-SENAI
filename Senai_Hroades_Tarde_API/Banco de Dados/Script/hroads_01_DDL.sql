create database senai_hroades_tarde;
go

use senai_hroades_tarde;
go

create table TipoUsuario(
idTipoUsuario tinyint primary key identity,
titulo varchar(30) not null
);
Go

create table Usuarios(
idUsuario int primary key identity,
nomeUsuario varchar(30) not null,
email varchar (100),
senha varchar (30),
idTipoUsuario tinyint foreign key references TipoUsuario(idTipoUsuario)
);
Go

create table Classes(
 idClasse smallint primary key identity (1,1),
 tipoClasse varchar(20) not null
);
go

create table TipoHabilidade(
 idTipo smallint primary key identity (1,1),
 TipoHabilidade varchar(30) not null
);
go

create table Personagem(
 idPersonagem smallint primary key identity (1,1),
 idClasse smallint foreign key references Classes(idClasse),
 nomePersonagem varchar(35) not null,
 maxMana varchar(10) not null,
 maxVida varchar(10) not null,
 dataAtualizacao date not null,
 dataCriacao date not null
);
go

create table Habilidades(
 idHabilidade smallint primary key identity (1,1),
 idTipo smallint foreign key references TipoHabilidade(idTipo),
 nomeHabilidade varchar(30) not null
);
go

create table HabilidadeClasse (
 idHabClasse smallint primary key identity (1,1),
 idHabilidade smallint foreign key references Habilidades(idHabilidade),
 idClasse smallint foreign key references Classes(idClasse),
);
go


drop table HabilidadeClasse
drop table Habilidades
drop table Personagem
drop table TipoHabilidade
drop table Classes
drop table TipoUsuario
drop table Usuarios