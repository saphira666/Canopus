
create database CanoppusDB;

use CanoppusDB;

create table TipoUsuario(
IdTipoUsuario int primary key identity not null,
DescricaoTipoUsuario varchar(150) not null
);
insert into TipoUsuario (DescricaoTipoUsuario) values('Administrador'),('Outros');
select * from TipoUsuario;


create table Usuario(
IdUsuario int primary key identity not null,
NomeUsuario varchar(150) not null,
SenhaUsuario char(6) not null,
CpfUsuario char(14) unique not null,
DtNascUsuario date not null,
UrlImagemUsuario varchar(250) not null,
TipoUsuario_IdTipoUsuario int,
foreign key (TipoUsuario_IdTipoUsuario) references TipoUsuario(IdTipoUsuario)
);

insert into Usuario (NomeUsuario,SenhaUsuario,CpfUsuario,DtNascUsuario,UrlImagemUsuario,TipoUsuario_IdTipoUsuario)
 values ('Cerjio','222222','22222222222','19810523','C:\\Users\\wil.rrsilva\\Desktop\\Canoppus\\Canoppus.UI\\Imagens\\img2.jpg',1),
 ('Letisgo','333333','33333333333','19901012','C:\\Users\\wil.rrsilva\\Desktop\\Canoppus\\Canoppus.UI\\Imagens\\img3.jpg',2),
 ('Hollyudisoun','444444','44444444444','19891211','C:\\Users\\wil.rrsilva\\Desktop\\Canoppus\\Canoppus.UI\\Imagens\\img4.jpg',2),
 ('Cylvia','555555','55555555555','20000626','C:\\Users\\wil.rrsilva\\Desktop\\Canoppus\\Canoppus.UI\\Imagens\\img5.jpg',2),
 ('Marsia','666666','66666666666','20010808','C:\\Users\\wil.rrsilva\\Desktop\\Canoppus\\Canoppus.UI\\Imagens\\img6.jpg',2),
 ('Rodometálica','777777','77777777777','19790116','C:\\Users\\wil.rrsilva\\Desktop\\Canoppus\\Canoppus.UI\\Imagens\\img7.jpg',1);
 
 update Usuario set UrlImagemUsuario = 'C:\\Users\\wil.rrsilva\\Desktop\\Canoppus\\Canoppus.UI\\Imagens\\img7.jpg' 
 where IdUsuario = 7;
 select * from Usuario;
 
 select NomeUsuario, SenhaUsuario,CpfUsuario,DtNascUsuario,DescricaoTipoUsuario from Usuario
 inner join TipoUsuario on TipoUsuario_IdTipoUsuario = IdTipoUsuario;
 
 
 create table Tarefa(
  idTarefa int primary key identity not null,
nomeTarefa varchar(30) not null,
 descricaoTarefa varchar(150) not null,
prazoTarefa date not null,
statusTarefa varchar(10) not null,
responsavelTarefaIdUsuario int,
foreign key (responsavelTarefaIdUsuario) references Usuario(IdUsuario)
);
insert into Tarefa (nomeTarefa,descricaoTarefa,prazoTarefa,statusTarefa,responsavelTarefaIdUsuario)
 values ('Manutenção','Verificação de bugs e correção','2022-08-19','Ativo',4);
select * from tarefa;
select nomeTarefa,descricaoTarefa,prazoTarefa,statusTarefa,NomeUsuario from Tarefa 
inner join Usuario on responsavelTarefaIdUsuario = IdUsuario;


