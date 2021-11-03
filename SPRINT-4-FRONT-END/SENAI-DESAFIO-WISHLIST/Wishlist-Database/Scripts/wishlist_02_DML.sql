USE WISHLIST_DESAFIO;
GO

INSERT INTO USUARIO (username, email, senha)
VALUES ('zeck', 'zeck@wishlist.com', 'garimpeiro'), ('tavinlima','tavin@wishlist.com','aranhaescarlate');
GO

INSERT INTO WISHLIST (idUsuario, desejo)
VALUES (1, 'Achar um ingresso no cinema para o novo filme do homem-aranha'), (1, 'Comer um X-tudão'), (2, 'Lançar minhas histórias.'), (2, 'Conhecer o mundo.');
GO
