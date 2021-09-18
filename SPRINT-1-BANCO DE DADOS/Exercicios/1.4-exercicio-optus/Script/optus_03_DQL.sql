SELECT * FROM Artista
SELECT * FROM Estilo
SELECT * FROM Album
SELECT * FROM AlbumEstilo
SELECT * FROM Usuario

-- listar todos os usuários administradores, sem exibir suas senhas
SELECT nomeUsuario FROM Usuario
-- listar todos os álbuns lançados após o um determinado ano de lançamento
SELECT nomeAlbum, anoDeLancamento 
FROM Album
WHERE anoDeLancamento = 2020
-- listar os dados de um usuário através do e-mail e senha
SELECT emailUsuario, senhaUsuario 
FROM Usuario
WHERE nomeUsuario = 'ADM'
-- listar todos os álbuns ativos, mostrando o nome do artista e os estilos do álbum 
SELECT nomeAlbum, nomeArtista, nomeEstilo 
FROM Album
INNER JOIN Artista
ON Artista.idArtista = Album.idArtista
INNER JOIN AlbumEstilo
ON AlbumEstilo.idAlbum = AlbumEstilo.idAlbumEstilo
INNER JOIN Estilo
ON Estilo.idEstilo = AlbumEstilo.idEstilo;
