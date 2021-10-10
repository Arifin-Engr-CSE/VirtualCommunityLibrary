CREATE TABLE [dbo].[ItemParties](
	[ItemPartyID] [int] IDENTITY(1,1) NOT NULL,
	[ItemPartyName] [nvarchar](50) NOT NULL,
	[PartyAddress] [nvarchar](200) NULL,
	[PartyMobile] [nvarchar](50) NULL,
	[PartyNoteIfAny] [nvarchar](1000) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL,
	[ItemPartyTypeID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ItemParties] PRIMARY KEY CLUSTERED 
(
	[ItemPartyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]