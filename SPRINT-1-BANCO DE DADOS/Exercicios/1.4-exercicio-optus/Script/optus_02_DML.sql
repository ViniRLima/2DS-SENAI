USE Optus;
GO

INSERT INTO Artista (nomeArtista)
VALUES ('Paula'),('Leonardo'),('Rafael');
GO

INSERT INTO Album (idArtista, nomeAlbum, anoDeLancamento)
VALUES (1,'EstrelaNegra', 2020),(2,'LuaAzul', 2019),(3,'VermelhoLuz', 2018);
GO

INSERT INTO Estilo (nomeEstilo)
VALUES ('Hard Rock'),('Samba'),('Funk');
GO

INSERT INTO AlbumEstilo (idAlbum, idEstilo, codAlbumEstilo)
VALUES (1,2,142536),(2,3,526314),(3,1,485896);
GO

INSERT INTO Usuario (nomeUsuario, emailUsuario, senhaUsuario)
VALUES ('ADM','adm@email.com',123645689), ('ADM2','adm2@email.com',123645788), ('USER','user@gmail.com',45564565)
GO


