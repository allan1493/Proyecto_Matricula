 select * from dbo.Roles
 /*Error*/
 insert into dbo.Roles (Descripcion) values ('Administrador')
 insert into dbo.Roles (Descripcion) values ('Estudiante')

 delete from dbo.Roles where IdRol = '4' 

 select * from dbo.Persona
 insert into dbo.Persona (IdUsuario,IdCarrera,Nombre,Apellidos,Identificacion,IdTipo,IdGenero,IdEstadoCivil,FechaNacimiento,AnoIngreso,IdEstado) 
 values (1,1,'Fiorella','Garita','1234',1,1,1,'04/09/2002','2020',1)
 delete from dbo.Persona where IdAlumno ='1009'

 

 insert into dbo.Persona (IdUsuario,IdCarrera,Nombre,Apellidos,Identificacion,IdTipo,IdGenero,IdEstadoCivil,FechaNacimiento,AnoIngreso,IdEstado) 
 values (2,2,'Daniela','Araya','4567',2,1,2,'12/01/2002','2019',3)

 --delete from dbo.Persona where IdAlumno=6

 select * from Carrera
 insert into dbo.Carrera (Carrera) values ('Ingenieria Informatica')
 insert into dbo.Carrera (Carrera) values ('Derecho')
 delete from dbo.Carrera where IdCarrera = '4'

 select * from dbo.Usuario
 insert into dbo.Usuario (IdRol,Usuario,Contra) values (1,'Fiorella','123')
 insert into dbo.Usuario (IdRol,Usuario,Contra) values (2,'Daniela','456')
 delete from dbo.Usuario where IdUsuarios ='4'

 select * from dbo.Genero
 insert into dbo.Genero (Genero) values ('Mujer')
  insert into dbo.Genero (Genero) values ('Hombre')
   insert into dbo.Genero (Genero) values ('Otro')
delete from dbo.Genero where IdGenero='6'

 select * from dbo.EstadoCivil
 insert into dbo.EstadoCivil (EstadoCivil) values ('Soltero')
 insert into dbo.EstadoCivil (EstadoCivil) values ('Casado')
 insert into dbo.EstadoCivil (EstadoCivil) values ('Divorciado')
 delete from dbo.EstadoCivil where IdCivil = '6'

 select * from dbo.TipoIdentidad
 insert into dbo.TipoIdentidad (TipoIdenti) values ('Cedula Nacional')
insert into dbo.TipoIdentidad (TipoIdenti) values ('Dimex')
insert into dbo.TipoIdentidad (TipoIdenti) values ('Pasaporte')

select * from dbo.Estados
insert into dbo.Estados (Estado) values ('Activo')
insert into dbo.Estados (Estado) values ('Matriculado')
insert into dbo.Estados (Estado) values ('Graduado')
insert into dbo.Estados (Estado) values ('Inactivo')
delete from dbo.Estados where IdEstados='8'

select * from dbo.Materia
insert into dbo.Materia (IdCarrera,NombreCarrera,Creditos) values (1,'Progra 4','4')
insert into dbo.Materia (IdCarrera,NombreCarrera,Creditos) values (2,'Derecho','5')
delete from dbo.Materia where IdMaterias = '4'
update dbo.Grupos set IdMateria = '1003' where IdGrupo = '1003' 

select * from dbo.Periodo 
insert into dbo.Periodo (NombrePeriodo) values ('2Q')
delete from dbo.Periodo where IdPeriodo='2'

select * from dbo.Grupos
insert into dbo.Grupos (IdPeriodo,IdMateria,NumeroGrupo,Horario,Capacidad,Estado) 
values (1,1,'4','jueves de 6:30 a 9:30pm','25 personas','abierto')
insert into dbo.Grupos (IdPeriodo,IdMateria,NumeroGrupo,Horario,Capacidad,Estado) 
values (1,2,'9','Lunes de 8 a 12 am','20 personas','cerrado')
delete from dbo.Grupos where IdGrupo = '4'


select * from dbo.Matricula
insert into dbo.Matricula (IdPersona,IdGrupo,FechaMatricula) values (4,1,'04/09/2023')
insert into dbo.Matricula (IdPersona,IdGrupo,FechaMatricula) values (7,2,'06/15/2022')
delete from dbo.Matricula where IdMatricula='3'

go
create procedure dbo.spINSERT_dbo_Persona 
@usuario int,@carrera int,@nombre varchar(100),@apellidos varchar(100),@identificacion varchar(100),@tipo int,@genero int,@civil int,@nacimiento varchar(50),@ingreso varchar(50),@estado int
as
begin
insert into dbo.Persona (IdUsuario,IdCarrera,Nombre,Apellidos,Identificacion,IdTipo,IdGenero,IdEstadoCivil,FechaNacimiento,AnoIngreso,IdEstado) values (@usuario,@carrera,@nombre,@apellidos,@identificacion,@tipo,@genero,@civil,@nacimiento,@ingreso,@estado)
end
exec dbo.spINSERT_dbo_Persona @usuario = '5', @carrera = '1', @nombre='Allan', @apellidos = 'Picado Fonseca', @identificacion='702230743', @tipo='3', @genero ='2',@civil='1',@nacimiento='14/11/1993',@ingreso='08/01/2021',@estado='1'

update dbo.Persona set AnoIngreso = '2021' where IdAlumno = '10'

go
create procedure dbo.spInsert_dbo_Usuario
@rol int, @usuario varchar(100), @contra varchar(100)
as
begin
insert into dbo.Usuario (IdRol,Usuario,Contra) values (@rol,@usuario,@contra)
end

exec dbo.spInsert_dbo_Usuario @rol='2', @usuario='Allan', @contra='1234'

go
create procedure dbo.spSelect_infoPersonal @identificacion varchar(100)
as
begin
select Nombre, Apellidos, Identificacion, TipoIdenti, Genero, EstadoCivil, FechaNacimiento from dbo.Persona
join dbo.TipoIdentidad
on dbo.Persona.IdTipo = dbo.TipoIdentidad.IdTipo
join dbo.Genero
on dbo.Persona.IdGenero = dbo.Genero.IdGenero
join dbo.EstadoCivil
on dbo.Persona.IdEstadoCivil = dbo.EstadoCivil.IdCivil
where dbo.Persona.Identificacion = @identificacion;
end

go
create procedure dbo.spSelect_infoAcademica @identificacion varchar(100)
as
begin
select Carrera, AnoIngreso, Estado from dbo.Persona
join dbo.Carrera
on dbo.Persona.IdCarrera = dbo.Carrera.IdCarrera
join dbo.Estados
on dbo.Persona.IdEstado = dbo.Estados.IdEstados
where dbo.Persona.Identificacion = @identificacion;
end

go
create procedure dbo.spInsert_Carrera @carrera varchar(100)
as
begin
insert into dbo.Carrera (Carrera) values (@carrera)
end

exec dbo.spInsert_Carrera @carrera = 'Medicina'

go
create procedure dbo.spInsert_Materia @carrera int, @nombre varchar(50), @creditos varchar(50)
as
begin
insert into dbo.Materia (IdCarrera,NombreCarrera,Creditos) values (@carrera,@nombre,@creditos)
end

exec dbo.spInsert_Materia @carrera = '1', @nombre='Sistemas Operativos', @creditos='3'

go
create procedure dbo.spInsert_Periodo @nombre varchar(50)
as
begin
insert into dbo.Periodo (NombrePeriodo) values (@nombre)
end

exec dbo.spInsert_Periodo @nombre = '3Q'

go
create procedure dbo.spInsert_Grupos @periodo int, @materia int, @numero varchar(50), @horario varchar(100), @capacidad varchar(50), @estado varchar(50)
as 
begin
insert into dbo.Grupos (IdPeriodo,IdMateria,NumeroGrupo,Horario,Capacidad,Estado) values (@periodo,@materia,@numero,@horario,@capacidad,@estado)
end

exec dbo.spInsert_Grupos @periodo ='3', @materia = '5', @numero='1', @horario = 'Lunes de 6:30 a 9:30 pm', @capacidad = '25 personas', @estado = 'abierto'

go
create procedure dbo.spSelect_OfertaGrupos @periodo varchar(50), @carrera varchar(100)
as
begin
select NombreCarrera as Curso, NombrePeriodo, NumeroGrupo, Horario, Capacidad, Estado from dbo.Grupos
join dbo.Periodo
on dbo.Grupos.IdPeriodo = dbo.Periodo.IdPeriodo
join dbo.Materia
on dbo.Grupos.IdMateria = dbo.Materia.IdMaterias
join dbo.Carrera
on dbo.Materia.IdCarrera = dbo.Carrera.IdCarrera
where dbo.Periodo.NombrePeriodo = @periodo and dbo.Carrera.Carrera = @carrera
end

select NombreCarrera as Curso, NombrePeriodo, NumeroGrupo, Horario, Capacidad, Estado from dbo.Grupos
join dbo.Periodo
on dbo.Grupos.IdPeriodo = dbo.Periodo.IdPeriodo
join dbo.Materia
on dbo.Grupos.IdMateria = dbo.Materia.IdMaterias
join dbo.Carrera
on dbo.Materia.IdCarrera = dbo.Carrera.IdCarrera
where dbo.Periodo.NombrePeriodo = '2Q' and dbo.Carrera.Carrera = 'Ingenieria Informatica'

select * from dbo.Periodo
select * from dbo.Carrera
select * from dbo.Grupos
select * from Materia

go
create procedure dbo.spSelect_Carreras @carrera varchar(100)
as begin
select dbo.Carrera.Carrera, Count(DISTINCT dbo.Materia.NombreCarrera) Materias, COUNT( DISTINCT dbo.Persona.IdAlumno) as estudiantes, SUM(CAST( dbo.Materia.Creditos as bigint)) as Creditos from dbo.Materia
inner join dbo.Carrera
on dbo.Materia.IdCarrera = dbo.Carrera.IdCarrera
inner join dbo.Persona
on dbo.Carrera.IdCarrera = dbo.Persona.IdCarrera
where dbo.Carrera.Carrera = @carrera
group by Carrera.Carrera
end

select dbo.Carrera.Carrera, Count(DISTINCT dbo.Materia.NombreCarrera) Materias, COUNT( DISTINCT dbo.Persona.IdAlumno) as estudiantes, SUM(CAST( dbo.Materia.Creditos as bigint)) as Creditos from dbo.Materia
inner join dbo.Carrera
on dbo.Materia.IdCarrera = dbo.Carrera.IdCarrera
inner join dbo.Persona
on dbo.Carrera.IdCarrera = dbo.Persona.IdCarrera
where dbo.Carrera.Carrera = 'Farmacia'
group by Carrera.Carrera

go
create procedure dbo.spSelect_Materias @carrera varchar(100)
as
begin
select dbo.Carrera.Carrera, dbo.Materia.NombreCarrera as Materia, dbo.Materia.Creditos from dbo.Materia
inner join dbo.Carrera
on dbo.Materia.IdCarrera = dbo.Carrera.IdCarrera
where dbo.Carrera.Carrera = @carrera
end
exec dbo.spSelect_Materias @carrera ='Ingenieria Informatica'
go
create procedure dbo.spUpdate_Carrera @carrera varchar(50), @actualizar varchar(50)
as
begin
update dbo.Carrera
set Carrera = @actualizar
where Carrera = @carrera
end

go
create procedure dbo.spUpdate_Materia @materia varchar(50), @carrera int, @creditos varchar(50), @actualizar varchar(50)
as
begin
update dbo.Materia
set NombreCarrera = @actualizar, IdCarrera = @carrera, Creditos = @creditos
where NombreCarrera = @materia
end

go 
create procedure dbo.spMatricular @alumno int, @grupo int, @fecha date
as
begin 
insert into dbo.Matricula (IdPersona,IdGrupo,FechaMatricula) values (@alumno,@grupo,@fecha)
end

go
create procedure dbo.spDelete_Matricula @alumno int, @grupo int
as
begin
Delete from dbo.Matricula
where IdPersona = @alumno and IdGrupo = @grupo
end

select * from Grupos
