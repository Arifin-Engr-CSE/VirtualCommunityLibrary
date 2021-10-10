CREATE TABLE [dbo].[ItemLibraryLocations](
	[LibraryLocationID] [int] IDENTITY(1,1) NOT NULL,
	[LibraryLocation] [nvarchar](50) NOT NULL,
	[LibraryLocationAddress] [nvarchar](max) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL,
	[ItemPartyID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ItemLibraryLocations] PRIMARY KEY CLUSTERED 
(
	[LibraryLocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]