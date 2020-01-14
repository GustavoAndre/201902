CREATE DATABASE BD_PROYECTO_FINAL_2019II
GO
-----------------------------
USE BD_PROYECTO_FINAL_2019II
GO
------------------------------
CREATE TABLE Empleado01
(
	IdEmp int identity primary key,
	ApePatEmp varchar (50) not null,
	ApeMatEmp  varchar (50) not null,
	NomEmp varchar(50) not null,
	FecNacEmp Date null,
	FecIngEmp Date not null,
	SexEmp char(1) not null,
	TelEmp int null,
	CelEmp int not null,
	CorEmp varchar(200)not null,
	ObsEmp varchar null,
	IdDis int not null,
	IdCar int not null,
	IdAre int not null,
	Activo bit not null
)
GO
CREATE TABLE Usuario
(
	IdUsu int identity primary key not null,
	LogUsu varchar(120) not null,
	PasUsu varchar (120)not null,
	IdEmp int not null,
	Activo Bit
)
GO
CREATE TABLE Categoria
(
	IdCat int identity primary key not null,
	NomCat nvarchar(50) not null,
	DesCat nvarchar(500) null,
	Activo bit
)
GO
CREATE TABLE Cargo
(
	IdCar int identity primary key not null,
	NomCar varchar(150) not null,
	DesCar varchar (200) null,
	Activo bit
)
GO 
CREATE TABLE Area
(
	IdAre int identity primary key not null,
	NomAre varchar (50) not null,
	Activo bit not null
)
GO
CREATE TABLE Distrito
(
	IdDis int Identity primary key not null,
	NomDis Varchar(100),
	ConDis varchar(50),
	Activo bit
)
GO
CREATE TABLE Proveedor
(
	IdProv int identity  primary key not null,
	RucCom int not null,
	NomCom Varchar(200) not null,
	NomCon varchar(200) not null,
	ApePatCon Varchar(50) not null,
	ApeMatCon Varchar(50) not null,
	CarCon Varchar(200) null,
	DirPro varchar(500) null,
	CelPro int not null,
	CorPro varchar(200) null,
	FecRegPro Date null,
	CodDis int not null, 
	Activo bit
)
GO
CREATE TABLE Producto
(
	IdPro int identity primary key Not null,
	NomPro Varchar(200) not null,
	DesPro varchar(200) null,
	IdCat int not null,
	CanxUniPro varchar(100) null,
	PreComPro decimal(10,2)not null,
	FecRegPro date ,
	StoPro int not null,
	StoMinPro int null,
	StoMaxPro int null,
	IdUni int not null,
	IdMer int not null,
	Activo bit
)
GO
create TABLE Despachos
(
	IdDes int identity primary key not null,
	IdEmp int not null,
	FecDes Date not null,
	idDoc int not null,
	idOpe int not null,
	Activo bit not null
)
GO
DROP TABLE Pedidos
(
	IdPedido int identity primary key not null,
	IdProv int not null,
	IdEmp int not null,
	FecPed date not null,
	idOpe int  null,
	idDoc int null,
	Activo bit  null
)
GO
create TABLE DetallePedidos
(
	IdPedido int not null,
	IdPro int not null,
	Cantidad int not null,
	PreCompra decimal(10,2) null,
	Activo bit null
)
GO
create TABLE DetalleDespacho
(
	IdDes int not null,
	IdPro int not null,
	Cantidad int not null,
	PreCompra decimal(10,2) null,
	Activo bit null
)
create TABLE Almacen
(
	IdAlm int identity primary key not null,
	NomAlm varchar(50) not null,
	DesAlm varchar(100) not null,
	UbiAlm varchar(100) null,
	Activo bit null
)
-----------------LLAVES FORANEAS-------------------------------

ALTER TABLE Usuario
ADD FOREIGN KEY (IdEmp) REFERENCES Empleado
GO
ALTER TABLE Usuario
ADD FOREIGN KEY (IdEmp) REFERENCES Empleado
GO
ALTER TABLE Empleado
ADD FOREIGN KEY (IdDis) REFERENCES Distrito
GO
ALTER TABLE Empleado
ADD FOREIGN KEY (IdCar) REFERENCES Cargo
GO
ALTER TABLE Empleado
ADD FOREIGN KEY (IdAre) REFERENCES Area
GO
ALTER TABLE Despachos
ADD FOREIGN KEY (IdEmp) REFERENCES Empleado
GO
ALTER TABLE Pedidos
ADD FOREIGN KEY (IdProv) REFERENCES Proveedor
GO
ALTER TABLE Pedidos
ADD FOREIGN KEY (IdEmp) REFERENCES Empleado
GO
ALTER TABLE Pedidos
ADD FOREIGN KEY (idDoc) REFERENCES TipoDocumento
GO
ALTER TABLE Pedidos
ADD FOREIGN KEY (idOpe) REFERENCES TipoOperacion
GO
ALTER TABLE Despachos
ADD FOREIGN KEY (idDoc) REFERENCES TipoDocumento
GO
ALTER TABLE Despachos
ADD FOREIGN KEY (idOpe) REFERENCES TipoOperacion
GO
ALTER TABLE Producto
ADD FOREIGN KEY (IdCat) REFERENCES Categoria
GO
ALTER TABLE Producto
ADD FOREIGN KEY (IdUni) REFERENCES UnidadMedida
GO
ALTER TABLE Producto
ADD FOREIGN KEY (IdMer) REFERENCES TipoExistencia
GO
ALTER TABLE Producto
ADD FOREIGN KEY (idAlm) REFERENCES Almacen
GO
ALTER TABLE Proveedor
ADD FOREIGN KEY (CodDis) REFERENCES Distrito
GO
ALTER TABLE DetallePedidos
ADD FOREIGN KEY (IdPro) REFERENCES Producto
GO
ALTER TABLE DetallePedidos
ADD FOREIGN KEY (IdPedido) REFERENCES Pedidos
GO
ALTER TABLE DetalleDespacho
ADD FOREIGN KEY (IdPro) REFERENCES Producto
GO
ALTER TABLE DetalleDespacho
ADD FOREIGN KEY (IdDes) REFERENCES Despachos
GO
-------PROCEDIMIENTOS ALMACENADOS[MANTENIMIENTO]------------

CREATE PROCEDURE USP_ValidarUsuario
(
@nom varchar(50),
@con varchar(50)
)
AS
 SELECT IdUsu,LogUsu,PasUsu
 FROM Usuario
 where LogUsu=@nom and PasUsu = @con

 EXECUTE USP_ValidarUsuario 'Gustavo02','Valerio02'
GO
------USP ALMACEN----------------
CREATE PROCEDURE USP_ListarAlmacen
(@idAlm int =0)
as
begin
	if(@idAlm = 0)
		begin
			select * from Almacen order by IdAlm desc
		END
	ELSE
		BEGIN
			SELECT *  FROM Almacen
			Where IdAlm=@idAlm
		end
end
GO
CREATE PROCEDURE USP_AgregarAlmacen
(
	@idAlm int output,
	@nomAlm varchar(50),
	@desAlm varchar(50),
	@ubiAlm varchar(50),
	@activo bit
)
AS
	BEGIN
		INSERT INTO Almacen
		VALUES (@nomAlm,@desAlm,@ubiAlm,@activo)
		SET @idAlm = @@IDENTITY
		RETURN @idAlm
	END
GO
CREATE PROCEDURE USP_ActualizarAlmacen
(
	@idAlm int ,
	@nomAlm varchar(50),
	@desAlm varchar(50),
	@ubiAlm varchar(50),
	@activo bit
)
AS
	BEGIN
		UPDATE Almacen
		SET NomAlm = @nomAlm,
			DesAlm = @desAlm,
			UbiAlm = @ubiAlm,
			Activo =  @activo
		WHERE IdAlm = @idAlm
	END
GO
CREATE PROCEDURE USP_EliminarAlmacen
(
	@idAlm int
)
AS
	BEGIN
		UPDATE Almacen SET Activo = 0 Where IdAlm = @idAlm
	END
GO

------USP PRODUCTOS ------------------------
ALTER PROCEDURE USP_ListarProducto
(@IdProducto int =0)
as
begin
	if(@IdProducto = 0)
		begin
			select * from Producto order by IdPro desc
		END
	ELSE
		BEGIN
			SELECT *  FROM Producto
			Where IdPro=@IdProducto
		end
end
GO
CREATE PROCEDURE USP_AgregarProducto
( 
	@idPro int output,
	@nomPro	nvarchar(200),
	@desPro nvarchar(200),
	@idCat int,
	@canxUniPro nvarchar(100),
	@preComPro decimal(10,2),
	@fecRegPro date,
	@stoPro int,
	@stoMinPro int,
	@stoMaxPro int,
	@idUni int,
	@idMer int,
	@activo bit
)

AS
BEGIN
	INSERT INTO Producto VALUES (@nomPro,@desPro,@idCat,
	@canxUniPro,@preComPro,@fecRegPro,@stoPro,@stoMinPro,@stoMaxPro,@idUni,@idMer,@activo)
	SET @idPro = @@IDENTITY
	RETURN @idPro
END
GO
ALTER PROCEDURE USP_ActualizarProducto
(
	@idPro int,
	@nomPro	nvarchar(200),
	@desPro nvarchar(200),
	@idCat int,
	@canxUniPro nvarchar(100),
	@preComPro decimal(10,2),
	@fecRegPro date,
	@stoPro int,
	@stoMinPro int,
	@stoMaxPro int,
	@idUni int,
	@idMer int,
	@activo bit
)
AS
	BEGIN
		UPDATE Producto
		SET NomPro = @nomPro,
			DesPro = @desPro,
			IdCat = @idCat,
			CanxUniPro = @canxUniPro,
			PreComPro = @preComPro,
			FecRegPro = @fecRegPro,
			StoPro = @stoPro,
			StoMinPro = @stoMinPro,
			StoMaxPro = @stoMaxPro,
			idMer = @idMer,
			IdUni = @idUni,
			Activo = @activo
		WHERE IdPro = @idPro
	END
GO
CREATE PROCEDURE USP_EliminarProducto
@idProd int
AS
	UPDATE Producto	SET Activo = 0 WHERE IdPro = @idProd
GO

------USP EMPLEADOS ------------------------
CREATE PROCEDURE USP_ListarEmpleado
(@IdEmp int =0)
as
begin
	if(@IdEmp = 0)
		begin
			select * from Empleado order by 1
		END
	ELSE
		BEGIN
			SELECT *  FROM Empleado
			Where IdEmp = @IdEmp
		end
End
GO
CREATE PROCEDURE USP_GuardarEmpleado
( 
	@idEmp int output ,
	@apePatEmp nvarchar(50),
	@apeMatEmp nvarchar(50),
	@nomEmp nvarchar(50),
	@fecNacEmp		Date ,
	@fecIngEmp		date,
	@SexEmp char(1),
	@telEmp int,
	@celEmp int,
	@corEmp varchar(200),
	@obsEmp varchar,
	@idDis int,
	@idCar int,
	@idAre int,
	@activo		bit
)

AS
BEGIN
	INSERT INTO Empleado(ApePatEmp,ApeMatEmp,NomEmp,FecNacEmp,FecIngEmp,SexEmp,TelEmp,
	CelEmp,CorEmp,ObsEmp,DisEmp,CarEmp,AreEmp,Activo)
	Values(@apePatEmp,@apeMatEmp,@nomEmp,@fecNacEmp,@fecIngEmp,@SexEmp,@telEmp,@celEmp,@corEmp,
	@obsEmp,@idDis,@idCar,@idAre,@activo)

	SET @idEmp = @@IDENTITY
	return @IdEmp
END
GO
create PROCEDURE USP_ActualizarEmpleado
@idEmp int ,
	@idCar int,
	@apePatEmp nvarchar(50),
	@apeMatEmp nvarchar(50),
	@nomEmp nvarchar(50),
	@fecNacEmp		Date ,
	@fecIngEmp		date,
	@idDis int,
	@telEmp int,
	@celEmp int,
	@corEmp varchar(200),
	@obsEmp varchar,
	@activo		bit
AS
BEGIN 
	UPDATE Empleado 
	SET
	CarEmp = @idCar,
	ApePatEmp=@apePatEmp,
	ApeMatEmp=@apeMatEmp,
	NomEmp=@nomEmp,
	FecNacEmp=@fecNacEmp,
	FecIngEmp=@fecIngEmp,
	DisEmp=@idDis,
	TelEmp=@telEmp,
	CelEmp=@celEmp,
	CorEmp=@corEmp,
	ObsEmp=@obsEmp,
	Activo=@activo
	WHERE IdEmp = @idEmp
END
GO
CREATE PROCEDURE USP_EliminarEmpleado
@idEmp int
AS
	BEGIN
		UPDATE Empleado SET Activo = 0 WHERE IdEmp = @idEmp
	END
GO

-----USP PROVEEDOR -----------------------
CREATE PROCEDURE USP_ListarProveedor
(@IdProv int =0)
as
begin
	if(@IdProv = 0)
		begin
			select * from Proveedor order by 1
		END
	ELSE
		BEGIN
			SELECT *  FROM Proveedor
			Where IdProv = @IdProv
		end
End

go
CREATE PROCEDURE USP_ListarCategoria
(@IdcCat int =0)
as
begin
	if(@IdcCat = 0)
		begin
			select * from Categoria order by 1
		END
	ELSE
		BEGIN
			SELECT *  FROM Categoria
			Where IdCat = @IdcCat
		end
End
GO
CREATE PROCEDURE USP_AgregarProveedor 
(
	@idProv int output,
	@rucCom int,
	@nomCom varchar(200),
	@nomCon varchar(200),
	@apePatCon varchar(50),
	@apeMatCon varchar(50),
	@carCon varchar(200),
	@dirPro varchar(500),
	@celPro int,
	@corPro varchar(200),
	@fecRegPro date,
	@codDis int,
	@activo bit
)
AS
	BEGIN
		INSERT INTO Proveedor
		VALUES(@rucCom,@nomCom,@nomCon,@apePatCon,
		@apeMatCon,@carCon,@dirPro,@celPro,@corPro,
		@fecRegPro,@codDis,@activo)
		SET @idProv = @@identity
		RETURN @idProv
	END
GO
CREATE PROCEDURE USP_ActualizarProveedor 
(
	@idPro int,
	@rucCom int,
	@nomCom varchar(200),
	@nomCon varchar(200),
	@apePatCon varchar(50),
	@apeMatCon varchar(50),
	@carCon varchar(200),
	@dirPro varchar(500),
	@celPro int,
	@corPro varchar(200),
	@fecRegPro date,
	@codDis int,
	@activo bit
)
AS
	BEGIN
		UPDATE Proveedor
		SET RucCom= @rucCom,
			NomCom=	@nomCom,
			NomCon=	@nomCon,
			ApePatCon=	@apePatCon,
			ApeMatCon=	@apeMatCon,
			CarCon=	@carCon,
			DirPro=	@dirPro,
			CelPro=	@celPro,
			CorPro=	@corPro,
			FecRegPro=	@fecRegPro,
			CodDis=	@codDis,
			Activo=	@activo
		WHERE IdProv = @idPro
	END
GO
CREATE PROCEDURE USP_EliminarProveedor
@idPro int
AS
	BEGIN
		UPDATE Proveedor SET Activo = 0 WHERE IdProv = @idPro
	END
GO

-----USP DISTRITO-----------------------
CREATE PROCEDURE USP_ListarDistrito
(@IdDis int =0)
as
begin
	if(@IdDis = 0)
		begin
			select * from Distrito order by 1
		END
	ELSE
		BEGIN
			SELECT *  FROM Distrito
			Where IdDis = @IdDis
		end
End
GO
CREATE PROCEDURE USP_AgregarDistrito
(
	@nomDis varchar(100),
	@conDis varchar(50),
	@activo bit
)
AS
	BEGIN
	INSERT INTO Distrito VALUES(@nomDis,@conDis,@activo)
	END
GO
CREATE PROCEDURE USP_ActualizarDistrito
(
	@idDis int,
	@nomDis varchar(100),
	@conDis varchar(50),
	@activo bit
)
AS
	BEGIN
	UPDATE Distrito 
		SET NomDis = @nomDis,
			ConDis = @conDis,
			Activo = @activo

		WHERE IdDis = @idDis
	END
GO
CREATE PROCEDURE USP_EliminarDistrito
@idDis int
AS
	BEGIN
		UPDATE Distrito set Activo = 0 WHERE IdDis = @idDis
	END
GO

-----USP PEDIDOS -----------------------

-----USP DESPACHO ----------------------

-----USP CATEGORIA ---------------------
CREATE PROCEDURE USP_ListarCategoria
@idCat int = 0
AS
	BEGIN
		IF(@idCat = 0)
			BEGIN
				SELECT * FROM Categoria ORDER BY 1
			END
		ELSE
			BEGIN
				SELECT * FROM Categoria WHERE IdCat = @idCat ORDER BY 1
			END
	END
GO
CREATE PROCEDURE USP_AgregarCategoria
(
	@idCat int OUTPUT,
	@nomCat varchar(50),
	@desCat varchar(500),
	@activo bit
)
AS
	BEGIN
		INSERT INTO Categoria VALUES (@nomCat,@desCat,@activo)
		SET @idCat = @@IDENTITY
		RETURN @idCat
	END
GO
Create PROCEDURE USP_ActualizarCategoria
(
	@idCat int,
	@nomCat varchar(50),
	@desCat varchar(500),
	@activo bit
)
AS
	BEGIN
	UPDATE Categoria 
		SET NomCat = @nomCat,
			DesCat = @desCat,
			Activo = @activo

		WHERE IdCat = @idCat
	END
GO
CREATE PROCEDURE USP_EliminarCategoria
@idCat int 
AS
	BEGIN
	UPDATE Categoria SET Activo = 0 WHERE IdCat = @idCat
	END
GO
-----USP CARGO -------------------------
CREATE PROCEDURE USP_ListarCargo
@idCar int =0
AS 
	BEGIN 
		IF(@idCar = 0)
			BEGIN
				SELECT * FROM Cargo ORDER BY 1
			END
		ELSE
			BEGIN
				SELECT * FROM Cargo WHERE IdCar = @idCar order by 1
			END
	END
GO
CREATE PROCEDURE USP_AgregarCargo
(
	@idCar int OUTPUT,
	@nomCar varchar(150),
	@desCar varchar(200),
	@activo bit
)
AS
	BEGIN
		INSERT INTO Cargo VALUES(@idCar,@nomCar,@desCar,@activo)
		SET @idCar = @@IDENTITY
		return @idCar
	END
GO
CREATE PROCEDURE USP_ActualizarCargo
(
	@idCar int OUTPUT,
	@nomCar varchar(150),
	@desCar varchar(200),
	@activo bit
)
AS
	BEGIN
		UPDATE Cargo 
			SET NomCar = @nomCar,
				DesCar = @desCar,
				Activo = @activo

			WHERE IdCar = @idCar
	END
GO
CREATE PROCEDURE USP_EliminarCargo
@idCar int
AS
	BEGIN
		UPDATE Cargo SET Activo = 0 WHERE IdCar = @idCar
	END
GO
-----USP AREA --------------------------
CREATE PROCEDURE USP_ListarArea
(@IdArea int =0)
as
begin
	if(@IdArea = 0)
		begin
			select * from Area order by 1
		END
	ELSE
		BEGIN
			SELECT *  FROM Area
			Where IdAre = @IdArea
		end
End
GO
CREATE PROCEDURE USP_AgregarArea
(
	@idArea int output,
	@nomArea varchar(50),
	@activo bit
)
AS
	BEGIN 
		INSERT INTO Area values(@nomArea,@activo)
		SET @idArea = @@IDENTITY
		RETURN @idArea
	END
GO
CREATE PROCEDURE USP_ActualizarArea
(
	@idAre int,
	@nomArea varchar(50),
	@activo bit
)
AS
	BEGIN 
		UPDATE Area 
			SET NomAre = @nomArea,
				Activo = @activo
			
			WHERE IdAre = @idAre
	END
GO
CREATE PROCEDURE USP_EliminarArea
@idAre int
AS
	BEGIN
		UPDATE Area SET Activo = 0 WHERE IdAre = @idAre
	END
GO
-------USP TIPO DE EXISTENCIA------
CREATE PROCEDURE USP_ListarTipoExistencia
@idTipoExistencia int = 0
AS
	BEGIN
		if(@idTipoExistencia = 0)
		begin
			select * from TipoExistencia where Activo = 1 order by 1
		END
	ELSE
		BEGIN
			SELECT *  FROM TipoExistencia
			Where idMer = @idTipoExistencia and Activo = 1
		end
	END
GO
CREATE PROCEDURE USP_AgregarTipoExistencia
(
	@idMer int output,
	@nomMer varchar(100),
	@activo bit
)
AS
	BEGIN
		INSERT INTO TipoExistencia
		VALUES(@nomMer,@activo)

		SET @idMer =@@IDENTITY;
		RETURN @idMer
	END
GO
CREATE PROCEDURE USP_ActualizarTipoExistencia
(
	@idTipoExistencia int,
	@nomMer varchar(100),
	@activo bit
)
AS
	BEGIN
		UPDATE TipoExistencia 
		SET nomMer = @nomMer,
			activo = @activo
		WHERE idMer = @idTipoExistencia
	END
GO
CREATE PROCEDURE USP_EliminarTipoExistencia
(
	@idTipoExistencia int
)
AS
	BEGIN
		UPDATE TipoExistencia
		SET activo = 0
		WHERE idMer = @idTipoExistencia
	END
GO
-------USP TIPO DE DOCUMENTO------
CREATE PROCEDURE USP_ListarTipoDocumento
@idTipoDocumento int = 0
AS
	BEGIN
		IF(@idTipoDocumento = 0)
			BEGIN
				SELECT * FROM TipoDocumento WHERE activo = 1
			END
		ELSE
			BEGIN
				SELECT * FROM TipoDocumento 
				WHERE @idTipoDocumento = idDoc and activo = 1
			END
	END
GO
CREATE PROCEDURE USP_AgregarTipoDocumento
(
	@idDoc int output,
	@nomDoc varchar(100),
	@activo bit
)
AS
	BEGIN
	INSERT INTO TipoDocumento VALUES (@nomDoc,@activo)
	SET @idDoc = @@IDENTITY;
	RETURN @idDoc
	END
GO
CREATE PROCEDURE USP_ActualizarTipoDocumento
(
	@idDoc int ,
	@nomDoc varchar(100),
	@activo bit
)
AS
	BEGIN
		UPDATE TipoDocumento
		SET nomDoc = @nomDoc,
			activo = @activo
			WHERE idDoc = @idDoc
	END
GO
CREATE PROCEDURE USP_EliminarTipoDocumento
(
	@idDoc int
)
AS
	BEGIN
		UPDATE TipoDocumento
		SET activo = 0
		WHERE idDoc = @idDoc
	END
GO

-------USP TIPO DE OPERACION------

CREATE PROCEDURE USP_ListarTipoOperacion 
(
	@idTipoOperacion int  = 0
)
AS
	BEGIN
		IF(@idTipoOperacion = 0)
		BEGIN
			SELECT * FROM TipoOperacion WHERE activo = 1 Order BY 1
		END
		ELSE
		BEGIN
			SELECT * FROM TipoOperacion WHERE activo = 1 and idOpe = @idTipoOperacion
		END
	END
GO
CREATE PROCEDURE USP_AgregarTipoOperacion
(
	@idOpe int output,
	@nomOpe varchar(100),
	@activo bit
)
AS
	BEGIN
	INSERT INTO TipoOperacion VALUES(@nomOpe,@activo)
	SET @idOpe = @@IDENTITY;
	RETURN @idOpe
	END
GO
CREATE PROCEDURE USP_ActualizarTipoOperacion
(
	@idOpe int,
	@nomOpe varchar(100),
	@activo bit
)
AS
	BEGIN
		UPDATE TipoOperacion
		SET nomOpe = @nomOpe,
			activo = @activo
		WHERE idOpe = @idOpe
	END
GO
CREATE PROCEDURE USP_EliminarTipoOperacion 
(
	@idOpe int
)
AS
	BEGIN
	UPDATE TipoOperacion SET activo = 0 WHERE idOpe = @idOpe
	END
GO

-------USP UNIDAD MEDIDA------
CREATE PROCEDURE USP_ListarUnidadMedida 
(
	@idUnidadMedida int = 0
)
AS
	BEGIN
		IF(@idUnidadMedida  = 0)
			BEGIN
			SELECT * FROM UnidadMedida WHERE activo = 1 ORDER BY 1
			END
		ELSE
			BEGIN
				SELECT * FROM UnidadMedida WHERE idUni = @idUnidadMedida and activo = 1
			END
	END
GO
CREATE PROCEDURE USP_AgregarUnidadMedida
(
	@idUni int output,
	@nomUni varchar(100),
	@activo bit
)
AS
	BEGIN
		INSERT INTO UnidadMedida VALUES(@nomUni,@activo)
		SET @idUni = @@IDENTITY;
		RETURN @idUni 
	END
GO
CREATE PROCEDURE USP_ActualizarUnidadMedida
(
	@idUni int,
	@nomUni varchar(100),
	@activo bit
)
AS
	BEGIN
		INSERT INTO UnidadMedida VALUES(@nomUni,@activo)
		SET @idUni = @@IDENTITY;
		RETURN @idUni 
	END
GO
CREATE PROCEDURE USP_EliminarUnidadMedida
(
	@idUni int
)
AS
	BEGIN
		UPDATE UnidadMedida
		SET activo = 0
		WHERE idUni = @idUni
	END
GO


CREATE PROCEDURE USP_ListarEmpleado02
AS
SELECT * FROM Empleado
ORDER BY CarEmp,ApePatEmp
GO

CREATE PROCEDURE USP_ListarProveedor02
AS
	SELECT * FROM Proveedor
	ORDER BY FecRegPro
GO
CREATE PROCEDURE USP_ListarProducto02
AS
	SELECT * FROM Producto
	ORDER BY NomPro
GO

--------------USP CONSULTAS -------------------------
--CONSULTA PRODUCTOS POR CATEGORIA ----------
CREATE PROCEDURE USP_ListarCategoria
AS
	SELECT * FROM Producto 
GO
CREATE PROCEDURE USP_ListarProductoxCategoria 
@IdCat int
AS
	BEGIN
		SELECT * FROM Producto WHERE idCat = @IdCat
	END
GO
--CONSULTA BUSCAR EMPLEADO---
ALTER PROCEDURE USP_BuscarEmpleado
(
	@nomEmpleado varchar(50) = ''
)
AS
	BEGIN
		SELECT * FROM Empleado WHERE NomEmp LIKE @nomEmpleado+'%'
									or ApePatEmp LIKE @nomEmpleado+'%' 
									or ApeMatEmp LIKE @nomEmpleado+'%'
	END
GO
 
EXECUTE USP_BuscarEmpleado 
SELECT * FROM Empleado
DELETE FROM Pedidos
DELETE FROM DetallePedidos
--COMO REINICIAR EL IDENTITY--
DBCC CHECKIDENT('Empleado',reseed,0)
go

Set identity_insert Empleado On
go

CREATE PROCEDURE USP_ReporteEmpleadoxArea
(
	@NomAre varchar(100)
)
AS
	BEGIN
		select e.IdEmp as 'ID',e.ApePatEmp as'A. PATERNO',e.ApeMatEmp as'A. MATERNO',
		e.NomEmp as 'NOMBRE',e.FecNacEmp as 'F. NACIMIENTO',e.FecIngEmp as 'F. INGRESO',
		e.SexEmp as 'SEXO',e.TelEmp'TELEFONO',e.CelEmp as 'CELULAR',e.CorEmp as 'CORREO',
		e.ObsEmp as 'OBSERVACION',d.NomDis as 'DISTRITO',c.NomCar as 'CARGO',
		a.NomAre as'AREA',e.Activo as 'ACTIVO' 
		from Empleado e inner join Distrito d on e.IdDis=d.IdDis
		inner join Cargo c on e.IdCar = c.IdCar
		inner join Area a on e.IdAre=a.IdAre 
		where a.NomAre=@NomAre
	END
GO
