// Ativação de uso de chave extrangeira
pragma foreign_keys = on;

CREATE table nome (
	IdNome INTEGER PRIMARY KEY AUTOINCREMENT,
	PriNome TEXT,
	SobNome TEXT,
	DataNascimento TEXT
);


// Uma pessoa pode ter varios email e/ou telefones

CREATE table email(
	IdEmail INTEGER PRIMARY KEY AUTOINCREMENT,
	email TEXT,
	IdNome integer,
	foreign key (IdNome) references nome (IdNome)
);

CREATE table telefone(
	IdTelefone INTEGER PRIMARY KEY AUTOINCREMENT,
	telefone NUMERIC,
	IdNome integer,
	foreign key (IdNome) references nome (IdNome)
);

CREATE table endereco(
	IdTEndereco INTEGER PRIMARY KEY AUTOINCREMENT,
	Logradouro Text,
	Numero NUMERIC,
	Bairro Text,
	CEP Numeric
);


\\ Dados para testes 
INSERT into nome (PriNome, SobNome, DataNascimento)
values
('Rafael', 'Sagawe', '25091985'), ('Bruna', 'Martins', '10111985');

INSERT into email (email, IdNome)
values 
('sagawersf@gmail.com', '1'), 
('sagawe_r@hotmail.com', '1'), 
('brunas2sagawe@hotmail.com', '2');

INSERT into telefone (telefone, IdNome) 
values
('2864', '1'), ('9137', '2'), ('789321', '1'), ('31579', '2'), ('28640', '1'), ('91370', '2'), ('7893201', '1'), ('301579', '2');


// Criação da View de Contatos
CREATE view Contatos_VW 
as 
SELECT PriNome || ' ' || SobNome as NomeCompleto, DataNascimento, telefone, email 
FROM nome
inner join telefone on nome.IdNome = telefone.IdNome
inner JOIN  email on nome.IdNome = email.IdNome;