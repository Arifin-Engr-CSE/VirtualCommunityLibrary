CREATE TABLE [dbo].[ItemBorrowHistory](
	[ItemBorrowID] [int] IDENTITY(1,1) Primary Key NOT NULL,
	[ItemID] [int] NULL,
	[ItemPartyID] [int] NULL,
	[LibraryLocationID] [int] NULL,
	[BorrowDate] [datetime] NULL,
	[BorrowedForHowManyDays] [int] NOT NULL,
	[CalculatedReturnDate] [datetime] NULL,
	[ActualReturnDate] [datetime] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL
)
