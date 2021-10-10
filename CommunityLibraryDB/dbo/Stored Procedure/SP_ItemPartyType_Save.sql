CREATE PROC [dbo].[ItemPartyType_Save]

	@ItemPartyTypeID int,
	@PartyTypeName nvarchar(50),
	@PartyTypeDescription nvarchar(1000),
	@LibraryLocationID int,
	@CreatedBy nvarchar(100),
	@ModifiedBy nvarchar(100)
AS
/*
Created on - 26/03/2021
Created by - Shamim

Purpose - Get All ItemPartyType data from table
Usage - In ItemPartyType controller

*/
SET NOCOUNT ON
IF @ItemPartyTypeID = 0 BEGIN
	INSERT INTO [dbo].[ItemPartyType] (
		[PartyTypeName],
		[PartyTypeDescription],
		[LibraryLocationID],
		[CreatedOn],
		[CreatedBy]
	)
	VALUES (
		@PartyTypeName,
		@PartyTypeDescription,
		@LibraryLocationID,
		GETDATE(),
		@CreatedBy
	)
END
ELSE BEGIN
	UPDATE ItemPartyType SET 
		[PartyTypeName] = @PartyTypeName,
		[PartyTypeDescription] = @PartyTypeDescription,
		[LibraryLocationID]	= @LibraryLocationID,
		[ModifiedOn] = GETDATE(),
		[ModifiedBy] = @ModifiedBy
	WHERE [ItemPartyTypeID] = @ItemPartyTypeID

END

SET NOCOUNT OFF
