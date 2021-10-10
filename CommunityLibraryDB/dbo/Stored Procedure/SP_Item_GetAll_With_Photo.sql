CREATE PROC dbo.SP_Item_GetAll_With_Photo
	@LibraryLocationID INT = 0
AS
/*
Created on - 16/03/2021
Created by - Shamim

Purpose - Get all item/book from table with photo data
Usage - In Item /book controller ViewBooks page

*/

SET NOCOUNT ON

SELECT t1.ItemID, 
	t1.ItemName, 
	t1.ItemMaker, 
	t1.ItemProducer, 
	t1.ItemHasPhoto, 
	t1.ItemBorrowStatusID,
	t2.BorrowStatus,
	t3.PhotoURL,
	t3.PhotoBinary,
	t1.ItemConditionWhenRegistered, 
	t1.AdditionalNote 
FROM dbo.Item t1 WITH(NOLOCK)
	LEFT JOIN dbo.ItemBorrowStatus t2 WITH(NOLOCK) ON t1.ItemBorrowStatusID = t2.BorrowStatusID
	LEFT JOIN dbo.ItemPhoto t3 WITH(NOLOCK) ON t1.ItemID = t3.ItemID and t3.PhotoPriority = 1 -- 1 means book cover photo
WHERE (t1.LibraryLocationID = @LibraryLocationID OR @LibraryLocationID = 0)

SET NOCOUNT OFF