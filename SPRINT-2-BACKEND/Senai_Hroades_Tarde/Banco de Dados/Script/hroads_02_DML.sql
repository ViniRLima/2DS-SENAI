
Use senai_hroades_tarde;
Go

insert into TipoUsuario(titulo)
values ('ADMINISTRADOR'),('JOGADOR');

insert into Usuarios(nomeUsuario,email,senha,idTipoUsuario)
values ('Vinicius','vinicius@email.com','123456',1),('Marcos','marcos@email.com','456123',2)

Insert into Classes(tipoClasse)
Values	('Barbaro'),
		('Monge'),
		('Arcanista'),
		('Cruzado'),
		('Caçadora'),
		('Necromante'),
		('Feiticeiro');
Go

insert into TipoHabilidade(tipoHabilidade)
Values	('Ataque'),
		('Defesa'),
		('Cura'),
		('Magia');
Go

insert into Personagem(
 idClasse,
 nomePersonagem,
 maxMana,
 maxVida, 
 dataCriacao,
 dataAtualizacao)
Values	(1,'DeuBug','80','100','18/01/2019','09/08/2021'),
		(2,'BitBug','100','70','17/03/2016','09/08/2021'),
		(3,'Fer8','60','75','18/03/2018','09/08/2021');
Go

Insert Into Habilidades(idTipo,nomeHabilidade)
Values	(1,'Lança-Mortal'),
		(2,'Escudo Supremo'),
		(3,'Recuperar Vida');
Go

Insert Into HabilidadeClasse(idHabilidade,idClasse)
Values	(1,1),
		(2,1),
		(3,2),
		(2,2),
		(2,4),
		(1,5),
		(3,7);
Go

Insert Into HabilidadeClasse(idClasse)
Values (3),(6);
Go

-- Atualizar o nome do personagem Fer8 para Fer7
Update Personagem
Set nomePersonagem = 'Fer7'
Where idPersonagem = 3;
Go

-- Atualizar o nome da classe de Necromante para Necromancer
Update Classes
Set tipoClasse = 'Necromancer'
Where idClasse = 6;
Go