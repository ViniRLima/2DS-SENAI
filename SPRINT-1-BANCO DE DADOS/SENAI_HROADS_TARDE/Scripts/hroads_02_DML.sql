USE SENAI_HROADS_TARDE;
GO

INSERT INTO PERSONAGEM (idClasses, nomePersonagem, dataDeAtualizacao, dataDeCriacao)
VALUES (1,'DeuBug','20/08/2021','18/01/2019'),(4,'BitBug','20/08/2021','17/03/2016'),(7,'Fer8','20/08/2021','18/03/2018');
GO

INSERT INTO Classes (classes,capacidadeMaximaVida,capacidadeMaximaMana)
VALUES ('Bárbaro',100,80),('Cruzado',null,null),('Caçadora de Demônios',null,null),('Monge',70,100),('Necromante',null,null),('Feiticeiro',null,null),('Arcanista',75,60);
GO

INSERT INTO Habilidades (idTipodehabilidades, Habilidades)
VALUES (1,'Lança Mortal'),(2,'Escudo Supremo'),(3,'Recuperar Vida');
GO

INSERT INTO TipoDeHabilidades (tipoDeHabilidades)
VALUES ('Ataque'),('Defesa'),('Cura'),('Magia');
GO

INSERT INTO ClasseHabilidades (idHabilidades, idClasses)
VALUES (1,1),(2,1),(2,2),(1,3),(3,4),(2,4),(3,6);
GO

