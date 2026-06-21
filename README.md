Projeto feito utilizando a caixa de ferramentas do Visual Studio, os elementos ficam semelhantes ao Delphi(embarcadero).



Todas as funções que são vitais para as buscas e funcionamento do programa ficaram no arquivo Program.cs, visando tornar testes unitários fáceis de se produzir.



Foram utilizadas as bibliotecas ClosedXML(0.105.0), para montar o relatório, e Npgsql(4.1.14) para acessar o banco de dados, foi evitado o uso da ferramenta do Visual Studio para conexão com o banco de dados para que fica tangível a capacidade do uso do SQL.



Na parte de GUI foi feito um bom filtro para evitar que o usuário tenha problemas (não era requisito do projeto).



Os relatórios são salvos no desktop (sem solicitação do caminho que deseja salvar), o tipo de arquivo .xlsx.



Na pasta modelo contém Classes referentes às entradas do banco, já na pasta telas existem as telas de GUI do aplicativo.



Foram feitas restrições pertinentes nas inserções do banco de dados, além disso caso um funcionário for inativado seus tickets também o serão.



Os comandos para geração do banco de dados estão no arquivo criarBancodeDados.sql, o banco de dados utilizado é o PostgreSQL(17.4). São geradas as tabelas e algumas inserções para testes.

