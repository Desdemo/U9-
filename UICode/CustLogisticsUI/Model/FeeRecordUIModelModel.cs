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
	public partial class FeeRecordUIModelModel : UIModel
	{
		#region Constructor
		public FeeRecordUIModelModel() : base("FeeRecordUIModel")
		{
			InitClass();
			this.SetResourceInfo("e1210e7f-c492-444f-b0ba-82067618e805");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private FeeRecordUIModelModel(bool isInit) : base("FeeRecordUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new FeeRecordUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private FeeRecordView viewFeeRecord;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public FeeRecordView FeeRecord
		{
			get { return (FeeRecordView)this["FeeRecord"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewFeeRecord = new FeeRecordView(this);
			this.viewFeeRecord.SetResourceInfo("ae84bf7b-f07b-4301-a326-1e3fe58d02dc");
			this.Views.Add(this.viewFeeRecord);			

			
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
	public partial class FeeRecordView : UIView
	{
		#region Constructor
		public FeeRecordView(IUIModel model) : base(model,"FeeRecord","UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private FeeRecordView():base(null,"FeeRecord","UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new FeeRecordView();
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
		public IUIField FieldBusinessType
		{
			get { return this.Fields["BusinessType"]; }
		}
		public IUIField FieldSalesman
		{
			get { return this.Fields["Salesman"]; }
		}
		public IUIField FieldCustomerContact
		{
			get { return this.Fields["CustomerContact"]; }
		}
		public IUIField FieldCustomerContact_Name
		{
			get { return this.Fields["CustomerContact_Name"]; }
		}
		public IUIField FieldCustomerContact_Code
		{
			get { return this.Fields["CustomerContact_Code"]; }
		}
		public IUIField FieldContactPhone
		{
			get { return this.Fields["ContactPhone"]; }
		}
		public IUIField FieldShipDate
		{
			get { return this.Fields["ShipDate"]; }
		}
		public IUIField FieldSaleNo
		{
			get { return this.Fields["SaleNo"]; }
		}
		public IUIField FieldSupplier
		{
			get { return this.Fields["Supplier"]; }
		}
		public IUIField FieldSupplier_Code
		{
			get { return this.Fields["Supplier_Code"]; }
		}
		public IUIField FieldSupplier_Name
		{
			get { return this.Fields["Supplier_Name"]; }
		}
		public IUIField FieldQty
		{
			get { return this.Fields["Qty"]; }
		}
		public IUIField FieldProductCategory
		{
			get { return this.Fields["ProductCategory"]; }
		}
		public IUIField FieldProvince
		{
			get { return this.Fields["Province"]; }
		}
		public IUIField FieldLocation
		{
			get { return this.Fields["Location"]; }
		}
		public IUIField FieldLocation_Code
		{
			get { return this.Fields["Location_Code"]; }
		}
		public IUIField FieldLocation_Name
		{
			get { return this.Fields["Location_Name"]; }
		}
		public IUIField FieldIBulk
		{
			get { return this.Fields["IBulk"]; }
		}
		public IUIField FieldWeight
		{
			get { return this.Fields["Weight"]; }
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
		public IUIField FieldStandardShipping
		{
			get { return this.Fields["StandardShipping"]; }
		}
		public IUIField FieldTotalFreight
		{
			get { return this.Fields["TotalFreight"]; }
		}
		public IUIField FieldRealFreight
		{
			get { return this.Fields["RealFreight"]; }
		}
		public IUIField FieldAverageCost
		{
			get { return this.Fields["AverageCost"]; }
		}
		public IUIField FieldUintPrice
		{
			get { return this.Fields["UintPrice"]; }
		}
		public IUIField FieldRemark
		{
			get { return this.Fields["Remark"]; }
		}


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","473dd9d4-8515-4b94-842d-f8eeac880426");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","f5dceaad-fb01-4486-8fb6-a94b805ce47c");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","85dfdc5c-af38-4065-befb-934151314220");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","f784a2e8-7440-4917-afb0-f02adbec5299");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b9e22f71-5dad-4858-bf5a-21593a9e208b");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c898f267-8af9-4338-9237-9f2b1bcbf480");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessType", typeof(Int32), true,"0","UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum", "BusinessType", true,true, false, "",false,(UIFieldType)2,"ebf551e5-ef92-4e68-87e4-867ba965506e","428bb246-e672-4183-9857-7598be5a4d9f");
			UIModelRuntimeFactory.AddNewUIField(this,"Salesman", typeof(String), true,"","System.String", "Salesman", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5ef7643b-b3ec-4751-b783-9f04f59552c2");
			UIModelRuntimeFactory.AddNewUIField(this,"CustomerContact", typeof(Int64), true,"","System.String", "CustomerContact", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb56caf1-dae3-45f4-bf19-0c79c73bbfca");
			UIModelRuntimeFactory.AddNewUIField(this,"CustomerContact_Name", typeof(String), true,"","System.String", "CustomerContact.Name", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c2bfb562-9c14-4073-a353-71c8dbb50ada");
			UIModelRuntimeFactory.AddNewUIField(this,"CustomerContact_Code", typeof(String), false,"","System.String", "CustomerContact.Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2ceea8df-468d-4dd6-ae44-4842c87374d5");
			UIModelRuntimeFactory.AddNewUIField(this,"ContactPhone", typeof(String), true,"","System.String", "ContactPhone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8cabe6e4-b759-4821-b1bd-3efd258e4526");
			UIModelRuntimeFactory.AddNewUIField(this,"ShipDate", typeof(DateTime), true,"","System.Date", "ShipDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","d666b7de-3fa5-4cba-a2c1-77b1c6acf351");
			UIModelRuntimeFactory.AddNewUIField(this,"SaleNo", typeof(String), true,"","System.String", "SaleNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c131ec6c-6fa7-4ca5-b839-045e960ce117");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Supplier.Supplier", "Supplier", true,true, false, "",false,(UIFieldType)4,"ac3510e5-3337-46d4-b41c-46ac40f343e1","cd0c6e05-03ad-4242-b304-8793b291eb8c");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier_Code", typeof(String), false,"","System.String", "Supplier.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","12ee4f44-f6e2-4593-8cc8-43452e612cc2");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier_Name", typeof(String), true,"","System.String", "Supplier.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9afd142b-7562-47d3-877c-9138d21e96d7");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Double), true,"0","System.Decimal", "Qty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","26c451af-dc1f-4a82-8e09-d8283535d36f");
			UIModelRuntimeFactory.AddNewUIField(this,"ProductCategory", typeof(Int32), true,"0","UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum", "ProductCategory", true,true, false, "",false,(UIFieldType)2,"d5868ff5-40c3-4e1d-a7fb-7fe10fa09eea","34425456-9dbd-4fce-b075-a68c86b65cb3");
			UIModelRuntimeFactory.AddNewUIField(this,"Province", typeof(String), true,"","UFIDA.U9.Base.Location.Province", "Province", true,true, false, "",false,(UIFieldType)4,"1e9b6162-9f3d-4678-80a9-934f060f50c7","3874cfee-aaa9-4176-8fcb-381feddf714a");
			UIModelRuntimeFactory.AddNewUIField(this,"Location", typeof(Int64), true,"","System.String", "Location", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c4093b1d-0e93-47a8-b49f-90b2038f17fd");
			UIModelRuntimeFactory.AddNewUIField(this,"Location_Code", typeof(String), false,"","System.String", "Location.Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5c5079ca-8531-47d1-b693-ea7db1a85ad3");
			UIModelRuntimeFactory.AddNewUIField(this,"Location_Name", typeof(String), true,"","System.String", "Location.Name", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7210c04e-f8ee-4991-90c7-60e73b965e04");
			UIModelRuntimeFactory.AddNewUIField(this,"IBulk", typeof(Double), true,"0","System.Decimal", "IBulk", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","a0c6479c-a41e-4894-b8b9-6b674ccc99bd");
			UIModelRuntimeFactory.AddNewUIField(this,"Weight", typeof(Double), true,"0","System.Decimal", "Weight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","ae7b15a6-48b2-4acd-9575-1169cf988fee");
			UIModelRuntimeFactory.AddNewUIField(this,"BulkUom", typeof(Int64), true,"","UFIDA.U9.Base.UOM.UOM", "BulkUom", true,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","1701ff0d-7ace-4170-a9dd-a29467604954");
			UIModelRuntimeFactory.AddNewUIField(this,"BulkUom_Code", typeof(String), false,"","System.String", "BulkUom.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","879f9d9c-d4f6-472c-83df-065e1ce4d826");
			UIModelRuntimeFactory.AddNewUIField(this,"BulkUom_Name", typeof(String), true,"","System.String", "BulkUom.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5ec3dc67-d2e7-4d25-aae4-a2d84d3e6543");
			UIModelRuntimeFactory.AddNewUIField(this,"WeightUom", typeof(Int64), true,"","UFIDA.U9.Base.UOM.UOM", "WeightUom", true,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","5c797198-be1a-4aa8-b324-4bb9803c88bc");
			UIModelRuntimeFactory.AddNewUIField(this,"WeightUom_Code", typeof(String), false,"","System.String", "WeightUom.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d00f390a-d211-4289-9b4c-c504d7025f02");
			UIModelRuntimeFactory.AddNewUIField(this,"WeightUom_Name", typeof(String), true,"","System.String", "WeightUom.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a44c5ad7-87e7-42a5-9e6f-969d9edbcaa0");
			UIModelRuntimeFactory.AddNewUIField(this,"PickupFee", typeof(Double), true,"0","System.Decimal", "PickupFee", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","e791d7e1-67f8-4fe2-a3a4-bdf9d55393e6");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryFee", typeof(Double), true,"0","System.Decimal", "DeliveryFee", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","f46d429d-6103-4414-b8c9-d9290bd24bfd");
			UIModelRuntimeFactory.AddNewUIField(this,"DischargeFee", typeof(Double), true,"0","System.Decimal", "DischargeFee", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","a8cf7954-2adb-49f0-883d-8b641ebf8843");
			UIModelRuntimeFactory.AddNewUIField(this,"OtherFee", typeof(Double), true,"0","System.Decimal", "OtherFee", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","4d9bcbf7-fbf0-4943-9539-b740d71796dc");
			UIModelRuntimeFactory.AddNewUIField(this,"StandardShipping", typeof(Double), true,"0","System.Decimal", "StandardShipping", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","a306926a-a138-4558-a431-332cf816ba33");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalFreight", typeof(Double), true,"0","System.Decimal", "TotalFreight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","48cd9974-7351-4034-87f2-38f2ae42e15a");
			UIModelRuntimeFactory.AddNewUIField(this,"RealFreight", typeof(Double), true,"0","System.Decimal", "RealFreight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","185f904b-7214-4369-a266-8fb2fb1b8dd3");
			UIModelRuntimeFactory.AddNewUIField(this,"AverageCost", typeof(Double), true,"0","System.Decimal", "AverageCost", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","a2f1cd52-d7b3-4173-ab71-b72413cc7a50");
			UIModelRuntimeFactory.AddNewUIField(this,"UintPrice", typeof(Double), true,"0","System.Decimal", "UintPrice", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","ff0fc881-5701-4496-a5d9-ae9394800460");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","da0db379-06b2-47ec-80a2-1678c53771a5");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new FeeRecordRecord(builder);
		}
		#endregion

		#region new method
		public new FeeRecordRecord FocusedRecord
		{
			get { return (FeeRecordRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new FeeRecordRecord AddNewUIRecord()
		{	
			return (FeeRecordRecord)base.AddNewUIRecord();
		}
		public new FeeRecordRecord NewUIRecord()
		{	
			return (FeeRecordRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class FeeRecordRecord : UIRecord
	{
		#region Constructor
		public FeeRecordRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private FeeRecordView uiviewFeeRecord
		{
			get { return (FeeRecordView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new FeeRecordRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewFeeRecord.FieldID);
			}
			set{
				this[this.uiviewFeeRecord.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewFeeRecord.FieldCreatedOn);
			}
			set{
				this[this.uiviewFeeRecord.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldCreatedBy);
			}
			set{
				this[this.uiviewFeeRecord.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewFeeRecord.FieldModifiedOn);
			}
			set{
				this[this.uiviewFeeRecord.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldModifiedBy);
			}
			set{
				this[this.uiviewFeeRecord.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewFeeRecord.FieldSysVersion);
			}
			set{
				this[this.uiviewFeeRecord.FieldSysVersion] = value;
			}
		}
		
		
		public  Int32? BusinessType
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldBusinessType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewFeeRecord.FieldBusinessType);
			}
			set{
				this[this.uiviewFeeRecord.FieldBusinessType] = value;
			}
		}
		
		
		public  String Salesman
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldSalesman] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldSalesman);
			}
			set{
				this[this.uiviewFeeRecord.FieldSalesman] = value;
			}
		}
		
		
		public  Int64? CustomerContact
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldCustomerContact] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewFeeRecord.FieldCustomerContact);
			}
			set{
				this[this.uiviewFeeRecord.FieldCustomerContact] = value;
			}
		}
		
		
		public  String CustomerContact_Name
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldCustomerContact_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldCustomerContact_Name);
			}
			set{
				this[this.uiviewFeeRecord.FieldCustomerContact_Name] = value;
			}
		}
		
		
		public  String CustomerContact_Code
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldCustomerContact_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldCustomerContact_Code);
			}
			set{
				this[this.uiviewFeeRecord.FieldCustomerContact_Code] = value;
			}
		}
		
		
		public  String ContactPhone
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldContactPhone] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldContactPhone);
			}
			set{
				this[this.uiviewFeeRecord.FieldContactPhone] = value;
			}
		}
		
		
		public  DateTime? ShipDate
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldShipDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewFeeRecord.FieldShipDate);
			}
			set{
				this[this.uiviewFeeRecord.FieldShipDate] = value;
			}
		}
		
		
		public  String SaleNo
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldSaleNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldSaleNo);
			}
			set{
				this[this.uiviewFeeRecord.FieldSaleNo] = value;
			}
		}
		
		
		public  Int64? Supplier
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldSupplier] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewFeeRecord.FieldSupplier);
			}
			set{
				this[this.uiviewFeeRecord.FieldSupplier] = value;
			}
		}
		
		
		public  String Supplier_Code
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldSupplier_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldSupplier_Code);
			}
			set{
				this[this.uiviewFeeRecord.FieldSupplier_Code] = value;
			}
		}
		
		
		public  String Supplier_Name
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldSupplier_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldSupplier_Name);
			}
			set{
				this[this.uiviewFeeRecord.FieldSupplier_Name] = value;
			}
		}
		
		
		public  Double? Qty
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldQty] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldQty);
			}
			set{
				this[this.uiviewFeeRecord.FieldQty] = value;
			}
		}
		
		
		public  Int32? ProductCategory
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldProductCategory] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewFeeRecord.FieldProductCategory);
			}
			set{
				this[this.uiviewFeeRecord.FieldProductCategory] = value;
			}
		}
		
		
		public  String Province
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldProvince] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldProvince);
			}
			set{
				this[this.uiviewFeeRecord.FieldProvince] = value;
			}
		}
		
		
		public  Int64? Location
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldLocation] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewFeeRecord.FieldLocation);
			}
			set{
				this[this.uiviewFeeRecord.FieldLocation] = value;
			}
		}
		
		
		public  String Location_Code
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldLocation_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldLocation_Code);
			}
			set{
				this[this.uiviewFeeRecord.FieldLocation_Code] = value;
			}
		}
		
		
		public  String Location_Name
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldLocation_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldLocation_Name);
			}
			set{
				this[this.uiviewFeeRecord.FieldLocation_Name] = value;
			}
		}
		
		
		public  Double? IBulk
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldIBulk] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldIBulk);
			}
			set{
				this[this.uiviewFeeRecord.FieldIBulk] = value;
			}
		}
		
		
		public  Double? Weight
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldWeight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldWeight);
			}
			set{
				this[this.uiviewFeeRecord.FieldWeight] = value;
			}
		}
		
		
		public  Int64? BulkUom
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldBulkUom] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewFeeRecord.FieldBulkUom);
			}
			set{
				this[this.uiviewFeeRecord.FieldBulkUom] = value;
			}
		}
		
		
		public  String BulkUom_Code
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldBulkUom_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldBulkUom_Code);
			}
			set{
				this[this.uiviewFeeRecord.FieldBulkUom_Code] = value;
			}
		}
		
		
		public  String BulkUom_Name
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldBulkUom_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldBulkUom_Name);
			}
			set{
				this[this.uiviewFeeRecord.FieldBulkUom_Name] = value;
			}
		}
		
		
		public  Int64? WeightUom
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldWeightUom] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewFeeRecord.FieldWeightUom);
			}
			set{
				this[this.uiviewFeeRecord.FieldWeightUom] = value;
			}
		}
		
		
		public  String WeightUom_Code
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldWeightUom_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldWeightUom_Code);
			}
			set{
				this[this.uiviewFeeRecord.FieldWeightUom_Code] = value;
			}
		}
		
		
		public  String WeightUom_Name
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldWeightUom_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldWeightUom_Name);
			}
			set{
				this[this.uiviewFeeRecord.FieldWeightUom_Name] = value;
			}
		}
		
		
		public  Double? PickupFee
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldPickupFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldPickupFee);
			}
			set{
				this[this.uiviewFeeRecord.FieldPickupFee] = value;
			}
		}
		
		
		public  Double? DeliveryFee
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldDeliveryFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldDeliveryFee);
			}
			set{
				this[this.uiviewFeeRecord.FieldDeliveryFee] = value;
			}
		}
		
		
		public  Double? DischargeFee
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldDischargeFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldDischargeFee);
			}
			set{
				this[this.uiviewFeeRecord.FieldDischargeFee] = value;
			}
		}
		
		
		public  Double? OtherFee
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldOtherFee] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldOtherFee);
			}
			set{
				this[this.uiviewFeeRecord.FieldOtherFee] = value;
			}
		}
		
		
		public  Double? StandardShipping
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldStandardShipping] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldStandardShipping);
			}
			set{
				this[this.uiviewFeeRecord.FieldStandardShipping] = value;
			}
		}
		
		
		public  Double? TotalFreight
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldTotalFreight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldTotalFreight);
			}
			set{
				this[this.uiviewFeeRecord.FieldTotalFreight] = value;
			}
		}
		
		
		public  Double? RealFreight
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldRealFreight] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldRealFreight);
			}
			set{
				this[this.uiviewFeeRecord.FieldRealFreight] = value;
			}
		}
		
		
		public  Double? AverageCost
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldAverageCost] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldAverageCost);
			}
			set{
				this[this.uiviewFeeRecord.FieldAverageCost] = value;
			}
		}
		
		
		public  Double? UintPrice
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldUintPrice] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewFeeRecord.FieldUintPrice);
			}
			set{
				this[this.uiviewFeeRecord.FieldUintPrice] = value;
			}
		}
		
		
		public  String Remark
		{
			get{
				//object value = this[this.uiviewFeeRecord.FieldRemark] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFeeRecord.FieldRemark);
			}
			set{
				this[this.uiviewFeeRecord.FieldRemark] = value;
			}
		}
		#endregion
	}
	



}