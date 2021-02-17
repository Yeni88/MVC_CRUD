USE Northwind;
GO

CREATE OR ALTER PROCEDURE sp_ShowSuppliers
AS
BEGIN
SELECT S.CompanyName
FROM [dbo].[Suppliers] AS S
ORDER BY S.CompanyName ASC
END;

EXEC sp_ShowSuppliers;

