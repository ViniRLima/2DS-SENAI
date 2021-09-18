USE LOCADORA;
GO

INSERT INTO EMPRESA (nomeEmpresa) 
VALUES ('Empresa1');
GO

INSERT INTO MARCA (nomeMarca)
VALUES ('VOLKSWAG'),('HARLEY DAVIDSON');
GO

INSERT INTO CLIENTE (nomeCliente)
VALUES ('CARLOS'),('AMANDA'),('JOSÉ'),('ARTHUR');
GO

INSERT INTO MODELO (idMarca, nomeModelo)
VALUES (1,'GOL'),(2,'FAT BOB');
GO

INSERT INTO VEICULO (idEmpresa, idModelo, nomeVeiculo)
VALUES (1, 1, 'CARRO'),(1, 2, 'MOTO');
GO

INSERT INTO ALUGUEL (IdVeiculo, IdCliente, aluguel, datainicio, datafim)
VALUES (1,1,500,'01/08/2020','10/08/2020'),(2,2,600,'05/07/2020','10/07/2020'),(2,4,700,'20/07/2020','25/07/2020'),(1,3,800,'20/05/2020','25/05/2020');
GO
