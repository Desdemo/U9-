/**************************************************************
 * Description:
 * CalculationFeeUIModelAction.cs
 * Product: U9
 * Co.    : UFSoft Group
 * Author : Auto Generated 
 * version: 1.0
 **************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using System.Data;
using UFSoft.UBF.ExportService;
using UFSoft.UBF.UI.MD.Runtime.Implement;
using UFSoft.UBF.UI.IView;
using System.Linq;

namespace UFIDA.U9.Cust.BLT.CustLogisticsUI
{
	public partial class CalculationFeeUIModelAction 
	{
		public override void OnInitAction()
		{
			base.OnInitAction();
			//提示:可注册你自己的方法到相应的事件中,如下.
			//this.CommonAction.BeforeLoad += new ActionLoadDelegate(CommonAction_BeforeLoad);
		}
		private void SaveClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.SaveClick_DefaultImpl(sender,e);								
        } 
		private void CancelClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.CancelClick_DefaultImpl(sender,e);								
        } 
		private void NewClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.NewClick_DefaultImpl(sender,e);								
        } 
		private void DeleteClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.DeleteClick_DefaultImpl(sender,e);								
        } 
		private void CopyClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.CopyClick_DefaultImpl(sender,e);								
        } 
		private void SubmitClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.SubmitClick_DefaultImpl(sender,e);								
        } 
		private void ApproveClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.ApproveClick_DefaultImpl(sender,e);								
        } 
		private void FindClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.FindClick_DefaultImpl(sender,e);								
        } 
		private void ListClick_Extend(object sender, UIActionEventArgs e)
		{
			//List Click Code Demo...
			//this.CurrentPart.NavigatePage("TestList", null);
			//this.ListClick_DefaultImpl(sender,e) ;	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.ListClick_DefaultImpl(sender,e);								
        } 
		private void FirstPage_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.FirstPage_DefaultImpl(sender,e);								
        } 
		private void PrevPage_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.PrevPage_DefaultImpl(sender,e);								
        } 
		private void NextPage_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.NextPage_DefaultImpl(sender,e);								
        } 
		private void LastPage_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.LastPage_DefaultImpl(sender,e);								
        } 
		private void AttachmentClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.AttachmentClick_DefaultImpl(sender,e);								
        } 
		private void FlowClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.FlowClick_DefaultImpl(sender,e);								
        } 
		private void OutputClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OutputClick_DefaultImpl(sender,e);								
        } 
		private void PrintClick_Extend(object sender, UIActionEventArgs e)
		{
            //调用模版定义的默认实现方法.如需扩展,请直接在此编程
            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject(); ;
            settings.PrintTemplateCatalogType = "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee";
            settings.UserDataCallBack = new DataCallBackHandle(this.MyPrintData);
            e.Tag = settings;     
            //调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
            this.PrintClick_DefaultImpl(sender, e);
        }
        public void MyPrintData(object sender, DataCallBackEventArgs args)
        {
            IPart _part = this.CurrentPart;
            this.CurrentPart.Model.ClearErrorMessage();
            this.CurrentPart.DataCollect();
            if (string.IsNullOrEmpty(args.PrintTemplateID)) return;

            DataSet dataSet = new DataSet();
            DataTable dt = new DataTable();

            foreach (IUIField field in _part.Model.Views[0].Fields)
            {
                dt.Columns.Add(string.Format("{0}_{1}", _part.Model.Views[0].Name, field.Name));
            }

            foreach (IUIField field in _part.Model.Views[1].Fields)
            {
                dt.Columns.Add(string.Format("{0}_{1}", _part.Model.Views[1].Name, field.Name));
            }

            foreach (IUIField field in _part.Model.Views[2].Fields)
            {
                dt.Columns.Add(string.Format("{0}_{1}", _part.Model.Views[2].Name, field.Name));
            }

            foreach (IUIField field in _part.Model.Views[3].Fields)
            {
                dt.Columns.Add(string.Format("{0}_{1}", _part.Model.Views[3].Name, field.Name));
            }

            IList<IUIRecord> selectRecords = null;
            if (_part.Model.Views.Count > 1)
            {
                selectRecords = _part.Model.Views[1].Records.ToList();
                if (selectRecords.Count == 0)
                    selectRecords = _part.Model.Views[1].Records.ToList();
            }

            if (_part.Model.Views[0] != null && _part.Model.Views[0].FocusedRecord != null)
            {
                foreach (IUIRecord record in selectRecords)
                {
                    DataRow dr = dt.NewRow();

                    foreach (IUIField field in _part.Model.Views[0].Fields)
                    {
                        dr[string.Format("{0}_{1}", _part.Model.Views[0].Name, field.Name)] = _part.Model.Views[0].FocusedRecord[field.Name];
                    }

                    if (_part.Model.Views.Count > 1)
                    {
                        foreach (IUIField field in _part.Model.Views[1].Fields)
                        {
                            dr[string.Format("{0}_{1}", _part.Model.Views[1].Name, field.Name)] = record[field.Name];
                        }
                    }

                    dt.Rows.Add(dr);
                }
            }
            dataSet.Tables.Add(dt);
            args.ReturnData = dataSet;
        }


        private void GetPrintData(object sender, UFSoft.UBF.ExportService.DataCallBackEventArgs args)
        {
            args.ReturnData = GetPrintDataSet2(sender, args);
        }
        private System.Data.DataSet GetPrintDataSet(object sender, UFSoft.UBF.ExportService.DataCallBackEventArgs args)
        {
            UFSoft.UBF.ExportService.PrepareDataService prepareDataService = new UFSoft.UBF.ExportService.PrepareDataService();
            return prepareDataService.GetDataSet(this.CurrentModel.CalculationFee, this.CurrentModel.CalculationFee_CalculationFeeLine, "Delivery");//三个参数分别为:表头Model、表体Model、任意表名
        }

		private DataSet GetPrintDataSet2(object sender, DataCallBackEventArgs args)
		{
			DataSet ds = new DataSet();
			DataTable table = new DataTable();
			table.Columns.Add("CalculationFee_ID");
			table.Columns.Add("CalculationFee_DescriLocation");
			table.Columns.Add("CalculationFee_NumberOfTrucks");
			table.Columns.Add("CalculationFee_Remark");

             ds.Tables.Add(table);
			return ds;
		}


            private void OnOk_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnOk_DefaultImpl(sender,e);								
        } 
		private void OnClose_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnClose_DefaultImpl(sender,e);								
        } 
		private void Query_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.Query_DefaultImpl(sender,e);								
        } 
		private void Complex_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.Complex_DefaultImpl(sender,e);								
        } 
		private void ManualCostsharing_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.ManualCostsharing_DefaultImpl(sender,e);								
        } 
		private void Costsharing_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.Costsharing_DefaultImpl(sender,e);								
        } 
		
		#region UBF 内置两数据处理Action
		//数据加载的扩展
		private void OnLoadData_Extend(object sender, UIActionEventArgs e)
		{
this.OnLoadData_DefaultImpl(sender,e);			
		}

		//数据收集的扩展
		private void OnDataCollect_Extend(object sender, UIActionEventArgs e)
		{
			this.OnDataCollect_DefaultImpl(sender,e);
		}
		#endregion 
		

	}
}
