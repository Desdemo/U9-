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
	public partial class CostsharingUIModelModel : UIModel
	{
		#region Constructor
		public CostsharingUIModelModel() : base("CostsharingUIModel")
		{
			InitClass();
			this.SetResourceInfo("47e35085-f40d-4f9e-9311-8054ede3ac28");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private CostsharingUIModelModel(bool isInit) : base("CostsharingUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new CostsharingUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private CostsharingViewView viewCostsharingView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public CostsharingViewView CostsharingView
		{
			get { return (CostsharingViewView)this["CostsharingView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewCostsharingView = new CostsharingViewView(this);
			this.viewCostsharingView.SetResourceInfo("c7c64f7d-cb31-489b-8194-81f6b05c0825");
			this.Views.Add(this.viewCostsharingView);			

			
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
	public partial class CostsharingViewView : UIView
	{
		#region Constructor
		public CostsharingViewView(IUIModel model) : base(model,"CostsharingView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private CostsharingViewView():base(null,"CostsharingView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new CostsharingViewView();
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
		public IUIField FieldDocNo
		{
			get { return this.Fields["DocNo"]; }
		}
		public IUIField FieldDocID
		{
			get { return this.Fields["DocID"]; }
		}
		public IUIField FieldDocType
		{
			get { return this.Fields["DocType"]; }
		}
		public IUIField FieldAmount
		{
			get { return this.Fields["Amount"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public CostsharingViewDefaultFilterFilter DefaultFilter
		{
			get { return (CostsharingViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","1137925b-a57f-4a60-b64d-c88de0513f5d");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","edf4f8e9-dfb7-478f-8627-5e0accbcab2e");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1597756b-02f1-4d24-abfc-7c01de0b8cc9");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","6443fb19-b062-42aa-99ee-797047a56c40");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8fcd4ca6-8220-4b0c-b872-661798084b3d");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","e8bec691-8a76-4345-a3fb-b2618f412112");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c1a2064d-e021-463b-9d2f-4fe58384b00d");
			UIModelRuntimeFactory.AddNewUIField(this,"DocID", typeof(Int64), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7e4b4e94-3f42-46fe-a971-c9103ebb3659");
			UIModelRuntimeFactory.AddNewUIField(this,"DocType", typeof(Int32), false,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum", "", false,false, false, "",false,(UIFieldType)2,"453b1008-de2b-4c62-b193-5670d392d30b","f82bd9e6-09f2-4399-b1b6-60ab6c41a42a");
			UIModelRuntimeFactory.AddNewUIField(this,"Amount", typeof(Double), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0a93518b-7462-408c-81bd-02233d90218c");


			this.CurrentFilter = new CostsharingViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new CostsharingViewRecord(builder);
		}
		#endregion

		#region new method
		public new CostsharingViewRecord FocusedRecord
		{
			get { return (CostsharingViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new CostsharingViewRecord AddNewUIRecord()
		{	
			return (CostsharingViewRecord)base.AddNewUIRecord();
		}
		public new CostsharingViewRecord NewUIRecord()
		{	
			return (CostsharingViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class CostsharingViewRecord : UIRecord
	{
		#region Constructor
		public CostsharingViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private CostsharingViewView uiviewCostsharingView
		{
			get { return (CostsharingViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new CostsharingViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCostsharingView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCostsharingView.FieldID);
			}
			set{
				this[this.uiviewCostsharingView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewCostsharingView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewCostsharingView.FieldCreatedOn);
			}
			set{
				this[this.uiviewCostsharingView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCostsharingView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCostsharingView.FieldCreatedBy);
			}
			set{
				this[this.uiviewCostsharingView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewCostsharingView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewCostsharingView.FieldModifiedOn);
			}
			set{
				this[this.uiviewCostsharingView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCostsharingView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCostsharingView.FieldModifiedBy);
			}
			set{
				this[this.uiviewCostsharingView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewCostsharingView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCostsharingView.FieldSysVersion);
			}
			set{
				this[this.uiviewCostsharingView.FieldSysVersion] = value;
			}
		}
		
		
		public  String DocNo
		{
			get{
				//object value = this[this.uiviewCostsharingView.FieldDocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCostsharingView.FieldDocNo);
			}
			set{
				this[this.uiviewCostsharingView.FieldDocNo] = value;
			}
		}
		
		
		public  Int64 DocID
		{
			get{
				//object value = this[this.uiviewCostsharingView.FieldDocID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCostsharingView.FieldDocID);
			}
			set{
				this[this.uiviewCostsharingView.FieldDocID] = value;
			}
		}
		
		
		public  Int32 DocType
		{
			get{
				//object value = this[this.uiviewCostsharingView.FieldDocType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewCostsharingView.FieldDocType);
			}
			set{
				this[this.uiviewCostsharingView.FieldDocType] = value;
			}
		}
		
		
		public  Double Amount
		{
			get{
				//object value = this[this.uiviewCostsharingView.FieldAmount] ;
				//return (Double)value;
				return GetValue<Double>(this.uiviewCostsharingView.FieldAmount);
			}
			set{
				this[this.uiviewCostsharingView.FieldAmount] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class CostsharingViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public CostsharingViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private CostsharingViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new CostsharingViewDefaultFilterFilter();
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