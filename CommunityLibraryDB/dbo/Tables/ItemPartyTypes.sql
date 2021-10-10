CREATE TABLE [dbo].[ItemPartyTypes](
	[ItemPartyTypeID] [int] IDENTITY(1,1) NOT NULL,
	[PartyTypeName] [nvarchar](50) NOT NULL,
	[PartyTypeDescription] [nvarchar](1000) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL,
 CONSTRAINT [PK_dbo.ItemPartyTypes] PRIMARY KEY CLUSTERED 
(
	[ItemPartyTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]