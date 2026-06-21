CREATE DATABASE "ticketChecker";

\c "ticketChecker"
  
-- Tabela Funcionario
CREATE TABLE funcionario (
	id              SERIAL 		PRIMARY KEY,
    	nome            VARCHAR(200) 	NOT NULL,
    	CPF             VARCHAR(11)  	UNIQUE NOT NULL,
    	situacao        CHAR(1)      	NOT NULL DEFAULT 'A',			-- criação sempre como ativo
    	dataAlteracao  	TIMESTAMP    	NOT NULL DEFAULT CURRENT_TIMESTAMP,
    
    	CONSTRAINT verificaFuncionarioSituacao CHECK (situacao IN ('A', 'I')),	-- situação ou ativo ou inativo
    	CONSTRAINT verificaFuncionarioCPF CHECK (CPF ~ '^[0-9]{11}$')		-- expressão regular para formato do CPF
);

-- Tabela Ticket, chave estrangeira id e situação do funcionário
-- Imagino que tickets que situação de ativiade do ticket tenha haver com a do funcionário
CREATE TABLE ticket (
    	id           	SERIAL 		PRIMARY KEY,
    	idFuncionario	INTEGER 	NOT NULL,
    	quantidade	INTEGER 	NOT NULL CHECK (quantidade > 0),
    	situacao   	CHAR(1) 	NOT NULL DEFAULT 'A',
    	dataEntrega  	TIMESTAMP 	NOT NULL DEFAULT CURRENT_TIMESTAMP,
    
    	CONSTRAINT chaveIdTicketFuncionario
        	FOREIGN KEY (idFuncionario) 
        	REFERENCES funcionario(id) 
        	ON DELETE RESTRICT ON UPDATE CASCADE,	-- o 'DELETE RESTRICT'	é desnecessário no escopo da tarafa

	CONSTRAINT verifcaTicketSituacao 
        	CHECK (situacao IN ('A', 'I'))
);



-- Função de ajuste de alteração com cuidado sobre a alteração dos tickets
CREATE OR REPLACE FUNCTION gatilhoAlteracaoFuncionario()
RETURNS TRIGGER AS $$
BEGIN
    	NEW.dataAlteracao := CURRENT_TIMESTAMP;

    	-- Lógica, caso o funcionário fique inativo seus tickets ficam inativos igualmente
    	IF NEW.situacao = 'I' AND (OLD.situacao IS DISTINCT FROM 'I') THEN
        
        	UPDATE ticket 
        	SET situacao = 'I'
        	WHERE idFuncionario = NEW.id 
          		AND situacao = 'A';   -- só inativa os que ainda estão ativos
    	END IF;
    	RETURN NEW;
END;
$$ LANGUAGE plpgsql;

-- Gatilho para atualizar a data quando a tabela funcionário é modificada
CREATE TRIGGER gatilhoAlteracaoFuncionario
    	BEFORE UPDATE ON funcionario
    	FOR EACH ROW
    	EXECUTE FUNCTION gatilhoAlteracaoFuncionario();

-- Função para bloquear criação de novas entradas para funcionários inativos
CREATE OR REPLACE FUNCTION bloqueioTicketFuncionarioInativo()
RETURNS TRIGGER AS $$
DECLARE
    	vSituacao CHAR(1);
BEGIN
	-- Busca a situação do funcionário
    	SELECT situacao 
      		INTO vSituacao
    	FROM funcionario 
    	WHERE id = NEW.idFuncionario;

    	-- exceção para funcionário não existente
    	IF vSituacao IS NULL THEN
        	RAISE EXCEPTION 'Funcionário com ID % não encontrado.', NEW.idFuncionario;
    	END IF;

    	-- Se o funcionário estiver inativo, não cria a entrada na tabela
    	IF vSituacao = 'I' THEN
        	RAISE EXCEPTION 'Não é possível criar ou alterar ticket para funcionários inativos (ID: % está inativo).', 
            		NEW.idFuncionario;
    	END IF;

    	RETURN NEW;
END;
$$ LANGUAGE plpgsql;


CREATE TRIGGER gatilhoTicketFuncionarioAtivo
    	BEFORE INSERT OR UPDATE ON ticket
    	FOR EACH ROW
    	EXECUTE FUNCTION bloqueioTicketFuncionarioInativo();


-- Comentários no banco de dados
COMMENT ON DATABASE "ticketChecker" IS 'Controle de entrega de tickets para funcionários';

COMMENT ON TABLE funcionario IS 'Cadastro de funcionários';
COMMENT ON COLUMN funcionario.id IS 'Identificador do funcionário';
COMMENT ON COLUMN funcionario.nome IS 'Nome completo do funcionário';
COMMENT ON COLUMN funcionario.cpf IS 'CPF do funcionário';
COMMENT ON COLUMN funcionario.situacao IS 'Situação do funcionário: A = Ativo, I = Inativo';
COMMENT ON COLUMN funcionario.dataAlteracao IS 'Data e hora da última alteração cadastral';

COMMENT ON TABLE ticket IS 'Registro de entrega de tickets';
COMMENT ON COLUMN ticket.id IS 'Identificador da entrega';
COMMENT ON COLUMN ticket.idFuncionario IS 'Funcionário quem recebeu os tickets';
COMMENT ON COLUMN ticket.quantidade IS 'Quantidade de tickets entregues';
COMMENT ON COLUMN ticket.situacao IS 'Situação do registro: A = Ativo, I = Inativo';
COMMENT ON COLUMN ticket.dataEntrega IS 'Data da entrega dos tickets';

-- dados teste
INSERT into funcionario(nome, cpf, dataalteracao) values ('afonso roberto', '12345678901', '10-05-2025');
INSERT into funcionario(nome, cpf, dataalteracao) values ('ali abreu', '12345638901', '10-05-2026');
INSERT into funcionario(nome, cpf, dataalteracao) values ('bob loco', '12345675901', '10-05-2024');
INSERT into funcionario(nome, cpf, dataalteracao) values ('adolfo', '12345678101', '10-12-2025');
INSERT into funcionario(nome, cpf, dataalteracao) values ('vilson nola', '14345678901', '01-05-2025');
INSERT into funcionario(nome, cpf, dataalteracao) values ('cassio', '12945678901', '10-01-2025');
INSERT into funcionario(nome, cpf, dataalteracao) values ('bruno aa', '16345678901', '10-11-2025');
INSERT into funcionario(nome, cpf, dataalteracao) values ('jakso', '12344678901', '10-05-2022');

insert into ticket(idFuncionario, quantidade, dataEntrega) values ('1', 32, '21-06-2026');
insert into ticket(idFuncionario, quantidade, dataEntrega) values ('1', 12, '21-06-2026');
insert into ticket(idFuncionario, quantidade, dataEntrega) values ('1', 62, '21-05-2026');
insert into ticket(idFuncionario, quantidade, dataEntrega) values ('5', 32, '21-06-2026');
insert into ticket(idFuncionario, quantidade, dataEntrega) values ('5', 32, '21-04-2026');
insert into ticket(idFuncionario, quantidade, dataEntrega) values ('5', 52, '21-06-2026');
insert into ticket(idFuncionario, quantidade, dataEntrega) values ('5', 22, '21-06-2026');
insert into ticket(idFuncionario, quantidade, dataEntrega) values ('5', 12, '21-03-2026');
