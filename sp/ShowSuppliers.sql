USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowSuppliers]    Script Date: 2/24/2021 2:14:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   PROCEDURE [dbo].[sp_ShowSuppliers]
AS
BEGIN
SELECT S.CompanyName,
S.SupplierID
FROM [dbo].[Suppliers] AS S
ORDER BY S.CompanyName ASC
END;