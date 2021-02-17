USE NORTHWND
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowAllProducts]    Script Date: 14/2/2021 23:31:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER   PROCEDURE [dbo].[sp_ShowAllProducts]
AS BEGIN 

SELECT 
P.ProductID, 
P.ProductName, 
P.UnitPrice, 
S.SupplierID,
S.ContactTitle, 
C.CategoryID,
C.CategoryName  

FROM Products AS P
INNER JOIN Suppliers AS S
ON P.SupplierID = S.SupplierID
INNER JOIN Categories as C
ON P.CategoryID = C.CategoryID
END

