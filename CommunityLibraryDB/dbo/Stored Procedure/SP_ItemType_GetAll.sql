CREATE PROC [dbo].[ItemType_GetAll]
	@LibraryLocationID int
AS

/*
Created on - 23/03/2021
Created by - Shamim

Purpose - Get all Item type from ItemType table
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
WHERE LibraryLocationID = @LibraryLocationID


SET NOCOUNT OFF
