CREATE TABLE [dbo].[ItemType](
	[ID] [int] IDENTITY(1,1) Primary key,
	[ItemTypeName] [nvarchar](50) NOT NULL,
	[TypeDescription] [nvarchar](1000) NULL,
	[LibraryLocationID] INT NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL
)
