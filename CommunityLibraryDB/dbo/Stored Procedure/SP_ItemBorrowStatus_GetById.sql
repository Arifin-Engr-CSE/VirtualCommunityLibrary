CREATE PROC [dbo].[ItemBorrowStatus_GetById]
	@BorrowStatusID int
AS
SET NOCOUNT ON

SELECT [BorrowStatusID], 
	[BorrowStatus], 
	[BorrowDescription], 
	[LibraryLocationID], 
	[CreatedOn], 
	[CreatedBy], 
	[ModifiedOn]
FROM [dbo].[ItemBorrowStatus] WITH(NOLOCK)
WHERE [BorrowStatusID] = @BorrowStatusID


SET NOCOUNT OFF
