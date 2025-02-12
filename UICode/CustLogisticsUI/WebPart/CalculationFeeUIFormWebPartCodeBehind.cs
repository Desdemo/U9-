﻿using System;
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
using UFSoft.UBF.Business;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI;
using System.Collections.Generic;

/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.CustLogisticsUI
{
    public partial class CalculationFeeUIFormWebPart
    {
        #region eventBind
		 
				//MethodName:OutputClick0_Click ActionName:OutputClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void OutputClick0_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,OutputClick0_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void OutputClick0_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:OutputClick

	
		Action.OutputClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:AttachmentClick0_Click ActionName:AttachmentClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void AttachmentClick0_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,AttachmentClick0_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void AttachmentClick0_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:AttachmentClick

	
		Action.AttachmentClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:FlowClick0_Click ActionName:FlowClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void FlowClick0_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,FlowClick0_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void FlowClick0_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:FlowClick

	
		Action.FlowClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:PrintClick0_Click ActionName:PrintClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void PrintClick0_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,PrintClick0_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void PrintClick0_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:PrintClick

	
		Action.PrintClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:Query0_Click ActionName:Query
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void Query0_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,Query0_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void Query0_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

	
		Action.Query(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:Complex0_Click ActionName:Complex
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void Complex0_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,Complex0_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void Complex0_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

	
		Action.Complex(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:ManualCostsharing0_Click ActionName:ManualCostsharing
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void ManualCostsharing0_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,ManualCostsharing0_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void ManualCostsharing0_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

	
		Action.ManualCostsharing(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:Costsharing0_Click ActionName:Costsharing
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void Costsharing0_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,Costsharing0_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void Costsharing0_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

	
		Action.Costsharing(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:SaveClick0_Click ActionName:SaveClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void SaveClick0_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,SaveClick0_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void SaveClick0_Click_DefaultImpl(object sender, EventArgs e)
        {
			if (adjust.DoRequireCheck())
			{
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:SaveClick

	
		Action.SaveClick(sender,new UIActionEventArgs());

		
			

			}
        }
		#region  数据初始化加载和数据收集方法
		public void OnLoadData(object sender)
		{	
		    try
			{
			    OnLoadData_Extend(sender) ;
			}
			catch(Exception ex)
			{
				if (UFSoft.UBF.Exceptions.ExceptionHelper.IsUnknownException(ex, true)) {
                    throw;
                }
                IUIModel model = this.Model;
				this.Model.ErrorMessage.SetErrorMessage(ref model,ex);
			}			
		}		
		public void OnLoadData_DefaultImpl(object sender)
		{
			Action.OnLoadData(sender,new UIActionEventArgs());
		}
		
		public override void OnDataCollect(object sender)
		{
			try
			{
			    adjust.ProcessAdjustBeforeDataCollect(this);
			    OnDataCollect_Extend(sender);
			    adjust.ProcessAdjustAfterDataCollect(this);
			}
			catch(Exception ex)
			{
				if (UFSoft.UBF.Exceptions.ExceptionHelper.IsUnknownException(ex, true)) {
                    throw;
                }
                IUIModel model = this.Model;
				this.Model.ErrorMessage.SetErrorMessage(ref model,ex);
			}
		}
		private void OnDataCollect_DefaultImpl(object sender)
		{
			Action.OnDataCollect(sender,new UIActionEventArgs());			
		}

		#endregion 
		
        #region Grid控件DataGrid0的分页事件	
        void UFGridDataGrid0_GridMakePageEventHandler(Object sender, GridMakePageEventArgs  e)
        {
            //Grid的首页、下页、上页、末页处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridMakePage",this.Action,this.DataGrid0,e);
        }
        #endregion

        #region Grid控件DataGrid0的客户化筛选事件	
        void UFGridDataGrid0_GridCustomFilterHandler(Object sender, GridCustomFilterArgs  e)
        {
            //Grid的客户化筛选，首条、上一条、下一条、末条处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridCustomFilter",this.Action,this.DataGrid0,e);
        }
        #endregion
			
        #endregion
        
    }
}