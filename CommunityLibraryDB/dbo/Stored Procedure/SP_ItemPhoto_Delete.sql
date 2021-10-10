CREATE PROC [dbo].[ItemPhoto_Delete]
	@PhotoID int
AS
SET NOCOUNT ON

DELETE FROM [dbo].[ItemPhoto]
WHERE [PhotoID] = @PhotoID

SET NOCOUNT OFF
