USE [ShopIn]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 12/14/2017 16:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserID] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Type] [nvarchar](max) NOT NULL
) ON [PRIMARY]

Insert into Login values('100','100','admin')
