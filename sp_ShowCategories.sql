USE Northwind;
GO

CREATE OR ALTER PROCEDURE sp_ShowCategories
AS
BEGIN
SELECT C.CategoryName
FROM [dbo].[Categories] AS C
ORDER BY C.CategoryName ASC
END;

EXEC sp_ShowCategories;