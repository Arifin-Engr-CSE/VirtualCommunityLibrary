CREATE PROC [dbo].[ItemBorrowHistory_Delete]
	@ItemBorrowID int
AS
/*
TODO -- add comment
*/
SET NOCOUNT ON

DELETE FROM [dbo].[ItemBorrowHistory]
WHERE [ItemBorrowID] = @ItemBorrowID

SET NOCOUNT OFF
