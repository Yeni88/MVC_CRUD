USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowCategories]    Script Date: 2/19/2021 9:29:29 AM ******/
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