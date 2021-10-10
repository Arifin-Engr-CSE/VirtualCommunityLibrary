CREATE PROC [dbo].[SP_ItemParty_GetLibraryManager]
	@LibraryLocationID int
AS
/*
Created on - 14/03/2021
Created by - Shamim

Purpose - Get all Item party of type Library Manager or Incharge
Usage - In Item/Book Contorller

*/
SET NOCOUNT ON

SELECT [ItemPartyID], 
	[PartyName], 
	t2.PartyTypeName,
	t3.LibraryLocationName
FROM [dbo].[ItemParty] t1 WITH(NOLOCK)
	INNER JOIN  [dbo].[ItemPartyType] t2 WITH(NOLOCK) 
		ON t1.PartyTypeID = t2.ItemPartyTypeID AND t2.PartyTypeName = 'LibraryInCharge'
	INNER JOIN [dbo].[ItemLibraryLocation] t3 WITH(NOLOCK)
		ON t1.LibraryLocationID = t3.LibraryLocationID  AND t3.LibraryLocationID =  @LibraryLocationID
SET NOCOUNT OFF
