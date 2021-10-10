CREATE PROC [dbo].[SP_ItemType_GetIdForBook]
	@LibraryLocationID int
AS

/*
Created on - 29/03/2021
Created by - Shamim

Purpose - Get ID for BOOK from ItemType table
Usage - In Book Controller, Add Method

*/

SET NOCOUNT ON

SELECT [ID] 
FROM ItemType WITH(NOLOCK)
WHERE LibraryLocationID = @LibraryLocationID
AND UPPER(ItemTypeName) = 'BOOK'


SET NOCOUNT OFF
