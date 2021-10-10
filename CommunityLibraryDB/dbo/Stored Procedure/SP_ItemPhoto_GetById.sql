CREATE PROC [dbo].[ItemPhoto_GetById]
	@ItemID int
AS
/*
Created on - 22/03/2021
Created by - Shamim

Purpose - Get Book/Item Photo
Usage - In BookController

*/

SET NOCOUNT ON

SELECT 
	t2.[PhotoID], 
	t1.[ItemID],
	t1.[ItemName],
	t2.[PhotoURL], 
	t2.[PhotoBinary], 
	t2.[PhotoPriority] 
FROM (SELECT ItemID, ItemName FROM [dbo].[Item] WITH(NOLOCK) WHERE ItemID=@ItemID) t1 
	LEFT JOIN [dbo].[ItemPhoto] t2 WITH(NOLOCK)
		ON t2.ItemID = t1.ItemID AND t2.PhotoPriority = 1 --getting only the primary photo

SET NOCOUNT OFF
