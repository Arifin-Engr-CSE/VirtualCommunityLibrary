CREATE PROC [dbo].[ItemBorrowHistory_GetById]
	@ItemID int
AS
/*
Created on - 19/03/2021
Created by - Shamim

Purpose - Get Last book Borrow data 
Usage - In BookController in BookReturn GET method

*/
SET NOCOUNT ON

SELECT TOP 1
	t1.[ItemBorrowID], 
	t1.[ItemID],
	t2.[ItemName],
	t1.[ItemPartyID], 
	t1.[LibraryLocationID], 
	t1.[BorrowDate], 
	t1.[BorrowedForHowManyDays], 
	t1.[CalculatedReturnDate], 
	t1.[ActualReturnDate] 
FROM [dbo].[ItemBorrowHistory] t1 WITH(NOLOCK)
	INNER JOIN [dbo].[Item] t2 WITH(NOLOCK) on t1.ItemID = t2.ItemID
WHERE t1.[ItemID] = @ItemID
	AND t1.[ActualReturnDate] IS NULL
ORDER BY t1.[ItemBorrowID] DESC

SET NOCOUNT OFF
