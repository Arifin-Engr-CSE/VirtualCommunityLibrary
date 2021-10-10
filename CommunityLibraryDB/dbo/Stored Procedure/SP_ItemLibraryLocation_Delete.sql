CREATE PROC [dbo].[ItemLibraryLocation_Delete]
	@LibraryLocationID int
AS
SET NOCOUNT ON

DELETE FROM [dbo].[ItemLibraryLocation]
WHERE [LibraryLocationID] = @LibraryLocationID

SET NOCOUNT OFF
