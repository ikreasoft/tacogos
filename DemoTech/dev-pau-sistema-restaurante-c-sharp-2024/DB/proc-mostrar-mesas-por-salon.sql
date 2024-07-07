create proc mostrar_mesas_por_salon
@id_salon int
as
select * from MESAS inner join SALON on  SALON.Id_salon = MESAS.Id_salon
where MESAS.Id_salon = @id_salon;