CREATE PROC [dbo].[ItemType_Delete]
	@ID int
AS
SET NOCOUNT ON

DELETE FROM [dbo].[ItemType]
WHERE [ID] = @ID

SET NOCOUNT OFF
