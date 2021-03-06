USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowProducts]    Script Date: 2/24/2021 2:14:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   PROCEDURE [dbo].[sp_ShowProducts]
AS
BEGIN 

SELECT 
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
WHERE ProductID <= 10;
END