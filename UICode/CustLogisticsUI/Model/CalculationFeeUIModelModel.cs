#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsUI
{
	[Serializable]
	public partial class CalculationFeeUIModelModel : UIModel
	{
		#region Constructor
		public CalculationFeeUIModelModel() : base("CalculationFeeUIModel")
		{
			InitClass();
			this.SetResourceInfo("e5385ff2-d918-437a-b7a3-79a2939c340a");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private CalculationFeeUIModelModel(bool isInit) : base("CalculationFeeUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new CalculationFeeUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private CalculationFeeView viewCalculationFee;			
		private CalculationFee_CalculationFeeLineView viewCalculationFee_CalculationFeeLine;			
		private CalculationFee_HuangdaoTotalView viewCalculationFee_HuangdaoTotal;			
		private CalculationFee_ChenyangTotalView viewCalculationFee_ChenyangTotal;			
		#endregion
		
		#region links
		//private IUILink linkCalculationFee__CalculationFee_CalculationFeeLine;			
		//private IUILink linkCalculationFee__CalculationFee_HuangdaoTotal;			
		//private IUILink linkCalculationFee__CalculationFee_ChenyangTotal;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public CalculationFeeView CalculationFee
		{
			get { return (CalculationFeeView)this["CalculationFee"]; }
		}
		public CalculationFee_CalculationFeeLineView CalculationFee_CalculationFeeLine
		{
			get { return (CalculationFee_CalculationFeeLineView)this["CalculationFee_CalculationFeeLine"]; }
		}
		public CalculationFee_HuangdaoTotalView CalculationFee_HuangdaoTotal
		{
			get { return (CalculationFee_HuangdaoTotalView)this["CalculationFee_HuangdaoTotal"]; }
		}
		public CalculationFee_ChenyangTotalView CalculationFee_ChenyangTotal
		{
			get { return (CalculationFee_ChenyangTotalView)this["CalculationFee_ChenyangTotal"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewCalculationFee = new CalculationFeeView(this);
			this.viewCalculationFee.SetResourceInfo("b63b2ef0-fba2-4ca8-b365-8bc807e21c14");
			this.Views.Add(this.viewCalculationFee);			
			this.viewCalculationFee_CalculationFeeLine = new CalculationFee_CalculationFeeLineView(this);
			this.viewCalculationFee_CalculationFeeLine.SetResourceInfo("1f4a8353-8cb4-4c6f-834d-7d93533d5ae1");
			this.Views.Add(this.viewCalculationFee_CalculationFeeLine);			
			this.viewCalculationFee_HuangdaoTotal = new CalculationFee_HuangdaoTotalView(this);
			this.viewCalculationFee_HuangdaoTotal.SetResourceInfo("5388467c-6f9a-4fb2-a44e-e211de67b2f9");
			this.Views.Add(this.viewCalculationFee_HuangdaoTotal);			
			this.viewCalculationFee_ChenyangTotal = new CalculationFee_ChenyangTotalView(this);
			this.viewCalculationFee_ChenyangTotal.SetResourceInfo("f4e82dd6-aa83-420c-9c02-ccf1952ad60f");
			this.Views.Add(this.viewCalculationFee_ChenyangTotal);			

			//this.linkCalculationFee__CalculationFee_CalculationFeeLine
			{
			IUILink link = new UILink("CalculationFee__CalculationFee_CalculationFeeLine",this,this.viewCalculationFee.FieldID,this.viewCalculationFee_CalculationFeeLine.FieldCalculationFee,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"CalculationFeeLine");
			this.Links.Add(link);
			}
			//this.linkCalculationFee__CalculationFee_CalculationFeeLine.ChildKeyConstraint.UpdateRule = Rule.Cascade;
			//this.linkCalculationFee__CalculationFee_CalculationFeeLine.ChildKeyConstraint.DeleteRule = Rule.Cascade;
			//this.linkCalculationFee__CalculationFee_CalculationFeeLine.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			//this.linkCalculationFee__CalculationFee_HuangdaoTotal
			{
			IUILink link = new UILink("CalculationFee__CalculationFee_HuangdaoTotal",this,this.viewCalculationFee.FieldHuangdaoTotal,this.viewCalculationFee_HuangdaoTotal.FieldID,EnumAssociationKind.ASSOCIATION,EnumAssociationDirection.Single,EnumCardinality.MORE,EnumCardinality.ONE,"");
			this.Links.Add(link);
			}
			//this.linkCalculationFee__CalculationFee_HuangdaoTotal.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkCalculationFee__CalculationFee_HuangdaoTotal.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkCalculationFee__CalculationFee_HuangdaoTotal.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			//this.linkCalculationFee__CalculationFee_ChenyangTotal
			{
			IUILink link = new UILink("CalculationFee__CalculationFee_ChenyangTotal",this,this.viewCalculationFee.FieldChenyangTotal,this.viewCalculationFee_ChenyangTotal.FieldID,EnumAssociationKind.ASSOCIATION,EnumAssociationDirection.Single,EnumCardinality.MORE,EnumCardinality.ONE,"");
			this.Links.Add(link);
			}
			//this.linkCalculationFee__CalculationFee_ChenyangTotal.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkCalculationFee__CalculationFee_ChenyangTotal.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkCalculationFee__CalculationFee_ChenyangTotal.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.BLT.CustLogisticsUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class CalculationFeeView : UIView
	{
		#region Constructor
		public CalculationFeeView(IUIModel model) : base(model,"CalculationFee","UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private CalculationFeeView():base(null,"CalculationFee","UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new CalculationFeeView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldSup
		{
			get { return this.Fields["Sup"]; }
		}
		public IUIField FieldSup_Code
		{
			get { return this.Fields["Sup_Code"]; }
		}
		public IUIField FieldSup_Name
		{
			get { return this.Fields["Sup_Name"]; }
		}
		public IUIField FieldDeliveryFactory
		{
			get { return this.Fields["DeliveryFactory"]; }
		}
		public IUIField FieldAddress_Code
		{
			get { return this.Fields["Address_Code"]; }
		}
		public IUIField FieldAddress_Name
		{
			get { return this.Fields["Address_Name"]; }
		}
		public IUIField FieldShipDate
		{
			get { return this.Fields["ShipDate"]; }
		}
		public IUIField FieldPricingMethod
		{
			get { return this.Fields["PricingMethod"]; }
		}
		public IUIField FieldTotalAmount
		{
			get { return this.Fields["TotalAmount"]; }
		}
		public IUIField FieldRealAmount
		{
			get { return this.Fields["RealAmount"]; }
		}
		public IUIField FieldUintPrice
		{
			get { return this.Fields["UintPrice"]; }
		}
		public IUIField FieldRemark
		{
			get { return this.Fields["Remark"]; }
		}
		public IUIField FieldContain
		{
			get { return this.Fields["Contain"]; }
		}
		public IUIField FieldNumberOfTrucks
		{
			get { return this.Fields["NumberOfTrucks"]; }
		}
		public IUIField FieldHuangdaoTotal
		{
			get { return this.Fields["HuangdaoTotal"]; }
		}
		public IUIField FieldChenyangTotal
		{
			get { return this.Fields["ChenyangTotal"]; }
		}
		public IUIField FieldSetLocation
		{
			get { return this.Fields["SetLocation"]; }
		}
		public IUIField FieldProvince
		{
			get { return this.Fields["Province"]; }
		}
		public IUIField FieldProvince_Code
		{
			get { return this.Fields["Province_Code"]; }
		}
		public IUIField FieldProvince_Name
		{
			get { return this.Fields["Province_Name"]; }
		}
		public IUIField FieldCity
		{
			get { return this.Fields["City"]; }
		}
		public IUIField FieldCity_Code
		{
			get { return this.Fields["City_Code"]; }
		}
		public IUIField FieldCity_Name
		{
			get { return this.Fields["City_Name"]; }
		}
		public IUIField FieldCounty
		{
			get { return this.Fields["County"]; }
		}
		public IUIField FieldCounty_Code
		{
			get { return this.Fields["County_Code"]; }
		}
		public IUIField FieldCounty_Name
		{
			get { return this.Fields["County_Name"]; }
		}
		public IUIField FieldDescriLocation
		{
			get { return this.Fields["DescriLocation"]; }
		}
		public IUIField FieldAddress
		{
			get { return this.Fields["Address"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public CalculationFeeDefaultFilterFilter DefaultFilter
		{
			get { return (CalculationFeeDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","3a6d58a1-db6f-4eae-ab32-ec7b8aa54970");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","0708f6ae-8759-463e-9e7c-a572b4b63299");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","38aced56-d3c6-45a0-b31a-7cce7cbac624");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","28d11575-d22f-4fe1-8225-8cdee64e550a");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b986d8d-8759-4a21-91df-36b9b1e84037");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","59701f91-9728-4fe8-b3e8-6b1af8a04eb7");
			UIModelRuntimeFactory.AddNewUIField(this,"Sup", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Supplier.Supplier", "Sup", true,true, false, "",false,(UIFieldType)4,"ac3510e5-3337-46d4-b41c-46ac40f343e1","fde35994-6853-4aaa-869b-bab9b1a857cf");
			UIModelRuntimeFactory.AddNewUIField(this,"Sup_Code", typeof(String), false,"","System.String", "Sup.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","250f2671-a0de-4e29-bb75-0b8a5fd5a46a");
			UIModelRuntimeFactory.AddNewUIField(this,"Sup_Name", typeof(String), true,"","System.String", "Sup.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dd3e8d41-f8e2-48cd-81c7-7712489bd012");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryFactory", typeof(Int32), true,"-1","UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum", "DeliveryFactory", true,true, false, "",false,(UIFieldType)2,"0bda0d68-2eee-47d5-ba80-59c869cf4316","9a63b8e4-d4ea-497c-bf1b-27ea10cb9e6e");
			UIModelRuntimeFactory.AddNewUIField(this,"Address_Code", typeof(String), false,"","System.String", "Address.Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6afd5cc8-4f69-47a7-9ecd-6a7a0f35fcb4");
			UIModelRuntimeFactory.AddNewUIField(this,"Address_Name", typeof(String), true,"","System.String", "Address.Name", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0a7142f4-fbca-4e69-b18c-6879b562beff");
			UIModelRuntimeFactory.AddNewUIField(this,"ShipDate", typeof(DateTime), true,"","System.Date", "ShipDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","62d2a081-6372-44bc-b3c4-33a521bb5ace");
			UIModelRuntimeFactory.AddNewUIField(this,"PricingMethod", typeof(Int32), true,"0","UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum", "PricingMethod", true,true, false, "",false,(UIFieldType)2,"5208ce26-38bb-4e7f-830b-d38cde9eb7d3","2f6df6c7-be67-4d30-81a1-9cb4456dc72d");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalAmount", typeof(Double), true,"0","System.Double", "TotalAmount", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","e82c37ac-f17e-4bfb-99ff-7a5791e9c783");
			UIModelRuntimeFactory.AddNewUIField(this,"RealAmount", typeof(Double), true,"0","System.Double", "RealAmount", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","c59f375f-b5a0-41de-9cd1-bdc8901afd9e");
			UIModelRuntimeFactory.AddNewUIField(this,"UintPrice", typeof(Double), true,"0","System.Double", "UintPrice", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","0e37bed4-9c8c-4dfd-8d76-50f908e252da");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6f2040d8-c2ff-47b9-b283-951326c3927b");
			UIModelRuntimeFactory.AddNewUIField(this,"Contain", typeof(Boolean), true,"false","System.Boolean", "Contain", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","0b4d7327-65d9-4566-83df-bd69d7f147fa");
			UIModelRuntimeFactory.AddNewUIField(this,"NumberOfTrucks", typeof(Int32), true,"1","System.Int32", "NumberOfTrucks", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","efcd952b-712f-4b16-b24d-3c938286a0ad");
			UIModelRuntimeFactory.AddNewUIField(this,"HuangdaoTotal", typeof(Int64), true,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine", "HuangdaoTotal", true,true, false, "",false,(UIFieldType)4,"1fccd3bf-9dea-493a-afaa-2d8231340258","e8d8ea26-42d3-49d5-895f-633b547a4050");
			UIModelRuntimeFactory.AddNewUIField(this,"ChenyangTotal", typeof(Int64), true,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine", "ChenyangTotal", true,true, false, "",false,(UIFieldType)4,"1fccd3bf-9dea-493a-afaa-2d8231340258","e915ba6f-b270-4cc8-8ea7-ff2bfab5bbfc");
			UIModelRuntimeFactory.AddNewUIField(this,"SetLocation", typeof(Int64), true,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine", "SetLocation", true,true, false, "",false,(UIFieldType)4,"8d0d3098-9880-40f7-8f3c-73bf58035ec6","4c1d55a7-ed0e-4ce3-85e5-57c0d78a65d9");
			UIModelRuntimeFactory.AddNewUIField(this,"Province", typeof(Int64), true,"","UFIDA.U9.Base.Location.Province", "Province", true,true, false, "",false,(UIFieldType)4,"1e9b6162-9f3d-4678-80a9-934f060f50c7","e1b76148-d0ee-4eb8-965d-affa97c261c8");
			UIModelRuntimeFactory.AddNewUIField(this,"Province_Code", typeof(String), false,"","System.String", "Province.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8b6d8739-0e0c-40db-a4c6-1ef27e9f2881");
			UIModelRuntimeFactory.AddNewUIField(this,"Province_Name", typeof(String), true,"","System.String", "Province.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0abadc89-c25e-49ef-913d-567937eba763");
			UIModelRuntimeFactory.AddNewUIField(this,"City", typeof(Int64), true,"","UFIDA.U9.Base.Location.City", "City", true,true, false, "",false,(UIFieldType)4,"0e5d5fb8-bbf6-4464-9cf0-15e3af3c659b","8b26faca-cfaf-410c-aac6-40d55182e857");
			UIModelRuntimeFactory.AddNewUIField(this,"City_Code", typeof(String), false,"","System.String", "City.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4239715a-52a4-4c18-8072-809f4905416e");
			UIModelRuntimeFactory.AddNewUIField(this,"City_Name", typeof(String), true,"","System.String", "City.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ab466921-c312-4e5a-8d75-81dfac1ac218");
			UIModelRuntimeFactory.AddNewUIField(this,"County", typeof(Int64), true,"","UFIDA.U9.Base.Location.County", "County", true,true, false, "",false,(UIFieldType)4,"b969a0b2-3dee-4350-9461-acd80485bdf3","58c8b12d-9075-46a2-8e24-0f1f6eb3821c");
			UIModelRuntimeFactory.AddNewUIField(this,"County_Code", typeof(String), false,"","System.String", "County.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","97811c27-b90d-4819-94cf-ed5f8f11ffb6");
			UIModelRuntimeFactory.AddNewUIField(this,"County_Name", typeof(String), true,"","System.String", "County.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f5fa7a98-732d-4f8a-b93a-a7cddd03690b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescriLocation", typeof(String), true,"","System.String", "DescriLocation", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","22b279e0-3df4-4f8b-bac0-20a19846dbd3");
			UIModelRuntimeFactory.AddNewUIField(this,"Address", typeof(String), true,"","System.String", "Address", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","208fc44d-9ad6-4a74-8282-40d94b86de94");


			this.CurrentFilter = new CalculationFeeDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new CalculationFeeRecord(builder);
		}
		#endregion

		#region new method
		public new CalculationFeeRecord FocusedRecord
		{
			get { return (CalculationFeeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new CalculationFeeRecord AddNewUIRecord()
		{	
			return (CalculationFeeRecord)base.AddNewUIRecord();
		}
		public new CalculationFeeRecord NewUIRecord()
		{	
			return (CalculationFeeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class CalculationFeeRecord : UIRecord
	{
		#region Constructor
		public CalculationFeeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private CalculationFeeView uiviewCalculationFee
		{
			get { return (CalculationFeeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new CalculationFeeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCalculationFee.FieldID);
			}
			set{
				this[this.uiviewCalculationFee.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCalculationFee.FieldCreatedOn);
			}
			set{
				this[this.uiviewCalculationFee.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldCreatedBy);
			}
			set{
				this[this.uiviewCalculationFee.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCalculationFee.FieldModifiedOn);
			}
			set{
				this[this.uiviewCalculationFee.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldModifiedBy);
			}
			set{
				this[this.uiviewCalculationFee.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee.FieldSysVersion);
			}
			set{
				this[this.uiviewCalculationFee.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? Sup
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldSup] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee.FieldSup);
			}
			set{
				this[this.uiviewCalculationFee.FieldSup] = value;
			}
		}
		
		
		public  String Sup_Code
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldSup_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldSup_Code);
			}
			set{
				this[this.uiviewCalculationFee.FieldSup_Code] = value;
			}
		}
		
		
		public  String Sup_Name
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldSup_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldSup_Name);
			}
			set{
				this[this.uiviewCalculationFee.FieldSup_Name] = value;
			}
		}
		
		
		public  Int32? DeliveryFactory
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldDeliveryFactory] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCalculationFee.FieldDeliveryFactory);
			}
			set{
				this[this.uiviewCalculationFee.FieldDeliveryFactory] = value;
			}
		}
		
		
		public  String Address_Code
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldAddress_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldAddress_Code);
			}
			set{
				this[this.uiviewCalculationFee.FieldAddress_Code] = value;
			}
		}
		
		
		public  String Address_Name
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldAddress_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldAddress_Name);
			}
			set{
				this[this.uiviewCalculationFee.FieldAddress_Name] = value;
			}
		}
		
		
		public  DateTime? ShipDate
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldShipDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCalculationFee.FieldShipDate);
			}
			set{
				this[this.uiviewCalculationFee.FieldShipDate] = value;
			}
		}
		
		
		public  Int32? PricingMethod
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldPricingMethod] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCalculationFee.FieldPricingMethod);
			}
			set{
				this[this.uiviewCalculationFee.FieldPricingMethod] = value;
			}
		}
		
		
		public  Double? TotalAmount
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldTotalAmount] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee.FieldTotalAmount);
			}
			set{
				this[this.uiviewCalculationFee.FieldTotalAmount] = value;
			}
		}
		
		
		public  Double? RealAmount
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldRealAmount] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee.FieldRealAmount);
			}
			set{
				this[this.uiviewCalculationFee.FieldRealAmount] = value;
			}
		}
		
		
		public  Double? UintPrice
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldUintPrice] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee.FieldUintPrice);
			}
			set{
				this[this.uiviewCalculationFee.FieldUintPrice] = value;
			}
		}
		
		
		public  String Remark
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldRemark] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldRemark);
			}
			set{
				this[this.uiviewCalculationFee.FieldRemark] = value;
			}
		}
		
		
		public  Boolean? Contain
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldContain] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCalculationFee.FieldContain);
			}
			set{
				this[this.uiviewCalculationFee.FieldContain] = value;
			}
		}
		
		
		public  Int32? NumberOfTrucks
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldNumberOfTrucks] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCalculationFee.FieldNumberOfTrucks);
			}
			set{
				this[this.uiviewCalculationFee.FieldNumberOfTrucks] = value;
			}
		}
		
		
		public  Int64? HuangdaoTotal
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldHuangdaoTotal] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee.FieldHuangdaoTotal);
			}
			set{
				this[this.uiviewCalculationFee.FieldHuangdaoTotal] = value;
			}
		}
		
		
		public  Int64? ChenyangTotal
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldChenyangTotal] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee.FieldChenyangTotal);
			}
			set{
				this[this.uiviewCalculationFee.FieldChenyangTotal] = value;
			}
		}
		
		
		public  Int64? SetLocation
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldSetLocation] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee.FieldSetLocation);
			}
			set{
				this[this.uiviewCalculationFee.FieldSetLocation] = value;
			}
		}
		
		
		public  Int64? Province
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldProvince] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee.FieldProvince);
			}
			set{
				this[this.uiviewCalculationFee.FieldProvince] = value;
			}
		}
		
		
		public  String Province_Code
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldProvince_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldProvince_Code);
			}
			set{
				this[this.uiviewCalculationFee.FieldProvince_Code] = value;
			}
		}
		
		
		public  String Province_Name
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldProvince_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldProvince_Name);
			}
			set{
				this[this.uiviewCalculationFee.FieldProvince_Name] = value;
			}
		}
		
		
		public  Int64? City
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldCity] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee.FieldCity);
			}
			set{
				this[this.uiviewCalculationFee.FieldCity] = value;
			}
		}
		
		
		public  String City_Code
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldCity_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldCity_Code);
			}
			set{
				this[this.uiviewCalculationFee.FieldCity_Code] = value;
			}
		}
		
		
		public  String City_Name
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldCity_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldCity_Name);
			}
			set{
				this[this.uiviewCalculationFee.FieldCity_Name] = value;
			}
		}
		
		
		public  Int64? County
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldCounty] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee.FieldCounty);
			}
			set{
				this[this.uiviewCalculationFee.FieldCounty] = value;
			}
		}
		
		
		public  String County_Code
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldCounty_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldCounty_Code);
			}
			set{
				this[this.uiviewCalculationFee.FieldCounty_Code] = value;
			}
		}
		
		
		public  String County_Name
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldCounty_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldCounty_Name);
			}
			set{
				this[this.uiviewCalculationFee.FieldCounty_Name] = value;
			}
		}
		
		
		public  String DescriLocation
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldDescriLocation] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldDescriLocation);
			}
			set{
				this[this.uiviewCalculationFee.FieldDescriLocation] = value;
			}
		}
		
		
		public  String Address
		{
			get{
				//object value = this[this.uiviewCalculationFee.FieldAddress] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee.FieldAddress);
			}
			set{
				this[this.uiviewCalculationFee.FieldAddress] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class CalculationFeeDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public CalculationFeeDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private CalculationFeeDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new CalculationFeeDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



	[Serializable]
	public partial class CalculationFee_CalculationFeeLineView : UIView
	{
		#region Constructor
		public CalculationFee_CalculationFeeLineView(IUIModel model) : base(model,"CalculationFee_CalculationFeeLine","UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private CalculationFee_CalculationFeeLineView():base(null,"CalculationFee_CalculationFeeLine","UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new CalculationFee_CalculationFeeLineView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldCalculationFee
		{
			get { return this.Fields["CalculationFee"]; }
		}
		public IUIField FieldDocNo
		{
			get { return this.Fields["DocNo"]; }
		}
		public IUIField FieldDocID
		{
			get { return this.Fields["DocID"]; }
		}
		public IUIField FieldLineID
		{
			get { return this.Fields["LineID"]; }
		}
		public IUIField FieldItem
		{
			get { return this.Fields["Item"]; }
		}
		public IUIField FieldItem_Code
		{
			get { return this.Fields["Item_Code"]; }
		}
		public IUIField FieldItem_Name
		{
			get { return this.Fields["Item_Name"]; }
		}
		public IUIField FieldQty
		{
			get { return this.Fields["Qty"]; }
		}
		public IUIField FieldSalesUom
		{
			get { return this.Fields["SalesUom"]; }
		}
		public IUIField FieldSalesUom_Code
		{
			get { return this.Fields["SalesUom_Code"]; }
		}
		public IUIField FieldSalesUom_Name
		{
			get { return this.Fields["SalesUom_Name"]; }
		}
		public IUIField FieldRealDeliveryFactory
		{
			get { return this.Fields["RealDeliveryFactory"]; }
		}
		public IUIField FieldRealPricingMethod
		{
			get { return this.Fields["RealPricingMethod"]; }
		}
		public IUIField FieldIBulk
		{
			get { return this.Fields["IBulk"]; }
		}
		public IUIField FieldBulkUom
		{
			get { return this.Fields["BulkUom"]; }
		}
		public IUIField FieldBulkUom_Code
		{
			get { return this.Fields["BulkUom_Code"]; }
		}
		public IUIField FieldBulkUom_Name
		{
			get { return this.Fields["BulkUom_Name"]; }
		}
		public IUIField FieldWeight
		{
			get { return this.Fields["Weight"]; }
		}
		public IUIField FieldWeightUom
		{
			get { return this.Fields["WeightUom"]; }
		}
		public IUIField FieldWeightUom_Code
		{
			get { return this.Fields["WeightUom_Code"]; }
		}
		public IUIField FieldWeightUom_Name
		{
			get { return this.Fields["WeightUom_Name"]; }
		}
		public IUIField FieldPricingQty
		{
			get { return this.Fields["PricingQty"]; }
		}
		public IUIField FieldPricingUom
		{
			get { return this.Fields["PricingUom"]; }
		}
		public IUIField FieldPricingUom_Code
		{
			get { return this.Fields["PricingUom_Code"]; }
		}
		public IUIField FieldPricingUom_Name
		{
			get { return this.Fields["PricingUom_Name"]; }
		}
		public IUIField FieldDocType
		{
			get { return this.Fields["DocType"]; }
		}


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","6e4272e6-5793-4b83-9af2-78263069f138");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","bcc56412-a953-4028-9a07-eec8eb4899ef");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","55120a54-f0a4-438d-8296-e0210aeb17b4");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","3913c921-7ec2-4d1e-9a1b-26826d6fa23a");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","61c6326b-5a7c-4a18-ba39-f31a161bec65");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","0a0e1876-e9dc-4153-9511-a2f7d9a43c5b");
			UIModelRuntimeFactory.AddNewUIField(this,"CalculationFee", typeof(Int64), true,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee", "CalculationFee", true,true, false, "",false,(UIFieldType)4,"c9784ebe-f3b1-46b2-b157-cc143bbe9dc8","a8188f7e-1dff-4452-8c47-a8406a21452c");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), true,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c0a25543-3afc-4917-81f3-31a5382bd3fb");
			UIModelRuntimeFactory.AddNewUIField(this,"DocID", typeof(Int64), true,"0","System.Int64", "DocID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","703b696c-e785-4e7a-8026-7b90ece852e7");
			UIModelRuntimeFactory.AddNewUIField(this,"LineID", typeof(Int64), true,"0","System.Int64", "LineID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c1d87e12-eeb8-44fe-a02b-1ec9f8731316");
			UIModelRuntimeFactory.AddNewUIField(this,"Item", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "Item", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","c751a0b7-fe86-4103-961b-334c927ed5d3");
			UIModelRuntimeFactory.AddNewUIField(this,"Item_Code", typeof(String), false,"","System.String", "Item.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b8fe39d7-15ca-4e09-b9f2-bb5a4e6cbc2f");
			UIModelRuntimeFactory.AddNewUIField(this,"Item_Name", typeof(String), false,"","System.String", "Item.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eaac36e7-5f7a-4bd3-84ca-2e95d030f94d");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Double), true,"0","System.Double", "Qty", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","3d2fe207-ba1c-432b-ab3c-643d3a313303");
			UIModelRuntimeFactory.AddNewUIField(this,"SalesUom", typeof(Int64), true,"","UFIDA.U9.Base.UOM.UOM", "SalesUom", true,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","97f74019-6b18-4a8f-a5cd-654ea7307633");
			UIModelRuntimeFactory.AddNewUIField(this,"SalesUom_Code", typeof(String), false,"","System.String", "SalesUom.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fe0b3e0f-be28-4c6f-9d36-4c63de9bca8a");
			UIModelRuntimeFactory.AddNewUIField(this,"SalesUom_Name", typeof(String), true,"","System.String", "SalesUom.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4ffe6ee9-3570-49dc-a2a2-1412b1229662");
			UIModelRuntimeFactory.AddNewUIField(this,"RealDeliveryFactory", typeof(Int32), true,"-1","UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum", "RealDeliveryFactory", true,true, false, "",false,(UIFieldType)2,"0bda0d68-2eee-47d5-ba80-59c869cf4316","ac285e9f-011e-4c05-b126-1102a6a1dbc3");
			UIModelRuntimeFactory.AddNewUIField(this,"RealPricingMethod", typeof(Int32), true,"0","UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum", "RealPricingMethod", true,true, false, "",false,(UIFieldType)2,"5208ce26-38bb-4e7f-830b-d38cde9eb7d3","da14e749-0408-44b7-8304-d863947e2719");
			UIModelRuntimeFactory.AddNewUIField(this,"IBulk", typeof(Double), true,"0","System.Double", "IBulk", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","494b0f6c-3b88-4a05-b9d0-80f6b4f1a6ae");
			UIModelRuntimeFactory.AddNewUIField(this,"BulkUom", typeof(Int64), true,"","UFIDA.U9.Base.UOM.UOM", "BulkUom", true,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","e99856a8-a541-45b6-840b-f032eaedc50e");
			UIModelRuntimeFactory.AddNewUIField(this,"BulkUom_Code", typeof(String), false,"","System.String", "BulkUom.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","babee122-c152-434b-b4fe-9be3804dae89");
			UIModelRuntimeFactory.AddNewUIField(this,"BulkUom_Name", typeof(String), true,"","System.String", "BulkUom.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b6a159d7-adac-48bd-a653-c188b69ed129");
			UIModelRuntimeFactory.AddNewUIField(this,"Weight", typeof(Double), true,"0","System.Double", "Weight", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","1bc96e84-8b11-4c53-b6ce-999cd0e08a3e");
			UIModelRuntimeFactory.AddNewUIField(this,"WeightUom", typeof(Int64), true,"","UFIDA.U9.Base.UOM.UOM", "WeightUom", true,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","42dacd6b-0edb-4bbd-8a5d-d1b750f168c0");
			UIModelRuntimeFactory.AddNewUIField(this,"WeightUom_Code", typeof(String), false,"","System.String", "WeightUom.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e3345658-7abf-494e-9e44-2de38f5cc95f");
			UIModelRuntimeFactory.AddNewUIField(this,"WeightUom_Name", typeof(String), true,"","System.String", "WeightUom.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","08140f64-c61d-4ec7-a739-1c4f9af79716");
			UIModelRuntimeFactory.AddNewUIField(this,"PricingQty", typeof(Double), true,"0","System.Double", "PricingQty", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","91d40757-eb38-492f-b65f-e7ccbc980cea");
			UIModelRuntimeFactory.AddNewUIField(this,"PricingUom", typeof(Int64), true,"","UFIDA.U9.Base.UOM.UOM", "PricingUom", true,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","b749cece-3955-4c2a-8f81-7165bc199c2f");
			UIModelRuntimeFactory.AddNewUIField(this,"PricingUom_Code", typeof(String), false,"","System.String", "PricingUom.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","adc47d38-298a-4a91-bd98-c9e6136860bd");
			UIModelRuntimeFactory.AddNewUIField(this,"PricingUom_Name", typeof(String), true,"","System.String", "PricingUom.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","288a6bc0-ae00-4edd-a355-3c5d1173ada6");
			UIModelRuntimeFactory.AddNewUIField(this,"DocType", typeof(Int32), true,"0","UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum", "DocType", true,true, false, "",false,(UIFieldType)2,"453b1008-de2b-4c62-b193-5670d392d30b","97818bdc-3129-4e05-b259-35512135fe83");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new CalculationFee_CalculationFeeLineRecord(builder);
		}
		#endregion

		#region new method
		public new CalculationFee_CalculationFeeLineRecord FocusedRecord
		{
			get { return (CalculationFee_CalculationFeeLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new CalculationFee_CalculationFeeLineRecord AddNewUIRecord()
		{	
			return (CalculationFee_CalculationFeeLineRecord)base.AddNewUIRecord();
		}
		public new CalculationFee_CalculationFeeLineRecord NewUIRecord()
		{	
			return (CalculationFee_CalculationFeeLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class CalculationFee_CalculationFeeLineRecord : UIRecord
	{
		#region Constructor
		public CalculationFee_CalculationFeeLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private CalculationFee_CalculationFeeLineView uiviewCalculationFee_CalculationFeeLine
		{
			get { return (CalculationFee_CalculationFeeLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new CalculationFee_CalculationFeeLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCalculationFee_CalculationFeeLine.FieldID);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCalculationFee_CalculationFeeLine.FieldCreatedOn);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldCreatedBy);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCalculationFee_CalculationFeeLine.FieldModifiedOn);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldModifiedBy);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee_CalculationFeeLine.FieldSysVersion);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? CalculationFee
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldCalculationFee] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee_CalculationFeeLine.FieldCalculationFee);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldCalculationFee] = value;
			}
		}
		
		
		public  String DocNo
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldDocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldDocNo);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldDocNo] = value;
			}
		}
		
		
		public  Int64? DocID
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldDocID] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee_CalculationFeeLine.FieldDocID);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldDocID] = value;
			}
		}
		
		
		public  Int64? LineID
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldLineID] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee_CalculationFeeLine.FieldLineID);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldLineID] = value;
			}
		}
		
		
		public  Int64? Item
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldItem] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee_CalculationFeeLine.FieldItem);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldItem] = value;
			}
		}
		
		
		public  String Item_Code
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldItem_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldItem_Code);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldItem_Code] = value;
			}
		}
		
		
		public  String Item_Name
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldItem_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldItem_Name);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldItem_Name] = value;
			}
		}
		
		
		public  Double? Qty
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldQty] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_CalculationFeeLine.FieldQty);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldQty] = value;
			}
		}
		
		
		public  Int64? SalesUom
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldSalesUom] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee_CalculationFeeLine.FieldSalesUom);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldSalesUom] = value;
			}
		}
		
		
		public  String SalesUom_Code
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldSalesUom_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldSalesUom_Code);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldSalesUom_Code] = value;
			}
		}
		
		
		public  String SalesUom_Name
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldSalesUom_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldSalesUom_Name);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldSalesUom_Name] = value;
			}
		}
		
		
		public  Int32? RealDeliveryFactory
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldRealDeliveryFactory] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCalculationFee_CalculationFeeLine.FieldRealDeliveryFactory);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldRealDeliveryFactory] = value;
			}
		}
		
		
		public  Int32? RealPricingMethod
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldRealPricingMethod] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCalculationFee_CalculationFeeLine.FieldRealPricingMethod);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldRealPricingMethod] = value;
			}
		}
		
		
		public  Double? IBulk
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldIBulk] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_CalculationFeeLine.FieldIBulk);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldIBulk] = value;
			}
		}
		
		
		public  Int64? BulkUom
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldBulkUom] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee_CalculationFeeLine.FieldBulkUom);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldBulkUom] = value;
			}
		}
		
		
		public  String BulkUom_Code
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldBulkUom_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldBulkUom_Code);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldBulkUom_Code] = value;
			}
		}
		
		
		public  String BulkUom_Name
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldBulkUom_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldBulkUom_Name);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldBulkUom_Name] = value;
			}
		}
		
		
		public  Double? Weight
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldWeight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_CalculationFeeLine.FieldWeight);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldWeight] = value;
			}
		}
		
		
		public  Int64? WeightUom
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldWeightUom] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee_CalculationFeeLine.FieldWeightUom);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldWeightUom] = value;
			}
		}
		
		
		public  String WeightUom_Code
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldWeightUom_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldWeightUom_Code);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldWeightUom_Code] = value;
			}
		}
		
		
		public  String WeightUom_Name
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldWeightUom_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldWeightUom_Name);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldWeightUom_Name] = value;
			}
		}
		
		
		public  Double? PricingQty
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldPricingQty] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_CalculationFeeLine.FieldPricingQty);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldPricingQty] = value;
			}
		}
		
		
		public  Int64? PricingUom
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldPricingUom] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee_CalculationFeeLine.FieldPricingUom);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldPricingUom] = value;
			}
		}
		
		
		public  String PricingUom_Code
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldPricingUom_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldPricingUom_Code);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldPricingUom_Code] = value;
			}
		}
		
		
		public  String PricingUom_Name
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldPricingUom_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_CalculationFeeLine.FieldPricingUom_Name);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldPricingUom_Name] = value;
			}
		}
		
		
		public  Int32? DocType
		{
			get{
				//object value = this[this.uiviewCalculationFee_CalculationFeeLine.FieldDocType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCalculationFee_CalculationFeeLine.FieldDocType);
			}
			set{
				this[this.uiviewCalculationFee_CalculationFeeLine.FieldDocType] = value;
			}
		}
		#endregion
	}
	



	[Serializable]
	public partial class CalculationFee_HuangdaoTotalView : UIView
	{
		#region Constructor
		public CalculationFee_HuangdaoTotalView(IUIModel model) : base(model,"CalculationFee_HuangdaoTotal","UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private CalculationFee_HuangdaoTotalView():base(null,"CalculationFee_HuangdaoTotal","UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new CalculationFee_HuangdaoTotalView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldTotalBulk
		{
			get { return this.Fields["TotalBulk"]; }
		}
		public IUIField FieldTotalWeight
		{
			get { return this.Fields["TotalWeight"]; }
		}
		public IUIField FieldRealBulk
		{
			get { return this.Fields["RealBulk"]; }
		}
		public IUIField FieldRealWeight
		{
			get { return this.Fields["RealWeight"]; }
		}
		public IUIField FieldPickupFee
		{
			get { return this.Fields["PickupFee"]; }
		}
		public IUIField FieldDeliveryFee
		{
			get { return this.Fields["DeliveryFee"]; }
		}
		public IUIField FieldDischargeFee
		{
			get { return this.Fields["DischargeFee"]; }
		}
		public IUIField FieldOtherFee
		{
			get { return this.Fields["OtherFee"]; }
		}
		public IUIField FieldTotalFreight
		{
			get { return this.Fields["TotalFreight"]; }
		}
		public IUIField FieldRealFreight
		{
			get { return this.Fields["RealFreight"]; }
		}


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","794bd189-a0c4-42f0-986b-60d75d60543b");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","88b59363-f092-43f2-95f6-3951095ad5ea");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","948345af-c3ce-49d7-be65-ebcf7c9916dd");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","422bbaa0-ef21-4d01-b393-ce6a352ddf1a");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3fcecba7-c0ee-4ff9-a409-88fef65cc215");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","8b9d06c9-614c-44cf-9bca-d2992ba740c9");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalBulk", typeof(Double), true,"0","System.Double", "TotalBulk", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","faa7cc7e-9ec6-4e0e-81f4-962be22a05c7");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalWeight", typeof(Double), true,"0","System.Double", "TotalWeight", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","5a71ddfc-64f4-47a7-9a7e-a81eb1d9e08a");
			UIModelRuntimeFactory.AddNewUIField(this,"RealBulk", typeof(Double), true,"0","System.Double", "RealBulk", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","a1c2302c-65a6-47b1-99e4-9c5959680c84");
			UIModelRuntimeFactory.AddNewUIField(this,"RealWeight", typeof(Double), true,"0","System.Double", "RealWeight", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","bb29cfec-9622-451c-af58-5917114ae11a");
			UIModelRuntimeFactory.AddNewUIField(this,"PickupFee", typeof(Double), true,"0","System.Double", "PickupFee", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","0aa4de95-c9d8-4d3c-b40f-12efdcac916a");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryFee", typeof(Double), true,"0","System.Double", "DeliveryFee", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","1c51151a-a6de-4c9a-a3da-c166bb076e85");
			UIModelRuntimeFactory.AddNewUIField(this,"DischargeFee", typeof(Double), true,"0","System.Double", "DischargeFee", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","35cb9043-a9ed-4e3d-bbe6-08be2b23eae0");
			UIModelRuntimeFactory.AddNewUIField(this,"OtherFee", typeof(Double), true,"0","System.Double", "OtherFee", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","5994ec3b-f4ec-42e7-b86c-b9de42a73aca");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalFreight", typeof(Double), true,"0","System.Double", "TotalFreight", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","3657b0ef-e7a4-45f5-a486-4a05d3631786");
			UIModelRuntimeFactory.AddNewUIField(this,"RealFreight", typeof(Double), true,"0","System.Double", "RealFreight", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","2fda720e-2cb7-4137-9513-6ec89220309d");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new CalculationFee_HuangdaoTotalRecord(builder);
		}
		#endregion

		#region new method
		public new CalculationFee_HuangdaoTotalRecord FocusedRecord
		{
			get { return (CalculationFee_HuangdaoTotalRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new CalculationFee_HuangdaoTotalRecord AddNewUIRecord()
		{	
			return (CalculationFee_HuangdaoTotalRecord)base.AddNewUIRecord();
		}
		public new CalculationFee_HuangdaoTotalRecord NewUIRecord()
		{	
			return (CalculationFee_HuangdaoTotalRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class CalculationFee_HuangdaoTotalRecord : UIRecord
	{
		#region Constructor
		public CalculationFee_HuangdaoTotalRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private CalculationFee_HuangdaoTotalView uiviewCalculationFee_HuangdaoTotal
		{
			get { return (CalculationFee_HuangdaoTotalView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new CalculationFee_HuangdaoTotalRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCalculationFee_HuangdaoTotal.FieldID);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCalculationFee_HuangdaoTotal.FieldCreatedOn);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_HuangdaoTotal.FieldCreatedBy);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCalculationFee_HuangdaoTotal.FieldModifiedOn);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_HuangdaoTotal.FieldModifiedBy);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee_HuangdaoTotal.FieldSysVersion);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldSysVersion] = value;
			}
		}
		
		
		public  Double? TotalBulk
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldTotalBulk] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_HuangdaoTotal.FieldTotalBulk);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldTotalBulk] = value;
			}
		}
		
		
		public  Double? TotalWeight
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldTotalWeight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_HuangdaoTotal.FieldTotalWeight);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldTotalWeight] = value;
			}
		}
		
		
		public  Double? RealBulk
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldRealBulk] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_HuangdaoTotal.FieldRealBulk);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldRealBulk] = value;
			}
		}
		
		
		public  Double? RealWeight
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldRealWeight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_HuangdaoTotal.FieldRealWeight);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldRealWeight] = value;
			}
		}
		
		
		public  Double? PickupFee
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldPickupFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_HuangdaoTotal.FieldPickupFee);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldPickupFee] = value;
			}
		}
		
		
		public  Double? DeliveryFee
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldDeliveryFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_HuangdaoTotal.FieldDeliveryFee);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldDeliveryFee] = value;
			}
		}
		
		
		public  Double? DischargeFee
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldDischargeFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_HuangdaoTotal.FieldDischargeFee);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldDischargeFee] = value;
			}
		}
		
		
		public  Double? OtherFee
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldOtherFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_HuangdaoTotal.FieldOtherFee);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldOtherFee] = value;
			}
		}
		
		
		public  Double? TotalFreight
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldTotalFreight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_HuangdaoTotal.FieldTotalFreight);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldTotalFreight] = value;
			}
		}
		
		
		public  Double? RealFreight
		{
			get{
				//object value = this[this.uiviewCalculationFee_HuangdaoTotal.FieldRealFreight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_HuangdaoTotal.FieldRealFreight);
			}
			set{
				this[this.uiviewCalculationFee_HuangdaoTotal.FieldRealFreight] = value;
			}
		}
		#endregion
	}
	



	[Serializable]
	public partial class CalculationFee_ChenyangTotalView : UIView
	{
		#region Constructor
		public CalculationFee_ChenyangTotalView(IUIModel model) : base(model,"CalculationFee_ChenyangTotal","UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private CalculationFee_ChenyangTotalView():base(null,"CalculationFee_ChenyangTotal","UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new CalculationFee_ChenyangTotalView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldTotalBulk
		{
			get { return this.Fields["TotalBulk"]; }
		}
		public IUIField FieldTotalWeight
		{
			get { return this.Fields["TotalWeight"]; }
		}
		public IUIField FieldRealBulk
		{
			get { return this.Fields["RealBulk"]; }
		}
		public IUIField FieldRealWeight
		{
			get { return this.Fields["RealWeight"]; }
		}
		public IUIField FieldPickupFee
		{
			get { return this.Fields["PickupFee"]; }
		}
		public IUIField FieldDeliveryFee
		{
			get { return this.Fields["DeliveryFee"]; }
		}
		public IUIField FieldDischargeFee
		{
			get { return this.Fields["DischargeFee"]; }
		}
		public IUIField FieldOtherFee
		{
			get { return this.Fields["OtherFee"]; }
		}
		public IUIField FieldTotalFreight
		{
			get { return this.Fields["TotalFreight"]; }
		}
		public IUIField FieldRealFreight
		{
			get { return this.Fields["RealFreight"]; }
		}


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","d29e337a-8c1c-47a5-a7b2-7bf142365551");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","bf7baa58-9054-455e-b669-927c21186ce1");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","03fe7168-2b38-4a3e-b73b-28c1934981f5");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","a35c2165-f887-41f8-9769-f381ff2887aa");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e1f1b777-720c-4a2c-9a42-a3c1133c853f");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","2c2b7f10-bc75-4767-9500-4e438534cd4b");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalBulk", typeof(Double), true,"0","System.Double", "TotalBulk", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","eb59303e-83d8-4f1f-96a7-0728a8166d74");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalWeight", typeof(Double), true,"0","System.Double", "TotalWeight", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","77069d4c-cbbe-4e16-9f58-fafe5a01ce3e");
			UIModelRuntimeFactory.AddNewUIField(this,"RealBulk", typeof(Double), true,"0","System.Double", "RealBulk", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","70a83b06-b4d6-4153-a83d-fd5336abe235");
			UIModelRuntimeFactory.AddNewUIField(this,"RealWeight", typeof(Double), true,"0","System.Double", "RealWeight", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","f6b5f60f-77c5-4024-8fe1-90dc1502cb58");
			UIModelRuntimeFactory.AddNewUIField(this,"PickupFee", typeof(Double), true,"0","System.Double", "PickupFee", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","7c1a72c6-622b-4d4d-97ef-006d5f029483");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryFee", typeof(Double), true,"0","System.Double", "DeliveryFee", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","3e25846d-ec9d-4832-9984-a6cd75e6cd44");
			UIModelRuntimeFactory.AddNewUIField(this,"DischargeFee", typeof(Double), true,"0","System.Double", "DischargeFee", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","92200600-8792-4a3a-8f46-b7d69a6ca2f3");
			UIModelRuntimeFactory.AddNewUIField(this,"OtherFee", typeof(Double), true,"0","System.Double", "OtherFee", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","187561b5-de86-4a3b-a76b-ab602694bab2");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalFreight", typeof(Double), true,"0","System.Double", "TotalFreight", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","77361a10-b484-40c1-8dd7-105bb17ca5c9");
			UIModelRuntimeFactory.AddNewUIField(this,"RealFreight", typeof(Double), true,"0","System.Double", "RealFreight", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","8bff73b7-6b10-4621-b88d-15b9aee711ef");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new CalculationFee_ChenyangTotalRecord(builder);
		}
		#endregion

		#region new method
		public new CalculationFee_ChenyangTotalRecord FocusedRecord
		{
			get { return (CalculationFee_ChenyangTotalRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new CalculationFee_ChenyangTotalRecord AddNewUIRecord()
		{	
			return (CalculationFee_ChenyangTotalRecord)base.AddNewUIRecord();
		}
		public new CalculationFee_ChenyangTotalRecord NewUIRecord()
		{	
			return (CalculationFee_ChenyangTotalRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class CalculationFee_ChenyangTotalRecord : UIRecord
	{
		#region Constructor
		public CalculationFee_ChenyangTotalRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private CalculationFee_ChenyangTotalView uiviewCalculationFee_ChenyangTotal
		{
			get { return (CalculationFee_ChenyangTotalView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new CalculationFee_ChenyangTotalRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCalculationFee_ChenyangTotal.FieldID);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCalculationFee_ChenyangTotal.FieldCreatedOn);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_ChenyangTotal.FieldCreatedBy);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCalculationFee_ChenyangTotal.FieldModifiedOn);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCalculationFee_ChenyangTotal.FieldModifiedBy);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCalculationFee_ChenyangTotal.FieldSysVersion);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldSysVersion] = value;
			}
		}
		
		
		public  Double? TotalBulk
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldTotalBulk] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_ChenyangTotal.FieldTotalBulk);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldTotalBulk] = value;
			}
		}
		
		
		public  Double? TotalWeight
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldTotalWeight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_ChenyangTotal.FieldTotalWeight);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldTotalWeight] = value;
			}
		}
		
		
		public  Double? RealBulk
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldRealBulk] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_ChenyangTotal.FieldRealBulk);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldRealBulk] = value;
			}
		}
		
		
		public  Double? RealWeight
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldRealWeight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_ChenyangTotal.FieldRealWeight);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldRealWeight] = value;
			}
		}
		
		
		public  Double? PickupFee
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldPickupFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_ChenyangTotal.FieldPickupFee);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldPickupFee] = value;
			}
		}
		
		
		public  Double? DeliveryFee
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldDeliveryFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_ChenyangTotal.FieldDeliveryFee);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldDeliveryFee] = value;
			}
		}
		
		
		public  Double? DischargeFee
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldDischargeFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_ChenyangTotal.FieldDischargeFee);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldDischargeFee] = value;
			}
		}
		
		
		public  Double? OtherFee
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldOtherFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_ChenyangTotal.FieldOtherFee);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldOtherFee] = value;
			}
		}
		
		
		public  Double? TotalFreight
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldTotalFreight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_ChenyangTotal.FieldTotalFreight);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldTotalFreight] = value;
			}
		}
		
		
		public  Double? RealFreight
		{
			get{
				//object value = this[this.uiviewCalculationFee_ChenyangTotal.FieldRealFreight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewCalculationFee_ChenyangTotal.FieldRealFreight);
			}
			set{
				this[this.uiviewCalculationFee_ChenyangTotal.FieldRealFreight] = value;
			}
		}
		#endregion
	}
	



}