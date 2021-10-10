CREATE PROC [dbo].[ItemType_Save]
	@ID int,
	@ItemTypeName nvarchar(50),
	@TypeDescription nvarchar(1000),
	@LibraryLocationID int,
	@CreatedBy nvarchar(100) = '',
	@ModifiedBy nvarchar(100) = ''
AS
SET NOCOUNT ON
IF @ID = 0 BEGIN
	INSERT INTO [dbo].[ItemType] (
		[ItemTypeName],
		[TypeDescription],
		[LibraryLocationID],
		[CreatedOn],
		[CreatedBy]
	)
	VALUES (
		@ItemTypeName,
		@TypeDescription,
		@LibraryLocationID,
		GETDATE(),
		@CreatedBy
	)
END
ELSE BEGIN
	UPDATE ItemType SET 
		[ItemTypeName] = @ItemTypeName,
		[TypeDescription] = @TypeDescription,
		[LibraryLocationID] = @LibraryLocationID,
		[ModifiedOn] = GETDATE(),
		[ModifiedBy] = @ModifiedBy
	WHERE [ID] = @ID

END

SET NOCOUNT OFF
