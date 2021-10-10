CREATE PROC [dbo].[ItemType_GetById]
	@ItemTypeID int
AS
/*
Created on - 23/03/2021
Created by - Shamim

Purpose - Get a single Item Type from ItemType table
Usage - In ItemType Controller

*/
SET NOCOUNT ON

SELECT [ID], 
	[ItemTypeName], 
	[TypeDescription],
	[LibraryLocationID],
	[CreatedOn], 
	[CreatedBy], 
	[ModifiedOn], 
	[ModifiedBy]
FROM ItemType WITH(NOLOCK)
WHERE [ID] = @ItemTypeID


SET NOCOUNT OFF
