CREATE TABLE [dbo].[ItemBorrowDayCount](
	[LibraryLocationID] [int] NOT NULL,
	[NumberOfDays] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL
)