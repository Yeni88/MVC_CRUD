USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowSuppliers]    Script Date: 2/19/2021 9:28:07 AM ******/
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