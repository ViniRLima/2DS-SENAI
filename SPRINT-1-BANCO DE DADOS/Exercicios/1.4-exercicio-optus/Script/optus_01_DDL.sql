CREATE DATABASE Optus;
GO

USE Optus;
GO

CREATE TABLE Usuario
(
idUsuario INT PRIMARY KEY IDENTITY,
nomeUsuario VARCHAR(20) NOT NULL,
emailUsuario VARCHAR(256) NOT NULL,
senhaUsuario INT NOT NULL
);
GO

CREATE TABLE Artista
(
	idArtista INT PRIMARY KEY IDENTITY,
	nomeArtista VARCHAR(20) NOT NULL 
);
GO

CREATE TABLE Estilo
(
	idEstilo INT PRIMARY KEY IDENTITY,
	nomeEstilo VARCHAR(20) NOT NULL 
);
GO

CREATE TABLE Album
(
	idAlbum INT PRIMARY KEY IDENTITY,
	idArtista INT FOREIGN KEY REFERENCES Artista(idArtista),
	nomeAlbum VARCHAR(20) NOT NULL,
	anoDeLancamento INT 
);
GO

CREATE TABLE AlbumEstilo
(
	idAlbumEstilo INT PRIMARY KEY IDENTITY,
	idAlbum INT FOREIGN KEY REFERENCES Album(idAlbum),
	idEstilo INT FOREIGN KEY REFERENCES Estilo(idEstilo),
	codAlbumEstilo INT NOT NULL
);
GO

