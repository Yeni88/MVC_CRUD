USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_consultProduct]    Script Date: 2/24/2021 2:13:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[sp_consultProduct]
@index INT = NULL

AS 
BEGIN 
SELECT TOP 1
P.ProductID,
P.ProductName,
S.SupplierID,
C.CategoryID,
P.UnitPrice

FROM Products AS P
INNER JOIN Suppliers AS S
ON P.SupplierID = S.SupplierID
INNER JOIN Categories as C
ON P.CategoryID = C.CategoryID
WHERE P.ProductID = @index
ORDER By ProductID ASC
END