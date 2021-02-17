USE Northwind
GO

CREATE OR ALTER PROCEDURE sp_DiscontinuedProduct
@ProductID_s INT,
@Disc INT

AS
BEGIN
SELECT 
@Disc

IF(@Disc = 0) 
BEGIN
UPDATE Products
SET Discontinued = '0'
WHERE ProductID = @ProductID_s;
END

ELSE

UPDATE Products
SET Discontinued = '1'
WHERE ProductID = @ProductID_s;

END

GO

EXEC sp_DiscontinuedProduct
@ProductID_s = 78,
@Disc = 0

SELECT *
FROM Products
WHERE ProductID = 78