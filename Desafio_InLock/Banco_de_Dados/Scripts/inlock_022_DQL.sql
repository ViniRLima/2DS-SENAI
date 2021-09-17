--Utilizar o banco de dados
USE inlock_games_tarde;

--Listar todos os usu�rios;
Select * From Usuarios
Select * from TipoUsuario
Go

--Listar todos os est�dios;
Select * From Estudios
Go

--Listar todos os jogos;
Select * From Jogos
SELECT idJogo, nomeJogo, dataLancamento FROM Jogos
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
SELECT idUsuario, email, senha, idTipoUsuario FROM USUARIOS WHERE email = 'admin@admin.com' and senha = 'admin' ;
Go

SELECT idJogo, nomeJogo, dataLancamento, idEstudio FROM Jogos



SELECT idJogo, nomeJogo, dataLancamento, jogos.idEstudio 
                                            FROM Jogos 
                                            INNER JOIN Estudios 
                                            ON Jogos.idEstudio = Estudios.idEstudio


											SELECT idUsuario, email, senha, titulo, Usuarios.idTipoUsuario
                                       FROM USUARIOS 
									   inner join TipoUsuario
									   on TipoUsuario.idTipoUsuario = Usuarios.idTipoUsuario
                                        WHERE email = 'cliente@cliente.com' and senha = 'cliente'
--Buscar um jogo por idJogo;
Select * From Jogos Where idJogo=1
Select * From Jogos Where idJogo=2
Go


--Buscar um est�dio por idEstudio;
Select * From Estudios Where idEstudio=1
Select * From Estudios Where idEstudio=2
Select * From Estudios Where idEstudio=3
Go

Select * from tipousuario;

ADMINISTRADOR, CLIENTE


SELECT idEstudio, nomeEstudio FROM Estudios