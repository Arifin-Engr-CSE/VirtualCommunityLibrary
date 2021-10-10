CREATE PROC [dbo].[ItemParty_Delete]
	@ItemPartyID int
AS
SET NOCOUNT ON

DELETE FROM [dbo].[ItemParty]
WHERE [ItemPartyID] = @ItemPartyID

SET NOCOUNT OFF
