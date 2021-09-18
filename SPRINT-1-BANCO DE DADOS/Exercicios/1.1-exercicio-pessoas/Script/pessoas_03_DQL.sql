-- Listar as pessoas em ordem alfabética reversa, mostrando seus telefones, seus e-mails e suas CNHs

select nomePessoa, CNH, telefone, email from Pessoa 
inner join Telefone
on Pessoa.idPessoa = Telefone.idPessoa
inner join Email
on Pessoa.idPessoa = Email.idPessoa
inner join CNH
on Pessoa.idPessoa = CNH.idPessoa
order by nomePessoa desc;