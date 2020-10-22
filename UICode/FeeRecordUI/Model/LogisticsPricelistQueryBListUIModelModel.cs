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
	public partial class LogisticsPricelistQueryBListUIModelModel : UIModel
	{
		#region Constructor
		public LogisticsPricelistQueryBListUIModelModel() : base("LogisticsPricelistQueryBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("a057746e-21ef-4418-88e6-3fbff38ae378");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private LogisticsPricelistQueryBListUIModelModel(bool isInit) : base("LogisticsPricelistQueryBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new LogisticsPricelistQueryBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private LogisticsPricelistView viewLogisticsPricelist;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public LogisticsPricelistView LogisticsPricelist
		{
			get { return (LogisticsPricelistView)this["LogisticsPricelist"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewLogisticsPricelist = new LogisticsPricelistView(this);
			this.viewLogisticsPricelist.SetResourceInfo("47ba1a83-6165-4311-bf77-18e96e2accca");
			this.Views.Add(this.viewLogisticsPricelist);			

			
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


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a3b92f2b-90a7-4998-94eb-9e21362e7030");


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
		#endregion
	}
	



}