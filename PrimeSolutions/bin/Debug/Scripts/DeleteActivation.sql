DROP TABLE Activation

CREATE TABLE [dbo].[Activation](
	[StartDate] [nvarchar](max) NULL,
	[Validity] [nvarchar](max) NULL CONSTRAINT [DF_Activation_Validity]  DEFAULT ((30)),
	[SerialNo] [nvarchar](max) NULL,
	[SrNo] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


insert into [Activation] values(Convert(varchar,GETDATE(),103),'15','')