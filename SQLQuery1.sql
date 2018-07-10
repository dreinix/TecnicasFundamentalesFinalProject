declare @sp varchar(25)
set @sp = '1081566'
select * from Alumnos where [ID] like '%'+@sp+'%'

create table [Maestro](
	ID varchar(30) not null,
	Nombre varchar(30) not null,
	Photo Image
)
