USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_ContinuedProduct]    Script Date: 2/24/2021 2:13:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[sp_ContinuedProduct]
@ProductID_s INT
AS
BEGIN
UPDATE Products
SET Discontinued = '1'
WHERE ProductID = @ProductID_s;
END
