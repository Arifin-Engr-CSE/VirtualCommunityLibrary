CREATE PROC [dbo].[ItemBorrowDayCount_Delete]
	@LibraryLocationID int
AS
/*
TODO -- add comment
*/
SET NOCOUNT ON

DELETE FROM [dbo].[ItemBorrowDayCount]
WHERE [LibraryLocationID] = @LibraryLocationID

SET NOCOUNT OFF
