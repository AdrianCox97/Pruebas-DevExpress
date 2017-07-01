create database tigres;
use tigres;
create table alumnos(
matricula char (20),
nombre char (50)
);

create trigger a_alumno on alumnos for insert as select 'diste de alta';

insert into alumnos values ('x','y');
select * from alumnos;
alter trigger a_alumno on alumnos for insert as select 'diste de alta',GETDATE();
insert into alumnos values ('r','t');
alter trigger a_alumno on alumnos for insert as select 'diste de alta',GETDATE(),USER;

insert into alumnos values ('gaspi','dani');

alter trigger a_alumno on alumnos for insert as select inserted.matricula 'diste de alta',GETDATE(),USER from inserted;

insert into alumnos values ('15090437i','da');

create trigger b_alumno on alumnos for delete as select deleted.matricula 'el o ella borro esta matricula',GETDATE(),USER,HOST_NAME() from deleted;

insert into alumnos values ('15090437i','r');
select * from alumnos;
delete  from alumnos where matricula='15090437i'

create trigger c_alumno on alumnos for update  as select inserted.matricula ,deleted.matricula 'cambio matricula',GETDATE(),USER,HOST_NAME() from deleted inner join inserted on deleted.nombre=inserted.nombre;
update alumnos set matricula='lbhjfjjbh' where matricula='15090437i';





