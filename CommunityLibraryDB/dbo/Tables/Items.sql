CREATE TABLE [dbo].[Items](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](50) NOT NULL,
	[ItemLocationID] [int] NULL,
	[ItemOwnerID] [int] NULL,
	[ItemMaker] [nvarchar](50) NULL,
	[ItemProducer] [nvarchar](50) NULL,
	[ItemTypeID] [int] NULL,
	[ItemHasPhoto] [bit] NOT NULL,
	[ItemBorrowStatusID] [int] NULL,
	[LibraryLocationID] [int] NULL,
	[ItemConditionWhenRegistered] [nvarchar](1000) NULL,
	[AdditionalNote] [nvarchar](1000) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL,
 CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]