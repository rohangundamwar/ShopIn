namespace PrimeSolutions.Common
{
    public enum VyapariHideShowStatus
    {
        Delete = 1,
        NotDelete
    }
    public enum PurchaseBillType
    {
        Estimate = 1,
        Vat
    }

    public enum OperationType
    {
        Create = 1,
        Edit
    }

    public enum StockType
    {
        Impure = 1,
        Fine
    }

    public enum RateCutStatus
    {
        GoldToAmount,
        SilverToAmount,
        AmountToGold,
        AmountToSilver
    }
    

    public enum CustomerType
    {
        SupplierPurchaseGST = 1,
        SupplierPurchaseVAT,
        SupplierPurchaseJobWork,
        SupplierFine,
        CustomerGST,
        CustomerVAT,
        CustomerReceiptGST,
        DiamondPurchase,
        ImitationSale,
        ImitationPurchase,
        CustomerOpening,
        CustomerFine,
        CustomerSaleGST,
        DiamondSaleGST,
        CustomerOrder,
        DiamondPurchaseGST,
        ImitationSales,
        ExchangePurchase,
        ExchangeSale,
        FinePurchase,
        FineSale,
        VyapariGST,
        VyapariVAT,
        Voucher,
        ReceiptVoucher,
        PaymentVoucher,
        ModEntry,
        VyapariApproval

    }

    public enum TableNames
    {
        BarcodeMaster = 1,
        Rates,
        RefineAddedTransaction,
        RefinedMod,
        CaratMaster,
        Refinery_Items,
        RefineryUpdated,
        CeremonyMaster,
        RefineSendTransaction,
        RegistrationMaster,
        CompanyMaster,
        RestoreMaster,
        CreditDebitDetails,
        SalesBBillMaster,
        CreditDebitMaster,
        CrystalReportPath,
        Customer_Master,
        CustomerTypeMaster,
        DiamondPurchaseBillMaster,
        DiamondSalesBillMaster,
        ErrorLog,
        ExchangeBillMaster,
        ExchangeBillPayMaster,
        ExchangeCustomerMaster,
        FinancialYearMaster,
        FineStockItems,
        FineStockTable,
        FTPRegistration,
        holidaymaster,
        SalesBMaster,
        HSN_MetalNameAndMetalCode,
        SalesBPayMaster,
        HSNItemMap,
        ImitationPurchaseBillMaster,
        ImitationSaleBillMaster,
        SalesBRateCutMaster,
        Setting_Value,
        ImitationSupplierMaster,
        ImitationSupplierPayMaster,
        ItemMaster,
        BillItemMaster,
        SMSLink,
        Sold_data,
        StateDetail,
        SubMetalMaster,
        SupplierBookingBillMaster,
        SupplierBookingMaster,
        SupplierBookingPayMaster,
        SupplierBookingRatecutMaster,
        SupplierMaster,
        SupplierPayMaster,
        ItemMasterTemp,
        sysdiagrams,
        LoginMaster,
        MainSideMenu,
        MetalMaster,
        Mod_Entries,
        SupplierRatecutMaster,
        TrayMaster,
        Visibility,
        VisibilityNew,
        SalesPersonMaster,
        VyapariBillMaster,
        VyapariPayMaster,
        VyapariMaster,
        VyapariApprovalMaster,
        VyapariRateCutMaster,
        ModBBillMaster,
        ImitationCategoryMaping,
        ImitationCategoryMaster,
        MsgTemplate,
        Opening_Value,
        OpnenigLedger,
        OrderItemMaster,
        OrderMaster,
        PaymentDetail,
        AccountLedger,
        PurchaseBillMaster,
        ReportColumnVisibility,
        AccountNature,
        UpdateQueries,
        Is_Visible,
        VoucherType,
        PhysicalStockMaster,
        ReceiptMaster,
        PaymentMaster
    }
}


public enum DiamondPurchaseBillMaster
{
    DPBillID = 1,
    SupplierId,
    BillNo,
    PayMode,
    date,
    TotalAmount,
    BalanceAmount,
    paybycheque,
    chequeId,
    payByCash,
    comment,
    CustomerType,
    status,
    Time,
    fixorunfix,
    forwardstatus,
    DateTime,
    SupplierBillNo,
    SupplierVatNo,
    vat,
    vatPer,
    Narration,
    PermanentDelete,
    DiscountAmount,
    SGST,
    CGST,
    IGST
}

public enum DiamondSalesBillMaster
{
    DSBillID,
    AccNo,
    PayMode,
    date,
    BillNo,
    TotalAmount,
    BalanceAmount,
    payByCash,
    PayByCheque,
    chequeId,
    comment,
    status,
    vat,
    discount,
    Amount,
    ShowHidden,
    vatPer,
    discPer,
    PreviousOrderAmount,
    PreviousBalance,
    DateTime,
    SalesPerson,
    CompanyId,
    PermanantDelete,
    Narration,
    CBillNo,
    NewBillNo,
    PermanentDelete,
    SGSTPer,
    CGSTPer,
    IGSTPer,
    CustId
}


public enum ImitationBillMaster
{
    IMBillID,
    SupplierId,
    date,
    BillNo,
    TotalAmount,
    BalanceAmount,
    comment,
    status,
    vat,
    discount,
    ShowHidden,
    vatPer,
    discPer,
    DateTime,
    PermanentDelete,
    Narration,
    SGSTPer,
    CGSTPer,
    IGSTPer,
    SupplierBillNo
}

public enum ImitationCategoryMaping
{
    SubMetalID,
    ImitationCategoryId
}

public enum ReportColumnVisibility
{
    Account_Number,
    Full_Name,
    Address,
    Contact_Number,
    Pancard_Number,
    State_Code,
    Bill_Number,
    Payment_Mode,
    Total_Gold,
    Total_Amount,
    Balance_Gold,
    Balance_Amount,
    Pay_By_Cash,
    Pay_By_Cheque,
    Cheque_ID,
    Comment,
    Vat,
    Discount,
    Mod,
    Amount,
    Mod_Gold,
    Mod_Silver,
    Vat_Percent,
    Discount_Percent,
    Previous_Order_Amount,
    Previous_Balance,
    Sales_Person,
    Company_ID,
    Narration,
    Hall_mark_percent,
    Hall_mark_fixed,
    CGST_Percent,
    SGST_Percent,
    IGST_Percent,
    Customer_Type,
    HSN_Serial_Number,
    Metal_Name,
    Item_Name,
    Initial_Weight,
    Reduce_Weight,
    Final_Weight,
    Current_Price,
    Total_Fine_Amount,
    Making_Charges,
    Quantity,
    NetPrice,
    Making_Charges_Type,
    Making_Unit_Price,
    Permanent_Delete,
    Date

}

public enum ImitationCategoryMaster
{
    ICID,
    CategoryName
}
public enum ImitationSaleBillMaster
{
    ISBillID,
    BillNo,
    CustomerID,
    date,
    comment,
    discount,
    Narration,
    status,
    ShowHidden,
    TotalAmount,
    BalanceAmount,
    SGSTPer,
    CGSTPer,
    IGSTPer,
    DateTime,
    PermanentDelete,
    AccNo,
    SalesPersonID,
    SupplierID
}


public enum ImitationSupplierMaster
{
    SrNo,
    SupplierId,
    Name,
    AccPartyName,
    Address,
    ContactNo,
    DateTime,
    SupplierVatNo,
    SupplierBillNo,
    StateCode,
    BillNo
}
public enum ImitationSupplierPayMaster
{
    supplierId,
    date,
    Amount,
    Gold,
    comment,
    status,
    PayslipNo,
    Silver,
    Time,
    BillNo,
    forwardstatus,
    ShowHidden,
    DateTime
}


public enum SalesBBillMaster
{
    AccNo,
    PayMode,
    date,
    BillNo,
    TotalAmount,
    totalGold,
    BalanceAmount,
    balanceGold,
    payByCash,
    PayByCheque,
    chequeId,
    comment,
    status,
    SBillID,
    vat,
    discount,
    mod,
    Amount,
    ShowHidden,
    modGold,
    modSilver,
    vatPer,
    discPer,
    PreviousOrderAmount,
    PreviousBalance,
    DateTime,
    SalesPerson,
    CompanyId,
    PermanentDelete,
    Narration,
    CBillNo,
    NewBillNo,
    Hm_per,
    Hm_fix,
    SGSTPer,
    CGSTPer,
    IGSTPer,
    CustID,
    CustomerType
}

public enum SalesBMaster
{
    AccNo,
    barcodeImage,
    FullName,
    Address,
    emailInfo,
    ContactNO,
    relese,
    PancardNo,
    DateTime,
    PermanentDelete,
    Profile,
    Doc1,
    Doc2,
    Doc3,
    Doc4,
    Defaulter,
    CustId,
    StateCode
}


public enum SalesBPayMaster
{
    payslipNo,
    AccNo,
    Date,
    GoldGiven,
    AmountGiven,
    comment,
    relese,
    status,
    ShowHidden,
    BillNo,
    DateTime,
    CompanyId,
    PermanentDelete,
    SBillID,
    SaleType,
    OrderID,
    ISBillID,
    DSBillID,
    MBillID
}

public enum SalesBRateCutMaster
{
    SrNo,
    Accno,
    date,
    amount,
    gold,
    comment,
    status,
    VSrno,
    DateTime,
    PermanentDelete,
    Silver
}

public enum SalesPersonMaster
{
    id,
    SalesPerson,
    DateTime,
    Salary,
    PermanentDelete
}

public enum SupplierBookingBillMaster
{
    SupplierId,
    BillNo,
    PayMode,
    date,
    TotalAmount,
    TotalGold,
    BalanceAmount,
    BalanceGold,
    paybycheque,
    chequeId,
    payByCash,
    comment,
    CustomerType,
    status,
    SrNo,
    TotalSilver,
    BalanceSilver,
    Time,
    fixorunfix,
    forwardstatus,
    Difference,
    DateTime
}

public enum SupplierBookingMaster
{
    SrNo,
    SupplierId,
    Name,
    AccPartyName,
    Address,
    tinNo,
    DateTime
}

public enum SupplierBookingPayMaster
{
    supplierId,
    date,
    Amount,
    Gold,
    comment,
    status,
    PayslipNo,
    Silver,
    Time,
    BillNo,
    forwardstatus,
    DateTime
}

public enum SupplierBookingRatecutMaster
{
    SrNo,
    AccountNo,
    date,
    amount,
    gold,
    comment,
    status,
    Silver,
    Time,
    BillNo,
    forwardstatus,
    type,
    DateTime
}

public enum AccountLedger
{
    ledgerId,
    accGroupId,
    Name,
    OpeningBal,
    CreditOrDebit,
    Narration,
    BankAccNo,
    NameOfBranch,
    BranchCode,
    AccNo,
    Date,
    DateTime,
    financialYearId,
    PermanentDelete,
    IsDefault,
    VoucherTypeID
}

public enum SupplierMaster
{
    SrNo,
    GSTNO,
    SupplierId,
    Name,
    AccPartyName,
    Address,
    ContactNo,
    VatNo,
    Owner,
    StateCode,
    DateTime,
    PermanentDelete,
    AID
}

public enum SupplierPayMaster
{
    PayslipNo,
    supplierId,
    PBillID,
    BillNo,
    date,
    Amount,
    Gold,
    comment,
    status,
    Silver,
    Time,
    forwardstatus,
    DateTime,
    PermanentDelete,
    DPBillID,
    IMBillID,
    PaymentType,
    RCSrNo
}

public enum SupplierRatecutMaster
{
    SrNo,
    AccountNo,
    date,
    Amount,
    Gold,
    comment,
    status,
    Silver,
    Time,
    BillNo,
    forwardstatus,
    type,
    DateTime,
    PreviousBalanceAmount,
    PreviousBalanceSilver,
    PreviousBalanceGold,
    PBillID
}

public enum SubMetalMaster
{
    SubMetalId,
    SubMetalName,
    SubMetalHindi,
}

public enum MetalMaster
{
    MetalId,
    MetalName,
    MetalHindi,
    MetalEnglish,
    MetalMarathi,
    PermanentDelete
}

public enum Mod_Entries
{
    SrNo,
    Mod_ID,
    MBillID,
    SBillID,
    VBillID,
    OrderID,
    IDs,
    Metal_Type,
    Item_Type,
    W_T,
    Reduce_W_T,
    Final_WT,
    Fine_Weight,
    Final_Weight_In_Percentage,
    Current_Price,
    Total_Amount,
    Date,
    Time,
    Status,
    Form_Identity,
    Acc_No,
    MID,
    SID,
    Making_Charges,
    Quantity,
    Final_Amount,
    DateTime,
    PermanantDelete,
    Narration,
    HSNID,
    HSNMapID,
    PermanentDelete
}

public enum ModBBillMaster
{
    MBillID,
    SBillID,
    VBillID,
    OrderID,
    BillNo,
    AccNo,
    date,
    TotalAmount,
    DateTime,
    CompanyId,
    PermanantDelete,
    Narration,
    SGSTPer,
    CGSTPer,
    IGSTPer,
    Amount,
    CBillNo,
    NewBillNo,
}

public enum ItemMaster
{
    SrNo,
    ItemCode,
    HSN_ID,
    Metaltype,
    itemtype,
    specify,
    wt,
    reducewt,
    finalwt,
    finalwtinpercent,
    finewt,
    currentprice,
    fineamount,
    makingcharges,
    quantity,
    netprice,
    comment,
    Date,
    CheckTrue,
    MetalId,
    SubMetalType,
    FromWhere,
    status,
    barcodecheck,
    BillItemNo,
    bulk_item,
    Barcode,
    trayId,
    Narration,
    MakingChargeType,
    MakingUnitPrice,
    DateTime,
    HSNMapID,
    IPurchasePrice,
    ITotalPrice,
    ISalePrice,
    DGoldWt,
    DGoldCarat,
    DiamondWt,
    DiamondCut,
    DiamondQuality,
    DiamondColour,
    DMRP,
    DSellAmount
}

public enum BillItemMaster
{
    SrNo,
    PBillID,
    DPBillID,
    IMBillID,
    VBillID,
    SBillID,
    ISBillID,
    DSBillID,
    BillNO,
    Item_Code,
    HSNSrNo,
    MetalID,
    itemId,
    specify,
    InitialWt,
    ReduceWt,
    FinalWt,
    FinalWtInPercent,
    FineWT,
    CurrentPrice,
    TotalFineAmount,
    MakingCharges,
    Quantity,
    NetPrice,
    Date,
    CustomerType,
    MakingChargeType,
    MakingUnitPrice,
    MID,
    SID,
    CompanyId,
    Comment,
    DateTime,
    PermanentDelete,
    HSNMapID,
    IPurchasePrice,
    ITotalPrice,
    ISellPrice,
    DGoldWt,
    DGoldCarat,
    DiamondWt,
    DiamondCut,
    DiamondQuality,
    DiamondColour,
    DiamondAmount,
    DSellAmount,
    VoucherNo
}

public enum FinancialYearMaster
{
    id,
    startyear,
    endyear,
    isSelected
}

public enum Setting_Value
{
    SrNo,
    language,
    visibility,
    fund_month,
    interest,
    receipt,
    Searchtype,
    printt,
    DateTime,
    PavtiNoAutoIncrement,
    sms,
    BillType,
    vat,
    PaymentForm,
    vatper,
    salescount,
    purchasecount,
    BarcodePrint,
    SaleWithModPrint,
    CGST_Amount,
    SGST_Amount,
    IGST_Amount,
    CGST_Making,
    SGST_Making,
    IGST_Making,
    PermanentDelete
}

public enum PayType
{
    Dr,
    Cr
}

public enum OrderMaster
{
    AccNo,
    PayMode,
    date,
    OrderNo,
    TotalAmount,
    totalGold,
    BalanceAmount,
    balanceGold,
    payByCash,
    PayByCheque,
    chequeId,
    comment,
    status,
    mod,
    Amount,
    ShowHidden,
    modGold,
    modSilver,
    payBalance,
    DateTime,
    DeliverDate,
    Narration,
    vat,
    discount,
    vatPer,
    discPer,
    SGSTPer,
    CGSTPer,
    IGSTPer,
    OrderID,
    PermanentDelete
}

public enum PurchaseBillMaster
{
    PBillID,
    SupplierId,
    BillNo,
    SupplierInvoiceNo,
    PayMode,
    date,
    TotalAmount,
    TotalGold,
    TotalSilver,
    BalanceAmount,
    BalanceGold,
    BalanceSilver,
    paybycheque,
    chequeId,
    payByCash,
    comment,
    CustomerType,
    status,
    Time,
    fixorunfix,
    forwardstatus,
    SupplierBillNo,
    SupplierVatNo,
    vat,
    vatPer,
    Narration,
    ExcessDue,
    ExcessDuePer,
    PurchaseBillType,
    DiscountAmount,
    SGST,
    CGST,
    IGST,
    DateTime,
    PermanentDelete
}

public enum VyapariMaster
{
    VyapariID,
    AccNo,
    FullName,
    Address,
    EmailInfo,
    ContactNo,
    ShopName,
    PancardNo,
    GSTNo,
    StateCode,
    BlackList,
    DateTime,
    PermanentDelete,
    VyapariType,
    District,
    Area
}

public enum VyapariPayMaster
{
    VPayNo,
    AccNo,
    VBillID,
    BillNo,
    Date,
    AmountGiven,
    GoldGiven,
    SilverGiven,
    PreviousBalanceAmount,
    PreviousBalanceSilver,
    PreviousBalanceGold,
    Comment,
    DateTime,
    PermanentDelete,
    PaymentType
}


public enum VyapariRateCutMaster
{
    VSrno,
    VBillID,
    AccNo,
    Date,
    Amount,
    Gold,
    Silver,
    Comment,
    Type,
    PreviousBalanceAmount,
    PreviousBalanceSilver,
    PreviousBalanceGold,
    DateTime,
    PermanentDelete
}

public enum VyapariBillMaster
{
    VBillID,
    AccNo,
    BillNo,
    VyapariID,
    PayMode,
    Date,
    TotalAmount,
    BalanceAmount,
    TotalGold,
    BalanceGold,
    PayByCash,
    Comment,
    TotalSilver,
    BalanceSilver,
    PreviousBalanceAmount,
    PreviousBalanceGold,
    PreviousBalanceSilver,
    DateTime,
    DiscPer,
    DiscAmount,
    SGSTPer,
    CGSTPer,
    IGSTPer,
    Narration,
    PermanentDelete,
        AID,
        CustomerType,
    VatPer,
    Hidden

}
public enum VyapariApprovalMaster
{
    VAID,
    BillNo,
    SalesPersonID,
    TotalGrossW,
    TotalFineW,
    TotalMakingCharges,
    SalesPersonName,
    PermanentDelete,
    CustomerType



}