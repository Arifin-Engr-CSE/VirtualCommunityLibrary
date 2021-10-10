CREATE TABLE [dbo].[ItemPhotoes](
	[PhotoID] [int] IDENTITY(1,1) NOT NULL,
	[PhotoURL] [nvarchar](2000) NULL,
	[PhotoBinary] [varbinary](max) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](100) NULL,
	[ItemID] [int] NOT NULL,
	[PhotoPriority] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ItemPhotoes] PRIMARY KEY CLUSTERED 
(
	[PhotoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ItemPhotoes] ADD  DEFAULT ((0)) FOR [PhotoPriority]