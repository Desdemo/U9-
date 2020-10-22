/**************************************************************
 * Description:
 * LogisticsPricelistQueryBListUIModelAction.cs
 * Product: U9
 * Co.    : UFIDA Group
 * Author : Auto Generated
 * version: 2.0
 **************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.IView; 
using System.Data;
using UFIDA.UBF.Query.CommonService;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.UBF.Query.CommonService.QueryStrategy;
using UFIDA.UBF.Query.CaseModel;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.ExportService;

namespace UFIDA.U9.Cust.BLT.FeeRecordUI
{
	public partial class LogisticsPricelistQueryBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(LogisticsPricelistQueryBListUIModelAction));
		//强类型化基类Model属性.
		public new LogisticsPricelistQueryBListUIModelModel CurrentModel 
		{
			get {
				return (LogisticsPricelistQueryBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public LogisticsPricelistQueryBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public LogisticsPricelistQueryBListUIModelAction(LogisticsPricelistQueryBListUIModelModel model) : base(model)
		{
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnLookCase(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnLookCase_Extend);
		}
		private void OnLookCase_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:QryClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("QryClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnCaseChanged(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnCaseChanged_Extend);
		}
		private void OnCaseChanged_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	        QryService.OnCaseChangedDefault("DDLCase", this.CurrentPart);
		QueryAdjust();
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnOutPut(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnOutPut_Extend);
		}
		private void OnOutPut_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:OnOutPut
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OnOutPut",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnGridRowDbClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnGridRowDbClick_Extend);
		}
		private void OnGridRowDbClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnNew(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnNew_Extend);
		}
		private void OnNew_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnPrint(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnPrint_Extend);
		}
		private void OnPrint_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:OnPrint
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OnPrint",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnDelete(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnDelete_Extend);
		}
		private void OnDelete_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:ListDeleteClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("ListDeleteClick",this,sender,e);

	  
		}
		#region Action的内置两个Action.
		/// <summary>
		/// Help: 数据加载(发生在Form的初始化加载时)
		/// </summary>
		public void OnLoadData(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnLoadData_Extend(sender,e) ;
		}
		private void OnLoadData_DefaultImpl(object sender, UIActionEventArgs e)
		{
		   
		     InitCaseModel();
				}
		/// <summary>
		/// Help: 数据收集(发生在Form的CallBack或者是PostBack时)
		/// </summary>
		public void OnDataCollect(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnDataCollect_Extend(sender,e) ;
		}
		private void OnDataCollect_DefaultImpl(object sender, UIActionEventArgs e)
		{
		    UFIDA.U9.UI.Commands.CommandFactory.DoCommand("DataCollect",this,sender,e);
		}
		#endregion
         

            
        #region BE列表自动产生的代码
        
		public void QueryAdjust()
		{
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist", "831a5ce0-7df5-42b1-9741-0bcfbb991e15", UIGrid.UIView, UIGrid, 1);

			beQryStrategyImpl.Adjust();
		    
			AfterQryAdjust_Extend(UIGrid);

			UIGrid.UIView.CurrentFilter.OPath = CustomFilterOpath_Extend(QryService.GetDefaultOpath((BaseWebForm)(this.CurrentPart)));
			UIGrid.UIView.CurrentFilter.OrderBy = QryService.GetOrderByOpath((BaseWebForm)(this.CurrentPart));

			UIGrid.UIView.Clear();
			this.NavigateAction.FirstPage(null);

			//20090316 UBF2.9_查询_yzx_修改查询设计器的tpl_用于显示多webpart查询的IE状态栏提示信息
			QryService.ShowQueryInfoInIEStatusBar((BaseWebForm)this.CurrentPart, UIGrid.UIView);
		}

		public void InitCaseModel()
		{
			QryService.ClearSession((UFSoft.UBF.UI.FormProcess.BaseWebForm)(this.CurrentPart));
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist", "831a5ce0-7df5-42b1-9741-0bcfbb991e15", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7VbNbxtFFA8XLtw5W75PMrOz8yUlqRq7kSylbUid3ufjTbJ047XW6za5USTIqaQSopU4FQlUTgiJ
iqpQwT9D0vSvgLd23Q+nxa7ECWUO9ps3M29+83tfu/DBwsLC3zjq/3p8WAvffrx8YX8vb9yEcpAV
vZUmW6TNBvR8EbLezkpzWEWimxdWlz8ZQnnQKvb6RQ96VSMLK02dUMPTwAhoH0hqE0W0NJxQEMpb
miSG22ajZ/dgpblR7GSDKvODzTLzkKM8MthshGzQz+3BlRm7YODLrF+NIDYbu5D36//RavegXx/F
zS8U21sdBMeZFR4oUSEKkiaOEaNSRqjz0TljGDDxYv+1Ylh6WB/m+RjF9nqnfXFx2yy2hoNqcW2j
OxJeYlu7tHgWZ7Ox3bmewa12aXfGgGqpXdzqNRtbEDu9WGwUNoyXWtbvQnN1ec0OMl8vjejkIqQ8
BkGsjZykFIC4qDWJTEaqdeQmugmdU7y9kyC8ulvcgJFuqyiqNm5rFb0K9qvrNh+Ojq5neQVl17rr
2SBzOeq65RCajVaRD/d6Z/XXirI6qx1bubTft72wATchxwdNbExrawvTuiWkY/MFUyM6mEqitpQS
I7hBByYJcT5IwgzjglkZuIL3pWOzLD4FX3Xar002bbVbT9c2OxXsjZfWNq/2obT18bGi3b06Wbm4
g/HfzvPXZmhp/6Ce4yO2O68/wjBBvY+WWKcYSSU+R0smCdVgTEqFTpn9Lx+x3blcBMgnL4lcRhFN
SpSTlqShTgIeHIYUOJFI5Z0V9aH1otx7ecZFHpWgJAqnSSqYIc7GhICl2gstnVD21UV4wFKhVCqB
JAwiSVOmidYgCUdLkWsLXOkRNW2IdphXLTuAV5NRgAxWl8fC2PPoXKFpJMCYRwSGERuBo33mJYQg
uWIT0lqIYoq4Z0/vPXtw+530Lb1xl3FgEgeBRKWwTNSucgYdxAMXEAUWCeCTu2rzU3cd373z7OHP
c95lMbsdj0CkTICkTnOivVdEolJwGhim/7vr5UbWg8UrxTSA346Ojx7PCYAqJgK3QCLnGI0gE6Jt
MCThxrKATFiuZwBoo4i94mDd+qo4U79Pju6ePnp4/PiH468+nxOTkNRpha0DlEZSEAPRBgT+0JiA
xAj16QxM9Qyb1WWodoswhej0p+/++v3xyb0nx0+P5kSUci4TqwKhPnXY1lCynAWiRIzSMhVkhBmI
trO6KKBm2lt3vkE0c+LwMhoXqCBIQoIFMBpMg8iIAhUYdZTCTBwTb21m/saw/1ZnnT56Mi8vgUkN
yhBBObZ7YwPRicJaFjxVzjvu3azwneBp7dpyBwZTgJ5/dvu9AHEWMZMkJyA15i44dFRqDfJlFAUT
fRpnhc56CfBWco6/uIP8nDw4PD78ck44MVAjoPYXfhdhrWeRWOkt4cC4QTw2gJ8DzoSjs4CQn/cC
hGklrABPuE6w+qcaP+WoiYQJCTbVTgKTMwB1S9sb9LFdj3phNztTAE//vHv6x9cn9399fv/RvBkf
PTMhKOJNim4LXhIDHquQwm7kQAP3s3jagj1b3phm6PvDk19+/DcQS9NNZ+mNlrT05jfu6kcL5+N8
nI/z8X8Y/wA=";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
