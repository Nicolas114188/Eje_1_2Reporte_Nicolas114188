CREATE DATABASE Facturacion_PII
GO

USE Facturacion_PII
GO
CREATE TABLE FormasPagos
(
	id_forma_pago int,
	forma_pago varchar(50),
	CONSTRAINT pk_formaPago PRIMARY KEY(id_forma_pago)
);
CREATE TABLE Facturas
(
	nroFactura int,
	fecha datetime,
	formaPago int,
	cliente varchar(100),
	CONSTRAINT pk_factura PRIMARY KEY(nroFactura),
	CONSTRAINT fk_formaPago FOREIGN KEY(formaPago)
			      REFERENCES FormasPagos(id_forma_pago)
);
CREATE TABLE Articulos
(
	id_articulo int,
	nombre varchar(100),
	precioUnitario decimal(10,2),
	stock int,
	CONSTRAINT pk_articulo PRIMARY KEY(id_articulo)
);
CREATE TABLE DetallesFacturas
(
	id_detalleFactura int IDENTITY (1, 1) NOT NULL,
	nroArticulo int,
	nroFactura int,
	cantidad int,
	precio decimal(10,2),
	CONSTRAINT pk_detalleFactura PRIMARY KEY(id_detalleFactura),
	CONSTRAINT fk_factura FOREIGN KEY(nroFactura)
			      REFERENCES Facturas(nroFactura),
	CONSTRAINT fk_articulo FOREIGN KEY(nroArticulo)
			      REFERENCES Articulos(id_articulo)
);
--formas de pago
INSERT INTO FormasPagos(id_forma_pago,forma_pago) VALUES(1,'Efectivo')
INSERT INTO FormasPagos(id_forma_pago,forma_pago) VALUES(2,'Tarjeta')
INSERT INTO FormasPagos(id_forma_pago,forma_pago) VALUES(3,'Transferencia')
INSERT INTO FormasPagos(id_forma_pago,forma_pago) VALUES(4,'QR')

--Articulos
INSERT INTO Articulos(id_articulo,nombre,precioUnitario,stock) VALUES(1,'Parlante con Bluetooth',4000,25)
INSERT INTO Articulos(id_articulo,nombre,precioUnitario,stock) VALUES(2,'Cargador portatil',1500,120)
INSERT INTO Articulos(id_articulo,nombre,precioUnitario,stock) VALUES(3,'Imanes de Recuerdo',1600,260)
INSERT INTO Articulos(id_articulo,nombre,precioUnitario,stock) VALUES(4,'Vaso de Recuerdo',2600,145)
INSERT INTO Articulos(id_articulo,nombre,precioUnitario,stock) VALUES(5,'Alfajores ArtesanalesX12',1800,200)
INSERT INTO Articulos(id_articulo,nombre,precioUnitario,stock) VALUES(6,'Audiculares',1200,300)

---CLIENTE 1---
INSERT INTO Facturas(nroFactura,fecha,formaPago,cliente) VALUES(1,GETDATE(),1,'NicoH')
INSERT INTO DetallesFacturas(nroArticulo,nroFactura,cantidad,precio)VALUES(5,1,1,1800)

CREATE PROC SP_INSERT_FACTURA
@nroFactura int,
@fecha datetime,
@formaPago int,
@cliente varchar(100)
AS
BEGIN
INSERT INTO Facturas(nroFactura,fecha,formaPago,cliente) 
				VALUES(@nroFactura,@fecha,@formaPago,@cliente)
END

CREATE PROC SP_INSERT_DetalleFactura
@nroArticulo int,
@nroFactura int,
@cantidad int,
@precio decimal(10,2)
AS
BEGIN
INSERT INTO DetallesFacturas(nroArticulo,nroFactura,cantidad,precio)
				VALUES(@nroArticulo,@nroFactura,@cantidad,@precio)
END

CREATE PROC SP_SELECT_FormaPago
AS
BEGIN
SELECT id_forma_pago, forma_pago
FROM FormasPagos
END

CREATE PROC SP_SELECT_Articulos
AS
BEGIN
SELECT id_articulo, nombre, precioUnitario
FROM Articulos
END

CREATE PROC SP_SELECT_DetalleFactura
AS
BEGIN
SELECT A.nombre'Articulo',A.precioUnitario'Precio Unitario',DF.cantidad 'Cantidad'
FROM DetallesFacturas DF
JOIN Articulos A ON DF.nroArticulo=A.id_articulo
END

CREATE PROC SP_SELECT_Factura
AS
BEGIN
SELECT * FROM Facturas
END

CREATE PROC SP_PROXIMO_ID
@next int OUTPUT
AS
BEGIN
SET @next =(SELECT MAX(nroFactura)+1 FROM Facturas)
END