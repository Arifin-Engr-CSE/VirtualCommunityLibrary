CREATE PROC [dbo].[ItemBorrowDayCount_GetAll]
	@LibraryLocationID INT = 0
AS
/*
Created on - 17/03/2021
Created by - Shamim

Purpose - Get all Borrow Days from table
Usage - In Item /book controller Borrow page

*/

SET NOCOUNT ON

SELECT 
	t1.[LibraryLocationID], 
	t2.LibraryLocationName,
	t1.[NumberOfDays], 
	t1.[CreatedOn], 
	t1.[CreatedBy], 
	t1.[ModifiedOn], 
	t1.[ModifiedBy]
FROM [dbo].[ItemBorrowDayCount] t1 WITH(NOLOCK)
INNER JOIN [dbo].[ItemLibraryLocation] t2 WITH(NOLOCK)
	ON t1.LibraryLocationID = t2.LibraryLocationID
WHERE (t1.LibraryLocationID = @LibraryLocationID OR @LibraryLocationID = 0)


SET NOCOUNT OFF
