# WishList -  Nos diga seu desejo✨
- WishList serve como um caderno virtual para você mostrar a todos os seus desejos e aspirações.
- Após inserir o seu id de usuário e escrever o seu desejo, aperte em 'escrever' para enviá-lo para nosso sistema e inserí-lo na lista logo abaixo do cadastro. A API é reponsável por fazer o contato entre o front-end e o banco de dados, fazendo também as requisições para cadastrar seu desejo em nosso banco de dados, e em seguida retornar para o usuário em forma de lista.
- Com o intuito de deixar o usuário masi confortável, estilizamos nosso site com o objetivo de lembrar um caderno de anotações, com um ar mais nostálgico, como se fossemos escrever nossos desejos num caderno durante a infância.

## Integrantes da equipe
- Enzzo Teixeira - <a href='https://github.com/enzzotj'>enzzotj</a>
- Erick Oliveira - <a href='https://github.com/z-eck'>z-eck</a>
- Gustavo Lima - <a href='https://github.com/tavinlima'>tavinlima</a>
- Vinicius Ramos

## Tecnologias utilizadas:
### Banco de Dados:
- <img align="center" alt="SQL" width="26px" src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/sql/sql.png" /> - SQL
### Back-end (API): 
- <img align="center" alt="logo-Csharp" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg"> - C# 
- <img align="center" alt="logo_visual_studio" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/9f4f5cdb393299a81125eb5127929ea7bfe42889/icons/visualstudio/visualstudio-plain.svg"> - Visual Studio

### Layouts (baixa e alta fidelidade): 
- <img align="center" alt="logo_figma" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/9f4f5cdb393299a81125eb5127929ea7bfe42889/icons/figma/figma-original.svg">- Figma

### Front-end: 
- <img align="center" alt="logo-React" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/react/react-original.svg"> <img align="center" alt="logo-JavaScript" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/javascript/javascript-plain.svg"> - ReactJS
- <img align="center" alt="logo-HTML" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/html5/html5-original.svg"> - HTML
- <img align="center" alt="logo-CSS" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/css3/css3-original.svg"> - CSS
- <img align="center" alt="logo_VS_code" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/9f4f5cdb393299a81125eb5127929ea7bfe42889/icons/vscode/vscode-original.svg"> - Visual Studio Code

## Como executar:
- O primeiro passo é clonar esse repositório na sua máquina. Dê um git clone em uma pasta do seu computador e puxe todo o conteúdo do repositório;
![image](https://user-images.githubusercontent.com/82414372/139128745-bba16a45-dd0f-412d-8fc6-97a758427c19.png)
![image](https://user-images.githubusercontent.com/82414372/139128823-ff065a72-ef85-4fa0-9a44-ce42be7597cd.png)
![image](https://user-images.githubusercontent.com/82414372/139128835-9f3437e5-ddf4-4327-b7f7-596120011dec.png)

- Abra o ssms no seu computador e abra os scripts localizados na pasta 'BD';
![image](https://user-images.githubusercontent.com/82414372/139128879-e5c1a5df-51c4-4f09-acd2-bedcc02ea6ab.png)

- Crie a database e execute os 3 scripts para conferir se está tudo funcionando;
![image](https://user-images.githubusercontent.com/82414372/139128912-2a0d01ad-449a-4728-8d1d-c2006a4a1a10.png)
![image](https://user-images.githubusercontent.com/82414372/139128924-15d6bb5a-6a3b-485c-b0d2-6274e43b5bbd.png)

- Após o banco responder, abra o VS Code na solução que se encontra na pasta 'Back-End';
![image](https://user-images.githubusercontent.com/82414372/139128954-b87169ab-c121-425c-8488-f2624bc919be.png)

- Vá direto para a pasta de contexto e troque a string de conexão para a que conecte ao seu banco de dados (incluindo login e senha);
![image](https://user-images.githubusercontent.com/82414372/139129620-e1cf95cf-d715-4acb-bea6-813dc181e65c.png)

- Para não sobrecarregar o processamento, feche a aplicação e a partir da barra de endereço da pasta onde se encontram os aquivos, abra o cmd e digite 'dotnet run';
![image](https://user-images.githubusercontent.com/82414372/139129151-62f419bb-dfff-4421-89fc-ebd0f64dded8.png)
![image](https://user-images.githubusercontent.com/82414372/139129188-59ec8f60-0f21-4736-9c53-f4362eedd15f.png)
![image](https://user-images.githubusercontent.com/82414372/139129203-c86aca5a-35c8-42c3-82c5-c632f47799f4.png)

- Para abrir o front-end da aplicação, abra o cmd na pasta 'wishlist_ui' e de um 'npm i' para instalar todos os módulos utilizados na aplicação;
![image](https://user-images.githubusercontent.com/82414372/139129252-b8b939d9-1cd0-4e95-b6b4-ed80a90f27a8.png)

- Em seguida, digite 'npm start' para rodar a aplicação;
![image](https://user-images.githubusercontent.com/82414372/139129295-278e15b6-7f1a-416a-80d3-7eff5589cd55.png)

- Caso tudo esteja funcionando, essa tela irá aparecer:
![image](https://user-images.githubusercontent.com/82414372/139176738-d4976a63-e9e3-48e1-aa8e-275febba33a0.png)

- Digite um id de usuário para relaciona-lo a um desejo;
- Em seguida, digite seu desejo no campo e aperte em 'Enviar'
![image](https://user-images.githubusercontent.com/82414372/139177004-19aa01e7-ecea-4599-a87a-e0819d53c884.png)

- Se tudo estiver ok, seu desejo aparecerá logo em seguida no fim da lista!
![image](https://user-images.githubusercontent.com/82414372/139177051-25f64d50-b276-46f3-911b-7a1fc6b99420.png)

