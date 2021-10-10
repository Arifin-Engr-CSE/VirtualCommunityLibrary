CREATE PROC dbo.Item_GetAll
	@LibraryLocationID INT = 0
AS
/*
Created on - 15/03/2021
Created by - Shamim

Purpose - Get all item/book from table
Usage - In Item /book controller GetAll page

*/

SET NOCOUNT ON

SELECT t1.ItemID, 
	t1.ItemName, 
	t1.ItemOwnerID, 
	t2.PartyName,
	t1.ItemMaker, 
	t1.ItemProducer, 
	t1.ItemTypeID, 
	t3.ItemTypeName,
	t1.ItemHasPhoto, 
	t1.ItemBorrowStatusID,
	t4.BorrowStatus,
	t1.LibraryLocationID, 
	t5.LibraryLocationName,
	t1.ItemConditionWhenRegistered, 
	t1.AdditionalNote, 
	t1.CreatedOn, 
	t1.CreatedBy, 
	t1.ModifiedOn, 
	t1.ModifiedBy
FROM dbo.Item t1 WITH(NOLOCK)
	LEFT JOIN dbo.ItemParty t2 WITH(NOLOCK) ON t1.ItemOwnerID = t2.ItemPartyID
	LEFT JOIN dbo.ItemType t3 WITH(NOLOCK) ON t1.ItemTypeID = t3.ID
	LEFT JOIN dbo.ItemBorrowStatus t4 WITH(NOLOCK) ON t1.ItemBorrowStatusID = t4.BorrowStatusID
	LEFT JOIN dbo.ItemLibraryLocation t5 WITH(NOLOCK) ON t1.LibraryLocationID = t5.LibraryLocationID
WHERE (t1.LibraryLocationID = @LibraryLocationID OR @LibraryLocationID = 0)

SET NOCOUNT OFF