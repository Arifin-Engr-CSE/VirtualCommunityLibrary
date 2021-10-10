CREATE TABLE [dbo].[ItemParty](
	[ItemPartyID] [int] IDENTITY(1,1) primary key NOT NULL,
	[PartyName] [nvarchar](50) NOT NULL,
	[PartyTypeID] [int] NOT NULL,
	[LibraryLocationID]  [int] NULL,
	[PartyAddress] [nvarchar](200) NULL,
	[PartyMobile] [nvarchar](50) NULL,
	[PartyNoteIfAny] [nvarchar](1000) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL
)