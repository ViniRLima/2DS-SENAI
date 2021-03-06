CREATE DATABASE WISHLIST_DESAFIO;
GO

USE WISHLIST_DESAFIO;
GO

CREATE TABLE USUARIO (

	idUsuario INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(16) NOT NULL UNIQUE,
	email VARCHAR(300) NOT NULL UNIQUE,
	senha VARCHAR(16) NOT NULL CONSTRAINT USUARIO_SENHA_CK CHECK (LEN(senha) >= 6)

);
GO

CREATE TABLE WISHLIST (

	idWishlist INT PRIMARY KEY IDENTITY(1,1),
	idUsuario INT FOREIGN KEY REFERENCES USUARIO(idUsuario),
	desejo VARCHAR(3000) NOT NULL,

);
GO