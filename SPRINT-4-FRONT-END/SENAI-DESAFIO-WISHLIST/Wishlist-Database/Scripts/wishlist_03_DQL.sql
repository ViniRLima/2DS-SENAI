USE WISHLIST_DESAFIO;
GO

-- Listar somente a Entidade "Wishlist"

SELECT * FROM WISHLIST

-- Listar somente a Entidade "Usuarios"

SELECT * FROM USUARIO

-- Listar desejos com o username de quem a desejou

SELECT	desejo [Desejos],
		username [Nome de Usu�rio] 
FROM WISHLIST W
LEFT JOIN USUARIO U ON (W.idUsuario = U.idUsuario)

-- Listar todos os desejos de um usu�rio

SELECT	username [Nome], 
		desejo [Desejos] 
FROM WISHLIST W
LEFT JOIN USUARIO U ON (W.idUsuario = U.idUsuario)
WHERE U.idUsuario = 2

-- Listar um desejo espec�fico, user de quem a desejou, e o email de quem desejou

SELECT	username [Nome], 
		email [Email],
		desejo [Desejos] 
FROM WISHLIST W
LEFT JOIN USUARIO U ON (W.idUsuario = U.idUsuario)
WHERE W.idWishlist = 1