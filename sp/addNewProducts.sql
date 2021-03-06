USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_addNewProducts]    Script Date: 2/24/2021 2:13:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   PROCEDURE [dbo].[sp_addNewProducts]

@ProductName  NVARCHAR(40) ,
@SupplierID INT  ,
@CategoryID INT  ,
@QuantityPerUnit INT  ,
@UnitPrice MONEY  ,
@UnitsInStock SMALLINT  ,
@UnitsOnOrder SMALLINT  ,
@ReorderLevel SMALLINT , 
@Discontinued SMALLINT 

AS
BEGIN

SET NOCOUNT ON 

INSERT INTO [dbo].[Products]
(
ProductName,
SupplierID,
CategoryID,
QuantityPerUnit,
UnitPrice,
UnitsInStock,
UnitsOnOrder,
ReorderLevel, 
Discontinued
)

VALUES(
@ProductName,
@SupplierID,
@CategoryID,
@QuantityPerUnit,
@UnitPrice,
@UnitsInStock,
@UnitsOnOrder,
@ReorderLevel, 
@Discontinued
)

END;