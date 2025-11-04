USE Northwind

-- EJEMPLO 1
SELECT * FROM Products

-- EJEMPLO 2
SELECT ProductID, ProductName, UnitPrice FROM Products

-- EJEMPLO 3
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE UnitPrice > 15

-- EJEMPLO 4
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE UnitPrice >= 15 AND UnitPrice <= 50

-- EJEMPLO 5
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE UnitPrice BETWEEN 15 AND 50

-- EJEMPLO 6
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE NOT UnitPrice > 15

-- EJEMPLO 7
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE ProductID > 15 OR UnitPrice < 10

-- EJEMPLO 8
SELECT EmployeeID, LastName FROM Employees
WHERE LastName LIKE 'D%'

-- EJEMPLO 9
SELECT EmployeeID, LastName FROM Employees
WHERE LastName LIKE '%N'

-- EJEMPLO 10
SELECT EmployeeID, LastName, Title FROM Employees
WHERE Title LIKE '%SALES%'

-- EJEMPLO 11
SELECT EmployeeID, LastName FROM Employees
WHERE LastName NOT LIKE 'D%'

-- EJEMPLO 12
SELECT ProductID, ProductName, UnitPrice
FROM Products
ORDER BY ProductID ASC

-- EJEMPLO 13
SELECT ProductID, ProductName, UnitPrice
FROM Products
ORDER BY ProductID DESC

-- EJEMPLO 14
SELECT DISTINCT OrderID FROM [Order Details]

-- EJEMPLO 15
SELECT TOP 5 OrderID, ProductID, Quantity
FROM [Order Details]

-- EJEMPLO 16
SELECT TOP 10 PERCENT OrderID, ProductID, Quantity
FROM [Order Details]

-- EJEMPLO 17
SELECT CategoryName AS [Nombre de Categoría]
FROM Categories

-- EJEMPLO 18
SELECT OrderID, OrderDate, ShippedDate, ShippedDate + 5 AS RetrasoEnvio
FROM Orders

-- EJEMPLO 19
SELECT OrderID, P.ProductID, ProductName
FROM Products P
INNER JOIN [Order Details] OD
ON P.ProductID = OD.ProductID

-- EJEMPLO 20
SELECT ProductName, CompanyName, ContactName
FROM Products P
FULL JOIN Suppliers S
ON P.SupplierID = S.SupplierID