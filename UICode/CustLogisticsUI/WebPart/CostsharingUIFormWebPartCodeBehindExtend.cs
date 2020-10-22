using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Globalization;

using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.CustLogisticsUI
{
    public partial class CostsharingUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//CostsharingAction185_Click...
		private void CostsharingAction185_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			// 清除之前页面错误信息
			this.Action.CurrentModel.ClearErrorMessage();
			CustLogisticsBP.Proxy.ManualCostsharingOperationProxy proxy = new CustLogisticsBP.Proxy.ManualCostsharingOperationProxy();
			proxy.Data = new List<CustLogisticsBP.CostsharingDTOData>();
			IUIRecordCollection records = this.Model.CostsharingView.Records;
			if (records.Count > 0)
			{
				List<CalculationFeeUIFormWebPart.Cost> Newcosts = new List<CalculationFeeUIFormWebPart.Cost>();
				foreach (CostsharingViewRecord i in records)
				{
					CustLogisticsBP.CostsharingDTOData dto = new CustLogisticsBP.CostsharingDTOData();
					dto.DocType = i.DocType;
					dto.DocID = i.DocID;
					dto.DocNo = i.DocNo;
					dto.Amount = i.Amount;
					CalculationFeeUIFormWebPart.Cost Newcost = new CalculationFeeUIFormWebPart.Cost()
																{ DocType = i.DocType, 
																  DocID = i.DocID, 
																  DocNo = i.DocNo,
																  Amount = i.Amount };
					Newcosts.Add(Newcost);
					proxy.Data.Add(dto);
				}
				bool status = proxy.Do();
				// todo: 操作提示弹窗
				this.CloseDialog();

				this.CurrentState["NewCosts"] = Newcosts;

			}

			
		}




		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{

			List<CalculationFeeUIFormWebPart.Cost> costs = (List<CalculationFeeUIFormWebPart.Cost>)this.CurrentState["Costs"];
			foreach (CalculationFeeUIFormWebPart.Cost cost in costs)
			{
				CostsharingViewRecord record = this.Model.CostsharingView.AddNewUIRecord();
				record.DocID = cost.DocID;
				record.DocNo = cost.DocNo;
				record.DocType = cost.DocType;
				record.Amount = cost.Amount;
			}
			OnLoadData_DefaultImpl(sender);
		}
		private void OnDataCollect_Extend(object sender)
		{	
			OnDataCollect_DefaultImpl(sender);
		}
		#endregion  

        #region 自己扩展 Extended Event handler 
		public void AfterOnLoad()
		{
		}

		//class Cost
		//{
		//	public string DocNo;
		//	public long DocID;
		//	public int DocType;
		//	public double Amount;
		//}
		public void AfterCreateChildControls()
        {
			
		}
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{

		}

		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}