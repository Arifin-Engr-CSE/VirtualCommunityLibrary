CREATE TABLE [dbo].[ItemBorrowStatus](
	[BorrowStatusID] [int] IDENTITY(1,1) primary key NOT NULL,
	[BorrowStatus] [nvarchar](50) NOT NULL,
	[BorrowDescription] [nvarchar](1000) NOT NULL,
	[LibraryLocationID] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	ModifiedBy [nvarchar](100) NULL
)