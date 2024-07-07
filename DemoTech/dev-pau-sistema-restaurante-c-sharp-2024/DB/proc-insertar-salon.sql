CREATE PROC insertar_salon
@Salon varchar(50)
as
declare @Estado varchar(50)
set @Estado = 'Activo'
if EXISTS(select Salon from SALON where Salon = @Salon ) 
RAISERROR('Ya existe un salon con este nombre, ingrese uno nuevo', 16,1)
else
insert into SALON values (@Salon , @Estado)