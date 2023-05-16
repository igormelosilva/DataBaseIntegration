CREATE TABLE IF NOT EXISTS products(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50),
	model VARCHAR(50),
	quantity INTEGER,
	value REAL

);
--Adicionar as bibliotecas
--NpgSql
--System.Configuration.ConfigurationManager
--Adicionar um arquivo de configurações
--inserir as credenciais no arquivo de configuração
--Criar a classe de conexão com o banco
SELECT * FROM products;