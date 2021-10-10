CREATE PROC [dbo].[ItemPartyType_GetById]
	@ItemPartyTypeID int
AS
/*
Created on - 26/03/2021
Created by - Shamim

Purpose - Get Single ItemPartyType data from table
Usage - In ItemPartyType controller

*/
SET NOCOUNT ON

SELECT [ItemPartyTypeID], 
	[PartyTypeName], 
	[PartyTypeDescription],
	[LibraryLocationID],
	[CreatedOn], 
	[CreatedBy], 
	[ModifiedOn], 
	[ModifiedBy]
FROM [dbo].[ItemPartyType] WITH(NOLOCK)
WHERE [ItemPartyTypeID] = @ItemPartyTypeID


SET NOCOUNT OFF
