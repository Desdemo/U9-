/**************************************************************
 * Description:
 * DynamicPriceBListUIModelAction.cs
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
	public partial class DynamicPriceBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(DynamicPriceBListUIModelAction));
		//强类型化基类Model属性.
		public new DynamicPriceBListUIModelModel CurrentModel 
		{
			get {
				return (DynamicPriceBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public DynamicPriceBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public DynamicPriceBListUIModelAction(DynamicPriceBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice", "b0832f38-673c-4beb-901c-8d69b00a8110", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice", "b0832f38-673c-4beb-901c-8d69b00a8110", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7VZNbxNHGE4vvfTaH2D5Ps587e6MlAQRm0iWUkiDzX0+3glb1t5ovS7JDU6tWhBI/eDSD5AqwaWo
VVshAb31p+CE/or2XTuGxGAwUg895L3szjs78zzzzPuxS+8tLS39g1Y9K3u/evnrw5Uze72s9ikU
gzTvr9ZZg9Zr0He5T/s7q/VhGYiqn1lb+XgIxX4z7+3mfeiXtdSv1q2MY64kECFYRCSjjBhwnnjt
A/BAuYzieq1verBab+3jM3VbRepgvFW95tPBbmb2z8+dh4Er0t1yTKteuwzZbvUcz3b2d3HRZjoo
jxzd7TYSokrwIBSJE+GItGCJpswR5WNtKTWKMXr0/cV8WDjYGGbZBL+70W6dbXR1ozkclI31zc74
ZTPfQYjUDdbPNY4zrNe67UspXG0VZmdCpXpr5Vf79do2hHY/5Ju58ZOppnGXob62sm4GqaumxuJp
51zkWEJUIhmRWibEyISSOFiufCI8lXIq3oxWc6VB6E5+Bca+7TwvW/hZM++XsFdeMtlwvHQjzUoo
OsZeSgepzdDXKYZ4oGaeDXv9V/0X86J81TvZ5dzerun7TfgUstW6mO4x6612mPUtoxxbR0qN5ZDG
0ShREYmU1kT6YFAYkMQxq11kRaSUf1c5tor8E3Blu3VssGXKy9VwfatdQm8ytb51YRcKUy2fOFqd
C9OZszsY7a0sOzbCnfb2qzEeots+fgifaGql5iTSVhGZJBh61cVKDoJxoC7h7L88RLf9Ue4hm54k
EnESgRQYQxElEiOJ6ICJEEtMgGAE1/E4cjfyojddQ6XTWoaEAEQV0ThCyiImTCnrlBC4nX0JhAtC
EhjzkSFWgSAy4ALrGZDABQejROQ9jKVpQTDDrGyaAbwcjANksLYyeRmLxpCa8iwmjhu8eQV487FX
JJIMfATW20RPRWvm1eYnhDt8+u3h3etz5Vs+gRU0l0EzT4KIPZFCA1EWaxd4oVRIbGL8C6xt6Jni
ygza6KfPDn57sCAa8xwC9RGJBcMUFzSqYhpxtXcuVpwnzryuPm6mfWicz2ehv3hwcO36syePDu4+
fX7vRmP0+Nbo1qNFD45Q2iZAOLMYGonB+3NUECqp8MZqa5WcS6XbT8ujsvdmRje/wcGCjMAFLrni
hKuqeWjNsEwLSjC2YuW1Y4rbuYwulqYo38bm6bXR/S8XZOOp9sCNIBGjlshIoD4M08BEiiUJxU5C
+Vw2zWGZh/AWOodPvjr4/scF6ZgE85Y7SwSgQlIbT3RsFIHEgHaJEkmVyXPodPLSZG8T58bjv+/8
Prr9+fOH9xbkxFXsqIkNCZGMicTmRUyggIpFOnY4IVQyl9Prk2mW1Lskl9UgIXCPKSWqVHZADAYy
ocFIHbj1WrHX0al68ht4HP76ZPTDwlHjOeegFdFgZNW0JFFRYrGRC07BKdTlRQyfCwEr90YKmZ+B
f/bnd4dfPxj9fOfg4R+LVhZslUqi+NhV8EeHxdhouMIiHgMXFpPaSzoFrkBmD3z75uH9X96EtTxb
sJdPlPPlk3+Dax8sndqpndqpndr/1f4F";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
