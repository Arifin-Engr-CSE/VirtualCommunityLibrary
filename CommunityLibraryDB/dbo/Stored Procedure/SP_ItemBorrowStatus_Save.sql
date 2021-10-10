CREATE PROC [dbo].[ItemBorrowStatus_Save]
	@BorrowStatusID int,
	@BorrowStatus nvarchar(50),
	@BorrowDescription nvarchar(1000),
	@LibraryLocationID int,
	@CreatedBy nvarchar(100),
	@ModifiedBy nvarchar(100)
AS
/*
Created on - 27/03/2021
Created by - Shamim

Purpose - Add/Save Borrow Status Type in table
Usage - In ItemBorrowStatus controller

*/
SET NOCOUNT ON
BEGIN
	INSERT INTO [dbo].[ItemBorrowStatus] (
		[BorrowStatus],
		[BorrowDescription],
		[LibraryLocationID],
		[CreatedOn],
		[CreatedBy],
		[ModifiedOn],
		[ModifiedBy]
	)
	VALUES (
		@BorrowStatus,
		@BorrowDescription,
		@LibraryLocationID,
		GETDATE(),
		@CreatedBy,
		GETDATE(),
		@ModifiedBy
	)
END

SET NOCOUNT OFF

