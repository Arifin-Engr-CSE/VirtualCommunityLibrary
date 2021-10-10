CREATE TABLE [dbo].[Item](
	[ItemID] [int] IDENTITY(1,1) primary key NOT NULL,
	[ItemName] [nvarchar](50) NOT NULL,
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
	[ModifiedBy] [nvarchar](100) NULL
)