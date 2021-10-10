CREATE PROC [dbo].[ItemParty_GetById]
	@ItemPartyID int
AS
/*
Created on - 27/03/2021
Created by - Shamim

Purpose - Get single Item party 
Usage - In ItemParty Contorller

*/
SET NOCOUNT ON

SELECT 
	t1.[ItemPartyID], 
	t1.[PartyName], 
	t1.[LibraryLocationID], 
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
WHERE t1.[ItemPartyID] = @ItemPartyID



SET NOCOUNT OFF
