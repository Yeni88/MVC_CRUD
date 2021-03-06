USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_DiscontinuedProduct]    Script Date: 2/24/2021 2:14:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[sp_DiscontinuedProduct]
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
