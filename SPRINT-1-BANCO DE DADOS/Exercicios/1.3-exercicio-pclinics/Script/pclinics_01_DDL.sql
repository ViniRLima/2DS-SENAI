CREATE DATABASE PClinics;
GO

USE PClinics;
GO

CREATE TABLE Clinica
(
	idClinica INT PRIMARY KEY IDENTITY,
	razaoSocial VARCHAR(200) NOT NULL UNIQUE,
	cnpj CHAR(14) NOT NULL UNIQUE,
	endereco VARCHAR(200) NOT NULL UNIQUE
);
GO

CREATE TABLE TiposPet
(
	idTipoPet INT PRIMARY KEY IDENTITY,
	descricao VARCHAR(200) UNIQUE
);
GO

CREATE TABLE Raca
(
	idRaca INT PRIMARY KEY IDENTITY,
	descricao VARCHAR(200) NOT NULL UNIQUE,
	idTipoPet INT FOREIGN KEY REFERENCES 	TiposPet(idTipoPet)
);
GO

CREATE TABLE Dono
(
	idDono INT PRIMARY KEY IDENTITY,
	nome VARCHAR(200) NOT NULL	
);
GO

CREATE TABLE Pet 
(
	idPet INT PRIMARY KEY IDENTITY,
	nome VARCHAR(200),
	dataNascimento DATE NOT NULL,
	idRaca INT FOREIGN KEY REFERENCES Raca	(idRaca),
	idDono INT FOREIGN KEY REFERENCES Dono	(idDono)
);
GO

CREATE TABLE Veterinario 
(
	idVeterinario INT PRIMARY KEY IDENTITY,
	nome VARCHAR(200),
	crmv CHAR(6) UNIQUE,
	idClinica INT FOREIGN KEY REFERENCES 	Clinica(idClinica)
);
GO

CREATE TABLE Atendimento
(
	idAtendimento INT PRIMARY KEY IDENTITY,
	descricao VARCHAR(200),
	dataAtendimento DATETIME NOT NULL,
	idVeterinario INT FOREIGN KEY REFERENCES 		Veterinario(idVeterinario),
	idPet INT FOREIGN KEY REFERENCES 			Pet(idPet)	
);
GO
