USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowCategories]    Script Date: 2/24/2021 2:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   PROCEDURE [dbo].[sp_ShowCategories]
AS
BEGIN
SELECT C.CategoryName, C.CategoryID
FROM [dbo].[Categories] AS C
ORDER BY C.CategoryName ASC
END;