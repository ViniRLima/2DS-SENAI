USE Pclinics;
GO

SELECT * FROM Clinica;
GO
SELECT * FROM TiposPet;
GO
SELECT * FROM Raca;
GO
SELECT * FROM Dono;
GO
SELECT * FROM Veterinario;
GO
SELECT * FROM Pet;
GO
SELECT * FROM Atendimento;
GO

-- Listar todos os veterinarios (nome e CRMV) de uma clinica (razão social)

SELECT nome, crmv, razaoSocial FROM Veterinario
INNER JOIN Clinica
ON Veterinario.idClinica = Clinica.idClinica
WHERE Clinica.idClinica = 1;

-- Listar todas as raças que comecem com a letra S

SELECT * FROM Raca
WHERE descricao LIKE 's%'

-- Listar todos os tipos de pet que terminam com a letra O

SELECT * FROM TiposPet
WHERE descricao LIKE '%o'

-- Listar todos os pets mostrando os nomes dos seus donos
-- ALIAS (apelido) AS

SELECT idPet, Pet.nome AS Pet, datanascimento, Dono.nome Dono FROM Pet
LEFT JOIN Dono
ON Dono.idDono = Pet.idDono;

-- Listar todos os atendimentos mostrando o nome do veterinario que atendeu,
-- o nome, a raça e o tipo do pet que foi atendido,
-- o nome do dono do pet e o nome da clinica onde o pet foi atendido 

SELECT idAtendimento, veterinario.nome [Veterinário], pet.nome Pet, raca.descricao [Raça], tiposPet.descricao [Espécie], dono.nome, razaoSocial [razão social] 
FROM Atendimento
INNER JOIN Veterinario
ON Atendimento.idVeterinario = Veterinario.idVeterinario
INNER JOIN Pet
ON atendimento.idPet = pet.idPet
INNER JOIN Raca
ON pet.idRaca = raca.idRaca
INNER JOIN TiposPet
raca.idTipopet = tipospet.idTipopet
INNER JOIN Dono
ON pet.idDono = Dono.idDono
INNER JOIN Clinica
ON veterinario.idClinica = Clinica.idClinica;




