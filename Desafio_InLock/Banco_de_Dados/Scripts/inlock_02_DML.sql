Use inlock_games_tarde;
Go

Insert into TipoUsuario(titulo)
Values ('ADMINISTRADOR'),('CLIENTE');
Go

Insert into Estudios(nomeEstudio)
Values ('Blizzard'),('Rockstar Studios'),('Square Enix');
Go

Insert Into Jogos(nomeJogo,dataLancamento,descricao,valor,idEstudio)
Values	('Diablo','15/05/2012','� um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�',99,1),
		('Red Dead Redemption II','26/10/2018','jogo eletr�nico de a��o-aventura western',120,2);

Insert into Usuarios(nomeUsuario,email,senha,idTipoUsuario)
Values ('Marcos','admin@admin.com','admin',1),('Vinicius','cliente@cliente.com','cliente',2);

