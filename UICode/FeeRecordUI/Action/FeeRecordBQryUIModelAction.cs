/**************************************************************
 * Description:
 * FeeRecordBQryUIModelAction.cs
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
	public partial class FeeRecordBQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(FeeRecordBQryUIModelAction));
		//强类型化基类Model属性.
		public new FeeRecordBQryUIModelModel CurrentModel 
		{
			get {
				return (FeeRecordBQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public FeeRecordBQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public FeeRecordBQryUIModelAction(FeeRecordBQryUIModelModel model) : base(model)
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
         
            
        #region BE查询自动产生的代码
        
        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord", "3fc47769-3d05-4062-8bae-f3ae964039f9", UIGrid.UIView, UIGrid, 1);

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
            BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord", "3fc47769-3d05-4062-8bae-f3ae964039f9", UIGrid.UIView, UIGrid, 1);
            beQryStrategyImpl.QueryComponentXMLCompressed = @"7ZnLblvHGYDdTTd9CYGL7sae+wWNEliSBQhwY8WSYqC7ufwjnZriIcjDxN7Fi0ZOW8MGnDRA4TRx
0MIFCjgpktZJ3SCv0QcwJeUp2v+QIi1SvpBtUFRAuSA5M5zzz3zzX4dnfnDmzJl/4qv+rF8/rL/8
Y/GV167tNhfegk63KFuLDXaWNhagFctUtLYXG70qE9t47dVX3uhB5/pyudsuW9CqFoq02LCGWZ8Y
JToLTaT1klivLaHG2Mick8rYxkLL78JiYxXgMsSykwbPaSykottu+uuvP3sQurFTtKvBghoLO9Bs
15+D0c3rbZyxdOHop4OPrctriw2RozRGOyISVURSzYkNHkgWHpyWVLjsjn6/UfY6EVZ7zeZQ/tbq
2sr5s1vu7HKvW51durg5+HKx3C66VRG7SxfOjlfYWNhae7OAt1c6fnu4lPrbSvl2q7FwGfJaK5cX
S5+GQ8s+7kDj1VeWfLeI9dAAm/csuyAkkdwhNm0cYvOZpJytMtmloNMI2xSo56JB0ZvlVRj0XS7L
agV/tly2KrhWvembvcHU1aJZQWfThzeLbhGa2LfZ6UFjYbls9nZbJ/s3yk51snf4lAvX2r6VLsJb
0ETyo2dM99ZPmO47hzjWj0gNcLhojFEyEeeSIVJQIE64RLjghmZEJJ2eF8d6p/w5xGpt5Vhj3Vc7
dXNpfa2C3eHQ0vqlNnR8PX3YsbJ5aTRyfhv1fKXZPNbCJ127XrdxE1trxzcRTeYmRIFWEC2+JYrb
4ZzoKJz03tjE4ve5ia21n5YJmqOdCJaZSOBIToESqRRaYpCRCO9CDApXYFU9abXs7I7myMzQYoIk
WQMQGQOqoUuZoEVn5wUzLImngnBCTtn6iIoqhcaNRmuIY8wR5hKzCahQiQ3QDJVhBXLRgu5kcwCL
xZy4k0BSzBwNgFsSnAwEtd+obDUguRGsN6ppZzHseQ4y38FjGnE93yx892jCWne1uAYofNU3u6jG
U1pd28tqAc00bTQ/g0651r2w266uj+eu+ApWhksa2nl9PBCL2oEOOzYq1Ck88Nd7u9Ap4rATG6Fu
4a/LolUtNvgJWkd4YsyaRmKpQ9gRkEwUlHhFadDW6RDZCM959Nt+G5bLbjWFaXJkDlwTE/+72C6W
5dWtNvqN6JsweO5ig5Afb1c/GZzhi7FxHmIUgLqUJfqRxIAElRwBmU2M2picx35kBZoFbvM6uvUp
bJMjc2CbmHiKsMnsnXZWEMs1apsMgQSKbwpjkuDcWG+fYiu6ccd3tuEZ3CaH5gE3MfMUkVM+1M5K
EpMUI9JLQbxJgmSkRjEWaCbNiNzaUq95dQrZqG8OVkdTThMkoMF5wwjLEjMejQZppWcYZXLwCaJC
bzeCdKnagc5J1TrWPQeqp7NOES2vREwSEvGgEpFOoUoxT4lR1ELQ0UeQI1rrRbzaa5/Edbx/Dl7H
pp0iYIliXq8xTHKIHm0QXVgIAVC9khBMMMx9xrHyMvjmageK7Z3pWDk5Mge0iYmnCFuI3PE6xdDS
oFU6xOaF8iRIwzHFSCFZN8KGuUwr+U7a2CnabawJp9g9Y3gOgCdnnyKKmssMHnNhDRTzWEwySBBc
kGhokpkqTPrHFDfL6nnaNzU0B73JmaeJnKAYBQAtVlnUPx8NCT5j0SKoAckiVzC+Odgq6sKriNN+
7nj/HMyOTTtFwFR0JhsNREkesQCTmVgmNHGZQRAyGqyiRsCuPEvJrvwb6nXlf16xzk2VmvjF95rV
su/C0a3L8LqiO9E6UkEsqjJWywkwJ5For+gCvSBUQ7DJGvSH41uYpV63fn63XuAU1ydf/bb/y/sH
f37c/92vnkv33Enx1KOL0Jh2R6axYucJUyLr68srL4N3VksxTh43EER317emRB8++rh/64N5hFrp
chI5Ya5fX9hR6Yl31BFujXM2em9hvOeNXrvdLKAzJXT/vW8Pv73T/+DdeeRKxgzDBIboxATBliIu
IPCcGccRyqUeb3a9U75VtE5Y+8G9G08ef/Mioecmz3ukCgMFGd9CDJaTHdTORxNOI3ofBWhMAQ/A
cfQ/0kRvAv0ej/6Y5BiNx4RXIYj6jpJjzmI5VqsuKPASNNYM+T8+9WPylPBBcWWQtI91ekSJEyg0
WzCKpZStGvvZ2np9rNZ3ytb0TvsPP92/+ejg/b8cfvbRjJIpOirqQGEmRlG/mZCYmGFszAg3IOik
wthh1cG/9gvTUvf+dvjlg/0P/7B/7+MZpQYRTWbCEi0YBhdhdH0HgEk0sGS1iNzDBN/Xy2m6Dz9F
uv3bj2YUaEXE+tlYYq1GgZyjZruQCKYBidoUVabh+VdZ+x98/t3e7RlFARM8JRsJAxaQKDBiQaHx
Uo57tk4oKo8ZUepF9IMVbJcnrtvRevt3b9SKe/NPsyqScppjzUZwFfUFY+DEJlGbsfYiKikcoy+q
dZ98c/fgwWczCsuOM26kxWBX32ZCYCREbZGs1ZxLlTyEFwa77/Zuzc6VyYiFVgp4hBmPUEYgIQtH
wBgJVJhohXhZzbV/+w6q6uGXX8+qNkrQhDkOoejo0REHgZE8OwwGVkkZjIo2vPyu6rt3bswlNfkk
Eo+BcIl6KnOItXV4kmIErbIOPKoZrnr6t76aTyzWYSI4T6KtrwCCk3VRqwiorLhFmSqEl1wB9H/x
1yePf4MiD97/46zHanR0ENFc6gJaxoDKKrDYiSGi5wPpklEzljj7n+z1997FsDf7nlnO2hmHIQat
kmBVhdIj1lueos8H5rTReobSYLjj/p2bhw/vz2qpkBNjqMQiRYYeKWCM1xKzC7QpYZihMfKXV8QH
j+8ePPzwyeNH+5/8fUbBgjHHuMfDDTGhi+BosCxmkgIPygavuYgvv7buf/1F/6O9uU462uSVtJyo
5DDIZfSOzjNLMuq25ciC5viyYmL/vQeH93+Nrh+3POt+qch4sJxodMMYW6kmNofaKUsWKPrETONT
0Lu+M+0T+7/f2/9i1k0qzUEa9BMp+jpddRltN2LOygUFG4zzbmxE9R+b51PqYNryTI/Rv/d5/6N3
XphLTWdPR+36Dz1s1R9DBnbwd4QklFKMSRzt29a+M9hoPY3Bq6e3e8sdwHCULk0nNM9dx+D/x0FJ
cH5jeWJZR8s4N5Hun5v8h/rVH535/+v4618=";
            
            BeforeGetQryModel_Extend(beQryStrategyImpl);
            
            CaseModel caseModel = beQryStrategyImpl.GetQryModel();
            
            AfterGetQueryModel_Extend(caseModel);
            
            QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
        }
        
        
        #endregion
         


	}
}
