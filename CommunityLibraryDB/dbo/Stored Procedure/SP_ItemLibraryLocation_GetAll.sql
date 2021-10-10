CREATE PROC [dbo].[ItemLibraryLocation_GetAll]
	@LibraryLocationID INT = 0
AS
/*
Created on - 6/04/2021
Created by - Shamim

Purpose - Get all library location from the table
Usage - In LibraryLocationContorller

*/

SET NOCOUNT ON

SELECT t1.LibraryLocationID, 
		t1.LibraryLocationName, 
		t1.LibraryLocationAddress, 
		t2.ItemPartyID AS LibraryLocationManagerID,
		t2.PartyName AS LibraryLocationManagerName
FROM [dbo].[ItemLibraryLocation] t1 WITH(NOLOCK)
	INNER JOIN [dbo].[ItemParty] t2 WITH(NOLOCK) ON t1.LibraryLocationManagerID = t2.ItemPartyID
		AND t1.LibraryLocationID = @LibraryLocationID

SET NOCOUNT OFF
