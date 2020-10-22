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
	public partial class DynamicPriceUIModelModel : UIModel
	{
		#region Constructor
		public DynamicPriceUIModelModel() : base("DynamicPriceUIModel")
		{
			InitClass();
			this.SetResourceInfo("008d6609-da2d-4cf9-9db6-1e757b537a1e");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private DynamicPriceUIModelModel(bool isInit) : base("DynamicPriceUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new DynamicPriceUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private DynamicPriceView viewDynamicPrice;			
		private DynamicPrice_DynamicPriceLineView viewDynamicPrice_DynamicPriceLine;			
		#endregion
		
		#region links
		//private IUILink linkDynamicPrice__DynamicPrice_DynamicPriceLine;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public DynamicPriceView DynamicPrice
		{
			get { return (DynamicPriceView)this["DynamicPrice"]; }
		}
		public DynamicPrice_DynamicPriceLineView DynamicPrice_DynamicPriceLine
		{
			get { return (DynamicPrice_DynamicPriceLineView)this["DynamicPrice_DynamicPriceLine"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewDynamicPrice = new DynamicPriceView(this);
			this.viewDynamicPrice.SetResourceInfo("cdffc96d-e3f4-4d23-b06d-286427560fae");
			this.Views.Add(this.viewDynamicPrice);			
			this.viewDynamicPrice_DynamicPriceLine = new DynamicPrice_DynamicPriceLineView(this);
			this.viewDynamicPrice_DynamicPriceLine.SetResourceInfo("a88c9afb-669b-4383-8ca5-b81ea5f95fc9");
			this.Views.Add(this.viewDynamicPrice_DynamicPriceLine);			

			//this.linkDynamicPrice__DynamicPrice_DynamicPriceLine
			{
			IUILink link = new UILink("DynamicPrice__DynamicPrice_DynamicPriceLine",this,this.viewDynamicPrice.FieldID,this.viewDynamicPrice_DynamicPriceLine.FieldDynamicPrice,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"DynamicPriceLine");
			this.Links.Add(link);
			}
			//this.linkDynamicPrice__DynamicPrice_DynamicPriceLine.ChildKeyConstraint.UpdateRule = Rule.Cascade;
			//this.linkDynamicPrice__DynamicPrice_DynamicPriceLine.ChildKeyConstraint.DeleteRule = Rule.Cascade;
			//this.linkDynamicPrice__DynamicPrice_DynamicPriceLine.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
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
	public partial class DynamicPriceView : UIView
	{
		#region Constructor
		public DynamicPriceView(IUIModel model) : base(model,"DynamicPrice","UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private DynamicPriceView():base(null,"DynamicPrice","UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new DynamicPriceView();
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
		public IUIField FieldUom
		{
			get { return this.Fields["Uom"]; }
		}
		public IUIField FieldUom_Code
		{
			get { return this.Fields["Uom_Code"]; }
		}
		public IUIField FieldUom_Name
		{
			get { return this.Fields["Uom_Name"]; }
		}
		public IUIField FieldRemark
		{
			get { return this.Fields["Remark"]; }
		}
		public IUIField FieldDynamicPriceType
		{
			get { return this.Fields["DynamicPriceType"]; }
		}
		public IUIField FieldEffectField
		{
			get { return this.Fields["EffectField"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public DynamicPriceDefaultFilterFilter DefaultFilter
		{
			get { return (DynamicPriceDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","eda15da5-a6ad-43d7-9bd7-9d9fd5644822");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","ef615faa-075f-49d2-82c4-694940014dc3");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6278a493-258e-4bbd-b84a-d04409ae738b");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","582b0bf5-3c4e-4674-bcae-5968106f4639");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","41fd70b6-a86c-4b0b-baf7-0dc80bb5f5c8");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","546cf9a8-676e-41f6-b1c8-3cba5086cf03");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), true,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","facaee8b-0721-4f61-97f0-9b7c3092f326");
			UIModelRuntimeFactory.AddNewUIField(this,"Uom", typeof(Int64), true,"","UFIDA.U9.Base.UOM.UOM", "Uom", true,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","d91c4e64-0ebb-4c47-9c2f-6d29c85947b9");
			UIModelRuntimeFactory.AddNewUIField(this,"Uom_Code", typeof(String), false,"","System.String", "Uom.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","72b2b9d8-cfad-4310-bfb1-5d15c3d58835");
			UIModelRuntimeFactory.AddNewUIField(this,"Uom_Name", typeof(String), true,"","System.String", "Uom.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","05f7a182-eaf6-4a29-8ea8-663377871494");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3de477fc-905f-486f-b06b-56985d180484");
			UIModelRuntimeFactory.AddNewUIField(this,"DynamicPriceType", typeof(Int32), true,"0","UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum", "DynamicPriceType", true,true, false, "",false,(UIFieldType)2,"e51e8167-42c9-435a-85d5-00387bbe9495","1a48ef29-5e20-496a-9b0d-73f0a7188e95");
			UIModelRuntimeFactory.AddNewUIField(this,"EffectField", typeof(Int32), true,"0","UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum", "EffectField", true,true, false, "",false,(UIFieldType)2,"d32f0e83-7ac8-4d78-bc39-f40d7f1c43cc","532bd440-db16-4f8b-aaf9-43020bd3bb0c");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","72cb8b5a-3782-4a3a-a858-9f255e5028f0");


			this.CurrentFilter = new DynamicPriceDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new DynamicPriceRecord(builder);
		}
		#endregion

		#region new method
		public new DynamicPriceRecord FocusedRecord
		{
			get { return (DynamicPriceRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new DynamicPriceRecord AddNewUIRecord()
		{	
			return (DynamicPriceRecord)base.AddNewUIRecord();
		}
		public new DynamicPriceRecord NewUIRecord()
		{	
			return (DynamicPriceRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class DynamicPriceRecord : UIRecord
	{
		#region Constructor
		public DynamicPriceRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private DynamicPriceView uiviewDynamicPrice
		{
			get { return (DynamicPriceView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new DynamicPriceRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDynamicPrice.FieldID);
			}
			set{
				this[this.uiviewDynamicPrice.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDynamicPrice.FieldCreatedOn);
			}
			set{
				this[this.uiviewDynamicPrice.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDynamicPrice.FieldCreatedBy);
			}
			set{
				this[this.uiviewDynamicPrice.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDynamicPrice.FieldModifiedOn);
			}
			set{
				this[this.uiviewDynamicPrice.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDynamicPrice.FieldModifiedBy);
			}
			set{
				this[this.uiviewDynamicPrice.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDynamicPrice.FieldSysVersion);
			}
			set{
				this[this.uiviewDynamicPrice.FieldSysVersion] = value;
			}
		}
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDynamicPrice.FieldCode);
			}
			set{
				this[this.uiviewDynamicPrice.FieldCode] = value;
			}
		}
		
		
		public  Int64? Uom
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldUom] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDynamicPrice.FieldUom);
			}
			set{
				this[this.uiviewDynamicPrice.FieldUom] = value;
			}
		}
		
		
		public  String Uom_Code
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldUom_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDynamicPrice.FieldUom_Code);
			}
			set{
				this[this.uiviewDynamicPrice.FieldUom_Code] = value;
			}
		}
		
		
		public  String Uom_Name
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldUom_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDynamicPrice.FieldUom_Name);
			}
			set{
				this[this.uiviewDynamicPrice.FieldUom_Name] = value;
			}
		}
		
		
		public  String Remark
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldRemark] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDynamicPrice.FieldRemark);
			}
			set{
				this[this.uiviewDynamicPrice.FieldRemark] = value;
			}
		}
		
		
		public  Int32? DynamicPriceType
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldDynamicPriceType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDynamicPrice.FieldDynamicPriceType);
			}
			set{
				this[this.uiviewDynamicPrice.FieldDynamicPriceType] = value;
			}
		}
		
		
		public  Int32? EffectField
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldEffectField] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDynamicPrice.FieldEffectField);
			}
			set{
				this[this.uiviewDynamicPrice.FieldEffectField] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewDynamicPrice.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDynamicPrice.FieldName);
			}
			set{
				this[this.uiviewDynamicPrice.FieldName] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class DynamicPriceDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public DynamicPriceDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private DynamicPriceDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new DynamicPriceDefaultFilterFilter();
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
	public partial class DynamicPrice_DynamicPriceLineView : UIView
	{
		#region Constructor
		public DynamicPrice_DynamicPriceLineView(IUIModel model) : base(model,"DynamicPrice_DynamicPriceLine","UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private DynamicPrice_DynamicPriceLineView():base(null,"DynamicPrice_DynamicPriceLine","UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new DynamicPrice_DynamicPriceLineView();
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
		public IUIField FieldDynamicPrice
		{
			get { return this.Fields["DynamicPrice"]; }
		}
		public IUIField FieldDynamicPrice_Code
		{
			get { return this.Fields["DynamicPrice_Code"]; }
		}
		public IUIField FieldNo
		{
			get { return this.Fields["No"]; }
		}
		public IUIField FieldUnitPrice
		{
			get { return this.Fields["UnitPrice"]; }
		}
		public IUIField FieldStart
		{
			get { return this.Fields["Start"]; }
		}
		public IUIField FieldCutoff
		{
			get { return this.Fields["Cutoff"]; }
		}
		public IUIField FieldTotal
		{
			get { return this.Fields["Total"]; }
		}
		public IUIField FieldRemark
		{
			get { return this.Fields["Remark"]; }
		}


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","8c7473ef-c136-4435-a242-75e44d067f74");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4fba2708-ceaf-4b53-bcd1-74f6a2230f7c");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2c4b0d8a-b5b4-42cb-8a34-3657da9d4842");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","6bf04f1b-feed-49ca-b25f-aee2854b5d4f");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9fc9bba9-b350-4b5f-9517-1e1a32dfee87");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","5fd96ae1-42c9-4efc-babd-6fd08f437c26");
			UIModelRuntimeFactory.AddNewUIField(this,"DynamicPrice", typeof(Int64), true,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice", "DynamicPrice", true,true, false, "",false,(UIFieldType)4,"c3e22170-307d-4e27-bd01-2bb26f5e0d6b","1510ba74-6f75-4aad-93c0-dbb7d7b5ddf7");
			UIModelRuntimeFactory.AddNewUIField(this,"DynamicPrice_Code", typeof(String), true,"","System.String", "DynamicPrice.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","134c0c3b-d764-4854-91c3-25fd2c7e1ef1");
			UIModelRuntimeFactory.AddNewUIField(this,"No", typeof(Int32), true,"0","System.Int32", "No", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","69eba915-8041-4927-a2ab-6baadc60dd99");
			UIModelRuntimeFactory.AddNewUIField(this,"UnitPrice", typeof(Double), true,"0","System.Double", "UnitPrice", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","6106a393-4b9f-4afa-aa91-5d5e60491dfa");
			UIModelRuntimeFactory.AddNewUIField(this,"Start", typeof(Double), true,"0","System.Double", "Start", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","60174dba-46fc-4521-900e-f263e32a8840");
			UIModelRuntimeFactory.AddNewUIField(this,"Cutoff", typeof(Double), true,"0","System.Double", "Cutoff", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","7dd3fbe6-ab7d-428a-b8a2-393e3dde3f1d");
			UIModelRuntimeFactory.AddNewUIField(this,"Total", typeof(Double), true,"0","System.Double", "Total", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","565e94a0-d014-43e2-a41e-31698bb23aaa");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","12690aaa-eab8-4ba1-89ef-f543b74e389d");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new DynamicPrice_DynamicPriceLineRecord(builder);
		}
		#endregion

		#region new method
		public new DynamicPrice_DynamicPriceLineRecord FocusedRecord
		{
			get { return (DynamicPrice_DynamicPriceLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new DynamicPrice_DynamicPriceLineRecord AddNewUIRecord()
		{	
			return (DynamicPrice_DynamicPriceLineRecord)base.AddNewUIRecord();
		}
		public new DynamicPrice_DynamicPriceLineRecord NewUIRecord()
		{	
			return (DynamicPrice_DynamicPriceLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class DynamicPrice_DynamicPriceLineRecord : UIRecord
	{
		#region Constructor
		public DynamicPrice_DynamicPriceLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private DynamicPrice_DynamicPriceLineView uiviewDynamicPrice_DynamicPriceLine
		{
			get { return (DynamicPrice_DynamicPriceLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new DynamicPrice_DynamicPriceLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDynamicPrice_DynamicPriceLine.FieldID);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDynamicPrice_DynamicPriceLine.FieldCreatedOn);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDynamicPrice_DynamicPriceLine.FieldCreatedBy);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDynamicPrice_DynamicPriceLine.FieldModifiedOn);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDynamicPrice_DynamicPriceLine.FieldModifiedBy);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDynamicPrice_DynamicPriceLine.FieldSysVersion);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? DynamicPrice
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldDynamicPrice] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDynamicPrice_DynamicPriceLine.FieldDynamicPrice);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldDynamicPrice] = value;
			}
		}
		
		
		public  String DynamicPrice_Code
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldDynamicPrice_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDynamicPrice_DynamicPriceLine.FieldDynamicPrice_Code);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldDynamicPrice_Code] = value;
			}
		}
		
		
		public  Int32? No
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldNo] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDynamicPrice_DynamicPriceLine.FieldNo);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldNo] = value;
			}
		}
		
		
		public  Double? UnitPrice
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldUnitPrice] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewDynamicPrice_DynamicPriceLine.FieldUnitPrice);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldUnitPrice] = value;
			}
		}
		
		
		public  Double? Start
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldStart] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewDynamicPrice_DynamicPriceLine.FieldStart);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldStart] = value;
			}
		}
		
		
		public  Double? Cutoff
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldCutoff] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewDynamicPrice_DynamicPriceLine.FieldCutoff);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldCutoff] = value;
			}
		}
		
		
		public  Double? Total
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldTotal] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewDynamicPrice_DynamicPriceLine.FieldTotal);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldTotal] = value;
			}
		}
		
		
		public  String Remark
		{
			get{
				//object value = this[this.uiviewDynamicPrice_DynamicPriceLine.FieldRemark] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDynamicPrice_DynamicPriceLine.FieldRemark);
			}
			set{
				this[this.uiviewDynamicPrice_DynamicPriceLine.FieldRemark] = value;
			}
		}
		#endregion
	}
	



}