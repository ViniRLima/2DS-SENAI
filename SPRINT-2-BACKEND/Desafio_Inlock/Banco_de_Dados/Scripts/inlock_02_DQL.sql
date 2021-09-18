--Listar todos os usu�rios;
Select * From Usuarios
Go

--Listar todos os est�dios;
Select * From Estudios
Go

--Listar todos os jogos;
Select * From Jogos
Go

--Listar todos os jogos e seus respectivos est�dios;
Select idJogo,nomeJogo,dataLancamento,descricao,valor,nomeEstudio,Jogos.idEstudio From Jogos
inner join Estudios
On Jogos.idEstudio = Estudios.idEstudio

--Buscar e trazer na lista todos os est�dios com os respectivos jogos. Obs.: Listar
--todos os est�dios mesmo que eles n�o contenham nenhum jogo de refer�ncia;
Select Estudios.idEstudio,nomeEstudio,idJogo,nomeJogo,dataLancamento,descricao,valor From Estudios
Left join Jogos
On Jogos.idEstudio = Estudios.idEstudio
Go

--Buscar um usu�rio por e-mail e senha (login);
Select idUsuario,nomeUsuario,email From Usuarios Where email='admin@admin.com' and senha='admin' 
Select idUsuario,nomeUsuario,email From Usuarios Where email='cliente@cliente.com' and senha='cliente'
Go

--Buscar um jogo por idJogo;
Select * From Jogos Where idJogo=1
Select * From Jogos Where idJogo=2
Go


--Buscar um est�dio por idEstudio;
Select * From Estudios Where idEstudio=1
Select * From Estudios Where idEstudio=2
Select * From Estudios Where idEstudio=3
Go