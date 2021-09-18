INSERT INTO Clinica (razaoSocial, cnpj, endereco)
VALUES ('MeuPimp�o', '99999999999999', 'Av. Bar�o de Limeira, 539');
GO

INSERT INTO TiposPet (descricao)
VALUES ('Cachorro'),('Gato');
GO

INSERT INTO Raca (descricao, idTipoPet)
VALUES ('Poodle', 1),('Labrador', 1),('SRD', 1),('Siam�s', 2);
GO

INSERT INTO Dono (nome)
VALUES ('Paulo'),('Odirlei');
GO

INSERT INTO Pet (nome, dataNascimento, idRaca, idDono)
VALUES ('Junior','10/10/2018', 1, 1), ('Loli','18/05/2017', 4, 1), ('Sammy','16/06/2016', 1, 2);
GO

INSERT INTO Veterinario (nome, crmv, idClinica)
VALUES ('Saulo', '432551', 1),('Lucas', '653655', 1);
GO

INSERT INTO Atendimento (descricao, dataAtendimento, idVeterinario, idPet)
VALUES ('Restam 10 dias de vida', '22/01/2019', 1, 1),('O paciente est� ok', '21/01/2019', 2, 2), 
('O paciente est� ok', '22/01/2019', 2, 1);
GO
