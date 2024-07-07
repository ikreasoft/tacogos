drop table dbo.MESAS;

create table MESAS (
	Id_mesa int not null PRIMARY KEY (Id_mesa),
	Mesa varchar(50),

	Estado_fisico_mesa varchar(50),
	Estado_disponibilidad varchar(50),
	Id_salon int not null FOREIGN KEY (ID_SALON)
	REFERENCES SALON(Id_salon)
);