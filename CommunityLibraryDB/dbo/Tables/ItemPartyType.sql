CREATE TABLE [dbo].[ItemPartyType](
	[ItemPartyTypeID] [int] IDENTITY(1,1) primary key NOT NULL,
	[PartyTypeName] [nvarchar](50) NOT NULL,
	[PartyTypeDescription] [nvarchar](1000) NOT NULL,
	[LibraryLocationID]  [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL
)