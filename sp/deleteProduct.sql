USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteProduct]    Script Date: 2/24/2021 2:14:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[sp_deleteProduct]
@ProductID AS INT
AS
BEGIN 
DELETE 
FROM Products
WHERE ProductID = @ProductID
END