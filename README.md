# escola-ds
Desenvolvimento de Sistemas

create database bd_escolajoao;
use bd_escolajoao;

drop database bd_escolajoao;

create table escola(
id_esc int primary key auto_increment,
nomeFantasia_esc varchar (300) not null,
razaoSocial_esc varchar (300) not null,
cnpj_esc varchar (18) not null,
inscricaoEstadual_esc varchar (200) not null,
tipo_esc varchar (100) not null,
data_criacao_esc date not null,
responsavel_esc varchar (500) not null,
responsavelTelefone_esc varchar (300) not null,
email_esc varchar (300) not null,
telefone_esc varchar (100) not null,
rua_esc varchar (100) not null,
numero_esc varchar (200) not null,
bairro_esc varchar (200) not null,
complemento_esc varchar (200) not null,
cep varchar (100) not null,
cidade varchar (100) not null,
estado_esc varchar (100)
);
