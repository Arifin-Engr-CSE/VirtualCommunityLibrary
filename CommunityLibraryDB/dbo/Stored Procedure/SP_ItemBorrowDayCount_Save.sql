CREATE PROC [dbo].[ItemBorrowDayCount_Save]

	@LibraryLocationID int,
	@NumberOfDays int,
	@CreatedBy nvarchar(100),
	@ModifiedBy nvarchar(100)
AS
/*
Created on - 27/03/2021
Created by - Shamim

Purpose - Add borrow Days count for a Library
Usage - In ItemBorrowDayCount controller Borrow page

*/

SET NOCOUNT ON

BEGIN
	INSERT INTO [dbo].[ItemBorrowDayCount] (
		[LibraryLocationID],
		[NumberOfDays],
		[CreatedOn],
		[CreatedBy],
		[ModifiedOn],
		[ModifiedBy]
	)
	VALUES (
		@LibraryLocationID,
		@NumberOfDays,
		GETDATE(),
		@CreatedBy,
		GETDATE(),
		@ModifiedBy
	)
END

SET NOCOUNT OFF
