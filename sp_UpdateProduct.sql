USE Northwind;
GO

CREATE OR ALTER PROCEDURE sp_UpdateProduct
@ProductID_s INT = NULL,
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
UPDATE Products
SET 
ProductName = @ProductName,
SupplierID = @SupplierID,
CategoryID = @CategoryID,
QuantityPerUnit = @QuantityPerUnit,
UnitPrice = @UnitPrice,
UnitsInStock = @UnitsInStock,
UnitsOnOrder = @UnitsOnOrder,
ReorderLevel = @ReorderLevel,
Discontinued = @Discontinued

WHERE ProductID = @ProductID_s;
END
GO


EXEC sp_UpdateProduct
@ProductID_s = 78,
@ProductName = 'Chia',
@SupplierID = 29,
@CategoryID = 1,
@QuantityPerUnit = 1,
@UnitPrice = 10.30,
@UnitsInStock = 10,
@UnitsOnOrder = 5,
@ReorderLevel = 30, 
@Discontinued = 0;


SELECT * 
FROM Products As P
WHERE ProductID = 78;
