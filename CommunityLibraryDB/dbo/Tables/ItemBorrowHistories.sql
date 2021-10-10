CREATE TABLE [dbo].[ItemBorrowHistories](
	[ItemBorrowID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NULL,
	[ItemPartyID] [int] NULL,
	[LibraryLocationID] [int] NULL,
	[BorrowDate] [datetime] NULL,
	[BorrowedForHowManyDays] [int] NOT NULL,
	[ReturnDate] [datetime] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL,
	[ItemBorrowDayCountID] [int] NULL,
 CONSTRAINT [PK_dbo.ItemBorrowHistories] PRIMARY KEY CLUSTERED 
(
	[ItemBorrowID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]