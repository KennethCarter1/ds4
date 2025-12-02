

CREATE DATABASE KennethCarter;
GO


USE KennethCarter;
GO


CREATE TABLE KC_Casos (
    CasoID INT IDENTITY(1,1) PRIMARY KEY,
    CasoNombre NVARCHAR(150) NOT NULL,
    FechaInicio DATE NOT NULL,
    FechaVencimiento DATE NOT NULL,
    AbogadoAsignado NVARCHAR(100) NOT NULL,
    NombreCliente NVARCHAR(100) NOT NULL,
    EstadoCaso NVARCHAR(50) NOT NULL,
    DescripcionCaso NVARCHAR(MAX), 
);
GO

SELECT * FROM KC_Casos