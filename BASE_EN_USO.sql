create database BasedeDatosMansStyle

use BasedeDatosMansStyle


-- Creaci�n de la tabla Sucursal
CREATE TABLE Sucursal (

    ID_Sucursal INT PRIMARY KEY IDENTITY(1,1), 
    Nombre NVARCHAR(100) NOT NULL,
    Direccion NVARCHAR(150) NOT NULL,
	Estado INT
);

INSERT INTO Sucursal(Nombre, Direccion, Estado)
VALUES 
('Variedades Mans Style', 'Unidad de proposito terminal de la ruta 105, Managua, Nicaragua', 1),
('Variedades Mans Style', 'Las Am�ricas #2 frente al parque del grupo A, camino hacia la terminal de la 114 y 170', 1);


-- Tabla de roles

CREATE TABLE Rol(ID_Rol INT PRIMARY KEY, 
				Puesto VARCHAR(40)
				)

INSERT INTO Rol(ID_Rol, Puesto)
VALUES  (0, 'Empleado'), (1, 'Administrador')
		

-- Creaci�n de la tabla Vendedor

CREATE TABLE Vendedor (

    ID_Vendedor INT PRIMARY KEY IDENTITY(1,1),
	ID_Rol INT,
	FOREIGN KEY (ID_Rol) REFERENCES Rol(ID_Rol),
    Nombre VARCHAR(100) NOT NULL,
    Cedula NVARCHAR(20),
    Edad Date,
	Usuario NVARCHAR(50),
	contra NVARCHAR(20),
	ID_Sucursal INT,
    FOREIGN KEY (ID_Sucursal) REFERENCES Sucursal(ID_Sucursal),
	Estado INT

);


INSERT INTO Vendedor(ID_Rol, Nombre, Cedula, Edad, Usuario, contra, ID_Sucursal, Estado)
VALUES 
(1, 'Kleyber Parrales', '001-K', '2000-03-11', 'AdminKleyber' , '123', 1, 1),
(0, 'Ares Stanley', '001-A', '2002-01-01', 'VendedorAres' , '321', 2, 1);



-- Creaci�n de la tabla Cliente

CREATE TABLE Cliente (

    ID_Cliente INT PRIMARY KEY IDENTITY (1,1),
    Nombre NVARCHAR(100) NOT NULL,
	Estado INT

);

INSERT INTO Cliente (Nombre, Estado) 
VALUES ('Cliente 1', 1), 
('Cliente 2', 1), 
('Cliente 3', 1), 
('Cliente 4', 1), 
('Cliente 5', 1), 
('Cliente 6', 1), 
('Cliente 7', 1), 
('Cliente 8', 1), 
('Cliente 9', 1), 
('Cliente 10', 1);


-- Creaci�n de la tabla Categoria

CREATE TABLE Categoria(
    ID_Categoria INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
	Estado INT
);

INSERT INTO Categoria(Nombre, Estado)
VALUES 
('Cosmeticos', 1),
('Electronica', 1);



 -- DE AQUI PARA ABAJO FALTAN CREAR TABLAS

-- Creaci�n de la tabla Producto
CREATE TABLE Producto (

    ID_Producto INT PRIMARY KEY IDENTITY (1,1),
    ID_Categoria INT,
    FOREIGN KEY (ID_Categoria) REFERENCES Categoria(ID_Categoria),
    Nombre NVARCHAR(100) NOT NULL,
    Marca NVARCHAR(50),
    Cantidad INT,
    Precio_Compra DECIMAL(10, 2),
    Precio_Producto DECIMAL(10, 2),
    ID_Sucursal INT,
    FOREIGN KEY (ID_Sucursal) REFERENCES Sucursal(ID_Sucursal),
	DetalleS VARCHAR(200),
	Estado INT
);

INSERT INTO Producto (ID_Categoria, Nombre, Marca, Cantidad, Precio_Compra, Precio_Producto, ID_Sucursal, Detalles, Estado) 
VALUES (1, 'Camiseta', 'Marca A', 50,								10.00, 20.00, 1, 'Camiseta de algod�n, talla M', 1), 
(2, 'Perfume', 'Marca B', 30,										25.00, 50.00, 2, 'Fragancia floral, 50ml', 1), 
(2, 'Auriculares', 'Marca C', 20,									15.00, 30.00, 1, 'Auriculares con cancelaci�n de ruido', 1), 
(1, 'Pantalones', 'Marca D', 40,									20.00, 40.00, 2, 'Pantalones de mezclilla, talla L', 1), 
(2, 'Labial', 'Marca E', 60,										5.00, 15.00, 1, 'Labial rojo, larga duraci�n', 1), 
(1, 'Cargador', 'Marca F', 70,										8.00, 20.00, 2, 'Cargador r�pido, 2A', 1), 
(1, 'Zapatos', 'Marca G', 35,										30.00, 60.00, 1, 'Zapatos de cuero, talla 42', 1), 
(2, 'Crema', 'Marca H', 45,											10.00, 25.00, 2, 'Crema hidratante, 100ml', 1), 
(2, 'Mouse', 'Marca I', 25,											12.00, 25.00, 1, 'Mouse ergon�mico, inal�mbrico', 1), 
(1, 'Chaqueta', 'Marca J', 15,										50.00, 100.00, 2, 'Chaqueta impermeable, talla XL', 1);


-- Creaci�n de la tabla Compra_Entrada (relaci�n muchos a muchos entre Proveedor y Producto)
CREATE TABLE Compra_Entrada (
    ID_Entrada INT PRIMARY KEY IDENTITY (1,1),
	Estado INT,
    ID_Producto INT,
    Fecha_Compra DATE,
	Precio_Compra decimal,
	CantidadCompra int,
    FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto)
);

INSERT INTO Compra_Entrada (Estado, ID_Producto, Fecha_Compra, Precio_Compra, CantidadCompra) 
VALUES (1, 1, '2024-01-01', 10.00, 50),
		(1, 2, '2024-01-02', 25.00, 30),
		(1, 3, '2024-01-03', 15.00, 20),
		(1, 4, '2024-01-04', 20.00, 40),
		(1, 5, '2024-01-05', 5.00, 60),
		(1, 6, '2024-01-06', 8.00, 70),
		(1, 7, '2024-01-07', 30.00, 35),
		(1, 8, '2024-01-08', 10.00,45), 
		(1, 9, '2024-01-09', 12.00, 25), 
		(1, 10, '2024-01-10', 50.00, 15);

-- Creaci�n de la tabla Venta_Factura (relaci�n muchos a muchos entre Cliente y Producto)
CREATE TABLE Venta_Factura (

    ID_Venta INT PRIMARY KEY IDENTITY (1,1),
	Estado INT,
    ID_Cliente INT,
    ID_Producto INT,
	ID_Vendedor INT,
    Fecha_Venta DATE,
    Cantidad INT,
    Subtotal DECIMAL(10, 2),
    Total DECIMAL(10, 2),
    FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente),
    FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto),
	FOREIGN KEY (ID_Vendedor) REFERENCES Vendedor(ID_Vendedor)

);

INSERT INTO Venta_Factura (Estado, ID_Cliente, ID_Producto, ID_Vendedor, Fecha_Venta, Cantidad, Subtotal, Total) 
VALUES (1, 1, 1, 1, '2024-01-01', 2, 40.00, 80.00), 
(1, 2, 2, 2, '2024-01-02', 1, 50.00, 100.00), 
(1, 3, 3, 1, '2024-01-03', 1, 30.00, 60.00), 
(1, 4, 4, 2, '2024-01-04', 2, 40.00, 80.00), 
(1, 5, 5, 1, '2024-01-05', 3, 45.00, 90.00), 
(1, 6, 6, 2, '2024-01-06', 1, 20.00, 40.00), 
(1, 7, 7, 1, '2024-01-07', 2, 60.00, 120.00), 
(1, 8, 8, 2, '2024-01-08', 1, 25.00, 50.00), 
(1, 9, 9, 1, '2024-01-09', 2, 24.00, 48.00), 
(1, 10, 10, 2, '2024-01-10', 1, 50.00, 100.00);


select * from Compra_Entrada

select * from Producto

select * from Cliente