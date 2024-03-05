# TestePlanetun
Teste técnico: Backend (C#) &amp; Frontend (Angular)

---------------------
Backend (C#):
1. Crie uma API RESTful em C# que simula o processamento de dados assíncrono. A
API deve conter um endpoint, com o nome da sua escolha, que aceite uma lista de
números inteiros como entrada.
2. Implemente um método assíncrono dentro da API que receba a lista de números.
Para cada número executar o seguinte processamento de forma assíncrona:
a. Criar um arquivo txt e gravar a tabuada no layout “n x tabNum = r” onde n é
o número da lista que está sendo processado, tabNum é a sequência de 1 a
10 e r é o resultado salvar o arquivo no diretório corrente com o nome
“tabuada_de_n.txt” onde n é o número da lista que está sendo processado.

Nota:
● Utilize a palavra-chave async e await para lidar com operações assíncronas;
● Implemente um mecanismo de controle de concorrência para garantir que as
operações sejam executadas de forma eficiente e segura em várias threads.

----------------------
Frontend (Angular):
1. Crie uma interface de usuário (UI) simples em Angular que permita ao usuário
inserir uma lista de números inteiros. Ao clicar em um botão, envie a lista de
números para o endpoint criado anteriormente.
2. Exiba os resultados retornados pela API na interface de usuário em uma lista.
Nota:
Considerar usar html semanticamente, evitando o máximo de usar divs genéricas.
