# Desafio_ApiRestSharp
Desafio testes de API - RestSharp
Arquitetura Projeto
Linguagem - CSharp
Orquestrador de testes - NUnit 
Relatório de testes automatizados - ExtentReports
Framework interação com API - Rest Sharp 

Objetivos
1) Implementar 50 scripts de testes que manipulem uma aplicação cuja interface é uma API REST. 
2) Alguns scripts devem ler dados de uma planilha Excel para implementar Data-Driven.
3) Notem que 50 scripts podem cobrir mais de 50 casos de testes se usarmos Data-Driven. Em outras palavras, implementar 50 CTs usando data-driven não é a mesma coisa que implementar 50 scripts.
4) O projeto deve tratar autenticação. Exemplo: OAuth2.
5) O projeto deverá gerar um relatório de testes automaticamente.
6) Implementar pelo menos dois ambientes (desenvolvimento / homologação)
7) A massa de testes deve ser preparada neste projeto, seja com scripts carregando massa nova no BD ou com restore de banco de dados.
Se usar WireMock (http://wiremock.org/) a massa será tratada implicitamente.
8) Executar testes em paralelo. Pelo menos duas threads (25 testes cada). Foi utilizado atributo [Parallelizable]
9) Testes deverão ser agendados pelo Azure DevOps, Gitlab-CI, Jenkins, CircleCI, TFS ou outra ferramenta de CI que preferir.
Resultado na pasta Results_Azure
