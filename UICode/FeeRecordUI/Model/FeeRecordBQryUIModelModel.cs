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
	public partial class FeeRecordBQryUIModelModel : UIModel
	{
		#region Constructor
		public FeeRecordBQryUIModelModel() : base("FeeRecordBQryUIModel")
		{
			InitClass();
			this.SetResourceInfo("fdf8acaf-4363-4c87-9119-19d18de035d1");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private FeeRecordBQryUIModelModel(bool isInit) : base("FeeRecordBQryUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new FeeRecordBQryUIModelModel(false);
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
			this.viewFeeRecord.SetResourceInfo("0aac5a2c-8ebd-4f97-bdc2-7cacbff70be9");
			this.Views.Add(this.viewFeeRecord);			

			
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


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","3bfebc16-940a-465d-a21a-135700e221d3");


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
		#endregion
	}
	



}