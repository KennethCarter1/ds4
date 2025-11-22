-- Script para crear la base de datos y tabla de Productos
-- Ejecutar este script en SQL Server Management Studio

-- Crear la base de datos si no existe
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Productos')
BEGIN
    CREATE DATABASE Productos;
END
GO

-- Usar la base de datos
USE Productos;
GO

-- Crear la tabla Productos si no existe
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Productos' AND xtype='U')
BEGIN
    CREATE TABLE Productos (
        Id INT PRIMARY KEY NOT NULL,
        Nombre NVARCHAR(100) NOT NULL,
        Precio DECIMAL(10,2) NOT NULL DEFAULT 0,
        Stock INT NOT NULL DEFAULT 0
    );
END
GO

-- Insertar algunos datos de ejemplo
IF NOT EXISTS (SELECT * FROM Productos)
BEGIN
    INSERT INTO Productos (Id, Nombre, Precio, Stock) VALUES
    (1, 'Laptop Dell', 1299.99, 10),
    (2, 'Mouse Logitech', 25.50, 50),
    (3, 'Teclado Mecánico', 89.99, 20),
    (4, 'Monitor Samsung 24"', 299.00, 8),
    (5, 'Auriculares Sony', 79.99, 15);
END
GO

-- Verificar que los datos se insertaron correctamente
SELECT * FROM Productos;
GO

PRINT 'Base de datos y tabla creadas exitosamente con datos de ejemplo';