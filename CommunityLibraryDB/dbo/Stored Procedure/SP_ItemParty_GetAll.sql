CREATE PROC [dbo].[ItemParty_GetAll]
	@LibraryLocationID int
AS
/*
Created on - 14/03/2021
Created by - Shamim

Purpose - Get all Item party for a library location
Usage - In ItemParty Contorller

*/
SET NOCOUNT ON

SELECT 
	t1.[ItemPartyID], 
	t1.[PartyName], 
	t1.[PartyTypeID], 
	t2.[PartyTypeName],
	t1.[PartyAddress], 
	t1.[PartyMobile], 
	t1.[PartyNoteIfAny], 
	t1.[CreatedOn], 
	t1.[CreatedBy], 
	t1.[ModifiedOn], 
	t1.[ModifiedBy]
FROM [dbo].[ItemParty] t1 WITH(NOLOCK)
	INNER JOIN [dbo].[ItemPartyType] t2 WITH(NOLOCK) ON t1.PartyTypeID = t2.ItemPartyTypeID
Where t1.LibraryLocationID = @LibraryLocationID


SET NOCOUNT OFF
