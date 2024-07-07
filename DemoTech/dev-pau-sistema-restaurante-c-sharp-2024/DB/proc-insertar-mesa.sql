CREATE PROC insertar_mesa
@Mesa varchar(50), 
@IdSalon int
AS 
declare @Estado_fisico_mesa varchar(50)
declare @Estado_disponibilidad varchar(50)
set @Estado_fisico_mesa = 'Activo'
set @Estado_disponibilidad = 'Libre'
if EXISTS(select Mesa from MESAS WHERE Mesa = @Mesa and Mesa <> 'NULO' )
RAISERROR ('Ya existe una mesa con este nombre, ingrese de nuevo', 16,1)
else
insert into MESAS values (@Mesa, @IdSalon, @Estado_fisico_mesa, @Estado_disponibilidad);