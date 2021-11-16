CREATE table if not exists contatos(
iDCont INTEGER primary key not null,
nome varchar(50) not null,
fone varchar (15) not null,
email varchar(50)
);

INSERT  into contatos (nome, fone, email)
values 
('Alpha', '123', 'alpha@sa.com'),
('Betha', '456', 'betha@sa.com'),
('Sigma', '789', 'sigma@sa.com');

