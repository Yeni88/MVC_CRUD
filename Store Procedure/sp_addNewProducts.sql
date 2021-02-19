USE NORTHWND
GO
CREATE OR ALTER PROCEDURE sp_addNewProducts

@ProductName  NVARCHAR(40) = NULL ,
@SupplierID INT = NULL ,
@CategoryID INT = NULL ,
@QuantityPerUnit INT = NULL ,
@UnitPrice MONEY = NULL ,
@UnitsInStock SMALLINT = NULL ,
@UnitsOnOrder SMALLINT = NULL ,
@ReorderLevel SMALLINT = NULL, 
@Discontinued SMALLINT = NULL

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

END
GO

BEGIN 
EXEC sp_addNewProducts
@ProductName = 'Clock Analogic',
@SupplierID = 29,
@CategoryID = 1,
@QuantityPerUnit = 1,
@UnitPrice = 49.30,
@UnitsInStock = 10,
@UnitsOnOrder = 5,
@ReorderLevel = 30, 
@Discontinued = 0;
END
GO

SELECT * 
FROM Products