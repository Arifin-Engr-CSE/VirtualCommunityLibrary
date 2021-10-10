CREATE PROC [dbo].[ItemPhoto_Save]
	@PhotoID int,
	@PhotoURL nvarchar(2000) = '',
	@PhotoBinary varbinary(MAX),
	@PhotoPriority int,
	@ItemID int,
	@CreatedBy nvarchar(100),
	@ModifiedBy nvarchar(100)
AS
/*
Created on - 21/03/2021
Created by - Shamim

Purpose - Add/Edit Book/Item Photo
Usage - In BookController

*/
SET NOCOUNT ON
IF @PhotoID = 0 BEGIN
	INSERT INTO [dbo].[ItemPhoto] (
		[PhotoURL],
		[PhotoBinary],
		[PhotoPriority],
		[ItemID],
		[CreatedOn],
		[CreatedBy]
	)
	VALUES (
		@PhotoURL,
		@PhotoBinary,
		@PhotoPriority,
		@ItemID,
		GETDATE(),
		@CreatedBy
	)
END
ELSE BEGIN
	UPDATE ItemPhoto SET 
		[PhotoURL] = @PhotoURL,
		[PhotoBinary] = @PhotoBinary,
		[PhotoPriority] = @PhotoPriority,
		[ModifiedOn] = GETDATE(),
		[ModifiedBy] = @ModifiedBy
	WHERE [PhotoID] = @PhotoID
		AND ItemID = @ItemID
		AND (PhotoPriority = @PhotoPriority 
				AND @PhotoPriority = 1)

END

SET NOCOUNT OFF
