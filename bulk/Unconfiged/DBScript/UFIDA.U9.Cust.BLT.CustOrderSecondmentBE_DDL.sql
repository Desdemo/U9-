set QUOTED_IDENTIFIER on
set ANSI_PADDING on

/*=================================================*/
/*       Drop database element                     */
/*=================================================*/

/*=============FK================*/

if object_id(N'fk_Cust_BLT_OrderSecondment_SrcDoc_reference_SM_SO_ID', N'F') is not null
    alter table [Cust_BLT_OrderSecondment]
        drop constraint fk_Cust_BLT_OrderSecondment_SrcDoc_reference_SM_SO_ID
go

if object_id(N'fk_Cust_BLT_OrderSecondment_Item_reference_CBO_ItemMaster_ID', N'F') is not null
    alter table [Cust_BLT_OrderSecondment]
        drop constraint fk_Cust_BLT_OrderSecondment_Item_reference_CBO_ItemMaster_ID
go

if object_id(N'fk_Cust_BLT_OrderSecondment_Doc_reference_SM_SO_ID', N'F') is not null
    alter table [Cust_BLT_OrderSecondment]
        drop constraint fk_Cust_BLT_OrderSecondment_Doc_reference_SM_SO_ID
go

if object_id(N'fk_Cust_BLT_OrderSecondment_SrcLine_reference_SM_SOLine_ID', N'F') is not null
    alter table [Cust_BLT_OrderSecondment]
        drop constraint fk_Cust_BLT_OrderSecondment_SrcLine_reference_SM_SOLine_ID
go

if object_id(N'fk_Cust_BLT_CustOrderSecondmentInfo_Item_reference_CBO_ItemMaster_ID', N'F') is not null
    alter table [Cust_BLT_CustOrderSecondmentInfo]
        drop constraint fk_Cust_BLT_CustOrderSecondmentInfo_Item_reference_CBO_ItemMaster_ID
go

if object_id(N'fk_Cust_BLT_CustOrderSecondmentSrcInfo_Item_reference_CBO_ItemMaster_ID', N'F') is not null
    alter table [Cust_BLT_CustOrderSecondmentSrcInfo]
        drop constraint fk_Cust_BLT_CustOrderSecondmentSrcInfo_Item_reference_CBO_ItemMaster_ID
go

/*=============Table================*/

if object_id(N'[Cust_BLT_OrderSecondment]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_OrderSecondment]',@IsChildTable=0
    drop table [Cust_BLT_OrderSecondment]
end
go

if object_id(N'[Cust_BLT_OrderSecondment_Trl]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_OrderSecondment_Trl]',@IsChildTable=0
    drop table [Cust_BLT_OrderSecondment_Trl]
end
go

if object_id(N'[Cust_BLT_CustOrderSecondmentInfo]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_CustOrderSecondmentInfo]',@IsChildTable=0
    drop table [Cust_BLT_CustOrderSecondmentInfo]
end
go

if object_id(N'[Cust_BLT_CustOrderSecondmentSrcInfo]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_BLT_CustOrderSecondmentSrcInfo]',@IsChildTable=0
    drop table [Cust_BLT_CustOrderSecondmentSrcInfo]
end
go

/*=================================================*/
/*       Create database element                   */
/*=================================================*/

/*=============Table================*/

create table [Cust_BLT_OrderSecondment]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [SrcDocNo] nvarchar(50) null,
    [SrcDocID] bigint null,
    [SrcLineID] bigint null,
    [SrcDoc] bigint null,
    [Item] bigint null,
    [Qty] decimal(24, 9) null,
    [LendQty] decimal(24, 9) null,
    [LoanedoutQty] decimal(24, 9) null,
    [Remark] nvarchar(50) null,
    [DocNo] nvarchar(50) null,
    [Doc] bigint null,
    [SrcLine] bigint null,
    [DocID] bigint null,
    [DocLineID] bigint null,
    [DescFlexField_PubDescSeg1] nvarchar(1000) null,
    [DescFlexField_PubDescSeg2] nvarchar(1000) null,
    [DescFlexField_PubDescSeg3] nvarchar(1000) null,
    [DescFlexField_PubDescSeg4] nvarchar(1000) null,
    [DescFlexField_PubDescSeg5] nvarchar(1000) null,
    [DescFlexField_PubDescSeg6] nvarchar(1000) null,
    [DescFlexField_PubDescSeg7] nvarchar(1000) null,
    [DescFlexField_PubDescSeg8] nvarchar(1000) null,
    [DescFlexField_PubDescSeg9] nvarchar(1000) null,
    [DescFlexField_PubDescSeg10] nvarchar(1000) null,
    [DescFlexField_PubDescSeg11] nvarchar(1000) null,
    [DescFlexField_PubDescSeg12] nvarchar(1000) null,
    [DescFlexField_PubDescSeg13] nvarchar(1000) null,
    [DescFlexField_PubDescSeg14] nvarchar(1000) null,
    [DescFlexField_PubDescSeg15] nvarchar(1000) null,
    [DescFlexField_PubDescSeg16] nvarchar(1000) null,
    [DescFlexField_PubDescSeg17] nvarchar(1000) null,
    [DescFlexField_PubDescSeg18] nvarchar(1000) null,
    [DescFlexField_PubDescSeg19] nvarchar(1000) null,
    [DescFlexField_PubDescSeg20] nvarchar(1000) null,
    [DescFlexField_PubDescSeg21] nvarchar(1000) null,
    [DescFlexField_PubDescSeg22] nvarchar(1000) null,
    [DescFlexField_PubDescSeg23] nvarchar(1000) null,
    [DescFlexField_PubDescSeg24] nvarchar(1000) null,
    [DescFlexField_PubDescSeg25] nvarchar(1000) null,
    [DescFlexField_PubDescSeg26] nvarchar(1000) null,
    [DescFlexField_PubDescSeg27] nvarchar(1000) null,
    [DescFlexField_PubDescSeg28] nvarchar(1000) null,
    [DescFlexField_PubDescSeg29] nvarchar(1000) null,
    [DescFlexField_PubDescSeg30] nvarchar(1000) null,
    [DescFlexField_PubDescSeg31] nvarchar(1000) null,
    [DescFlexField_PubDescSeg32] nvarchar(1000) null,
    [DescFlexField_PubDescSeg33] nvarchar(1000) null,
    [DescFlexField_PubDescSeg34] nvarchar(1000) null,
    [DescFlexField_PubDescSeg35] nvarchar(1000) null,
    [DescFlexField_PubDescSeg36] nvarchar(1000) null,
    [DescFlexField_PubDescSeg37] nvarchar(1000) null,
    [DescFlexField_PubDescSeg38] nvarchar(1000) null,
    [DescFlexField_PubDescSeg39] nvarchar(1000) null,
    [DescFlexField_PubDescSeg40] nvarchar(1000) null,
    [DescFlexField_PubDescSeg41] nvarchar(1000) null,
    [DescFlexField_PubDescSeg42] nvarchar(1000) null,
    [DescFlexField_PubDescSeg43] nvarchar(1000) null,
    [DescFlexField_PubDescSeg44] nvarchar(1000) null,
    [DescFlexField_PubDescSeg45] nvarchar(1000) null,
    [DescFlexField_PubDescSeg46] nvarchar(1000) null,
    [DescFlexField_PubDescSeg47] nvarchar(1000) null,
    [DescFlexField_PubDescSeg48] nvarchar(1000) null,
    [DescFlexField_PubDescSeg49] nvarchar(1000) null,
    [DescFlexField_PubDescSeg50] nvarchar(1000) null,
    [DescFlexField_ContextValue] nvarchar(50) null,
    [DescFlexField_PrivateDescSeg1] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg2] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg3] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg4] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg5] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg6] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg7] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg8] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg9] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg10] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg11] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg12] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg13] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg14] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg15] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg16] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg17] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg18] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg19] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg20] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg21] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg22] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg23] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg24] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg25] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg26] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg27] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg28] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg29] nvarchar(1000) null,
    [DescFlexField_PrivateDescSeg30] nvarchar(1000) null
)
go
exec p_CreateCustomType 'Cust_BLT_OrderSecondment'
go

create table [Cust_BLT_OrderSecondment_Trl]
(
    [ID] bigint not null,
    [SysMLFlag] nvarchar(20) not null,
    [DescFlexField_CombineName] nvarchar(4000) null
)
go
exec p_CreateCustomType 'Cust_BLT_OrderSecondment_Trl'
go

create table [Cust_BLT_CustOrderSecondmentInfo]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [Line] nvarchar(50) null,
    [Item] bigint null,
    [Qty] decimal(24, 9) null,
    [TotalQty] decimal(24, 9) null,
    [DocNo] nvarchar(50) null,
    [DocID] bigint null,
    [LineID] bigint null
)
go
exec p_CreateCustomType 'Cust_BLT_CustOrderSecondmentInfo'
go

create table [Cust_BLT_CustOrderSecondmentSrcInfo]
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
    [Qty] decimal(24, 9) null,
    [LendQty] decimal(24, 9) null
)
go
exec p_CreateCustomType 'Cust_BLT_CustOrderSecondmentSrcInfo'
go

/*=============PK================*/

alter table [Cust_BLT_OrderSecondment]
    add constraint pk_Cust_BLT_OrderSecondment
    primary key clustered
    ([ID] asc)
go

alter table [Cust_BLT_OrderSecondment_Trl]
    add constraint pk_Cust_BLT_OrderSecondment_Trl
    primary key clustered
    ([ID] asc, [SysMLFlag] asc)
go

alter table [Cust_BLT_CustOrderSecondmentInfo]
    add constraint pk_Cust_BLT_CustOrderSecondmentInfo
    primary key clustered
    ([ID] asc)
go

alter table [Cust_BLT_CustOrderSecondmentSrcInfo]
    add constraint pk_Cust_BLT_CustOrderSecondmentSrcInfo
    primary key clustered
    ([ID] asc)
go

/*=============FK================*/

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint fk_Cust_BLT_OrderSecondment_SrcDoc_reference_SM_SO_ID
    foreign key ([SrcDoc])
    references [SM_SO]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint fk_Cust_BLT_OrderSecondment_Item_reference_CBO_ItemMaster_ID
    foreign key ([Item])
    references [CBO_ItemMaster]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint fk_Cust_BLT_OrderSecondment_Doc_reference_SM_SO_ID
    foreign key ([Doc])
    references [SM_SO]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint fk_Cust_BLT_OrderSecondment_SrcLine_reference_SM_SOLine_ID
    foreign key ([SrcLine])
    references [SM_SOLine]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_CustOrderSecondmentInfo]
    with check
    add constraint fk_Cust_BLT_CustOrderSecondmentInfo_Item_reference_CBO_ItemMaster_ID
    foreign key ([Item])
    references [CBO_ItemMaster]([ID])
    on delete no action
    on update no action
go

alter table [Cust_BLT_CustOrderSecondmentSrcInfo]
    with check
    add constraint fk_Cust_BLT_CustOrderSecondmentSrcInfo_Item_reference_CBO_ItemMaster_ID
    foreign key ([Item])
    references [CBO_ItemMaster]([ID])
    on delete no action
    on update no action
go

/*=============Default================*/

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint [6e80426a-f465-469d-b152-1b69b99d48ba_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint [1534ed7d-51bb-48d3-abbd-d2948da456c2_Default]
    default 0 for [SrcDocID]
go

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint [09e0d86e-eddb-485a-8822-1bff05b24f35_Default]
    default 0 for [SrcLineID]
go

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint [29299ff0-c33e-402a-8bdc-b3796d22f53b_Default]
    default 0 for [Qty]
go

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint [12e04f86-d863-4121-b352-ad90543396cf_Default]
    default 0 for [LendQty]
go

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint [ddae2a96-8c16-49ac-8181-c2881012d8de_Default]
    default 0 for [LoanedoutQty]
go

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint [c2294970-11de-47fa-89eb-0828d5be2d13_Default]
    default 0 for [DocID]
go

alter table [Cust_BLT_OrderSecondment]
    with check
    add constraint [c169b67a-e361-4e73-a116-117b37515825_Default]
    default 0 for [DocLineID]
go

alter table [Cust_BLT_CustOrderSecondmentInfo]
    with check
    add constraint [3f268036-1920-435a-ab9e-0e4d699ef1e1_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_CustOrderSecondmentInfo]
    with check
    add constraint [20d41003-1953-4798-b740-278d5b6c44e3_Default]
    default 0 for [Qty]
go

alter table [Cust_BLT_CustOrderSecondmentInfo]
    with check
    add constraint [aee1d626-0666-429a-b99e-98651e368754_Default]
    default 0 for [TotalQty]
go

alter table [Cust_BLT_CustOrderSecondmentInfo]
    with check
    add constraint [e7fda7c7-a817-40d1-9f65-12f67f9d534d_Default]
    default 0 for [DocID]
go

alter table [Cust_BLT_CustOrderSecondmentInfo]
    with check
    add constraint [4257e877-0294-411e-9798-2634321cb3af_Default]
    default 0 for [LineID]
go

alter table [Cust_BLT_CustOrderSecondmentSrcInfo]
    with check
    add constraint [ac564abc-fc8c-4df5-b378-5fd5b21a128d_Default]
    default 0 for [SysVersion]
go

alter table [Cust_BLT_CustOrderSecondmentSrcInfo]
    with check
    add constraint [b1b03fcd-a591-4217-b86e-f9dd10115ba8_Default]
    default 0 for [DocID]
go

alter table [Cust_BLT_CustOrderSecondmentSrcInfo]
    with check
    add constraint [ab4595ef-8b1c-42d7-9a51-7acef1eb12bd_Default]
    default 0 for [LineID]
go

alter table [Cust_BLT_CustOrderSecondmentSrcInfo]
    with check
    add constraint [9ce4f11b-b973-4aec-a808-88321db5840b_Default]
    default 0 for [Qty]
go

alter table [Cust_BLT_CustOrderSecondmentSrcInfo]
    with check
    add constraint [9c8ed6ff-b51f-484a-8824-a0850d1b4f36_Default]
    default 0 for [LendQty]
go

/*=============TableAllCheck================*/

ALTER TABLE [Cust_BLT_OrderSecondment] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_BLT_OrderSecondment_Trl] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_BLT_CustOrderSecondmentInfo] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_BLT_CustOrderSecondmentSrcInfo] WITH CHECK NOCHECK CONSTRAINT ALL 

