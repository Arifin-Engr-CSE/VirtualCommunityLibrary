CREATE PROC [dbo].[ItemPhoto_GetAll]
AS
SET NOCOUNT ON

SELECT [PhotoID], 
	[PhotoURL], 
	[PhotoBinary], 
	[PhotoPriority], 
	[ItemID], 
	[CreatedOn], 
	[CreatedBy], 
	[ModifiedOn], 
	[ModifiedBy]
FROM [dbo].[ItemPhoto] WITH(NOLOCK)


SET NOCOUNT OFF
