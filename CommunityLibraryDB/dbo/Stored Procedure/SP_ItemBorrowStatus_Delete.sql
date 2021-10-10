CREATE PROC [dbo].[ItemBorrowStatus_Delete]
	@BorrowStatusID int
AS
SET NOCOUNT ON

DELETE FROM [dbo].[ItemBorrowStatus]
WHERE [BorrowStatusID] = @BorrowStatusID

SET NOCOUNT OFF
