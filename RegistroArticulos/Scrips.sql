CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO
CREATE TABLE Articulos
(
	ArticuloID int primary key identity(1,1),
	FechaVencimiento int,
	Descripcion varchar(max),
	Precio varchar(10),
	Existencia int,
	CantidadCotizada int
);