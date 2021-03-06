USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateProduct]    Script Date: 2/24/2021 2:14:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[sp_UpdateProduct]
@ProductID INT = NULL,
@ProductName  NVARCHAR(40) = NULL ,
@SupplierID INT = NULL ,
@CategoryID INT = NULL ,
@UnitPrice MONEY = NULL 

AS
BEGIN
UPDATE Products
SET 
ProductName = @ProductName,
SupplierID = @SupplierID,
CategoryID = @CategoryID,
UnitPrice = @UnitPrice
WHERE ProductID = @ProductID;
END