#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace FindLogisticsLineRef
{
	[Serializable]
	public partial class FindLogisticsLineRefModel : UIModel
	{
		#region Constructor
		public FindLogisticsLineRefModel() : base("FindLogisticsLineRef")
		{
			InitClass();
			this.SetResourceInfo("88867236-ed09-4ff4-b1a1-ac0225470b39");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private FindLogisticsLineRefModel(bool isInit) : base("FindLogisticsLineRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new FindLogisticsLineRefModel(false);
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
			this.viewcRef.SetResourceInfo("ae063091-50b1-4458-ac35-24274aef627b");
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine", true)
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
		public IUIField FieldDeliveryFactory
		{
			get { return this.Fields["DeliveryFactory"]; }
		}
		public IUIField FieldAddress_FormatAddress
		{
			get { return this.Fields["Address_FormatAddress"]; }
		}
		public IUIField FieldPricingMethod
		{
			get { return this.Fields["PricingMethod"]; }
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
		public IUIField FieldAddress_ID
		{
			get { return this.Fields["Address_ID"]; }
		}
		public IUIField FieldAddress_Code
		{
			get { return this.Fields["Address_Code"]; }
		}
		public IUIField FieldAddress_Name
		{
			get { return this.Fields["Address_Name"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a53c12ca-b293-4dfc-9549-afb9567325a4");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryFactory", typeof(Int32), true,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum", "DeliveryFactory", true,true, false, "",false,(UIFieldType)2,"0bda0d68-2eee-47d5-ba80-59c869cf4316","680d727b-ffb4-4583-a11b-06cc4527b82b");
			UIModelRuntimeFactory.AddNewUIField(this,"Address_FormatAddress", typeof(String), true,"","System.String", "Address.FormatAddress", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f1b6c684-fc7a-437a-af6d-d17128bcc382");
			UIModelRuntimeFactory.AddNewUIField(this,"PricingMethod", typeof(Int32), true,"","UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum", "PricingMethod", true,true, false, "",false,(UIFieldType)2,"5208ce26-38bb-4e7f-830b-d38cde9eb7d3","4c1c31e7-c50f-4004-9883-36bd57fe4111");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryPickup", typeof(Double), true,"","System.Double", "DeliveryPickup", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","0c601493-0946-4763-addb-63060906cacd");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryCharges", typeof(Double), true,"","System.Double", "DeliveryCharges", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","6d33913d-0d57-4b4e-a106-889641773cb8");
			UIModelRuntimeFactory.AddNewUIField(this,"FreePickup", typeof(Double), true,"","System.Double", "FreePickup", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","b232e9a5-c30a-4c5d-914a-e934e19639bd");
			UIModelRuntimeFactory.AddNewUIField(this,"FreeDelivery", typeof(Double), true,"","System.Double", "FreeDelivery", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","f51abeaa-81aa-4c63-a8ef-136602655033");
			UIModelRuntimeFactory.AddNewUIField(this,"Address_ID", typeof(Int64), false,"","System.Int64", "Address.ID", false,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","7d53625e-78c1-45e1-a563-914b13ad8f60");
			UIModelRuntimeFactory.AddNewUIField(this,"Address_Code", typeof(String), false,"","System.String", "Address.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c18da76f-a209-4a2e-9e23-5228b42b61a0");
			UIModelRuntimeFactory.AddNewUIField(this,"Address_Name", typeof(String), true,"","System.String", "Address.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","acb21fd0-68dc-484e-abaa-7701f23bcf02");


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
		
		
		public  Int32? DeliveryFactory
		{
			get{
				//object value = this[this.uiviewcRef.FieldDeliveryFactory] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldDeliveryFactory);
			}
			set{
				this[this.uiviewcRef.FieldDeliveryFactory] = value;
			}
		}
		
		
		public  String Address_FormatAddress
		{
			get{
				//object value = this[this.uiviewcRef.FieldAddress_FormatAddress] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldAddress_FormatAddress);
			}
			set{
				this[this.uiviewcRef.FieldAddress_FormatAddress] = value;
			}
		}
		
		
		public  Int32? PricingMethod
		{
			get{
				//object value = this[this.uiviewcRef.FieldPricingMethod] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldPricingMethod);
			}
			set{
				this[this.uiviewcRef.FieldPricingMethod] = value;
			}
		}
		
		
		public  Double? DeliveryPickup
		{
			get{
				//object value = this[this.uiviewcRef.FieldDeliveryPickup] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewcRef.FieldDeliveryPickup);
			}
			set{
				this[this.uiviewcRef.FieldDeliveryPickup] = value;
			}
		}
		
		
		public  Double? DeliveryCharges
		{
			get{
				//object value = this[this.uiviewcRef.FieldDeliveryCharges] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewcRef.FieldDeliveryCharges);
			}
			set{
				this[this.uiviewcRef.FieldDeliveryCharges] = value;
			}
		}
		
		
		public  Double? FreePickup
		{
			get{
				//object value = this[this.uiviewcRef.FieldFreePickup] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewcRef.FieldFreePickup);
			}
			set{
				this[this.uiviewcRef.FieldFreePickup] = value;
			}
		}
		
		
		public  Double? FreeDelivery
		{
			get{
				//object value = this[this.uiviewcRef.FieldFreeDelivery] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewcRef.FieldFreeDelivery);
			}
			set{
				this[this.uiviewcRef.FieldFreeDelivery] = value;
			}
		}
		
		
		public  Int64 Address_ID
		{
			get{
				//object value = this[this.uiviewcRef.FieldAddress_ID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewcRef.FieldAddress_ID);
			}
			set{
				this[this.uiviewcRef.FieldAddress_ID] = value;
			}
		}
		
		
		public  String Address_Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldAddress_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldAddress_Code);
			}
			set{
				this[this.uiviewcRef.FieldAddress_Code] = value;
			}
		}
		
		
		public  String Address_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldAddress_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldAddress_Name);
			}
			set{
				this[this.uiviewcRef.FieldAddress_Name] = value;
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