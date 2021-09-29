-- CRIANDO O BANCO DE DADOS
CREATE DATABASE SENAI_SPMEDGROUP_T;
GO

-- UTILIZANDO O BANCO DE DADOS
USE SENAI_SPMEDGROUP_T;
GO

-- CRIANDO A TABELA ESPECIALIDADE
CREATE TABLE Especialidade
(
idEspecialidade INT PRIMARY KEY IDENTITY(1,1),
especialidade VARCHAR(20) NOT NULL
);
GO


-- CRIANDO A TABELA SITUACAO
CREATE TABLE Situacao
(
idSituacao INT PRIMARY KEY IDENTITY(1,1),
situacao VARCHAR(20) NOT NULL
);
GO

-- CRIANDO A TABELA TIPOUSUARIO
CREATE TABLE TipoUsuario
(
idTipoUsuario INT PRIMARY KEY IDENTITY(1,1),
tipoUsuario VARCHAR(3) NOT NULL
);
GO

-- CRIANDO A TABELA CLINICA
CREATE TABLE Clinica 
(
idClinica INT PRIMARY KEY IDENTITY(1,1),
clinica VARCHAR(20) NOT NULL,
cnpj CHAR(14) NOT NULL,
razaoSocial VARCHAR(50) NOT NULL,
endereco VARCHAR(50) NOT NULL,
telefone VARCHAR(11) NOT NULL,
horarioInicio TIME NOT NULL,
horarioFim TIME NOT NULL
);
GO

-- CRIANDO A TABELA USUARIO
CREATE TABLE Usuario
(
idUsuario INT PRIMARY KEY IDENTITY(1,1),
idTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(idTipoUsuario),
usuario VARCHAR(50) NOT NULL,
email VARCHAR(256) NOT NULL,
senha VARCHAR(50) NOT NULL
);
GO

-- CRIANDO A TABELA MEDICO
CREATE TABLE Medico
(
idMedico INT PRIMARY KEY IDENTITY(1,1),
idEspecialidade INT FOREIGN KEY REFERENCES Especialidade(idEspecialidade),
idClinica INT FOREIGN KEY REFERENCES Clinica(idClinica),
idUsuario INT FOREIGN KEY REFERENCES Usuario(idUsuario),
medico VARCHAR(50) NOT NULL,
crm CHAR(6) NOT NULL
);
GO


-- CRIANDO A TABELA PACIENTE
CREATE TABLE Paciente
(
idPaciente INT PRIMARY KEY IDENTITY(1,1),
idUsuario INT FOREIGN KEY REFERENCES Usuario(idUsuario),
paciente VARCHAR(50) NOT NULL,
dataNascimento DATE NOT NULL,
rg CHAR(12) NOT NULL,
cpf CHAR(11) NOT NULL,
endereco VARCHAR(100) NOT NULL,
telefone VARCHAR(11) NOT NULL
);
GO

-- CRIANDO A TABELA CONSULTA
CREATE TABLE Consulta
(
idConsulta INT PRIMARY KEY IDENTITY(1,1),
idMedico INT FOREIGN KEY REFERENCES Medico(idMedico),
idPaciente INT FOREIGN KEY REFERENCES Paciente(idPaciente),
idSituacao INT FOREIGN KEY REFERENCES Situacao(idSituacao),
consulta VARCHAR(50) NOT NULL,
dataHorario DATETIME NOT NULL
);
GO

-- PRIMARY KEY - CHAVE PRIMARIA
-- FOREIGN KEY - CHAVE ESTRANGEIRA
-- NOT NULL - N�O PODE VALORES VAZIOS/NULOS
-- IDENTITY - O VALOR � UNICO

