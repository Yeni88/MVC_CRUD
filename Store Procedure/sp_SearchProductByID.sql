USE NORTHWND;
GO

CREATE OR ALTER PROCEDURE sp_SearchProductByID
@ProductID INT
AS
BEGIN 

SELECT 
TOP(1)
P.ProductName AS Producto, 
P.UnitPrice AS Precio, 
P.UnitsInStock AS Unidades, 
C.CategoryName As Categoría,
S.SupplierID AS Suplidor
FROM Products AS P
INNER JOIN Categories AS C
ON P.CategoryID = C.CategoryID
INNER JOIN Suppliers AS S
ON S.SupplierID = P.SupplierID
WHERE P.ProductID = @ProductID
END
GO

EXEC sp_SearchProductByID
@ProductID = 78