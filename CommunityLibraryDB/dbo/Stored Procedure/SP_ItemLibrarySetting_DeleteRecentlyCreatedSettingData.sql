CREATE PROC [dbo].[SP_ItemLibrarySetting_DeleteRecentlyCreatedSettingData]
	@LibraryLocationID INT
AS
/*
Created on - 3/04/2021
Created by - Shamim

Purpose - Delete recently created library setting data
Usage - In AccountController

*/
SET NOCOUNT ON

	
	delete from ItemLibraryLocation Where LibraryLocationID = @LibraryLocationID
	delete from ItemParty Where  LibraryLocationID = @LibraryLocationID
	delete from ItemPartyType Where LibraryLocationID = @LibraryLocationID
	delete from ItemType Where LibraryLocationID = @LibraryLocationID
	delete from ItemBorrowStatus Where LibraryLocationID  = @LibraryLocationID
	delete from AspNetUsers Where LibraryID	=	@LibraryLocationID
	

SET NOCOUNT OFF
