CREATE PROC [dbo].[ItemPartyType_GetAll]
	@LibraryLocationID INT
AS
/*
Created on - 26/03/2021
Created by - Shamim

Purpose - Get All ItemPartyType data from table
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
WHERE LibraryLocationID = @LibraryLocationID


SET NOCOUNT OFF
