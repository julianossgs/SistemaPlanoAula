create database PlanoAulas
go

use PlanoAulas
go

create table TblPlano
(Id int primary key identity not null,
 Data date not null,
 Hora varchar(50),
 Eixo varchar(200),
 Objetivo varchar(200),
 Conteudo varchar(200),
 Metodologia varchar(300),
 Avaliacao varchar(300))
 go

 select * from TblPlano
 go


 --Procedures--
 --excluir

 create procedure spExcluirAulas
 @Id int
 as begin
 begin try
 begin tran

 delete from TblPlano
 where Id=@Id

 commit tran
 end try
 begin catch
 rollback tran
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go
 
 --inserir
 create procedure spInserirAulas
 @Data date,
 @Hora varchar(50),
 @Eixo varchar(200),
 @Objetivo varchar(200),
 @Conteudo varchar(200),
 @Metodologia varchar(300),
 @Avaliacao varchar(300)
 as begin
 begin try
 begin tran

 insert into TblPlano(Data,Hora,Eixo,Objetivo,Conteudo,
 Metodologia,Avaliacao)
 values(@Data,@Hora,@Eixo,@Objetivo,@Conteudo,@Metodologia,@Avaliacao)

 commit tran
 end try
 begin catch
 rollback tran
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --alterar
 alter procedure spAlterarAulas
 @Id int,
 @Data date,
 @Hora varchar(50),
 @Eixo varchar(200),
 @Objetivo varchar(200),
 @Conteudo varchar(200),
 @Metodologia varchar(300),
 @Avaliacao varchar(300)
 as begin
 begin try
 begin tran

 update TblPlano set Data=@Data ,Hora=@Hora,Eixo=@Eixo,Objetivo=@Objetivo,
 Conteudo= @Conteudo,Metodologia=@Metodologia,Avaliacao=@Avaliacao
 
 where Id=@Id

 commit tran
 end try
 begin catch
 rollback tran
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 exec spAlterarAulas 19,'11/04/2019','diruno','taroba','taroba','taroba','taroba','taroba'
 go

 select * from TblPlano
 go


 --Mostrar
 alter procedure spMostrarAulas
 as begin
 begin try
 begin tran

 select top 50 * from TblPlano
 order by Data desc

 commit tran
 end try
 begin catch
 rollback tran
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure para buscar por data
alter procedure spBuscarData
@DataInicio varchar(50),
@DataFim varchar(50)
as begin
 begin tran
 begin try

 select * from TblPlano
 where Data >=@DataInicio and Data <=@DataFim
 order by Data desc

 commit tran
 end try
 begin catch
 rollback tran
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 


