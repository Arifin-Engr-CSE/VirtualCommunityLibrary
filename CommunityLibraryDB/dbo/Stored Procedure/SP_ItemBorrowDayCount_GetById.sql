CREATE PROC [dbo].[ItemBorrowDayCount_GetById]
	@LibraryLocationID int
AS
/*
TODO -- add comment
*/

SET NOCOUNT ON

SELECT [LibraryLocationID], 
	[NumberOfDays], 
	[CreatedOn], 
	[CreatedBy], 
	[ModifiedOn], 
	[ModifiedBy]
FROM [dbo].[ItemBorrowDayCount] WITH(NOLOCK)
WHERE [LibraryLocationID] = @LibraryLocationID


SET NOCOUNT OFF
