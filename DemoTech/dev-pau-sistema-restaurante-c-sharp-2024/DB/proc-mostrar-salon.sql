CREATE PROC mostrar_salon
@buscar varchar(50)
as
select * from SALON where Salon LIKE '%' + @buscar + '%';