

create table empregado(
	id int identity,
	nome varchar(30),
	ddd char(2),
	celular varchar(9), 
	cpf varchar(11),
	salario money,
	departamento varchar(15), 
	numCasa int,
	rua varchar(25),
	bairro varchar(20),
	cidade varchar(25)
)
select * from empregado