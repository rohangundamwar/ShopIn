USe['Gropure']

TRUNCATE TABLE AccountLedger
TRUNCATE TABLE BillItem
TRUNCATE TABLE CategoryMaster
TRUNCATE TABLE CreditDebitDetails
TRUNCATE TABLE CustomerBill
TRUNCATE TABLE CustomerMaster
TRUNCATE TABLE ErrorLog
TRUNCATE TABLE LooseItem
TRUNCATE TABLE Payment
TRUNCATE TABLE PaymentMaster
TRUNCATE TABLE ReceiptMaster
TRUNCATE TABLE SalesmanMaster
TRUNCATE TABLE SubCategoryMaster
TRUNCATE TABLE SupplierBill
TRUNCATE TABLE SupplierMaster
TRUNCATE TABLE Temp
TRUNCATE TABLE Maintenance
DROP TABLE Activation

CREATE TABLE [dbo].[Activation](
	[StartDate] [nvarchar](max) NULL,
	[Validity] [nvarchar](max) NULL CONSTRAINT [DF_Activation_Validity]  DEFAULT ((30)),
	[SerialNo] [nvarchar](max) NULL,
	[SrNo] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

insert into [Activation] values(Convert(varchar,GETDATE(),103),'15','')


INSERT [dbo].[CustomerMaster] ([SrNo], [CustId], [CustomerName], [Address], [ContactNo], [PanNo], [GSTIN], [State], [City], [Opening]) VALUES (1, N'C0000001', N'Counter', N'--', N'--', N'', N'', N'27-Maharashtra', N'nagpur', N'0')



