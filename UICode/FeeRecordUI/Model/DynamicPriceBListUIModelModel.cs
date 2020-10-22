#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.BLT.FeeRecordUI
{
	[Serializable]
	public partial class DynamicPriceBListUIModelModel : UIModel
	{
		#region Constructor
		public DynamicPriceBListUIModelModel() : base("DynamicPriceBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("f7f11d5a-b8e3-4f65-bd1e-f232ea835dde");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private DynamicPriceBListUIModelModel(bool isInit) : base("DynamicPriceBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new DynamicPriceBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private DynamicPriceView viewDynamicPrice;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public DynamicPriceView DynamicPrice
		{
			get { return (DynamicPriceView)this["DynamicPrice"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewDynamicPrice = new DynamicPriceView(this);
			this.viewDynamicPrice.SetResourceInfo("01f8cb70-242f-48ad-a41e-ca6c508a042d");
			this.Views.Add(this.viewDynamicPrice);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.BLT.FeeRecordUI"; }
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


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","712a777e-0109-40b5-8531-a47ddaed95d5");


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
		#endregion
	}
	



}