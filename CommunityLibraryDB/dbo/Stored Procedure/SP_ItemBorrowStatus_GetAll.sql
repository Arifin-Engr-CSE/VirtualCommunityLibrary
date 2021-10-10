CREATE PROC [dbo].[ItemBorrowStatus_GetAll]
	@LibraryLocationID INT
AS
/*
Created on - 27/03/2021
Created by - Shamim

Purpose - Get all Borrow Status Type from table
Usage - In ItemBorrowStatus controller

*/
SET NOCOUNT ON

SELECT 
	t1.[BorrowStatusID], 
	t1.[BorrowStatus], 
	t1.[BorrowDescription], 
	t1.[LibraryLocationID],
	t2.LibraryLocationName,
	t1.[CreatedOn], 
	t1.[CreatedBy], 
	t1.[ModifiedOn],
	t1.[ModifiedBy]
FROM [dbo].[ItemBorrowStatus] t1 WITH(NOLOCK)
INNER JOIN [dbo].[ItemLibraryLocation] t2 WITH(NOLOCK)
	ON t1.LibraryLocationID = t2.LibraryLocationID
WHERE (t1.LibraryLocationID = @LibraryLocationID OR @LibraryLocationID = 0)


SET NOCOUNT OFF