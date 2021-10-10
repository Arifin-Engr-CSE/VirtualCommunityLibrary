CREATE PROC [dbo].[SP_ItemLibrarySetting_CreateForInitialRegistration]

	@LibraryName nvarchar(200),
	@ManagerName nvarchar(200),
	@ManagerMobile nvarchar(100),
	@CreatedBy nvarchar(100),
	@ModifiedBy nvarchar(100)
AS
/*
Created on - 2/04/2021
Created by - Shamim

Purpose - Create Library, library manager from Registration form and return LibraryID. Also add other library setting data
Usage - In AccountController

*/
SET NOCOUNT ON

	IF @ModifiedBy IS NULL 
		SET @ModifiedBy = @CreatedBy

	DECLARE @LibrayLocationID INT
	DECLARE @ItemPartyID INT
	DECLARE @ItemPartyTypeID INT

	-------------------------------------------------------
	-- Adding library setting data
	-------------------------------------------------------

	--Creating LibraryLocation
	EXEC [dbo].[ItemLibraryLocation_Save]
		@LibraryLocationID			=	0,
		@LibraryLocationName		=	@LibraryName,
		@LibraryLocationAddress		=	'',
		@LibraryLocationManagerID	=	0,
		@CreatedBy					=	@CreatedBy,
		@ModifiedBy					=	@ModifiedBy	
	
	SELECT @LibrayLocationID = @@IDENTITY

	--Creating ItemParty
	EXEC [dbo].[ItemParty_Save]
		@ItemPartyID			=	0,
		@PartyName				=	@ManagerName,
		@PartyTypeID			=	0,
		@LibraryLocationID		=	@LibrayLocationID,
		@PartyAddress			=	'',
		@PartyMobile			= @ManagerMobile,
		@PartyNoteIfAny			= '',
		@CreatedBy				= @CreatedBy,
		@ModifiedBy				= @ModifiedBy

	SELECT @ItemPartyID = @@IDENTITY

	--Creating Borrow Status 
	INSERT INTO dbo.ItemBorrowStatus
		   ([BorrowStatus]
           ,[BorrowDescription]
           ,[LibraryLocationID]
           ,[CreatedOn]
           ,[CreatedBy])
		VALUES
			('Borrowed','Borrowed',@LibrayLocationID,GETDATE(),@CreatedBy),
			('Available','Available',@LibrayLocationID,GETDATE(),@CreatedBy);

	--ItemType
	INSERT INTO dbo.ItemType
           ([ItemTypeName]
           ,[TypeDescription]
           ,[LibraryLocationID]
           ,[CreatedOn]
           ,[CreatedBy])		
	VALUES
		('Book','Book',@LibrayLocationID,GETDATE(),@CreatedBy);

	--ItemPartyType
	INSERT INTO dbo.ItemPartyType
	       ([PartyTypeName]
           ,[PartyTypeDescription]
           ,[LibraryLocationID]
           ,[CreatedOn]
           ,[CreatedBy])
	VALUES
		('LibraryInCharge','LibraryInCharge',@LibrayLocationID,GETDATE(),@CreatedBy),
		('Borrower','Borrower',@LibrayLocationID,GETDATE(),@CreatedBy),
		('Owner','Owner',@LibrayLocationID,GETDATE(),@CreatedBy),
		('Supporter','Supporter',@LibrayLocationID,GETDATE(),@CreatedBy);

	--getting @ItemPartyTypeID
	SELECT 
		@ItemPartyTypeID = ItemPartyTypeID
	FROM dbo.ItemPartyType WITH(NOLOCK) 
	WHERE LibraryLocationID = @LibrayLocationID 
		AND PartyTypeName = 'LibraryInCharge' 

	--Updating LibraryLocation LibraryLocationManagerID
	UPDATE dbo.ItemLibraryLocation
		SET LibraryLocationManagerID =  @ItemPartyID 
	WHERE LibraryLocationID = @LibrayLocationID

	--Updating ItemParty PartyTypeID as LibraryInCharge
	UPDATE dbo.ItemParty
		SET PartyTypeID = @ItemPartyTypeID
	WHERE ItemPartyID = @ItemPartyID


	--Finally select LibraryID
	SELECT @LibrayLocationID AS LibraryID

SET NOCOUNT OFF

/*
--Sample execution for testing 

DECLARE	@LibraryName nvarchar(200),
	@ManagerName nvarchar(200),
	@ManagerMobile nvarchar(100),
	@CreatedBy nvarchar(100),
	@ModifiedBy nvarchar(100)

SET @LibraryName = 'Test1'
SET @ManagerName = 'Manager1'
SET @ManagerMobile = '000000'
SET @CreatedBy = 'abc'
SET @ModifiedBy = 'abc'


EXEC [dbo].[SP_ItemLibrarySetting_CreateForInitialRegistration]
		@LibraryName = @LibraryName,
		@ManagerName = @ManagerName,
		@ManagerMobile = @ManagerMobile,
		@CreatedBy = @CreatedBy,
		@ModifiedBy = @ModifiedBy
*/