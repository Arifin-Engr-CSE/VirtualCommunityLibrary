CREATE TABLE [dbo].[ItemLibraryLocation](
	[LibraryLocationID] [int] IDENTITY(1,1) primary key NOT NULL,
	[LibraryLocationName] [nvarchar](50) NOT NULL,
	[LibraryLocationAddress] [nvarchar](max) NULL,
	LibraryLocationManagerID  int,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL
)