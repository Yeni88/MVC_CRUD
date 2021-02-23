USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowAllProducts]    Script Date: 2/23/2021 9:05:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER     PROCEDURE [dbo].[sp_ShowAllProducts]
AS BEGIN 

SELECT TOP 10 
P.ProductID, 
P.ProductName, 
P.UnitPrice, 
S.SupplierID,
S.CompanyName, 
C.CategoryID,
C.CategoryName  

FROM Products AS P
INNER JOIN Suppliers AS S
ON P.SupplierID = S.SupplierID
INNER JOIN Categories as C
ON P.CategoryID = C.CategoryID
--WHERE ProductID <= 10
ORDER By ProductID DESC
END
