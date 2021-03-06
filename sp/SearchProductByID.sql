USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchProductByID]    Script Date: 2/24/2021 2:14:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[sp_SearchProductByID]
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
