CREATE TABLE [dbo].[ItemPhoto](
	[PhotoID] [int] IDENTITY(1,1) Primary Key NOT NULL,
	[PhotoURL] [nvarchar](2000) NULL,
	[PhotoBinary] [varbinary](max) NULL,
	[PhotoPriority] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL

)
GO
ALTER TABLE [dbo].[ItemPhoto] ADD  DEFAULT ((0)) FOR [PhotoPriority]