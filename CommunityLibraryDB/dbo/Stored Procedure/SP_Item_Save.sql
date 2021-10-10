CREATE PROC [dbo].[Item_Save]
	@ItemID int,
	@ItemName nvarchar(50),
	@ItemOwnerID int,
	@ItemMaker nvarchar(50),
	@ItemProducer nvarchar(50),
	@ItemTypeID int,
	@ItemBorrowStatusID int,
	@LibraryLocationID int,
	@ItemConditionWhenRegistered nvarchar(1000),
	@AdditionalNote nvarchar(1000),
	@CreatedBy nvarchar(100),
	@ModifiedBy nvarchar(100)
AS

/*
Created on - 29/03/2021
Created by - Shamim

Purpose - Add/Edit Item to table
Usage - In Item Contorller
*/

SET NOCOUNT ON
IF @ItemID = 0 BEGIN
	INSERT INTO [dbo].[Item] (
		[ItemName],
		[ItemOwnerID],
		[ItemMaker],
		[ItemProducer],
		[ItemTypeID],
		[ItemHasPhoto],
		[ItemBorrowStatusID],
		[LibraryLocationID],
		[ItemConditionWhenRegistered],
		[AdditionalNote],
		[CreatedOn],
		[CreatedBy]
	)
	VALUES (
		@ItemName,
		@ItemOwnerID,
		@ItemMaker,
		@ItemProducer,
		@ItemTypeID,
		0, --default no photo
		@ItemBorrowStatusID,
		@LibraryLocationID,
		@ItemConditionWhenRegistered,
		@AdditionalNote,
		GETDATE(),
		@CreatedBy
	)
END
ELSE BEGIN
	UPDATE [dbo].[Item] SET 
		[ItemName] = @ItemName,
		[ItemOwnerID] = @ItemOwnerID,
		[ItemMaker] = @ItemMaker,
		[ItemProducer] = @ItemProducer,
		[ItemTypeID] = @ItemTypeID,
		[ItemBorrowStatusID] = @ItemBorrowStatusID,
		[LibraryLocationID] = @LibraryLocationID,
		[ItemConditionWhenRegistered] = @ItemConditionWhenRegistered,
		[AdditionalNote] = @AdditionalNote,
		[ModifiedOn] = GETDATE(),
		[ModifiedBy] = @ModifiedBy
	WHERE [ItemID] = @ItemID

END

SET NOCOUNT OFF
