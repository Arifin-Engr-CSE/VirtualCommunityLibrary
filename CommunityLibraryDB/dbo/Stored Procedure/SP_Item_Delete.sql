CREATE PROC [dbo].[Item_Delete]
	@ItemID int
AS
/*
TODO -- add comment
*/
SET NOCOUNT ON

DELETE FROM [dbo].[Item]
WHERE [ItemID] = @ItemID

SET NOCOUNT OFF
