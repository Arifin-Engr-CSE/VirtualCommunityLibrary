CREATE PROC dbo.ItemLibraryLocation_GetById
	@LibraryLocationID int
AS
/*
Created on - 14/03/2021
Created by - Shamim

Purpose - Get single library location detail
Usage - In LibraryLocationContorller

*/

SET NOCOUNT ON

SELECT t1.LibraryLocationID, 
	t1.LibraryLocationName, 
	t1.LibraryLocationAddress, 
	t1.LibraryLocationManagerID,
	t2.PartyName AS LibraryManagerName,
	t1.CreatedOn, 
	t1.CreatedBy, 
	t1.ModifiedOn, 
	t1.ModifiedBy
FROM dbo.ItemLibraryLocation t1 WITH(NOLOCK)
	INNER JOIN dbo.ItemParty t2 WITH(NOLOCK) ON t1.LibraryLocationManagerID = t2.ItemPartyID
WHERE t1.LibraryLocationID = @LibraryLocationID


SET NOCOUNT OFF
