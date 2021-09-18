USE SENAI_HROADS_TARDE;
GO

-- Criar o banco de dados chamado SENAI_HROADS_MANHA/SENAI_HROADS_TARDE (conforme o período);
-- Criar as tabelas no banco de dados;
-- Inserir os registros conforme descrição no próprio texto (classes, habilidades, tipos de habilidades e personagens); 

-- Atualizar o nome do personagem Fer8 para Fer7

update personagem
set nomePersonagem='Fer7'
where nomePersonagem='Fer8'

-- Atualizar o nome da classe de Necromante para Necromancer;

update classes
set classes='Necromancer'
where classes='Necromante'

-- Selecionar todos os personagens;

SELECT * FROM PERSONAGEM;

-- Selecionar todos as classes;

SELECT * FROM CLASSE;

-- Selecionar somente o nome das classes;

SELECT classes FROM CLASSEs;

-- Selecionar todas as habilidades;

SELECT * FROM HABILIDADES;

-- Realizar a contagem de quantas habilidades estão cadastradas;

select count(habilidades) from habilidades;

-- Selecionar somente os id’s das habilidades classificando-os por ordem crescente;

select idHabilidades FROM HABILIDADES 
order by idHabilidades asc;

-- Selecionar todos os tipos de habilidades;

SELECT * FROM TIPODEHABILIDADES;

-- Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte; /////////

select habilidades, tipodehabilidades from habilidades
inner join tipodehabilidades
on tipodehabilidades.idtipodehabilidades = habilidades.idtipodehabilidades;

-- Selecionar todos os personagens e suas respectivas classes;

select nomePersonagem, classes from Personagem
inner join Classes
on Classes.idClasses = Personagem.idClasses;

-- Selecionar todos os personagens e as classes (mesmo que elas não tenham correspondência em personagens);

Select nomepersonagem , classes from personagem
right join Classes
on personagem.idclasses = classes.idclasses;

-- Selecionar todas as classes e suas respectivas habilidades;

select Classes, habilidades from Classes
inner join ClasseHabilidades
on Classes.idClasses = ClasseHabilidades.idClasses
inner join Habilidades
on Habilidades.idHabilidades = ClasseHabilidades.idHabilidades;

-- Selecionar todas as habilidades e suas classes (somente as que possuem correspondência);

select Classes, habilidades from Habilidades
inner join ClasseHabilidades
on Habilidades.idHabilidades = ClasseHabilidades.idHabilidades
inner join Classes
on Classes.idClasses = ClasseHabilidades.idClasses;

-- Selecionar todas as habilidades e suas classes (mesmo que elas não tenham correspondência).

select Classes, habilidades from Habilidades
right join ClasseHabilidades
on Habilidades.idHabilidades = ClasseHabilidades.idHabilidades
right join Classes
on Classes.idClasses = ClasseHabilidades.idClasses;



