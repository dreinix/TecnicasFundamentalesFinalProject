declare @sp varchar(25)
set @sp = '1081566'
select * from Alumnos where [ID] like '%'+@sp+'%'

create table [Registro](
	Alumno var
)
