USE WISHLIST_DESAFIO;
GO

-- Listar somente a Entidade "Wishlist"

SELECT * FROM WISHLIST

-- Listar somente a Entidade "Usuarios"

SELECT * FROM USUARIO

-- Listar desejos com o username de quem a desejou

SELECT	desejo [Desejos],
		username [Nome de Usuário] 
FROM WISHLIST W
LEFT JOIN USUARIO U ON (W.idUsuario = U.idUsuario)

-- Listar todos os desejos de um usuário

SELECT	username [Nome], 
		desejo [Desejos] 
FROM WISHLIST W
LEFT JOIN USUARIO U ON (W.idUsuario = U.idUsuario)
WHERE U.idUsuario = 2

-- Listar um desejo específico, user de quem a desejou, e o email de quem desejou

SELECT	username [Nome], 
		email [Email],
		desejo [Desejos] 
FROM WISHLIST W
LEFT JOIN USUARIO U ON (W.idUsuario = U.idUsuario)
WHERE W.idWishlist = 1