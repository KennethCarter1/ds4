CREATE DATABASE laboratoriomvc;
GO

USE laboratoriomvc;
GO

CREATE TABLE [User]
(
    id INT PRIMARY KEY IDENTITY(1,1),
    email VARCHAR(50) NOT NULL,
    [password] VARCHAR(100) NOT NULL
);
GO
