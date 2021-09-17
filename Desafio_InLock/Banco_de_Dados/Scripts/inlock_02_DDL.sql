Create database inlock_games_tarde;
Go

Use inlock_games_tarde;
Go

Create table Estudios(
idEstudio Smallint primary key identity,
nomeEstudio varchar(50) not null
);

Create Table Jogos(
idJogo int primary key identity,
nomeJogo varchar(100) not null,
descricao varchar(300),
dataLancamento date not null,
valor decimal(10,2),
idEstudio smallint foreign key references Estudios(idEstudio)
);
Go

Create Table TipoUsuario(
idTipoUsuario tinyint primary key identity,
titulo varchar(100)
);


Create Table Usuarios(
idUsuario int primary key identity,
nomeUsuario varchar(200),
email varchar(100),
senha varchar(10),
idTipoUsuario tinyint foreign key references TipoUsuario(idTipoUsuario)
);
