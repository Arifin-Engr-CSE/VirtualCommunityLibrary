CREATE PROC [dbo].[SP_ItemParty_GetLibraryBorrower]
	@LibraryLocationID int
AS
/*
Created on - 17/03/2021
Created by - Shamim

Purpose - Get all Borrower names from table
Usage - In Item /book controller Borrow page

*/
SET NOCOUNT ON

SELECT t1.[ItemPartyID], 
	t1.[PartyName], 
	t2.PartyTypeName,
	t3.LibraryLocationName
FROM [dbo].[ItemParty] t1 WITH(NOLOCK)
	INNER JOIN  [dbo].[ItemPartyType] t2 WITH(NOLOCK) 
		ON t1.PartyTypeID = t2.ItemPartyTypeID AND t2.PartyTypeName = 'Borrower'
	INNER JOIN [dbo].[ItemLibraryLocation] t3 WITH(NOLOCK)
		ON t1.LibraryLocationID = t3.LibraryLocationID  AND 
				(t3.LibraryLocationID = @LibraryLocationID OR @LibraryLocationID = 0)

SET NOCOUNT OFF
