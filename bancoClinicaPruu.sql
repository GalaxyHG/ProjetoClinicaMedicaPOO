create database ClinicaPruuPruu;
use ClinicaPruuPruu;

create table medico(
	idMedico int not null auto_increment,
    crm char(8) not null,
    nome varchar(180) not null,
    especialidade varchar(50) not null,
    primary key(idMedico)
)engine = InnoDB;

create table paciente(
	cpf char(14) not null,
    nome varchar(180) not null,
    telefone char(15) not null,
    primary key(cpf)
)engine = InnoDB;

create table consulta(
	idConsulta int not null auto_increment,
    nomeMedico varchar(180) not null,
    nomePaciente varchar(180) not null,
    dtConsulta varchar(30) not null,
    hrConsulta varchar(30) not null,
    primary key(idConsulta)
)engine = InnoDB;

select * from medico;
select * from paciente;
select * from consulta;

drop table consulta;
drop database ClinicaPruuPruu;