CREATE PROC [dbo].[ItemBorrowHistory_Save]

	@ItemBorrowID int = 0,
	@ItemID int,
	@ItemPartyID int,
	@LibraryLocationID int,
	@BorrowDate datetime,
	@BorrowedForHowManyDays int,
	@CalculatedReturnDate datetime, 
	@ActualReturnDate datetime = null,
	@CreatedBy nvarchar(100),
	@ModifiedBy nvarchar(100)
AS
/*
Created on - 19/03/2021
Created by - Shamim

Purpose - Add new Book Borrow data or updated existing one
Usage - In BookController in BookBorrow Post method

*/
SET NOCOUNT ON
IF @ItemBorrowID = 0 
BEGIN
	--Adding book borrow history
	INSERT INTO [dbo].[ItemBorrowHistory] (
		[ItemID],
		[ItemPartyID],
		[LibraryLocationID],
		[BorrowDate],
		[BorrowedForHowManyDays],
		[CalculatedReturnDate], 
		[ActualReturnDate],
		[CreatedOn],
		[CreatedBy],
		[ModifiedOn],
		[ModifiedBy]
	)
	VALUES (
		@ItemID,
		@ItemPartyID,
		@LibraryLocationID,
		@BorrowDate,
		@BorrowedForHowManyDays,
		@CalculatedReturnDate, 
		NULL,
		GETDATE(),
		@CreatedBy,
		NULL,
		@ModifiedBy
	)
	
	--Updating Item/Book Status to 'Borrowed'
	UPDATE [dbo].[Item]
		SET ItemBorrowStatusID = (SELECT BorrowStatusID FROM dbo.ItemBorrowStatus
										WHERE BorrowStatus = 'Borrowed'  
											AND LibraryLocationID = @LibraryLocationID  )
			,ModifiedOn = GETDATE()
			,ModifiedBy = @ModifiedBy
	WHERE ItemID = @ItemID  
		AND LibraryLocationID = @LibraryLocationID


END
ELSE BEGIN
	--Updating data when Item/book returned 
	UPDATE ItemBorrowHistory SET 
		[ActualReturnDate] = @ActualReturnDate,
		[ModifiedOn] = GETDATE(),
		[ModifiedBy] = @ModifiedBy
	WHERE [ItemBorrowID] = @ItemBorrowID

	--Updating Item/Book Status to 'Available'
	UPDATE [dbo].[Item]
		SET ItemBorrowStatusID = (SELECT BorrowStatusID FROM dbo.ItemBorrowStatus 
										WHERE BorrowStatus = 'Available' 
											AND LibraryLocationID = @LibraryLocationID )
			,ModifiedOn = GETDATE()
			,ModifiedBy = @ModifiedBy
	WHERE ItemID = @ItemID 
		AND LibraryLocationID = @LibraryLocationID

END

SET NOCOUNT OFF
