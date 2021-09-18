SELECT * FROM Artista
SELECT * FROM Estilo
SELECT * FROM Album
SELECT * FROM AlbumEstilo
SELECT * FROM Usuario

-- listar todos os usu�rios administradores, sem exibir suas senhas
SELECT nomeUsuario FROM Usuario
-- listar todos os �lbuns lan�ados ap�s o um determinado ano de lan�amento
SELECT nomeAlbum, anoDeLancamento 
FROM Album
WHERE anoDeLancamento = 2020
-- listar os dados de um usu�rio atrav�s do e-mail e senha
SELECT emailUsuario, senhaUsuario 
FROM Usuario
WHERE nomeUsuario = 'ADM'
-- listar todos os �lbuns ativos, mostrando o nome do artista e os estilos do �lbum 
SELECT nomeAlbum, nomeArtista, nomeEstilo 
FROM Album
INNER JOIN Artista
ON Artista.idArtista = Album.idArtista
INNER JOIN AlbumEstilo
ON AlbumEstilo.idAlbum = AlbumEstilo.idAlbumEstilo
INNER JOIN Estilo
ON Estilo.idEstilo = AlbumEstilo.idEstilo;
