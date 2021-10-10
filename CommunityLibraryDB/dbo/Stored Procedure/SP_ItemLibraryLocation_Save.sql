CREATE PROC [dbo].[ItemLibraryLocation_Save]

	@LibraryLocationID int,
	@LibraryLocationName nvarchar(50),
	@LibraryLocationAddress nvarchar(max),
	@LibraryLocationManagerID int,
	@CreatedBy nvarchar(100),
	@ModifiedBy nvarchar(100)
AS
/*
Created on - 14/03/2021
Created by - Shamim

Purpose - Add new Library location or updated existing one
Usage - In LibraryLocationContorller

*/
SET NOCOUNT ON

IF @ModifiedBy IS NULL 
	SET @ModifiedBy = @CreatedBy

IF @LibraryLocationID = 0 BEGIN
	INSERT INTO [dbo].[ItemLibraryLocation] (
		[LibraryLocationName],
		[LibraryLocationAddress],
		[LibraryLocationManagerID],
		[CreatedOn],
		[CreatedBy],
		[ModifiedOn],
		[ModifiedBy]
	)
	VALUES (
		@LibraryLocationName,
		@LibraryLocationAddress,
		@LibraryLocationManagerID,
		GETDATE(),
		@CreatedBy,
		GETDATE(),
		@ModifiedBy
	)
END
ELSE BEGIN
	UPDATE ItemLibraryLocation SET 
		[LibraryLocationName] = @LibraryLocationName,
		[LibraryLocationAddress] = @LibraryLocationAddress,
		[LibraryLocationManagerID] = @LibraryLocationManagerID,
		[ModifiedOn] = GETDATE(),
		[ModifiedBy] = @ModifiedBy
	WHERE [LibraryLocationID] = @LibraryLocationID

END

SET NOCOUNT OFF
