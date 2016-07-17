--drop database DB_TSistemas--

create database DB_TSistemas
go

use DB_TSistemas
go

----*******************----
----*******************----

Create table tbl_Rol
(
int_IdRol int not null Identity,
vrch_Rol varchar(50),
CONSTRAINT PK_int_IdRol PRIMARY KEY NONCLUSTERED (int_IdRol)
)
GO

Create table tbl_Estado
(
int_IdEstado int Identity not null,
vrch_Estado varchar(50),
CONSTRAINT PK_int_IdEstado PRIMARY KEY NONCLUSTERED (int_IdEstado)
)
GO

Create table tbl_Marca
(
int_IdMarca int Identity not null,
vrch_Marca varchar(50),
CONSTRAINT PK_int_IdMarca PRIMARY KEY NONCLUSTERED (int_IdMarca)
)
GO

create table tbl_Proveedor
(
int_IdProveedor int identity not null,
vrch_Nombre varchar(50) not null,
vrch_Contacto varchar(50) not null,
vrch_Email varchar(50) not null,
vrch_Telefono varchar(20) not null,
int_IdEstado int not null,
CONSTRAINT PK_int_IdProveedor PRIMARY KEY NONCLUSTERED (int_IdProveedor),
CONSTRAINT FK_PROVEEDOR_ESTADO FOREIGN KEY (int_IdEstado) REFERENCES tbl_Estado(int_IdEstado)
)
GO

CREATE table tbl_Articulo
(
int_IdArticulo int IDENTITY not null,
vrch_Descripion varchar(50) not null,
mny_Precio money not null,
int_Cantidad int not null,
int_IdProveedor int not null,
int_IdMarca int not null,
int_IdEstado int not null,
int_PorcentajeGanacia int,
dtm_FechaIngeso datetime not null,
dtm_FechaVencimiento datetime,
CONSTRAINT PK_int_IdArticulo PRIMARY KEY NONCLUSTERED (int_IdArticulo),
CONSTRAINT FK_ARTICULO_ESTADO FOREIGN KEY (int_IdEstado) REFERENCES tbl_Estado(int_IdEstado),
CONSTRAINT FK_ARTICULO_MARCA FOREIGN KEY (int_IdMarca) REFERENCES tbl_Marca(int_IdMarca),
CONSTRAINT FK_ARTICULO_PROVEEDOR FOREIGN KEY (int_IdProveedor) REFERENCES tbl_Proveedor(int_IdProveedor)
)
GO

Create table tbl_Bodega
(
int_IdBodega int IDENTITY not null,
vrch_Nombre varchar(50),
vrch_Descripcion varchar(250),
CONSTRAINT PK_int_IdBodega PRIMARY KEY NONCLUSTERED (int_IdBodega)
)
GO

Create Table tbl_Inventario
(
int_IdInventario int Identity not null,
int_IdBodega int not null,
int_IdArticulo int not null,
CONSTRAINT PK_int_IdInventario PRIMARY KEY NONCLUSTERED (int_IdInventario),
CONSTRAINT FK_INVENTARIO_BODEGA FOREIGN KEY (int_IdBodega) REFERENCES tbl_Bodega(int_IdBodega),
CONSTRAINT FK_INVENTARIO_ARTICULO FOREIGN KEY (int_IdArticulo) REFERENCES tbl_Articulo(int_IdArticulo)
)
GO

Create table tbl_Sucursal
(
int_IdSucursal int Identity NOT NULL,
int_IdBodega int not null,
vrch_Nombre varchar(50),
CONSTRAINT PK_int_IdSucursal PRIMARY KEY NONCLUSTERED (int_IdSucursal),
CONSTRAINT FK_SUCURSAL_BODEGA FOREIGN KEY (int_IdBodega) REFERENCES tbl_Bodega(int_IdBodega)
)
GO

create table tbl_Puesto
(
int_IdPuesto int identity not null,
vrch_Descripcion varchar(50) not null,
CONSTRAINT PK_int_IdPuesto PRIMARY KEY NONCLUSTERED (int_IdPuesto)
)
GO

create table tbl_Empleado
(
int_IdEmpleado int Identity not null,
vrch_Nombre varchar(50) not null,
vrch_Apellido1 varchar(50) not null,
vrch_Apellido2 varchar(50) not null,
vrch_Cedula varchar(20) not null UNIQUE,
int_IdPuesto int not null,
vrch_Direccion varchar(50),
vrch_Telefono varchar(20),
vrch_Correo varchar(50) UNIQUE not null,
dtm_FechaNacimiento datetime,
dtm_FechaIngreso datetime,
CONSTRAINT PK_int_IdEmpleado PRIMARY KEY NONCLUSTERED (int_IdEmpleado),
CONSTRAINT FK_EMPLEADO_PUESTO FOREIGN KEY (int_IdPuesto) REFERENCES tbl_Puesto(int_IdPuesto)
)
GO

Create table tbl_Usuario
(
int_IdUsuario int Identity not null,
int_IdEmpleado int not null,
vrch_Usuario varchar(50) not null,
vrch_Clave varchar(20) not null,
int_Intentos int,
int_IdEstado int not null,
vrch_Email varchar(50),
int_IdRol int,
CONSTRAINT PK_int_IdUsuario PRIMARY KEY NONCLUSTERED (int_IdUsuario),
CONSTRAINT FK_USUARIO_ESTADO FOREIGN KEY (int_IdEstado) REFERENCES tbl_Estado(int_IdEstado),
CONSTRAINT FK_USUARIO_EMPLEADO FOREIGN KEY (int_IdEmpleado) REFERENCES tbl_Empleado(int_IdEmpleado),
CONSTRAINT FK_USUARIO_ROL FOREIGN KEY (int_IdRol) REFERENCES tbl_Rol(int_IdRol)
)
GO

create table tbl_Cliente
(int_IdCliente int Identity not null,
vrch_NumCedula varchar(20) UNIQUE,
vrch_Nombre varchar(50),
vrch_Correo varchar(50),
vrch_Telefono varchar(20),
int_IdEstado int not null,
CONSTRAINT PK_int_IdCliente PRIMARY KEY NONCLUSTERED (int_IdCliente),
CONSTRAINT FK_CLIENTE_ESTADO FOREIGN KEY (int_IdEstado) REFERENCES tbl_Estado(int_IdEstado)
)
GO

Create Table tbl_Mascota
(
int_IdMascota int Identity not null,
int_IdCliente int not null,
vrch_Nombre varchar(50) not null,
vrch_Especie varchar(50),
vrch_Raza varchar(50),
dtm_FechaNacimiento datetime,
int_IdEstado int not null,
CONSTRAINT PK_int_IdMascota PRIMARY KEY NONCLUSTERED (int_IdMascota),
CONSTRAINT FK_MASCOTA_ESTADO FOREIGN KEY (int_IdEstado) REFERENCES tbl_Estado(int_IdEstado)
)
GO

Create Table tbl_Vacuna
(
int_IdVacuna int Identity not null,
vrch_Nombre varchar(50),
vrch_Detalle varchar(MAX),
int_IdEstado int not null,
CONSTRAINT PK_int_IdVacuna PRIMARY KEY NONCLUSTERED (int_IdVacuna),
CONSTRAINT FK_VACUNA_ESTADO FOREIGN KEY (int_IdEstado) REFERENCES tbl_Estado(int_IdEstado)
)
GO

Create table tbl_Servicio
(
int_IdServicio int Identity not null,
vrch_Descripcion varchar(50),
mny_Precio money not null,
int_IdEstado int not null,
CONSTRAINT PK_int_IdServicio PRIMARY KEY NONCLUSTERED (int_IdServicio),
CONSTRAINT FK_SERVICIO_ESTADO FOREIGN KEY (int_IdEstado) REFERENCES tbl_Estado(int_IdEstado)
)

create table tbl_Factura
(
int_IdFactura int identity not null,
int_IdEmpleado int not null,
int_IdCliente int not null,
mny_Total money not null,
dtm_Fecha datetime not null,
CONSTRAINT PK_int_IdFactura PRIMARY KEY NONCLUSTERED (int_IdFactura),
CONSTRAINT FK_FACTURA_EMPLEADO FOREIGN KEY (int_IdEmpleado) REFERENCES tbl_Empleado(int_IdEmpleado),
CONSTRAINT FK_FACTURA_CLIENTE FOREIGN KEY (int_IdCliente) REFERENCES tbl_Cliente(int_IdCliente)
)
GO

Create table tbl_DetalleFactura
(
int_IdDetalleFactura int identity not null,
int_IdFactura int not null,
int_Linea int not null,
int_IdArticulo int,
int_IdServicio int,
int_Cantidad int not null,
mny_Monto money,
mny_Impuesto money,
int_Descuento int,
CONSTRAINT PK_int_IdDetalleFactura PRIMARY KEY NONCLUSTERED (int_IdDetalleFactura),
CONSTRAINT FK_DETFACT_FACTURA FOREIGN KEY (int_IdFactura) REFERENCES tbl_Factura(int_IdFactura),
CONSTRAINT FK_DETFACT_ARTICULO FOREIGN KEY (int_IdArticulo) REFERENCES tbl_Articulo(int_IdArticulo),
CONSTRAINT FK_DETFACT_SERVICIOS FOREIGN KEY (int_IdServicio) REFERENCES tbl_Servicio(int_IdServicio)
)
GO

Create table tbl_Caja
(
int_IdCaja int Identity not null,
int_IdEmpleado int not null,
int_IdFactura int,
mny_SaldoInicial money not null,
mny_SaldoFinal money,
dtm_Apertura datetime,
dtm_Cierre datetime,
CONSTRAINT PK_int_IdCaja PRIMARY KEY NONCLUSTERED (int_IdCaja),
CONSTRAINT FK_CAJA_EMPLEADO FOREIGN KEY (int_IdEmpleado) REFERENCES tbl_Empleado(int_IdEmpleado),
CONSTRAINT FK_CAJA_FACTURA FOREIGN KEY (int_IdFactura) REFERENCES tbl_Factura(int_IdFactura)
)
GO

Create table tbl_Devolucion
(
int_IdDevolucion int Identity not null,
int_IdDetalleFactura int not null,
int_IdEmpleado int not null,
int_Cantidad int not null,
mny_Total money,
vrch_Detalle varchar(250),
CONSTRAINT PK_int_IdDevolucion PRIMARY KEY NONCLUSTERED (int_IdDevolucion),
CONSTRAINT FK_DEVOLUCION_EMPLEADO FOREIGN KEY (int_IdEmpleado) REFERENCES tbl_Empleado(int_IdEmpleado),
CONSTRAINT FK_DEVOLUCION_DETFACT FOREIGN KEY (int_IdDetalleFactura) REFERENCES tbl_DetalleFactura(int_IdDetalleFactura)
)
GO

Create table tbl_Expediente
(
int_IdExpediente int Identity not null,
int_IdMascota int not null,
int_IdVacuna int,
int_IdFactura int,
vrch_Detalle nvarchar(MAX),
CONSTRAINT PK_int_IdExpediente PRIMARY KEY NONCLUSTERED (int_IdExpediente),
CONSTRAINT FK_EXPEDIENTE_FACTURA FOREIGN KEY (int_IdFactura) REFERENCES tbl_Factura(int_IdFactura),
CONSTRAINT FK_EXPEDIENTE_MASCOTA FOREIGN KEY (int_IdMascota) REFERENCES tbl_Mascota(int_IdMascota),
CONSTRAINT FK_EXPEDIENTE_VACUNA FOREIGN KEY (int_IdVacuna) REFERENCES tbl_Vacuna(int_IdVacuna)
)
GO

--

Create table tbl_Bitacora
(
int_IdBitacora int identity not null,
int_IdEmpleado int,
int_Movimiento int,
dtm_Fecha datetime not null,
vrch_Operacion varchar(15),
vrch_Usuario varchar(25),
vrch_Tabla varchar(25),
CONSTRAINT PK_int_IdBitacora PRIMARY KEY NONCLUSTERED (int_IdBitacora),
CONSTRAINT FK_BITACORA_EMPLEADO FOREIGN KEY (int_IdEmpleado) REFERENCES tbl_Empleado(int_IdEmpleado)
)

----*******************----
----*******************----
--Procedimientos de consulta
GO

CREATE PROCEDURE [dbo].[sp_ConsultarEmpleado]
AS
BEGIN

SELECT * FROM tbl_Empleado

END--Fin sp_ConsultarEmpleado
GO
--
CREATE PROCEDURE [dbo].[sp_ConsultarEmpleadoEspecifico]
(
@Consulta VARCHAR(50)
)
AS
BEGIN

SELECT * FROM tbl_Empleado WHERE vrch_Nombre LIKE '%'+@Consulta+'%'
OR vrch_Apellido1 LIKE '%'+@Consulta+'%' OR vrch_Apellido2 LIKE '%'+@Consulta+'%'
OR vrch_Cedula LIKE '%'+@Consulta+'%'

END--Fin sp_ConsultarEmpleado
GO
--
Create Procedure sp_ConsultarArticulo
(@IdArticulo int)
as
begin
Select a.int_IdArticulo as Codigo,a.vrch_Descripion as Descripcion,a.mny_Precio Precio,a.int_Cantidad as Cantidad,
p.vrch_Nombre as Proveedor, m.vrch_Marca as Marca, e.vrch_Estado as Estado,
a.int_PorcentajeGanacia as Ganacia, a.dtm_FechaIngeso as Ingreso, 
a.dtm_FechaVencimiento as Vencimiento from tbl_Articulo a
INNER JOIN tbl_Proveedor p
ON a.int_IdProveedor = p.int_IdProveedor
INNER JOIN tbl_Marca m
ON a.int_IdMarca = m.int_IdMarca
INNER JOIN tbl_Estado e
ON a.int_IdEstado = e.int_IdEstado
WHERE a.int_IdArticulo = @IdArticulo
end--Fin sp_ConsultarArticulo
GO
--

Create Procedure sp_ConsultarCliente
(
@Consulta varchar(50)
)
as
begin

Select * from tbl_Cliente where vrch_Nombre LIKE '%'+@Consulta+'%'
OR vrch_NumCedula LIKE '%'+@Consulta+'%' 
end--Fin sp_ConsultarCliente
GO
--

Create Procedure sp_ConsultarFactura
(
@IdFactura int
)
as
begin
Select f.int_IdFactura, f.mny_Total, f.dtm_Fecha, e.vrch_Nombre as Empleado,
c.vrch_Nombre as Cliente, a.int_IdArticulo, a.vrch_Descripion as Articulo, s.vrch_Descripcion as Servicio,
d.int_Cantidad, d.mny_Monto, d.mny_Impuesto,d.int_Descuento
From tbl_Factura f
INNER JOIN tbl_DetalleFactura d
ON f.int_IdFactura = d.int_IdFactura
INNER JOIN tbl_Empleado e
ON e.int_IdEmpleado = f.int_IdEmpleado
INNER JOIN tbl_Cliente c
ON c.int_IdCliente = f.int_IdCliente
INNER JOIN tbl_Articulo a
ON a.int_IdArticulo = d.int_IdArticulo
INNER JOIN tbl_Servicio s
ON s.int_IdServicio = d.int_IdServicio
where f.int_IdFactura = @IdFactura
end--Fin sp_ConsultarFactura
GO
--

Create Procedure sp_ConsultarBodega
(
@Id int
)
as
begin
	Select * from tbl_Bodega where int_IdBodega = @Id
end
GO
--

Create Procedure sp_ConsultarEstado
as
begin
Select * from tbl_Estado
end
GO
--

Create Procedure sp_ConsultarMarca
as
begin
	Select * from tbl_Marca
end
GO
--

Create Procedure sp_ConsultarMarcaEspecifica
(@id int)
as
begin
	Select * from tbl_Marca where int_IdMarca = @id
end
GO
--

Create Procedure sp_ConsultarProveedor
as
begin
	Select * from tbl_Proveedor
end
GO
--

Create Procedure sp_ConsultarProveedorEspecifico
(@id int)
as
begin
	Select * from tbl_Proveedor where int_IdProveedor = @id
end
GO
--

Create Procedure sp_ConsultarPuesto
as
begin
	Select * from tbl_Puesto
end
GO
--

Create Procedure sp_ConsultarPuestoEspecifico
(@id int)
as
begin
	Select * from tbl_Puesto where int_IdPuesto = @id
end
GO
--

Create Procedure sp_ConsultarServicio
as
begin
	select * from tbl_Servicio
end
GO
--

Create Procedure sp_ConsultarServicioEspecifico
(@id int)
as
begin
	select * from tbl_Servicio where int_IdServicio = @id
end
GO
--

Create Procedure sp_ConsultarVacuna
(@id int)
as
begin
	Select * from tbl_Vacuna where int_IdVacuna = @id
end
GO
--

----*******************----
----*******************----
--Procedimientos de inclusion
Create Procedure sp_AgregarArticulo
(
@Descripcion varchar(50),
@Precio money,
@Cantidad int,
@IdProveedor int,
@IdMarca int,
@IdEstado int,
@Porcentaje int,
@Ingreso datetime,
@Vencimiento datetime
)
as
begin

Insert into tbl_Articulo
(vrch_Descripion,mny_Precio,int_Cantidad,int_IdProveedor,int_IdMarca,
int_IdEstado,int_PorcentajeGanacia,dtm_FechaIngeso,dtm_FechaVencimiento)
values(@Descripcion,@Precio,@Cantidad,@IdProveedor,@IdMarca,@IdEstado,
@Porcentaje,@Ingreso,@Vencimiento)
end-- Fin sp_AgregarArticulo
GO
--

Create Procedure sp_AgregarBodega
(
@Nombre varchar(50),
@Descripcion varchar(250)
)
as
begin
Insert into tbl_Bodega(vrch_Nombre, vrch_Descripcion)
values(@Nombre, @Descripcion)
end-- fin sp_AgregarBodega
GO
--

Create procedure sp_AgregarCaja
(
@IdEmpleado int,
@IdFactura int,
@SaldoInicial money,
@SaldoFinal money,
@Apertura datetime,
@Cierre datetime
)
as
begin
	Insert into tbl_Caja(int_IdEmpleado,int_IdFactura,mny_SaldoInicial,mny_SaldoFinal
	,dtm_Apertura,dtm_Cierre)
	Values(@IdEmpleado,@IdFactura,@SaldoFinal,@SaldoFinal,@Apertura,@Cierre)
end--FIN tbl_AgregarCaja
GO

Create Procedure sp_AgregarDevolucion
(
@IdDetalleFactura int,
@IdEmpleado int,
@Cantidad int,
@Total money,
@Detalle varchar(250)
)
as
begin
	Insert into tbl_Devolucion(int_IdDetalleFactura,int_IdEmpleado,int_Cantidad,mny_Total,vrch_Detalle)
	values(@IdDetalleFactura,@IdEmpleado,@Cantidad,@Total,@Detalle)
end-- FIN sp_AgregarDevolucion
GO

--Este sirve tanto para inclir como para actualizar
Create procedure sp_AgregarCliente
(
@Cedula varchar(20),
@Nombre varchar(50),
@Correo varchar(50),
@Telefono varchar(20),
@Estado int
)
as
begin

IF EXISTS (Select vrch_NumCedula from tbl_Cliente where vrch_NumCedula = @Cedula)
BEGIN
UPDATE tbl_Cliente
SET vrch_Nombre = @Nombre, vrch_Correo = @Correo, vrch_Telefono = @Telefono, int_IdEstado = @Estado
WHERE vrch_NumCedula = @Cedula
END-- FIN IF EXISTS

IF NOT EXISTS (Select vrch_NumCedula from tbl_Cliente where vrch_NumCedula = @Cedula)
BEGIN
insert into tbl_Cliente(vrch_NumCedula,vrch_Nombre,vrch_Correo,vrch_Telefono,int_IdEstado)
values(@Cedula,@Nombre,@Correo,@Telefono,@Estado)
END-- FIN IF NOT EXISTS
end-- Fin sp_AgregarCliente
GO
--

Create Procedure sp_AgregarEmpleado
(
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@Cedula varchar(20),
@IdPuesto int,
@Direccion varchar(50),
@Telefono varchar(20),
@Correo varchar(50),
@Nacimiento datetime,
@ingreso datetime
)
as
begin
IF EXISTS(select vrch_Cedula from tbl_Empleado where vrch_Cedula = @Cedula)
begin
	Update tbl_Empleado
	set vrch_Nombre = @Nombre, vrch_Apellido1 = @Apellido1, vrch_Apellido2 = @Apellido2,
	int_IdPuesto = @IdPuesto, vrch_Direccion = @Direccion, vrch_Telefono = @Telefono,
	vrch_Correo = @Correo, dtm_FechaNacimiento = @Nacimiento, dtm_FechaIngreso = @ingreso
	where vrch_Cedula = @Cedula
end --FIN IF exists
else
begin
	Insert into tbl_Empleado
	(vrch_Nombre,vrch_Apellido1,vrch_Apellido2,vrch_Cedula,int_IdPuesto,vrch_Direccion,
	vrch_Telefono, vrch_Correo,dtm_FechaNacimiento,dtm_FechaIngreso)
	values(@Nombre,@Apellido1,@Apellido2,@Cedula,@IdPuesto,@Direccion,@Telefono,@Correo,
	@Nacimiento,@ingreso)
end--Fin Else
end--Fin sp_AgregarEmpleado
GO
--

Create Procedure sp_AgregarEstado
(
@Estado varchar(50)
)
as
begin
	insert into tbl_Estado(vrch_Estado)
	values(@Estado)
end -- Fin sp_AgregarEstado
GO

Create procedure sp_AgregarMarca
(
@Marca varchar(50)
)
as
begin
Insert into tbl_Marca(vrch_Marca)
Values(@Marca)
end --Fin sp_AgregarMarca
GO
--

Create procedure sp_AgregarMascota
(@IdCliente int,
@Nombre varchar(50),
@Especie varchar(50),
@Raza varchar(50),
@Nacimiento datetime,
@Estado int
)
as 
begin
Insert into tbl_Mascota(int_IdCliente,vrch_Nombre,vrch_Especie,vrch_Raza,dtm_FechaNacimiento,int_IdEstado)
values(@IdCliente,@Nombre,@Especie,@Raza,@Nacimiento,@Estado)
end-- Fin sp_AgregarMascota
GO
--

Create Procedure sp_AgregarProveedor
(
@Nombre varchar(50),
@Contacto varchar(50),
@Email varchar(50),
@Telefono varchar(20),
@Estado int
)
as
begin
	insert into tbl_Proveedor(vrch_Nombre,vrch_Contacto,vrch_Email,vrch_Telefono,int_IdEstado)
	values(@Nombre,@Contacto,@Email,@Telefono,@Estado)
end-- fin sp_AgregarProveedor
GO
--

Create Procedure sp_AgregarPuesto
(@Descripcion varchar(50))
as
begin
	Insert Into tbl_Puesto(vrch_Descripcion)
	values(@Descripcion)
end--Fin sp_AgregarPuesto
GO
--

Create Procedure sp_AgregarServicio
(
@Descripcion varchar(50),
@Precio money,
@Estado int
)
as
begin
	Insert into tbl_Servicio(vrch_Descripcion,mny_Precio,int_IdEstado)
	values(@Descripcion,@Precio,@Estado)
end--Fin sp_AgregarServicio
GO
--

Create Procedure sp_AgregarSucursal
(
@IdBodega int,
@Nombre varchar(50)
)
as
begin
	Insert Into tbl_Sucursal(int_IdBodega,vrch_Nombre)
	values(@IdBodega,@Nombre)
end--Fin sp_AgregarSucursal
GO
--

Create Procedure sp_AgregarVacuna
(
@Nombre varchar(50),
@Detalle varchar(MAX),
@Estado int
)
as
begin
	Insert into tbl_Vacuna(vrch_Nombre,vrch_Detalle,int_IdEstado)
	values(@Nombre,@Detalle,@Estado)
end--Fin sp_AgregarVacuna
GO

--

Create Procedure sp_AbrirCaja
(
@IdEmpleado int,
@SaldoInicial money,
@Apertura datetime
)
as
begin
	insert into tbl_Caja(int_IdEmpleado, mny_SaldoInicial,dtm_Apertura)
	values(@IdEmpleado,@SaldoInicial,@Apertura)
end
GO
--
Create procedure [dbo].[stp_Login]
(
@vrch_Usuario varchar(50),
@vrch_Clave varchar(50)
)
as
begin
	 
		select * from tbl_Usuario where vrch_Usuario = @vrch_Usuario and vrch_Clave =@vrch_Clave 
end
GO
--
CREATE Procedure [dbo].[stp_BorraIntentosFallidos]
(
	@vrch_Usuario varchar(50)
)
as
begin

	update tbl_Usuario
	set int_Intentos = 0 
	where vrch_Usuario = @vrch_Usuario
end	
GO
--
CREATE Procedure [dbo].[stp_RecuperarClave]
(
	@vrch_Usuario varchar(20)
)
as
begin
	select vrch_Usuario, vrch_clave, vrch_Email, int_Intentos from tbl_Usuario where vrch_Usuario = @vrch_Usuario
end
GO
--
Create Procedure stp_InfoUser
(@int_IdUsuario int)
as
begin
Select int_IdUsuario, vrch_Usuario, vrch_Clave from tbl_Usuario where int_IdUsuario = @int_IdUsuario
end
GO
--
Create Procedure stp_CargarId
(@vrch_Usuario varchar(50))
as
begin
Select int_IdUsuario from tbl_Usuario where vrch_Usuario = @vrch_Usuario
end
GO
--
CREATE Procedure [dbo].[stp_AumentaIntentosFallidos]
(
	@vrch_Usuario varchar(50)
)
as
begin
	
		update tbl_Usuario
	set int_Intentos = int_Intentos + 1 
	where vrch_Usuario = @vrch_Usuario
	
end
GO

--
Create Procedure stp_SeguridadMenu
(
	@IdUsuario int
)
as
begin
	Select int_IdRol from tbl_Usuario where int_IdUsuario = @IdUsuario
end
GO
--
/*
Create Procedure sp_CerrarCaja
(
@IdCaja int
)
as
begin
	
end
GO
*/
----*******************----
----*******************----
--Hago esta vista para poder correr la funcion que genera la clave aleatoria automatica
Create view vwRandom
as
Select RAND()as Rnd
GO 

--Luego ocupo una funcion para poder hacer la clave
CREATE FUNCTION fnCustomPass()
RETURNS VARCHAR(6)
AS
BEGIN    

    DECLARE @chars AS VARCHAR(52),
            @numbers AS VARCHAR(10),
            @strChars AS VARCHAR(62),        
            @strPass AS VARCHAR(62),
            @index AS INT,
            @cont AS INT,
            @size AS INT --Tamaño de la clave

	SET @size = 6
    SET @strPass = ''
    SET @strChars = ''    
    SET @chars = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
    SET @numbers = '0123456789'
    

    SET @strChars =  @chars + @numbers --Ambos (Letras y Números)

    SET @cont = 0
    WHILE @cont < @size
    BEGIN
        SET @index = ceiling( ( SELECT rnd FROM vwRandom ) * (len(@strChars)))--Uso de la vista para el Rand() y no generar error.
        SET @strPass = @strPass + substring(@strChars, @index, 1)
        SET @cont = @cont + 1
    END    
        
    RETURN @strPass

END--fin fnCustomPass
GO

--Triggers 
Create trigger tr_Usuario_I
on tbl_Empleado
after Insert
as
begin
	declare 
	@int_IdEmpleado int,
	@vrch_Nombre varchar(50),
	@vrch_Apellido1 varchar(50),
	@Clave varchar(6),
	@vrch_userName varchar(30),
	@vrch_Email varchar(50)

		select top 1 @int_IdEmpleado = int_IdEmpleado from tbl_Empleado order by int_IdEmpleado desc 

		select top 1 @vrch_Nombre = LOWER(SUBSTRING(vrch_Nombre,1,1)) from tbl_Empleado order by int_IdEmpleado desc 
		
		select top 1 @vrch_Apellido1 = LOWER(vrch_Apellido1) from tbl_Empleado order by int_IdEmpleado desc  
		
		select top 1 @vrch_Email = vrch_Correo from tbl_Empleado order by int_IdEmpleado desc 
								
		--Valido que el usuario no existe de lo contrario le pongo el id al final para que sea único
		IF EXISTS(Select vrch_Usuario from tbl_Usuario where @vrch_Nombre + @vrch_Apellido1 = vrch_Usuario)
		begin
			set @vrch_userName = @vrch_Nombre + @vrch_Apellido1 + CONVERT(varchar,@int_IdEmpleado)
		end -- FIN IF EXISTS
		
		Else
		begin
			set @vrch_userName = @vrch_Nombre + @vrch_Apellido1
		end-- Fin del else
			
		set @Clave	=  (SELECT [dbo].[fnCustomPass] ())
		select @Clave
				 
		insert into tbl_Usuario(int_IdEmpleado,vrch_Usuario,vrch_Clave,int_Intentos,int_IdEstado,vrch_Email) 
		values(@int_IdEmpleado, @vrch_userName,@Clave,0,1,@vrch_Email)

End-- FIN DEL TRIGGER

GO

---
--TRIGGERS DE BITACOTA
--
Create trigger tr_EmpleadoBitacora_I
ON tbl_Empleado
after insert
as
begin
	insert into tbl_Bitacora(dtm_Fecha,vrch_Operacion,vrch_Usuario,vrch_Tabla)
	values(GETDATE(),'INSERT',SUSER_NAME(),'tbl_Usuario')
end
--fin tr_EmpleadoBitacora_I
GO

Create trigger tr_EmpleadoBitacora_U
ON tbl_Empleado
after update
as
begin
	insert into tbl_Bitacora(dtm_Fecha,vrch_Operacion,vrch_Usuario,vrch_Tabla)
	values(GETDATE(),'UPDATE',SUSER_NAME(),'tbl_Usuario')
end
--fin tr_EmpleadoBitacora_U
GO

Create trigger tr_EmpleadoBitacora_D
ON tbl_Empleado
after delete
as
begin
	insert into tbl_Bitacora(dtm_Fecha,vrch_Operacion,vrch_Usuario,vrch_Tabla)
	values(GETDATE(),'DELETE',SUSER_NAME(),'tbl_Usuario')
end
--fin tr_EmpleadoBitacora_D
GO

Create trigger tr_FacturaBitacora_I
ON tbl_Factura
after insert
as
begin
	declare @idfact int, @idempl int
	
	select top 1 @idfact = int_IdFactura From tbl_Factura order by int_IdFactura desc
	
	select top 1 @idempl = int_IdEmpleado From tbl_Factura order by int_IdFactura desc
	
	insert into tbl_Bitacora(int_IdEmpleado,int_Movimiento,dtm_Fecha,vrch_Operacion,vrch_Usuario,vrch_Tabla)
	values(@idempl,@idfact,GETDATE(),'INSERT',SUSER_NAME(),'tbl_Usuario')
end
GO
--FIN tr_FacturaBitacora_I


----*******************----
----*******************----
-- Inserts necesarios para que no hayan conflictos por llaves foraneas
--EJECUTARLOS UNO POR UNO
/*
exec sp_AgregarPuesto 'Administrador'
GO

Exec sp_AgregarEstado 'Activo'
GO

Exec sp_AgregarEstado 'Inactivo'
GO

Exec sp_AgregarMarca 'Super Perro'
GO

Exec sp_AgregarMarca 'Ascan'
GO

Exec sp_AgregarBodega 'Comestibles', 'Aqui se almacenan solamente comestibles'
go

Exec sp_AgregarProveedor 'Colono','Juan Vargas','jvargas@colono.com','22225555',1
GO

Exec sp_AgregarPuesto 'Administrador'
GO

Exec sp_AgregarPuesto 'Cajero'
GO

Exec sp_AgregarServicio 'Consulta Medica',5000,1
GO

Exec sp_AgregarSucursal 1,'Central'
GO

exec sp_AgregarEmpleado 'A','DMIN','','0',1,'Central','22222222','teoriasistemasuam@gmail.com','',''
GO

insert into tbl_Rol(vrch_Rol)
values('Administrador')

insert into tbl_Rol(vrch_Rol)
values('Cajero')

insert into tbl_Rol(vrch_Rol)
values('Bodeguero')

insert into tbl_Rol(vrch_Rol)
values('Jefatura')

Update tbl_Usuario
set vrch_Clave = 'admin'
where vrch_Usuario = 'admin'

Update tbl_Usuario
set int_IdRol = 1
where vrch_Usuario = 'admin'

exec sp_AgregarEmpleado 'Carlos','Alfaro','Jaén','114070566',1,'San Jose','87042417','carlosaj07@gmail.com','',''
GO

select * from tbl_Usuario
*/
