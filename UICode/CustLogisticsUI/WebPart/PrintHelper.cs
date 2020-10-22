using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using UFSoft.UBF.ExportService;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.MD.Runtime;

namespace UFIDA.U9.Cust.BLT.CustLogisticsUI
{
    public class PrintHelper
    {
        public static void BindPrintHelper(IPart part, string printTemplateCatalogType)
        {
            new PrintHelper(part, printTemplateCatalogType);
        }
        IPart _part = null;
        public PrintHelper(IPart part, string printTemplateCatalogType)
        {
            _part = part;
            part.Model.ClearErrorMessage();
            part.DataCollect();

            UIActionEventArgs args = new UIActionEventArgs();
            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.DirectPrintWithDefaultSettings = false;
            settings.PrintTemplateCatalogType = printTemplateCatalogType;
            settings.UserDataCallBack = new DataCallBackHandle(this.MyPrintData);
            args.Tag = settings;
        }

        public void MyPrintData(object sender, DataCallBackEventArgs args)
        {
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
                selectRecords = _part.Model.Views[1].GetSelectRecords();
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

        public void MyPrintData1(object sender, DataCallBackEventArgs args)
        {
            if (string.IsNullOrEmpty(args.PrintTemplateID)) return;

            DataSet dataSet = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("CalculationFee_ID");
            dt.Columns.Add("CalculationFee_DescriLocation");
            dt.Columns.Add("CalculationFee_NumberOfTrucks");
            dt.Columns.Add("CalculationFee_Remark");
           
            dataSet.Tables.Add(dt);
            args.ReturnData = dataSet;
        }
    }
}
