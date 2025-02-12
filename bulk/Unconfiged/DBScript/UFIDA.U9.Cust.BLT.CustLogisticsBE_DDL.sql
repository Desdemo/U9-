set QUOTED_IDENTIFIER on
set ANSI_PADDING on

/*=================================================*/
/*       Drop database element                     */
/*=================================================*/

/*=============FK================*/

if object_id(N'fk_Cust_BLT_Logistics_CalculationFeeLine_Item_reference_CBO_ItemMaster_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFeeLine]
        drop constraint fk_Cust_BLT_Logistics_CalculationFeeLine_Item_reference_CBO_ItemMaster_ID
go

if object_id(N'fk_Cust_BLT_Logistics_CalculationFeeLine_SalesUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFeeLine]
        drop constraint fk_Cust_BLT_Logistics_CalculationFeeLine_SalesUom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_BLT_Logistics_CalculationFeeLine_BulkUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFeeLine]
        drop constraint fk_Cust_BLT_Logistics_CalculationFeeLine_BulkUom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_BLT_Logistics_CalculationFeeLine_WeightUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFeeLine]
        drop constraint fk_Cust_BLT_Logistics_CalculationFeeLine_WeightUom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_BLT_Logistics_CalculationFeeLine_PricingUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFeeLine]
        drop constraint fk_Cust_BLT_Logistics_CalculationFeeLine_PricingUom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_BLT_Logistics_CalculationFee_Sup_reference_CBO_Supplier_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFee]
        drop constraint fk_Cust_BLT_Logistics_CalculationFee_Sup_reference_CBO_Supplier_ID
go

if object_id(N'fk_Cust_BLT_Logistics_CalculationFee_HuangdaoTotal_reference_Cust_BLT_Logistics_CalculationFeeTotalLine_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFee]
        drop constraint fk_Cust_BLT_Logistics_CalculationFee_HuangdaoTotal_reference_Cust_BLT_Logistics_CalculationFeeTotalLine_ID
go

if object_id(N'fk_Cust_BLT_Logistics_CalculationFee_ChenyangTotal_reference_Cust_BLT_Logistics_CalculationFeeTotalLine_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFee]
        drop constraint fk_Cust_BLT_Logistics_CalculationFee_ChenyangTotal_reference_Cust_BLT_Logistics_CalculationFeeTotalLine_ID
go

if object_id(N'fk_Cust_BLT_Logistics_CalculationFee_SetLocation_reference_Cust_BLT_Logistics_LogisticsPricelistLine_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFee]
        drop constraint fk_Cust_BLT_Logistics_CalculationFee_SetLocation_reference_Cust_BLT_Logistics_LogisticsPricelistLine_ID
go

if object_id(N'fk_Cust_BLT_Logistics_CalculationFee_Province_reference_Base_Province_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFee]
        drop constraint fk_Cust_BLT_Logistics_CalculationFee_Province_reference_Base_Province_ID
go

if object_id(N'fk_Cust_BLT_Logistics_CalculationFee_City_reference_Base_City_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFee]
        drop constraint fk_Cust_BLT_Logistics_CalculationFee_City_reference_Base_City_ID
go

if object_id(N'fk_Cust_BLT_Logistics_CalculationFee_County_reference_Base_County_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_CalculationFee]
        drop constraint fk_Cust_BLT_Logistics_CalculationFee_County_reference_Base_County_ID
go

if object_id(N'fk_Cust_BLT_Logistics_LogisticsPricelist_Sup_reference_CBO_Supplier_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_LogisticsPricelist]
        drop constraint fk_Cust_BLT_Logistics_LogisticsPricelist_Sup_reference_CBO_Supplier_ID
go

if object_id(N'fk_Cust_BLT_Logistics_LogisticsPricelist_Currency_reference_Base_Currency_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_LogisticsPricelist]
        drop constraint fk_Cust_BLT_Logistics_LogisticsPricelist_Currency_reference_Base_Currency_ID
go

if object_id(N'fk_Cust_BLT_Logistics_LogisticsPricelistLine_Address_reference_Base_Location_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
        drop constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_Address_reference_Base_Location_ID
go

if object_id(N'fk_Cust_BLT_Logistics_LogisticsPricelistLine_PricingUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
        drop constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_PricingUom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_BLT_Logistics_LogisticsPricelistLine_DynamicPrice_reference_Cust_BLT_Logistics_DynamicPrice_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
        drop constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_DynamicPrice_reference_Cust_BLT_Logistics_DynamicPrice_ID
go

if object_id(N'fk_Cust_BLT_Logistics_LogisticsPricelistLine_Province_reference_Base_Province_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
        drop constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_Province_reference_Base_Province_ID
go

if object_id(N'fk_Cust_BLT_Logistics_LogisticsPricelistLine_City_reference_Base_City_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
        drop constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_City_reference_Base_City_ID
go

if object_id(N'fk_Cust_BLT_Logistics_LogisticsPricelistLine_County_reference_Base_County_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
        drop constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_County_reference_Base_County_ID
go

if object_id(N'fk_Cust_BLT_Logistics_DynamicPrice_Uom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_DynamicPrice]
        drop constraint fk_Cust_BLT_Logistics_DynamicPrice_Uom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_BLT_Logistics_FeeRecord_WeightUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_FeeRecord]
        drop constraint fk_Cust_BLT_Logistics_FeeRecord_WeightUom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_BLT_Logistics_FeeRecord_BulkUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_FeeRecord]
        drop constraint fk_Cust_BLT_Logistics_FeeRecord_BulkUom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_BLT_Logistics_FeeRecord_Supplier_reference_CBO_Supplier_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_FeeRecord]
        drop constraint fk_Cust_BLT_Logistics_FeeRecord_Supplier_reference_CBO_Supplier_ID
go

if object_id(N'fk_Cust_BLT_Logistics_FeeRecord_City_reference_Base_City_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_FeeRecord]
        drop constraint fk_Cust_BLT_Logistics_FeeRecord_City_reference_Base_City_ID
go

if object_id(N'fk_Cust_BLT_Logistics_FeeRecord_County_reference_Base_County_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_FeeRecord]
        drop constraint fk_Cust_BLT_Logistics_FeeRecord_County_reference_Base_County_ID
go

if object_id(N'fk_Cust_BLT_Logistics_FeeRecord_Province_reference_Base_Province_ID', N'F') is not null
    alter table [Cust_BLT_Logistics_FeeRecord]
        drop constraint fk_Cust_BLT_Logistics_FeeRecord_Province_reference_Base_Province_ID
go

/*=============Table================*/

if object_id(N'[Cust_BLT_Logistics_CalculationFeeLine]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_Logistics_CalculationFeeLine]',@IsChildTable=0
    drop table [Cust_BLT_Logistics_CalculationFeeLine]
end
go

if object_id(N'[Cust_BLT_Logistics_CalculationFee]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_Logistics_CalculationFee]',@IsChildTable=0
    drop table [Cust_BLT_Logistics_CalculationFee]
end
go

if object_id(N'[Cust_BLT_Logistics_LogisticsPricelist]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_Logistics_LogisticsPricelist]',@IsChildTable=0
    drop table [Cust_BLT_Logistics_LogisticsPricelist]
end
go

if object_id(N'[Cust_BLT_Logistics_LogisticsPricelistLine]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_Logistics_LogisticsPricelistLine]',@IsChildTable=0
    drop table [Cust_BLT_Logistics_LogisticsPricelistLine]
end
go

if object_id(N'[Cust_BLT_Logistics_DynamicPrice]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_Logistics_DynamicPrice]',@IsChildTable=0
    drop table [Cust_BLT_Logistics_DynamicPrice]
end
go

if object_id(N'[Cust_BLT_Logistics_DynamicPriceLine]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_Logistics_DynamicPriceLine]',@IsChildTable=0
    drop table [Cust_BLT_Logistics_DynamicPriceLine]
end
go

if object_id(N'[Cust_BLT_Logistics_FeeRecord]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_Logistics_FeeRecord]',@IsChildTable=0
    drop table [Cust_BLT_Logistics_FeeRecord]
end
go

if object_id(N'[Cust_BLT_Logistics_CalculationFeeTotalLine]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_Logistics_CalculationFeeTotalLine]',@IsChildTable=0
    drop table [Cust_BLT_Logistics_CalculationFeeTotalLine]
end
go

if object_id(N'[Cust_BLT_Logistics_FeeRecordLinked]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_Logistics_FeeRecordLinked]',@IsChildTable=0
    drop table [Cust_BLT_Logistics_FeeRecordLinked]
end
go

/*=================================================*/
/*       Create database element                   */
/*=================================================*/

/*=============Table================*/

create table [Cust_BLT_Logistics_CalculationFeeLine]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [DocNo] nvarchar(50) null,
    [DocID] bigint null,
    [LineID] bigint null,
    [Item] bigint null,
    [Qty] float(53) null,
    [SalesUom] bigint null,
    [RealDeliveryFactory] int null,
    [RealPricingMethod] int null,
    [IBulk] float(53) null,
    [BulkUom] bigint null,
    [Weight] float(53) null,
    [WeightUom] bigint null,
    [PricingQty] float(53) null,
    [PricingUom] bigint null,
    [DocType] int null,
    [CalculationFee] bigint null
)
go
exec p_CreateCustomType 'Cust_BLT_Logistics_CalculationFeeLine'
go

create table [Cust_BLT_Logistics_CalculationFee]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [Sup] bigint null,
    [DeliveryFactory] int null,
    [Address] nvarchar(50) null,
    [ShipDate] datetime null,
    [PricingMethod] int null,
    [TotalAmount] float(53) null,
    [RealAmount] float(53) null,
    [UintPrice] float(53) null,
    [Remark] nvarchar(50) null,
    [Contain] bit null,
    [NumberOfTrucks] int null,
    [HuangdaoTotal] bigint null,
    [ChenyangTotal] bigint null,
    [SetLocation] bigint null,
    [Province] bigint null,
    [City] bigint null,
    [County] bigint null,
    [DescriLocation] nvarchar(50) null
)
go
exec p_CreateCustomType 'Cust_BLT_Logistics_CalculationFee'
go

create table [Cust_BLT_Logistics_LogisticsPricelist]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [Code] nvarchar(50) null,
    [Name] nvarchar(50) null,
    [Sup] bigint null,
    [Currency] bigint null
)
go
exec p_CreateCustomType 'Cust_BLT_Logistics_LogisticsPricelist'
go

create table [Cust_BLT_Logistics_LogisticsPricelistLine]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [No] int null,
    [DeliveryFactory] int null,
    [Address] bigint null,
    [PricingMethod] int null,
    [PricingUom] bigint null,
    [UintPrice] float(53) null,
    [DynamicPrice] bigint null,
    [DeliveryPickup] float(53) null,
    [DeliveryCharges] float(53) null,
    [FreePickup] float(53) null,
    [FreeDelivery] float(53) null,
    [TransportationTime] nvarchar(50) null,
    [Remark] nvarchar(50) null,
    [LogisticsPricelist] bigint null,
    [Province] bigint null,
    [City] bigint null,
    [County] bigint null,
    [DescribeAddress] nvarchar(50) null,
    [FormatAddress] nvarchar(50) null
)
go
exec p_CreateCustomType 'Cust_BLT_Logistics_LogisticsPricelistLine'
go

create table [Cust_BLT_Logistics_DynamicPrice]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [Code] nvarchar(50) null,
    [Uom] bigint null,
    [Remark] nvarchar(50) null,
    [DynamicPriceType] int null,
    [EffectField] int null,
    [Name] nvarchar(50) null
)
go
exec p_CreateCustomType 'Cust_BLT_Logistics_DynamicPrice'
go

create table [Cust_BLT_Logistics_DynamicPriceLine]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [No] int null,
    [UnitPrice] float(53) null,
    [Start] float(53) null,
    [Cutoff] float(53) null,
    [Total] float(53) null,
    [Remark] nvarchar(50) null,
    [DynamicPrice] bigint null
)
go
exec p_CreateCustomType 'Cust_BLT_Logistics_DynamicPriceLine'
go

create table [Cust_BLT_Logistics_FeeRecord]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [BusinessType] int null,
    [Salesman] nvarchar(50) null,
    [CustomerContact] nvarchar(50) null,
    [ContactPhone] nvarchar(50) null,
    [ShipDate] datetime null,
    [SaleNo] nvarchar(50) null,
    [Supplier] bigint null,
    [Qty] decimal(24, 9) null,
    [ProductCategory] int null,
    [Province] bigint null,
    [IBulk] decimal(24, 9) null,
    [Weight] decimal(24, 9) null,
    [BulkUom] bigint null,
    [WeightUom] bigint null,
    [PickupFee] decimal(24, 9) null,
    [DeliveryFee] decimal(24, 9) null,
    [DischargeFee] decimal(24, 9) null,
    [OtherFee] decimal(24, 9) null,
    [StandardShipping] decimal(24, 9) null,
    [TotalFreight] decimal(24, 9) null,
    [RealFreight] decimal(24, 9) null,
    [AverageCost] decimal(24, 9) null,
    [UintPrice] decimal(24, 9) null,
    [Remark] nvarchar(50) null,
    [City] bigint null,
    [County] bigint null,
    [DescribeAddress] nvarchar(50) null,
    [FullAddress] nvarchar(50) null
)
go
exec p_CreateCustomType 'Cust_BLT_Logistics_FeeRecord'
go

create table [Cust_BLT_Logistics_CalculationFeeTotalLine]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [TotalBulk] float(53) null,
    [TotalWeight] float(53) null,
    [RealBulk] float(53) null,
    [RealWeight] float(53) null,
    [PickupFee] float(53) null,
    [DeliveryFee] float(53) null,
    [DischargeFee] float(53) null,
    [OtherFee] float(53) null,
    [TotalFreight] float(53) null,
    [RealFreight] float(53) null
)
go
exec p_CreateCustomType 'Cust_BLT_Logistics_CalculationFeeTotalLine'
go

create table [Cust_BLT_Logistics_FeeRecordLinked]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [SrcType] int null,
    [SrcDocID] bigint null,
    [Amount] float(53) null,
    [DeliveryID] bigint null,
    [SrcDocNo] nvarchar(50) null,
    [DeliveryNo] nvarchar(50) null
)
go
exec p_CreateCustomType 'Cust_BLT_Logistics_FeeRecordLinked'
go

/*=============PK================*/

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    add constraint pk_Cust_BLT_Logistics_CalculationFeeLine
    primary key clustered
    ([ID] asc)
go

alter table [Cust_BLT_Logistics_CalculationFee]
    add constraint pk_Cust_BLT_Logistics_CalculationFee
    primary key clustered
    ([ID] asc)
go

alter table [Cust_BLT_Logistics_LogisticsPricelist]
    add constraint pk_Cust_BLT_Logistics_LogisticsPricelist
    primary key clustered
    ([ID] asc)
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    add constraint pk_Cust_BLT_Logistics_LogisticsPricelistLine
    primary key clustered
    ([ID] asc)
go

alter table [Cust_BLT_Logistics_DynamicPrice]
    add constraint pk_Cust_BLT_Logistics_DynamicPrice
    primary key clustered
    ([ID] asc)
go

alter table [Cust_BLT_Logistics_DynamicPriceLine]
    add constraint pk_Cust_BLT_Logistics_DynamicPriceLine
    primary key clustered
    ([ID] asc)
go

alter table [Cust_BLT_Logistics_FeeRecord]
    add constraint pk_Cust_BLT_Logistics_FeeRecord
    primary key clustered
    ([ID] asc)
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    add constraint pk_Cust_BLT_Logistics_CalculationFeeTotalLine
    primary key clustered
    ([ID] asc)
go

alter table [Cust_BLT_Logistics_FeeRecordLinked]
    add constraint pk_Cust_BLT_Logistics_FeeRecordLinked
    primary key clustered
    ([ID] asc)
go

/*=============Index================*/

create unique nonclustered index UFIDA_U9_Cust_BLT_CustLogisticsBE_LogisticsPricelist_BusinessKey_Index
    on [Cust_BLT_Logistics_LogisticsPricelist]([Code]  ASC, [Sup]  ASC, [Currency]  ASC)
go

create unique nonclustered index UFIDA_U9_Cust_BLT_CustLogisticsBE_LogisticsPricelistLine_BusinessKey_Index
    on [Cust_BLT_Logistics_LogisticsPricelistLine]([PricingMethod]  ASC, [DeliveryFactory]  ASC, [LogisticsPricelist]  ASC, [FormatAddress]  ASC)
go

create unique nonclustered index UFIDA_U9_Cust_BLT_CustLogisticsBE_DynamicPrice_BusinessKey_Index
    on [Cust_BLT_Logistics_DynamicPrice]([Code]  ASC, [DynamicPriceType]  ASC, [EffectField]  ASC, [Uom]  ASC)
go

create unique nonclustered index UFIDA_U9_Cust_BLT_CustLogisticsBE_FeeRecordLinked_BusinessKey_Index
    on [Cust_BLT_Logistics_FeeRecordLinked]([SrcDocID]  ASC, [DeliveryID]  ASC)
go

/*=============FK================*/

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFeeLine_Item_reference_CBO_ItemMaster_ID
    foreign key ([Item])
    references [CBO_ItemMaster]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFeeLine_SalesUom_reference_Base_UOM_ID
    foreign key ([SalesUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFeeLine_BulkUom_reference_Base_UOM_ID
    foreign key ([BulkUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFeeLine_WeightUom_reference_Base_UOM_ID
    foreign key ([WeightUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFeeLine_PricingUom_reference_Base_UOM_ID
    foreign key ([PricingUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFee_Sup_reference_CBO_Supplier_ID
    foreign key ([Sup])
    references [CBO_Supplier]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFee_HuangdaoTotal_reference_Cust_BLT_Logistics_CalculationFeeTotalLine_ID
    foreign key ([HuangdaoTotal])
    references [Cust_BLT_Logistics_CalculationFeeTotalLine]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFee_ChenyangTotal_reference_Cust_BLT_Logistics_CalculationFeeTotalLine_ID
    foreign key ([ChenyangTotal])
    references [Cust_BLT_Logistics_CalculationFeeTotalLine]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFee_SetLocation_reference_Cust_BLT_Logistics_LogisticsPricelistLine_ID
    foreign key ([SetLocation])
    references [Cust_BLT_Logistics_LogisticsPricelistLine]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFee_Province_reference_Base_Province_ID
    foreign key ([Province])
    references [Base_Province]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFee_City_reference_Base_City_ID
    foreign key ([City])
    references [Base_City]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint fk_Cust_BLT_Logistics_CalculationFee_County_reference_Base_County_ID
    foreign key ([County])
    references [Base_County]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_LogisticsPricelist]
    with check
    add constraint fk_Cust_BLT_Logistics_LogisticsPricelist_Sup_reference_CBO_Supplier_ID
    foreign key ([Sup])
    references [CBO_Supplier]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_LogisticsPricelist]
    with check
    add constraint fk_Cust_BLT_Logistics_LogisticsPricelist_Currency_reference_Base_Currency_ID
    foreign key ([Currency])
    references [Base_Currency]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_Address_reference_Base_Location_ID
    foreign key ([Address])
    references [Base_Location]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_PricingUom_reference_Base_UOM_ID
    foreign key ([PricingUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_DynamicPrice_reference_Cust_BLT_Logistics_DynamicPrice_ID
    foreign key ([DynamicPrice])
    references [Cust_BLT_Logistics_DynamicPrice]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_Province_reference_Base_Province_ID
    foreign key ([Province])
    references [Base_Province]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_City_reference_Base_City_ID
    foreign key ([City])
    references [Base_City]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint fk_Cust_BLT_Logistics_LogisticsPricelistLine_County_reference_Base_County_ID
    foreign key ([County])
    references [Base_County]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_DynamicPrice]
    with check
    add constraint fk_Cust_BLT_Logistics_DynamicPrice_Uom_reference_Base_UOM_ID
    foreign key ([Uom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint fk_Cust_BLT_Logistics_FeeRecord_WeightUom_reference_Base_UOM_ID
    foreign key ([WeightUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint fk_Cust_BLT_Logistics_FeeRecord_BulkUom_reference_Base_UOM_ID
    foreign key ([BulkUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint fk_Cust_BLT_Logistics_FeeRecord_Supplier_reference_CBO_Supplier_ID
    foreign key ([Supplier])
    references [CBO_Supplier]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint fk_Cust_BLT_Logistics_FeeRecord_City_reference_Base_City_ID
    foreign key ([City])
    references [Base_City]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint fk_Cust_BLT_Logistics_FeeRecord_County_reference_Base_County_ID
    foreign key ([County])
    references [Base_County]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint fk_Cust_BLT_Logistics_FeeRecord_Province_reference_Base_Province_ID
    foreign key ([Province])
    references [Base_Province]([ID])
    on delete no action
    on update no action
go

/*=============Default================*/

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint [16ee51bf-56bf-4352-bc7f-e99f1e8eac4e_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint [95dcca02-5873-40ab-b117-6ca6ab5e1be2_Default]
    default 0 for [DocID]
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint [18d09107-4208-4c89-8f17-e6649616963f_Default]
    default 0 for [LineID]
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint [e072d312-b3f8-4cfa-a2c6-e1ea0960adad_Default]
    default 0 for [Qty]
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint [2079a5c9-e989-449b-9434-4f348bc7462a_Default]
    default -1 for [RealDeliveryFactory]
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint [f7cf2e23-b2ca-4942-ab55-416b15819db8_Default]
    default 0 for [RealPricingMethod]
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint [6eedd6fb-da95-4443-905d-fd9152fe9830_Default]
    default 0 for [IBulk]
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint [957192d2-2b04-407d-848b-995d8ba24a58_Default]
    default 0 for [Weight]
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint [15edb097-16e3-4d4e-ad82-614e3c32d6e1_Default]
    default 0 for [PricingQty]
go

alter table [Cust_BLT_Logistics_CalculationFeeLine]
    with check
    add constraint [9c4b48fa-98fa-4421-b8ad-d7ad79946b5d_Default]
    default 0 for [DocType]
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint [f7bc5b51-a279-4d35-bab4-42ae845d3e44_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint [f8c5fbe6-315e-4687-840b-728b403de7fa_Default]
    default -1 for [DeliveryFactory]
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint [10496231-0782-43ec-a2b7-91ec6575b632_Default]
    default 0 for [PricingMethod]
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint [3cb6462c-f8df-40f1-ba40-eea168cf63d0_Default]
    default 0 for [TotalAmount]
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint [26e80ac1-90fb-43da-9fc1-09bd04ec3a0b_Default]
    default 0 for [RealAmount]
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint [0b84a9f6-b80a-42a2-8ba7-5b022dc19ad3_Default]
    default 0 for [UintPrice]
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint [df6fc50c-28f7-43fc-b825-b8e7269743cb_Default]
    default 0 for [Contain]
go

alter table [Cust_BLT_Logistics_CalculationFee]
    with check
    add constraint [8452e0de-d19f-4dac-99e6-b3103c894107_Default]
    default 1 for [NumberOfTrucks]
go

alter table [Cust_BLT_Logistics_LogisticsPricelist]
    with check
    add constraint [31817bdb-9dba-48e1-9c02-f43364fc35a7_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint [bce1da6e-3bc0-4728-a902-4fba543f3970_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint [9f1ebe16-16f9-4ccc-b4f1-d6ef947a12dd_Default]
    default 0 for [No]
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint [0668faeb-e97a-4b89-a94a-92fba1529bc3_Default]
    default 0 for [DeliveryFactory]
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint [6dfa0e25-ffce-4ab9-b1d3-13f0e5343b8b_Default]
    default 0 for [PricingMethod]
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint [78642f21-137e-469a-b317-060de900a563_Default]
    default 0 for [UintPrice]
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint [84cd4f4e-9957-42af-8878-2266896c2542_Default]
    default 0 for [DeliveryPickup]
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint [f659af68-963c-41fa-ba45-20dd14c77a3e_Default]
    default 0 for [DeliveryCharges]
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint [141d73fb-2864-409b-a018-ab8b430d4ec0_Default]
    default 0 for [FreePickup]
go

alter table [Cust_BLT_Logistics_LogisticsPricelistLine]
    with check
    add constraint [6d5a009d-a963-4960-aad1-821999013c5a_Default]
    default 0 for [FreeDelivery]
go

alter table [Cust_BLT_Logistics_DynamicPrice]
    with check
    add constraint [d382d969-32a2-453d-83a7-3b7fb6316fc7_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_Logistics_DynamicPrice]
    with check
    add constraint [1b6d0725-8693-4387-8bd4-2e8614989110_Default]
    default 0 for [DynamicPriceType]
go

alter table [Cust_BLT_Logistics_DynamicPrice]
    with check
    add constraint [4065dcfb-9a82-4789-b968-496f38123532_Default]
    default 0 for [EffectField]
go

alter table [Cust_BLT_Logistics_DynamicPriceLine]
    with check
    add constraint [5dc87218-5ed9-4f10-9a56-dcd467d6b934_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_Logistics_DynamicPriceLine]
    with check
    add constraint [7fc69115-2f8a-4cda-be27-edfc96312363_Default]
    default 0 for [No]
go

alter table [Cust_BLT_Logistics_DynamicPriceLine]
    with check
    add constraint [a94cb2e2-1bb4-4f6c-8190-c113a19cca2e_Default]
    default 0 for [UnitPrice]
go

alter table [Cust_BLT_Logistics_DynamicPriceLine]
    with check
    add constraint [b18b6303-966d-4afa-8cf3-dd338ff542e7_Default]
    default 0 for [Start]
go

alter table [Cust_BLT_Logistics_DynamicPriceLine]
    with check
    add constraint [26d2e813-f20a-4b41-8b4a-54755384ab56_Default]
    default 0 for [Cutoff]
go

alter table [Cust_BLT_Logistics_DynamicPriceLine]
    with check
    add constraint [1533a0c1-19c3-4a27-95d1-8220deaee2f6_Default]
    default 0 for [Total]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [ec8c206f-83b4-4d95-84fe-6acf72526d3c_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [87925474-8a7b-4684-af06-a8d17c6395e8_Default]
    default 0 for [BusinessType]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [26e12722-cba6-4415-9db7-24b57616d44a_Default]
    default 0 for [Qty]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [a48f130f-0387-4ae8-84f1-e64d49bb4b71_Default]
    default 0 for [ProductCategory]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [ba6512f9-ae81-4d11-b58c-cf2b5499bf89_Default]
    default 0 for [IBulk]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [6b442e6d-a89c-460e-af8a-74d6c640eb3f_Default]
    default 0 for [Weight]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [9598f843-4eb0-4ce8-aa67-97e471ab779f_Default]
    default 0 for [PickupFee]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [2eb82457-186a-423e-9d7a-ab49ef0dbaed_Default]
    default 0 for [DeliveryFee]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [683e6a68-7e61-4e11-ab19-1d7a9a31beab_Default]
    default 0 for [DischargeFee]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [c59f70e7-22b5-4b33-afee-e80036059f36_Default]
    default 0 for [OtherFee]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [2b06c8b8-035e-4108-a0a8-8516cf49cc03_Default]
    default 0 for [StandardShipping]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [6584499b-116d-47c0-91af-7a8bcb469dc6_Default]
    default 0 for [TotalFreight]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [63725e6d-888f-4d18-a392-04ede07edfc1_Default]
    default 0 for [RealFreight]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [e2ec79f1-6192-4e33-9c65-5f4034356665_Default]
    default 0 for [AverageCost]
go

alter table [Cust_BLT_Logistics_FeeRecord]
    with check
    add constraint [2aeaa5dd-0323-4bf9-8070-5955b12e0f47_Default]
    default 0 for [UintPrice]
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    with check
    add constraint [52cdab29-475b-4a35-91fb-1453e9681d54_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    with check
    add constraint [156a06b2-9388-44a2-bc1c-d0830067b3ec_Default]
    default 0 for [TotalBulk]
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    with check
    add constraint [42b2cf46-c1b1-4749-a4e3-8b99a73356c7_Default]
    default 0 for [TotalWeight]
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    with check
    add constraint [8e9a779f-6852-4cc8-a80e-6581d5ee95f8_Default]
    default 0 for [RealBulk]
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    with check
    add constraint [7cf08282-151b-4036-ac66-9278081269a0_Default]
    default 0 for [RealWeight]
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    with check
    add constraint [2ba1144a-0be9-4bad-bd06-283ed142188d_Default]
    default 0 for [PickupFee]
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    with check
    add constraint [7e0a4647-4e5f-434a-be9c-a32ea54b57c2_Default]
    default 0 for [DeliveryFee]
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    with check
    add constraint [6ea54d07-2124-47d2-addd-d76325e26f90_Default]
    default 0 for [DischargeFee]
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    with check
    add constraint [2e30c390-0be1-498f-a3b5-0c64977366bb_Default]
    default 0 for [OtherFee]
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    with check
    add constraint [dc460c8f-a4ad-4f60-a437-b2c4f746cee1_Default]
    default 0 for [TotalFreight]
go

alter table [Cust_BLT_Logistics_CalculationFeeTotalLine]
    with check
    add constraint [bf7d77b3-7af2-4196-9dee-9c82b71e4a7c_Default]
    default 0 for [RealFreight]
go

alter table [Cust_BLT_Logistics_FeeRecordLinked]
    with check
    add constraint [117d8529-ea26-4bfc-9979-5ce6e129d0ca_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_Logistics_FeeRecordLinked]
    with check
    add constraint [211adbc2-e28f-417d-a3ef-dac57f6697bb_Default]
    default 0 for [SrcType]
go

alter table [Cust_BLT_Logistics_FeeRecordLinked]
    with check
    add constraint [0bc0c6ac-7369-4691-ba24-0b535cb6195e_Default]
    default 0 for [SrcDocID]
go

alter table [Cust_BLT_Logistics_FeeRecordLinked]
    with check
    add constraint [b1b5a7ad-2c31-475c-ac61-1ffa073655ba_Default]
    default 0 for [Amount]
go

alter table [Cust_BLT_Logistics_FeeRecordLinked]
    with check
    add constraint [4b22f7a9-b4eb-4da5-8f06-4ea15b5f26aa_Default]
    default 0 for [DeliveryID]
go

alter table [Cust_BLT_Logistics_FeeRecordLinked]
    with check
    add constraint [e3ed6c4b-bb0b-42d5-bb87-c9fbdbf4694a_Default]
    default '0' for [SrcDocNo]
go

alter table [Cust_BLT_Logistics_FeeRecordLinked]
    with check
    add constraint [6c5d9e5d-eeec-4b94-90d9-e28fa5d3341c_Default]
    default '0' for [DeliveryNo]
go

/*=============TableAllCheck================*/

ALTER TABLE [Cust_BLT_Logistics_CalculationFeeLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_BLT_Logistics_CalculationFee] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_BLT_Logistics_LogisticsPricelist] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_BLT_Logistics_LogisticsPricelistLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_BLT_Logistics_DynamicPrice] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_BLT_Logistics_DynamicPriceLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_BLT_Logistics_FeeRecord] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_BLT_Logistics_CalculationFeeTotalLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_BLT_Logistics_FeeRecordLinked] WITH CHECK NOCHECK CONSTRAINT ALL 

