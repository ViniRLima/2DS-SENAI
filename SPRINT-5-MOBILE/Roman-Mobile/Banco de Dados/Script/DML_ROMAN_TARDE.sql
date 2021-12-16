USE ROMAN_TARDE;
GO

INSERT INTO TIPOUSUARIO (descricaoTipoUsuario)
VALUES ('Administrador'), ('Professor');
GO

INSERT INTO USUARIO (idTipoUsuario, email, senha)
VALUES (1, 'admin@prof.com', 'admin@132'), (2, 'saulo@prof.com', 'prof1@132'), (2, 'lucas@prof.com', 'prof2@132'), (2, 'thiago@prof.com', 'prof3@132');
GO

INSERT INTO PROFESSOR (idUsuario, nomeProfessor, sobrenomeProfessor)
VALUES (2, 'Saulo', 'Santos'), (3, 'Lucas', 'Aragão'), (4, 'Thiago', 'Nascimento');
GO

INSERT INTO TEMA (nomeTema)
VALUEs ('Banco de Dados'), ('API'), ('Front-End'), ('ReactJS'), ('React-Native');
GO

INSERT INTO PROJETO (idProfessor, idTema, nomeProjeto)
VALUEs (1, 1, 'HROADS'), (2, 2, 'InLock'), (2, 3, 'WishList'), (1, 4, 'Gufi'), (1, 5, 'SPMedGroup');
GO
