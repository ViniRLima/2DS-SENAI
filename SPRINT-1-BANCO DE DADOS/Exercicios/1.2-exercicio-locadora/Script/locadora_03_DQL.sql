-- listar todos os alugueis mostrando as datas de início e fim, o nome do cliente que alugou e nome do modelo do carro
-- listar os alugueis de um determinado cliente mostrando seu nome, as datas de início e fim e o nome do modelo do carro


SELECT aluguel, datainicio, datafim
FROM ALUGUEL
inner JOIN CLIENTE 
ON Aluguel.idCliente = Cliente.idCliente
inner join Veiculo
on Veiculo.idVeiculo = Aluguel.idVeiculo
inner join Modelo
on MODELO.idmodelo = veiculo.idmodelo


SELECT aluguel, nomecliente, datainicio, datafim, nomeModelo
FROM ALUGUEL
inner JOIN CLIENTE 
ON Aluguel.idCliente = Cliente.idCliente
inner join Veiculo
on Veiculo.idVeiculo = Aluguel.idVeiculo
inner join Modelo
on MODELO.idmodelo = veiculo.idmodelo
Where nomeCliente = 'Carlos'


