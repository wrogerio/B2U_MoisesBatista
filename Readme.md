# Teste de Programação - B2U (Desenvolvedor Jr.)
## 1 - Instruções para Teste de Programação
- Siga as instruções atentamente e tenha um bom teste.  

## 1.1 Tecnologia
- ASP.NET C# consultando uma base de dados SQL Server pré-determinada  

## 1.2 Código
- Você deverá utilizar o Microsoft Visual Studio 2019;
- O acesso ao banco poderá ser através de ADO.NET;
- Não será permitida a utilização de stored procedures para geração do resultado.
- Será permitida a utilização de Bootstrap, AngularJS, Angular 2, Angular Material para front-end

## 1.3 Acesso ao banco de dados:
- Em anexo, está um backup do banco de dados. Restaure-o em um SQL Server, podendo ser uma versão express, com o nome do banco de dados sendo TESTEPROG.

## 1.4 Tabelas a serem utilizadas são:
- Conta
- Transacao

## 1.5 Objetivo
- Trata-se de uma aplicação web que através de alguns filtros apresente um extrato bancário.

## 1.6 Escopo
- O usuário deverá escolher a conta corrente da qual deseja visualizar o extrato;
- O usuário deverá entrar com a data inicial para a visualização até a data de hoje;
- Ao submeter a pesquisa, o sistema deverá exibir o relatório(extrato) e opção fácil para impressão do browser;
- O sistema deverá apresentar os campos data, histórico e valor e o extrado devera ser ordenado por data em ordem crescente
- O sistema deverá apresentar um totalizador com o saldo final do periodo
- Valores negativos deverão ser exibidos em vermelho;
- Criar pagina que permita incluir um novo registro em transação, onde se possa selecionar uma conta, uma categoria, o tipo(debito, credito) e o valor

## 1.7 Observações
- É importante evitar usar codigo gerados automaticamente pelo visual studio, pois desta forma não conseguiremos verificar a forma como voce programa

- O importante é avançar o maximo possivel no escopo, porem caso nao consiga finalizar alguns dos itens, não tem problema, a ideia é analisar a forma como foi feito, os padrões utilizados etc

- Apesar das especificações de layout, o maior peso para a avaliação é a lógica e a qualidade da informação.

***

## 2 - Estruturaçao do Projeto
Nessa seção será apresentada a estrutura do projeto, bem como as tecnologias utilizadas. A descrição será feita sob a perspectiva de um overview do projeto, sendo que cada camada será descrita em detalhes em sua respectiva seção.

### 2.1 - Tecnologias Utilizadas
As tecnologias utilizadas no projeto foram:
- C# 9
- ASP.NET Core 6
- Entity Framework Core 6
- SQL Server 2019
- Bootstrap 5
- HTML 5
- CSS 3
- JavaScript
- Jquery.js
- Moment.js
- Toastr.js
- Particle.js
- Datatable.js
- FontAwesome

### 2.2 - Design Patterns
Os designer patterns utilizados no projeto foram:
- Repository Pattern
- Injeção de Dependência

### 2.3 - Arquitetura
A arquitetura utilizada no projeto foi a arquitetura em camadas. O modelo utilizado foi a arquitetura em 3 camadas, sendo elas:
- UI - User Interface, utiliznao o MVC (Model View Controller)
- BLL - Business Logic Layer
- DAL - Data Access Layer

### 2.4 - Estrutura do Projeto
A estrutura do projeto foi organizada da seguinte forma:
- B2U.WebUI
- B2U.BLL
- B2U.DAL
