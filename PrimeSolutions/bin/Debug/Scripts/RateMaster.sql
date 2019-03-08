
CREATE TABLE [dbo].[RateMaster](
	[SrNo] [int] IDENTITY(1,1) NOT NULL,
	[Barcode] [nvarchar](max) NULL,
	[Category] [nvarchar](max) NULL,
	[SubCategory] [nvarchar](max) NULL,
	[Size] [nvarchar](max) NULL,
	[SellingPrice] [nvarchar](max) NULL,
	[GST] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



