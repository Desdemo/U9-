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
	public partial class LogisticsPricelistUIModelModel : UIModel
	{
		#region Constructor
		public LogisticsPricelistUIModelModel() : base("LogisticsPricelistUIModel")
		{
			InitClass();
			this.SetResourceInfo("289a8f00-3ce7-4d28-b49f-8b59bc57399c");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private LogisticsPricelistUIModelModel(bool isInit) : base("LogisticsPricelistUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new LogisticsPricelistUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private LogisticsPricelistView viewLogisticsPricelist;			
		private LogisticsPricelist_LogisticsPricelistLineView viewLogisticsPricelist_LogisticsPricelistLine;			
		#endregion
		
		#region links
		//private IUILink linkLogisticsPricelist__LogisticsPricelist_LogisticsPricelistLine;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public LogisticsPricelistView LogisticsPricelist
		{
			get { return (LogisticsPricelistView)this["LogisticsPricelist"]; }
		}
		public LogisticsPricelist_LogisticsPricelistLineView LogisticsPricelist_LogisticsPricelistLine
		{
			get { return (LogisticsPricelist_LogisticsPricelistLineView)this["LogisticsPricelist_LogisticsPricelistLine"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewLogisticsPricelist = new LogisticsPricelistView(this);
			this.viewLogisticsPricelist.SetResourceInfo("8221d62a-f5ec-411e-85e9-8f21dd6403a6");
			this.Views.Add(this.viewLogisticsPricelist);			
			this.viewLogisticsPricelist_LogisticsPricelistLine = new LogisticsPricelist_LogisticsPricelistLineView(this);
			this.viewLogisticsPricelist_LogisticsPricelistLine.SetResourceInfo("b333802a-14fb-4942-9b74-7e8dc63935cf");
			this.Views.Add(this.viewLogisticsPricelist_LogisticsPricelistLine);			

			//this.linkLogisticsPricelist__LogisticsPricelist_LogisticsPricelistLine
			{
			IUILink link = new UILink("LogisticsPricelist__LogisticsPricelist_LogisticsPricelistLine",this,this.viewLogisticsPricelist.FieldID,this.viewLogisticsPricelist_LogisticsPricelistLine.FieldLogisticsPricelist,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"LogisticsPricelistLine");
			this.Links.Add(link);
			}
			//this.linkLogisticsPricelist__LogisticsPricelist_LogisticsPricelistLine.ChildKeyConstraint.UpdateRule = Rule.Cascade;
			//this.linkLogisticsPricelist__LogisticsPricelist_LogisticsPricelistLine.ChildKeyConstraint.DeleteRule = Rule.Cascade;
			//this.linkLogisticsPricelist__LogisticsPricelist_LogisticsPricelistLine.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
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
	public partial class LogisticsPricelistView : UIView
	{
		#region Constructor
		public LogisticsPricelistView(IUIModel model) : base(model,"LogisticsPricelist","UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private LogisticsPricelistView():base(null,"LogisticsPricelist","UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new LogisticsPricelistView();
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
		public IUIField FieldCode
		{
			get { return this.Fields["Code"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
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
		public IUIField FieldCurrency
		{
			get { return this.Fields["Currency"]; }
		}
		public IUIField FieldCurrency_Code
		{
			get { return this.Fields["Currency_Code"]; }
		}
		public IUIField FieldCurrency_Name
		{
			get { return this.Fields["Currency_Name"]; }
		}


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","298d69bb-f313-48d9-915d-6c90413c7779");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","cd56380e-3580-45de-8aa0-d81379c11677");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","66052a08-ae9b-4f99-b6c0-ffbb6195caf5");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","8e7b9f7f-ec01-44c9-ab01-4d59221da07f");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2b58240f-6b04-40a1-b41e-308514542f8c");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a2ef34d2-cfe8-439d-b19b-80cad5057f2c");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), true,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8a7bc2c9-3b4a-41fa-8166-394235f92961");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ae2d7d1-30dd-452d-904b-ac73e80d8f64");
			UIModelRuntimeFactory.AddNewUIField(this,"Sup", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Supplier.Supplier", "Sup", true,true, false, "",false,(UIFieldType)4,"ac3510e5-3337-46d4-b41c-46ac40f343e1","87202b0c-5de2-4f7c-aa67-b7ef0d0ff10b");
			UIModelRuntimeFactory.AddNewUIField(this,"Sup_Code", typeof(String), false,"","System.String", "Sup.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7f2b660e-4b03-418c-bf3c-0b53faa46bdc");
			UIModelRuntimeFactory.AddNewUIField(this,"Sup_Name", typeof(String), true,"","System.String", "Sup.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","986c0814-bb08-4487-98c1-ea1c1e1a4feb");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency", typeof(Int64), true,"","UFIDA.U9.Base.Currency.Currency", "Currency", true,true, false, "",false,(UIFieldType)4,"73536b96-4dce-4512-b5ef-97e90dc01cbb","104c808d-dce1-49b8-92af-ce497efb33bf");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_Code", typeof(String), false,"","System.String", "Currency.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a7a87560-b796-44e5-b14d-0a7758a8669d");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_Name", typeof(String), true,"","System.String", "Currency.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7888c8e1-1fd9-4c94-acf0-87cca754ac69");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new LogisticsPricelistRecord(builder);
		}
		#endregion

		#region new method
		public new LogisticsPricelistRecord FocusedRecord
		{
			get { return (LogisticsPricelistRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new LogisticsPricelistRecord AddNewUIRecord()
		{	
			return (LogisticsPricelistRecord)base.AddNewUIRecord();
		}
		public new LogisticsPricelistRecord NewUIRecord()
		{	
			return (LogisticsPricelistRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class LogisticsPricelistRecord : UIRecord
	{
		#region Constructor
		public LogisticsPricelistRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private LogisticsPricelistView uiviewLogisticsPricelist
		{
			get { return (LogisticsPricelistView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new LogisticsPricelistRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewLogisticsPricelist.FieldID);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewLogisticsPricelist.FieldCreatedOn);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist.FieldCreatedBy);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewLogisticsPricelist.FieldModifiedOn);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist.FieldModifiedBy);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewLogisticsPricelist.FieldSysVersion);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldSysVersion] = value;
			}
		}
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist.FieldCode);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldCode] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist.FieldName);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldName] = value;
			}
		}
		
		
		public  Int64? Sup
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldSup] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewLogisticsPricelist.FieldSup);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldSup] = value;
			}
		}
		
		
		public  String Sup_Code
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldSup_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist.FieldSup_Code);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldSup_Code] = value;
			}
		}
		
		
		public  String Sup_Name
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldSup_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist.FieldSup_Name);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldSup_Name] = value;
			}
		}
		
		
		public  Int64? Currency
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldCurrency] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewLogisticsPricelist.FieldCurrency);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldCurrency] = value;
			}
		}
		
		
		public  String Currency_Code
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldCurrency_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist.FieldCurrency_Code);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldCurrency_Code] = value;
			}
		}
		
		
		public  String Currency_Name
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist.FieldCurrency_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist.FieldCurrency_Name);
			}
			set{
				this[this.uiviewLogisticsPricelist.FieldCurrency_Name] = value;
			}
		}
		#endregion
	}
	



	[Serializable]
	public partial class LogisticsPricelist_LogisticsPricelistLineView : UIView
	{
		#region Constructor
		public LogisticsPricelist_LogisticsPricelistLineView(IUIModel model) : base(model,"LogisticsPricelist_LogisticsPricelistLine","UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private LogisticsPricelist_LogisticsPricelistLineView():base(null,"LogisticsPricelist_LogisticsPricelistLine","UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new LogisticsPricelist_LogisticsPricelistLineView();
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
		public IUIField FieldLogisticsPricelist
		{
			get { return this.Fields["LogisticsPricelist"]; }
		}
		public IUIField FieldLogisticsPricelist_Code
		{
			get { return this.Fields["LogisticsPricelist_Code"]; }
		}
		public IUIField FieldLogisticsPricelist_Name
		{
			get { return this.Fields["LogisticsPricelist_Name"]; }
		}
		public IUIField FieldNo
		{
			get { return this.Fields["No"]; }
		}
		public IUIField FieldDeliveryFactory
		{
			get { return this.Fields["DeliveryFactory"]; }
		}
		public IUIField FieldAddress
		{
			get { return this.Fields["Address"]; }
		}
		public IUIField FieldAddress_Code
		{
			get { return this.Fields["Address_Code"]; }
		}
		public IUIField FieldAddress_Name
		{
			get { return this.Fields["Address_Name"]; }
		}
		public IUIField FieldPricingMethod
		{
			get { return this.Fields["PricingMethod"]; }
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
		public IUIField FieldUintPrice
		{
			get { return this.Fields["UintPrice"]; }
		}
		public IUIField FieldDynamicPrice
		{
			get { return this.Fields["DynamicPrice"]; }
		}
		public IUIField FieldDynamicPrice_Code
		{
			get { return this.Fields["DynamicPrice_Code"]; }
		}
		public IUIField FieldDynamicPrice_Name
		{
			get { return this.Fields["DynamicPrice_Name"]; }
		}
		public IUIField FieldDeliveryPickup
		{
			get { return this.Fields["DeliveryPickup"]; }
		}
		public IUIField FieldDeliveryCharges
		{
			get { return this.Fields["DeliveryCharges"]; }
		}
		public IUIField FieldFreePickup
		{
			get { return this.Fields["FreePickup"]; }
		}
		public IUIField FieldFreeDelivery
		{
			get { return this.Fields["FreeDelivery"]; }
		}
		public IUIField FieldTransportationTime
		{
			get { return this.Fields["TransportationTime"]; }
		}
		public IUIField FieldRemark
		{
			get { return this.Fields["Remark"]; }
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
		public IUIField FieldDescribeAddress
		{
			get { return this.Fields["DescribeAddress"]; }
		}
		public IUIField FieldFormatAddress
		{
			get { return this.Fields["FormatAddress"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public LogisticsPricelist_LogisticsPricelistLineDefaultFilterFilter DefaultFilter
		{
			get { return (LogisticsPricelist_LogisticsPricelistLineDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","b4509be9-16d0-428e-bd03-8a7438841e51");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","8c34ae8c-bcd3-46dc-922d-298562d44bab");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f13049f6-45ff-4be0-be8d-3e15bbd907e3");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","72e02253-3f3c-4a66-b577-20dd9c3d6c3a");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","401beafa-38ad-4183-8c25-3d684d259f3e");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","b6f296d7-a93a-45dd-a9b9-0574dc874c12");
			UIModelRuntimeFactory.AddNewUIField(this,"LogisticsPricelist", typeof(Int64), true,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist", "LogisticsPricelist", true,true, false, "",false,(UIFieldType)4,"a52899f8-9d79-4f1d-8fd2-68a89b341ed2","2b3ed87e-e978-493c-8829-58a01418949a");
			UIModelRuntimeFactory.AddNewUIField(this,"LogisticsPricelist_Code", typeof(String), true,"","System.String", "LogisticsPricelist.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b3350e53-f1f4-49fc-8448-e3a5811efb75");
			UIModelRuntimeFactory.AddNewUIField(this,"LogisticsPricelist_Name", typeof(String), true,"","System.String", "LogisticsPricelist.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","06725581-9720-411b-86cc-6c21b1f4f9bb");
			UIModelRuntimeFactory.AddNewUIField(this,"No", typeof(Int32), true,"0","System.Int32", "No", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","b4e92ac5-327c-4996-a4b7-16ebd0ad56e5");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryFactory", typeof(Int32), true,"0","UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum", "DeliveryFactory", true,true, false, "",false,(UIFieldType)2,"0bda0d68-2eee-47d5-ba80-59c869cf4316","5b6b438f-203d-4d38-ad9b-d2e856fbcfe1");
			UIModelRuntimeFactory.AddNewUIField(this,"Address", typeof(Int64), true,"","UFIDA.U9.Base.Location.Location", "Address", true,true, false, "",false,(UIFieldType)4,"9f2e8034-0609-402e-9dc1-edfdecb1d8d6","0a27568d-2d4c-4c12-afa0-9ffab2f701c3");
			UIModelRuntimeFactory.AddNewUIField(this,"Address_Code", typeof(String), false,"","System.String", "Address.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a05fb1f9-883b-4ff1-b6b3-f5d7707f6b23");
			UIModelRuntimeFactory.AddNewUIField(this,"Address_Name", typeof(String), true,"","System.String", "Address.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4ce24be7-27ef-4367-8991-747bde964869");
			UIModelRuntimeFactory.AddNewUIField(this,"PricingMethod", typeof(Int32), true,"0","UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum", "PricingMethod", true,true, false, "",false,(UIFieldType)2,"5208ce26-38bb-4e7f-830b-d38cde9eb7d3","19d05cbf-d8b2-4df7-ae6e-f938dad214ce");
			UIModelRuntimeFactory.AddNewUIField(this,"PricingUom", typeof(Int64), true,"","UFIDA.U9.Base.UOM.UOM", "PricingUom", true,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","7453a7c4-e639-4278-b3f3-acf0353de20a");
			UIModelRuntimeFactory.AddNewUIField(this,"PricingUom_Code", typeof(String), false,"","System.String", "PricingUom.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c8f1dc7b-3889-42c4-9287-39e020ed69ef");
			UIModelRuntimeFactory.AddNewUIField(this,"PricingUom_Name", typeof(String), true,"","System.String", "PricingUom.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f4449d79-e273-45ad-a359-72c2020e76f1");
			UIModelRuntimeFactory.AddNewUIField(this,"UintPrice", typeof(Double), true,"0","System.Double", "UintPrice", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","6beaa2cc-188c-4e48-9f3a-508f6acca744");
			UIModelRuntimeFactory.AddNewUIField(this,"DynamicPrice", typeof(Int64), true,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice", "DynamicPrice", true,true, false, "",false,(UIFieldType)4,"c3e22170-307d-4e27-bd01-2bb26f5e0d6b","2d77cf8b-5cca-4cdc-b1ec-d6dd3ceeef8e");
			UIModelRuntimeFactory.AddNewUIField(this,"DynamicPrice_Code", typeof(String), true,"","System.String", "DynamicPrice.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b9e4a1d4-437a-4b4f-b2a9-828b7f337f3e");
			UIModelRuntimeFactory.AddNewUIField(this,"DynamicPrice_Name", typeof(String), true,"","System.String", "DynamicPrice.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d65a0775-36ee-4f8e-9274-2ffacbeb181d");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryPickup", typeof(Double), true,"0","System.Double", "DeliveryPickup", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","770ef7b0-e196-4695-8c0b-2e4c89e96213");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryCharges", typeof(Double), true,"0","System.Double", "DeliveryCharges", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","531834b5-5240-4c28-bd0e-502966a3be52");
			UIModelRuntimeFactory.AddNewUIField(this,"FreePickup", typeof(Double), true,"0","System.Double", "FreePickup", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","7262dd4b-0325-483a-b233-54ae487db552");
			UIModelRuntimeFactory.AddNewUIField(this,"FreeDelivery", typeof(Double), true,"0","System.Double", "FreeDelivery", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","913f7cc2-f224-4988-8520-0bc37ec71f08");
			UIModelRuntimeFactory.AddNewUIField(this,"TransportationTime", typeof(String), true,"","System.String", "TransportationTime", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fc2c1bcf-6949-4220-8ddd-4abe26a93747");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e2c49acd-a3f1-4434-b654-1b90fe641891");
			UIModelRuntimeFactory.AddNewUIField(this,"Province", typeof(Int64), true,"","UFIDA.U9.Base.Location.Province", "Province", true,true, false, "",false,(UIFieldType)4,"1e9b6162-9f3d-4678-80a9-934f060f50c7","06ae0622-c3ea-4e4a-9555-451046726ba0");
			UIModelRuntimeFactory.AddNewUIField(this,"Province_Code", typeof(String), false,"","System.String", "Province.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7822876c-87f4-41b5-bf4f-b731089242c2");
			UIModelRuntimeFactory.AddNewUIField(this,"Province_Name", typeof(String), true,"","System.String", "Province.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","857bef99-1a4d-408d-94ba-5aa4b189d087");
			UIModelRuntimeFactory.AddNewUIField(this,"City", typeof(Int64), true,"","UFIDA.U9.Base.Location.City", "City", true,true, false, "",false,(UIFieldType)4,"0e5d5fb8-bbf6-4464-9cf0-15e3af3c659b","9b16cb05-ff5e-45b9-8ef4-fdd55d3a4586");
			UIModelRuntimeFactory.AddNewUIField(this,"City_Code", typeof(String), false,"","System.String", "City.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","caeb9fab-ab46-455c-b6cb-42b669ee326e");
			UIModelRuntimeFactory.AddNewUIField(this,"City_Name", typeof(String), true,"","System.String", "City.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ff23de77-7041-48af-a99e-b1133103174d");
			UIModelRuntimeFactory.AddNewUIField(this,"County", typeof(Int64), true,"","UFIDA.U9.Base.Location.County", "County", true,true, false, "",false,(UIFieldType)4,"b969a0b2-3dee-4350-9461-acd80485bdf3","a0e16a4c-6273-49b5-929d-b5456c06d1a3");
			UIModelRuntimeFactory.AddNewUIField(this,"County_Code", typeof(String), false,"","System.String", "County.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f865fcdf-7341-484b-8586-9319a82b1349");
			UIModelRuntimeFactory.AddNewUIField(this,"County_Name", typeof(String), true,"","System.String", "County.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dcf800f0-b28a-46ec-8b3c-bfdde7c31af2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescribeAddress", typeof(String), true,"","System.String", "DescribeAddress", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e64eae19-7b7c-44a3-8bec-c74c99cf3ddf");
			UIModelRuntimeFactory.AddNewUIField(this,"FormatAddress", typeof(String), true,"","System.String", "FormatAddress", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9a0de70c-a761-4f36-b81c-2af6bc569e21");


			this.CurrentFilter = new LogisticsPricelist_LogisticsPricelistLineDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new LogisticsPricelist_LogisticsPricelistLineRecord(builder);
		}
		#endregion

		#region new method
		public new LogisticsPricelist_LogisticsPricelistLineRecord FocusedRecord
		{
			get { return (LogisticsPricelist_LogisticsPricelistLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new LogisticsPricelist_LogisticsPricelistLineRecord AddNewUIRecord()
		{	
			return (LogisticsPricelist_LogisticsPricelistLineRecord)base.AddNewUIRecord();
		}
		public new LogisticsPricelist_LogisticsPricelistLineRecord NewUIRecord()
		{	
			return (LogisticsPricelist_LogisticsPricelistLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class LogisticsPricelist_LogisticsPricelistLineRecord : UIRecord
	{
		#region Constructor
		public LogisticsPricelist_LogisticsPricelistLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private LogisticsPricelist_LogisticsPricelistLineView uiviewLogisticsPricelist_LogisticsPricelistLine
		{
			get { return (LogisticsPricelist_LogisticsPricelistLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new LogisticsPricelist_LogisticsPricelistLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldID);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCreatedOn);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCreatedBy);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldModifiedOn);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldModifiedBy);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldSysVersion);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? LogisticsPricelist
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldLogisticsPricelist] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldLogisticsPricelist);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldLogisticsPricelist] = value;
			}
		}
		
		
		public  String LogisticsPricelist_Code
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldLogisticsPricelist_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldLogisticsPricelist_Code);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldLogisticsPricelist_Code] = value;
			}
		}
		
		
		public  String LogisticsPricelist_Name
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldLogisticsPricelist_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldLogisticsPricelist_Name);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldLogisticsPricelist_Name] = value;
			}
		}
		
		
		public  Int32? No
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldNo] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldNo);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldNo] = value;
			}
		}
		
		
		public  Int32? DeliveryFactory
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDeliveryFactory] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDeliveryFactory);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDeliveryFactory] = value;
			}
		}
		
		
		public  Int64? Address
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldAddress] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldAddress);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldAddress] = value;
			}
		}
		
		
		public  String Address_Code
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldAddress_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldAddress_Code);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldAddress_Code] = value;
			}
		}
		
		
		public  String Address_Name
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldAddress_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldAddress_Name);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldAddress_Name] = value;
			}
		}
		
		
		public  Int32? PricingMethod
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingMethod] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingMethod);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingMethod] = value;
			}
		}
		
		
		public  Int64? PricingUom
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingUom] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingUom);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingUom] = value;
			}
		}
		
		
		public  String PricingUom_Code
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingUom_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingUom_Code);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingUom_Code] = value;
			}
		}
		
		
		public  String PricingUom_Name
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingUom_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingUom_Name);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldPricingUom_Name] = value;
			}
		}
		
		
		public  Double? UintPrice
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldUintPrice] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldUintPrice);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldUintPrice] = value;
			}
		}
		
		
		public  Int64? DynamicPrice
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDynamicPrice] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDynamicPrice);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDynamicPrice] = value;
			}
		}
		
		
		public  String DynamicPrice_Code
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDynamicPrice_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDynamicPrice_Code);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDynamicPrice_Code] = value;
			}
		}
		
		
		public  String DynamicPrice_Name
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDynamicPrice_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDynamicPrice_Name);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDynamicPrice_Name] = value;
			}
		}
		
		
		public  Double? DeliveryPickup
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDeliveryPickup] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDeliveryPickup);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDeliveryPickup] = value;
			}
		}
		
		
		public  Double? DeliveryCharges
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDeliveryCharges] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDeliveryCharges);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDeliveryCharges] = value;
			}
		}
		
		
		public  Double? FreePickup
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldFreePickup] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldFreePickup);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldFreePickup] = value;
			}
		}
		
		
		public  Double? FreeDelivery
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldFreeDelivery] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldFreeDelivery);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldFreeDelivery] = value;
			}
		}
		
		
		public  String TransportationTime
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldTransportationTime] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldTransportationTime);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldTransportationTime] = value;
			}
		}
		
		
		public  String Remark
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldRemark] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldRemark);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldRemark] = value;
			}
		}
		
		
		public  Int64? Province
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldProvince] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldProvince);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldProvince] = value;
			}
		}
		
		
		public  String Province_Code
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldProvince_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldProvince_Code);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldProvince_Code] = value;
			}
		}
		
		
		public  String Province_Name
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldProvince_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldProvince_Name);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldProvince_Name] = value;
			}
		}
		
		
		public  Int64? City
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCity] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCity);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCity] = value;
			}
		}
		
		
		public  String City_Code
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCity_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCity_Code);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCity_Code] = value;
			}
		}
		
		
		public  String City_Name
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCity_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCity_Name);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCity_Name] = value;
			}
		}
		
		
		public  Int64? County
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCounty] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCounty);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCounty] = value;
			}
		}
		
		
		public  String County_Code
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCounty_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCounty_Code);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCounty_Code] = value;
			}
		}
		
		
		public  String County_Name
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCounty_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCounty_Name);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldCounty_Name] = value;
			}
		}
		
		
		public  String DescribeAddress
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDescribeAddress] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDescribeAddress);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldDescribeAddress] = value;
			}
		}
		
		
		public  String FormatAddress
		{
			get{
				//object value = this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldFormatAddress] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldFormatAddress);
			}
			set{
				this[this.uiviewLogisticsPricelist_LogisticsPricelistLine.FieldFormatAddress] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class LogisticsPricelist_LogisticsPricelistLineDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public LogisticsPricelist_LogisticsPricelistLineDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private LogisticsPricelist_LogisticsPricelistLineDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new LogisticsPricelist_LogisticsPricelistLineDefaultFilterFilter();
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



}