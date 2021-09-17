--Listar todos os usuários;
Select * From Usuarios
Go

--Listar todos os estúdios;
Select * From Estudios
Go

--Listar todos os jogos;
Select * From Jogos
Go

--Listar todos os jogos e seus respectivos estúdios;
Select idJogo,nomeJogo,dataLancamento,descricao,valor,nomeEstudio,Jogos.idEstudio From Jogos
inner join Estudios
On Jogos.idEstudio = Estudios.idEstudio

--Buscar e trazer na lista todos os estúdios com os respectivos jogos. Obs.: Listar
--todos os estúdios mesmo que eles não contenham nenhum jogo de referência;
Select Estudios.idEstudio,nomeEstudio,idJogo,nomeJogo,dataLancamento,descricao,valor From Estudios
Left join Jogos
On Jogos.idEstudio = Estudios.idEstudio
Go

--Buscar um usuário por e-mail e senha (login);
Select idUsuario,nomeUsuario,email From Usuarios Where email='admin@admin.com' and senha='admin' 
Select idUsuario,nomeUsuario,email From Usuarios Where email='cliente@cliente.com' and senha='cliente'
Go

--Buscar um jogo por idJogo;
Select * From Jogos Where idJogo=1
Select * From Jogos Where idJogo=2
Go


--Buscar um estúdio por idEstudio;
Select * From Estudios Where idEstudio=1
Select * From Estudios Where idEstudio=2
Select * From Estudios Where idEstudio=3
Go