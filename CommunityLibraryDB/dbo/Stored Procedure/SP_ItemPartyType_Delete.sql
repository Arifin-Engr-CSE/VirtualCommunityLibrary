CREATE PROC [dbo].[ItemPartyType_Delete]
	@ItemPartyTypeID int
AS
SET NOCOUNT ON

DELETE FROM [dbo].[ItemPartyType]
WHERE [ItemPartyTypeID] = @ItemPartyTypeID

SET NOCOUNT OFF
