CREATE PROC [dbo].[ItemParty_Save]

	@ItemPartyID int,
	@PartyName nvarchar(50),
	@PartyTypeID int,
	@LibraryLocationID int,
	@PartyAddress nvarchar(200),
	@PartyMobile nvarchar(50),
	@PartyNoteIfAny nvarchar(1000),
	@CreatedBy nvarchar(100),
	@ModifiedBy nvarchar(100)
AS
/*
Created on - 28/03/2021
Created by - Shamim

Purpose - Add/Edit ItemParty 
Usage - In ItemParty Contorller

*/
SET NOCOUNT ON

IF @ModifiedBy IS NULL 
	SET @ModifiedBy = @CreatedBy


IF @ItemPartyID = 0 BEGIN
	INSERT INTO [dbo].[ItemParty] (
		[PartyName],
		[PartyTypeID],
		[LibraryLocationID],
		[PartyAddress],
		[PartyMobile],
		[PartyNoteIfAny],
		[CreatedOn],
		[CreatedBy]
	)
	VALUES (
		@PartyName,
		@PartyTypeID,
		@LibraryLocationID,
		@PartyAddress,
		@PartyMobile,
		@PartyNoteIfAny,
		GETDATE(),
		@CreatedBy
	)
END
ELSE BEGIN
	UPDATE ItemParty SET 
		[PartyName] = @PartyName,
		[PartyTypeID] = @PartyTypeID,
		[LibraryLocationID] = @LibraryLocationID,
		[PartyAddress] = @PartyAddress,
		[PartyMobile] = @PartyMobile,
		[PartyNoteIfAny] = @PartyNoteIfAny,
		[ModifiedOn] = GETDATE(),
		[ModifiedBy] = @ModifiedBy
	WHERE [ItemPartyID] = @ItemPartyID

END

SET NOCOUNT OFF
