use CATALOGO;
go

INSERT INTO GENERO (nomeGenero)
VALUES ('A��O'),('ROMANCE');
GO


SELECT * FROM GENERO
SELECT * FROM FILME

DELETE FROM GENERO 
WHERE idGenero = 2

INSERT INTO FILME(idGenero, tituloFilme)
VALUES(1,'Rambo'),(1,'Vingadores'),(2,'Ghost'),(2,'Di�rio de uma paix�o');
GO

DELETE FROM FILME
WHERE idFilme IN(2,3)

UPDATE FILME SET tituloFilme = 'RAMBO 2'
WHERE idFilme = 1