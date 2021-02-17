

USE Northwind
GO

CREATE OR ALTER PROCEDURE sp_deleteProduct
@ProductID AS INT
AS
BEGIN 
DELETE 
FROM Products
WHERE ProductID = @ProductID
END