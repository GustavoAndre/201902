USE BD_PROYECTO_FINAL_2019II
GO

--create proc USP_PRODUCTOS_LISTAR
--AS
--Select IdPro, NomPro
--From Producto Order by 2
--Go

create proc USP_EMPLEADOS_LISTAR
AS
Select IdEmp, Empleado=ApePatEmp+ ' '+NomEmp
From Empleado Order by 2
Go

ALTER Proc USP_DatosProducto 
@id int
As
	Select p.IdPro as 'ID',p.NomPro as 'PRODUCTO',p.DesPro as 'DESCRIPCION',c.NomCat as 'CATEGORIA',
	p.CanxUniPro as 'CANTIDAD POR UNIDAD',p.PreComPro as 'PRECIO DE COMPRA',p.FecRegPro as 'FECHA DE REGISTRO',
	p.StoPro as 'STOCK ACTUALES',p.StoMinPro as 'STOCK MINIMO',p.StoMaxPro as 'STOCK MAXIMO',u.nomUni as 'UNIDAD DE MEDIDA',
	e.nomMer as 'TIPO DE EXISTENCIA',p.Activo as 'ESTADO'
	From Producto p inner join Categoria c on p.IdCat=c.IdCat
	inner join UnidadMedida u on p.IdUni=u.idUni
	inner join TipoExistencia e on p.IdMer=e.idMer
	Where IdPro=@id
Go
ALTER PROCEDURE USP_ListarPedidosDelDia 
AS
	BEGIN
		SELECT * FROM Pedidos WHERE FecPed = convert(date,GETDATE()) order by IdPedido desc
	END
GO

ALTER PROCEDURE USP_ListarDespachosDelDia 
AS
	BEGIN
		SELECT de.IdDes as'ID',e.NomEmp as 'EMPLEADO',e.IdEmp as 'ID EMPLEADO',
		de.FecDes as 'FECHA DE DESPACHO',doc.nomDoc as 'TIPO DE DOCUMENTO',
		o.nomOpe as 'TIPO DE OPERACION',de.Activo 
		FROM Despachos de inner join Empleado e on de.IdEmp=e.IdEmp
		inner join TipoDocumento doc on de.idDoc=doc.idDoc
		inner join TipoOperacion o on de.idOpe=o.idOpe
		WHERE FecDes = convert(date,GETDATE()) order by IdDes desc
	END
GO

ALTER PROCEDURE USP_AdicionarPedido
@IdPed int output,
@IdProv int,
@IdEmp int,
@FecPed SmallDateTime,
@IdDoc int,
@IdOpe int,
@Activo bit
AS
Insert Into Pedidos (IdProv,IdEmp, FecPed,idDoc,idOpe,Acivo)
Values(@IdProv,@IdEmp,@FecPed,@IdDoc,@IdOpe,@Activo)
Set @IdPed=@@Identity;
Return @IdPed
Go
ALTER PROCEDURE USP_AdicionarDespacho
@IdDes int output,
@IdEmp int,
@FecDes SmallDateTime,
@idDoc int,
@idOpe int,
@activo bit
AS
	BEGIN
		INSERT INTO Despachos(IdEmp,FecDes,idDoc,idOpe,Activo)VALUES(@IdEmp,@FecDes,@idDoc,@idOpe,@activo)
		SET @IdDes = @@IDENTITY;
		RETURN @IdDes	
	END
GO
ALTER PROCEDURE USP_AdicionarDetalle
@IdPed int,
@IdProd int,
@Can smallint,
@precompra decimal(10,2),
@idMer int,
@idUni int,
@activo bit
As
Insert Into DetallePedidos(IdPedido, IdPro,Cantidad,PreCompra,idMer,idUni,Activo)
Values(@IdPed,@IdProd,@Can,@precompra,@idMer,@idUni,@activo)
GO
CREATE PROCEDURE USP_AdicionarDetalleDespacho
@IdDes int,
@IdPro int,
@Cantidad smallint,
@Precompra decimal(10,2),
@idMer int,
@idUni int,
@activo bit
As
Insert Into DetalleDespacho(IdDes,IdPro,Cantidad,PreCompra,idMer,idUni,Activo)
Values(@IdDes,@IdPro,@Cantidad,@precompra,@idMer,@idUni,@activo)
GO
CREATE PROCEDURE USP_ActualizarStock
@idProd int,
@can smallint
As
Update Producto set StoPro=StoPro-@can
Where IdPro=@idProd
Go

select * from Despachos
select * from DetalleDespacho
ALTER TABLE DetallePedidos
ADD Activo bit
