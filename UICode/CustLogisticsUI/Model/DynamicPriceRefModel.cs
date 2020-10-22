#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace DynamicPriceRef
{
	[Serializable]
	public partial class DynamicPriceRefModel : UIModel
	{
		#region Constructor
		public DynamicPriceRefModel() : base("DynamicPriceRef")
		{
			InitClass();
			this.SetResourceInfo("4f63643c-eaa3-47d5-814f-a2ab498e13f0");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private DynamicPriceRefModel(bool isInit) : base("DynamicPriceRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new DynamicPriceRefModel(false);
		}
		#endregion
		#region member
		#region views
		private cRefView viewcRef;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public cRefView cRef
		{
			get { return (cRefView)this["cRef"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewcRef = new cRefView(this);
			this.viewcRef.SetResourceInfo("79c6bc1a-d14a-4d4f-8de4-634779fac9ff");
			this.Views.Add(this.viewcRef);			

			
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
	public partial class cRefView : UIView
	{
		#region Constructor
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new cRefView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCode
		{
			get { return this.Fields["Code"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldEffectField
		{
			get { return this.Fields["EffectField"]; }
		}
		public IUIField FieldDynamicPriceType
		{
			get { return this.Fields["DynamicPriceType"]; }
		}
		public IUIField FieldUom_Name
		{
			get { return this.Fields["Uom_Name"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public cRefDefaultFilterFilter DefaultFilter
		{
			get { return (cRefDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","fcc5f621-b901-4339-b9d5-3c0c10762869");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), true,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bbb459c2-5609-49e5-9a51-8f034b636e89");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d8349b7d-ccda-43e5-9a2b-e9555b604395");
			UIModelRuntimeFactory.AddNewUIField(this,"EffectField", typeof(Int32), true,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum", "EffectField", true,true, false, "",false,(UIFieldType)2,"d32f0e83-7ac8-4d78-bc39-f40d7f1c43cc","12cc45de-cf38-46e9-9dc5-28fad091c8ab");
			UIModelRuntimeFactory.AddNewUIField(this,"DynamicPriceType", typeof(Int32), true,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum", "DynamicPriceType", true,true, false, "",false,(UIFieldType)2,"e51e8167-42c9-435a-85d5-00387bbe9495","87b2fa45-8782-4665-8058-be3466a44887");
			UIModelRuntimeFactory.AddNewUIField(this,"Uom_Name", typeof(String), true,"","System.String", "Uom.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ddd5bfbe-be1b-4276-9f26-48fc9f386a31");


			this.CurrentFilter = new cRefDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region new method
		public new cRefRecord FocusedRecord
		{
			get { return (cRefRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new cRefRecord AddNewUIRecord()
		{	
			return (cRefRecord)base.AddNewUIRecord();
		}
		public new cRefRecord NewUIRecord()
		{	
			return (cRefRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class cRefRecord : UIRecord
	{
		#region Constructor
		public cRefRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private cRefView uiviewcRef
		{
			get { return (cRefView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewcRef.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewcRef.FieldID);
			}
			set{
				this[this.uiviewcRef.FieldID] = value;
			}
		}
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCode);
			}
			set{
				this[this.uiviewcRef.FieldCode] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldName);
			}
			set{
				this[this.uiviewcRef.FieldName] = value;
			}
		}
		
		
		public  Int32? EffectField
		{
			get{
				//object value = this[this.uiviewcRef.FieldEffectField] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldEffectField);
			}
			set{
				this[this.uiviewcRef.FieldEffectField] = value;
			}
		}
		
		
		public  Int32? DynamicPriceType
		{
			get{
				//object value = this[this.uiviewcRef.FieldDynamicPriceType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldDynamicPriceType);
			}
			set{
				this[this.uiviewcRef.FieldDynamicPriceType] = value;
			}
		}
		
		
		public  String Uom_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldUom_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldUom_Name);
			}
			set{
				this[this.uiviewcRef.FieldUom_Name] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private cRefDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new cRefDefaultFilterFilter();
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