
Use senai_hroades_tarde;
Go


-- Selecionar todos os personagens
select * from Personagem
--delete from Personagem where idPersonagem = 8

-- Selecionar todas as classes
select * from Classes

-- Selecionar somente o nome das classes
select TipoClasse AS nome_Classes from Classes

-- Selecionar todas as habilidades
select * from Habilidades
--delete from Habilidades where idHabilidade = 10

-- Realizar a contagem de quantas habilidades estão cadastradas
select COUNT (idHabilidade) AS Habilidades from Habilidades;

-- Selecionar somente os id’s das habilidades classificando-os por ordem crescente
select idHabilidade from Habilidades order by idHabilidade

-- Selecionar todos os tipos de habilidades
select * from TipoHabilidade

-- Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte
select idHabilidade, TipoHabilidade.idTipo, NomeHabilidade, TipoHabilidade from Habilidades
inner join TipoHabilidade
on TipoHabilidade.idTipo = Habilidades.idTipo

-- Selecionar todos os personagens e suas respectivas classes
select * from Personagem
inner join Classes
on Classes.idClasse = Personagem.idClasse

-- Selecionar todos os personagens e as classes (mesmo que elas não tenham correspondência em personagens);
select nomePersonagem, TipoClasse from Personagem
left join Classes
on Classes.idClasse = Personagem.idClasse

-- Selecionar todas as classes e suas respectivas habilidades
select Classes.idClasse, tipoClasse, .Habilidades.idHabilidade, nomeHabilidade from Classes
left join HabilidadeClasse
on Classes.idClasse = HabilidadeClasse.idClasse
inner join Habilidades
on Habilidades.idHabilidade = HabilidadeClasse.idHabilidade

-- Selecionar todas as habilidades e suas classes (somente as que possuem correspondência)
select Habilidades.idHabilidade, nomeHabilidade Habilidades, tipoClasse Classse from Habilidades
inner join HabilidadeClasse
on Habilidades.idHabilidade = HabilidadeClasse.idHabilidade
inner join Classes
on HabilidadeClasse.idClasse = Classes.idClasse

-- Selecionar todas as habilidades e suas classes (mesmo que elas não tenham correspondência).
select Habilidades.idHabilidade, NomeHabilidade Habilidade, TipoClasse Classse from Habilidades
full outer join HabilidadeClasse
on Habilidades.idHabilidade = HabilidadeClasse.idHabilidade
full outer join Classes
on HabilidadeClasse.idClasse = Classes.idClasse


Select * from TipoUsuario
Select * from Usuarios
