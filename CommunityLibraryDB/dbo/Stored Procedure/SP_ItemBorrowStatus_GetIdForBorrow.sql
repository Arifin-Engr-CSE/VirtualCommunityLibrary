CREATE PROC [dbo].[SP_ItemBorrowStatus_GetIdForBorrow]
	@LibraryLocationID int
AS

/*
Created on - 29/03/2021
Created by - Shamim

Purpose - Get ID for Borrow from ItemBorrowStatus table
Usage - In Book Controller, Add Method

*/

SET NOCOUNT ON

SELECT BorrowStatusID
FROM ItemBorrowStatus WITH(NOLOCK)
WHERE LibraryLocationID = @LibraryLocationID
AND UPPER(BorrowStatus) LIKE '%AVAILABLE%'


SET NOCOUNT OFF
