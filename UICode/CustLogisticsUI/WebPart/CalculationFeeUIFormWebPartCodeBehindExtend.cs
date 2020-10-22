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
using UFSoft.UBF.Report.Proxy;
using System.Collections.Generic;
using UFSoft.UBF.Util.DataAccess;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.U9.Cust.BLT.CustLogisticsBE;
using UFIDA.U9.Cust.BLT.CustLogisticsBP;
using System.Runtime.CompilerServices;
using UFSoft.UBF.Service.Base;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.ExportService;




/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.CustLogisticsUI
{
    public partial class CalculationFeeUIFormWebPart
    {
        #region Custome eventBind
		 
				//OutputClick0_Click...
		private void OutputClick0_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			OutputClick0_Click_DefaultImpl(sender,e);
		}	
		 
				//AttachmentClick0_Click...
		private void AttachmentClick0_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			AttachmentClick0_Click_DefaultImpl(sender,e);
		}	
		 
				//FlowClick0_Click...
		private void FlowClick0_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			FlowClick0_Click_DefaultImpl(sender,e);
		}	
		 
				//PrintClick0_Click...
		private void PrintClick0_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			PrintClick0_Click_DefaultImpl(sender, e);

    }

        //Query0_Click...
        private void Query0_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			// 清除之前页面错误信息
			this.Model.CalculationFee_CalculationFeeLine.Clear();
			this.Model.CalculationFee_ChenyangTotal.Clear();
			this.Model.CalculationFee_HuangdaoTotal.Clear();
			this.Action.CurrentModel.ClearErrorMessage();
			
			if (this.Sup0.Key == "-1")
			{
				throw new Exception("供应商不能为空");
			}
			
			if (this.ShipDate0.Value == null)
			{
				throw new Exception("配送时间不能为空");
			}
			CustLogisticsBP.Proxy.QueryDescOperationProxy query1 = new CustLogisticsBP.Proxy.QueryDescOperationProxy();
			query1.Data = new CalculationFeeData();
            query1.Data.Sup = (long)this.Model.CalculationFee.FocusedRecord.Sup;
       
            query1.Data.Contain = (bool)this.Model.CalculationFee.FocusedRecord.Contain.GetValueOrDefault(true);
            query1.Data.ShipDate = (DateTime)this.Model.CalculationFee.FocusedRecord.ShipDate;
            query1.Data.PricingMethod = (int)this.Model.CalculationFee.FocusedRecord.PricingMethod;
            query1.Data.Province = (long)this.Model.CalculationFee.FocusedRecord.Province.GetValueOrDefault(0);
            query1.Data.City = (long)this.Model.CalculationFee.FocusedRecord.City.GetValueOrDefault(0);
            query1.Data.County = (long)this.Model.CalculationFee.FocusedRecord.County.GetValueOrDefault(0);
            query1.Data.DescriLocation = this.Model.CalculationFee.FocusedRecord.DescriLocation;

            // List<CalculationFeeLineDTOData> fees =  query.Do();

            List<CalculationFeeLineDTOData> fees =  query1.Do();
			// totals   0 城阳体积  1城阳重量  2黄岛体积 3 黄岛重量 
            Dictionary<int, double> totals = new Dictionary<int, double> { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 0, 0 } };
			if (fees.Count > 0) {
                foreach (CalculationFeeLineDTOData fee in fees)
                {
                    CalculationFee_CalculationFeeLineRecord record = this.Model.CalculationFee_CalculationFeeLine.AddNewUIRecord();
                    record.DocID = fee.DocID;
                    record.DocNo = fee.DocNo;
                    record.DocType = fee.DocType;
                    record.LineID = fee.LineID;
                    record.RealDeliveryFactory = fee.RealDeliveryFactory;
                    record.Item = fee.Item.ID;
                    record.Item_Code = fee.Item.Code;
                    record.Item_Name = fee.Item.Name;
                    record.SalesUom = fee.SalesUom.ID;
                    record.SalesUom_Code = fee.SalesUom.Code;
                    record.SalesUom_Name = fee.SalesUom.Name;
                    record.Qty = fee.Qty;
                    record.RealPricingMethod = fee.RealPricingMethod;
                    record.IBulk = fee.IBulk;
                    record.Weight = fee.Weight;
					if (fee.WeightUom != null)
					{
                        record.WeightUom = fee.WeightUom.ID;
                        record.WeightUom_Code = fee.WeightUom.Code;
                        record.WeightUom_Name = fee.WeightUom.Name;
                    }
					if (fee.BulkUom != null)
					{
                        record.BulkUom = fee.BulkUom.ID;
                        record.BulkUom_Code = fee.BulkUom.Code;
                        record.BulkUom_Name = fee.BulkUom.Name;
                    }
                    
                    record.PricingQty = fee.PricingQty;
                    record.PricingUom = fee.PricingUom.ID;
                    record.PricingUom_Code = fee.PricingUom.Code;
                    record.PricingUom_Name = fee.PricingUom.Name;
                    // 计价方式 0 包车 1 体积 2 重量
                    // 提货工厂 0 黄岛 1 城阳 
                    switch (record.RealPricingMethod)
                    {
                        case 0:
                            totals[0] = totals[1] = totals[2] = totals[3] = 0;
                            break;
                        case 1:
                            if (record.RealDeliveryFactory == 0) totals[2] = totals[2] + (double)record.IBulk;
                            else totals[0] = totals[0] + (double)record.IBulk;
                            break;
                        case 2:
                            if (record.RealDeliveryFactory == 0) totals[3] = totals[3] + (double)record.Weight;
                            else totals[1] = totals[1] + (double)record.Weight;
                            break;

                    }
                    record.SetParentRecord(this.Model.CalculationFee.FocusedRecord);

                }
                CalculationFeeRecord feeRecord = this.Model.CalculationFee.FocusedRecord;
                feeRecord.TotalAmount = 0;
                feeRecord.RealAmount = 0;
                CalculationFee_HuangdaoTotalRecord huangdao = this.Model.CalculationFee_HuangdaoTotal.AddNewUIRecord();
                CalculationFee_ChenyangTotalRecord chengyang = this.Model.CalculationFee_ChenyangTotal.AddNewUIRecord();
                huangdao.TotalBulk = huangdao.RealBulk = totals[2];
                huangdao.TotalWeight = huangdao.RealWeight = totals[3];
                chengyang.TotalBulk = chengyang.RealBulk = totals[0];
                chengyang.TotalWeight = chengyang.RealWeight = totals[1];
            }
        }
        private void Complex0_Click_Extend(object sender, EventArgs e)
		{
			// 清除之前页面错误信息
			this.Action.CurrentModel.ClearErrorMessage();
			IUIRecordCollection records = (IUIRecordCollection)this.Model.CalculationFee_CalculationFeeLine.Records;
			if (records.Count > 0)
			{
				// 调用BP
				CustLogisticsBP.Proxy.CalculationFeeOperationProxy proxy = new CustLogisticsBP.Proxy.CalculationFeeOperationProxy();
				proxy.Data = new CalculationFeeData();
				proxy.Dataline = new List<CalculationFeeLineData>();
				//proxy.Data.Address = Convert.ToInt64(this.Model.CalculationFee.FocusedRecord.Address.Value);
				proxy.Data.SetLocation = Convert.ToInt64(this.SetLocation966.Key);
				proxy.Data.Sup = Convert.ToInt64(this.Sup0.Key);
				proxy.Data.NumberOfTrucks = Convert.ToInt32(this.NumberOfTrucks0.Value);
				proxy.Data.PricingMethod = Convert.ToInt32(this.PricingMethod0.Value);
				proxy.Data.Contain = Convert.ToBoolean(this.Contain0.Value);
                proxy.Data.Province = (long)this.Model.CalculationFee.FocusedRecord.Province.GetValueOrDefault(0);
                proxy.Data.City = (long)this.Model.CalculationFee.FocusedRecord.City.GetValueOrDefault(0);
                proxy.Data.County = (long)this.Model.CalculationFee.FocusedRecord.County.GetValueOrDefault(0);
                proxy.Data.DescriLocation = this.Model.CalculationFee.FocusedRecord.DescriLocation;

                proxy.DataH = new CalculationFeeTotalLineData();
				proxy.DataC = new CalculationFeeTotalLineData();
				proxy.DataH.RealBulk = Convert.ToDouble(this.RealBulk0.Value);
				proxy.DataH.RealWeight = Convert.ToDouble(this.RealWeight0.Value);
				proxy.DataC.RealBulk = Convert.ToDouble(this.RealBulk1.Value);
				proxy.DataC.RealWeight = Convert.ToDouble(this.RealWeight1.Value);

                proxy.DataH.TotalBulk = Convert.ToDouble(this.TotalBulk0.Value);
                proxy.DataH.TotalWeight = Convert.ToDouble(this.TotalWeight0.Value);
                proxy.DataC.TotalBulk = Convert.ToDouble(this.TotalBulk2.Value);
                proxy.DataC.TotalWeight = Convert.ToDouble(this.TotalWeight1.Value);
                foreach (CalculationFee_CalculationFeeLineRecord line in records)
				{
					CalculationFeeLineData dataline = new CalculationFeeLineData();
					dataline.RealDeliveryFactory = line.RealDeliveryFactory.Value;
					dataline.RealPricingMethod = line.RealPricingMethod.Value;
					dataline.PricingQty = (double)line.PricingQty;
					
					// 计价方式判断
					// 包车
					if (line.RealPricingMethod == 0)
					{
						dataline.PricingUom = 1002006191000011;
					}
					// 体积
					else if (line.RealPricingMethod == 1)
					{
						dataline.PricingUom = (long)line.BulkUom;
					}
					// 重量
					else
					{
						dataline.PricingUom = (long)line.WeightUom;
					}
					proxy.Dataline.Add(dataline);
				}

				CalculationFeeDTOData result = proxy.Do();
				CalculationFeeRecord record = this.Model.CalculationFee.FocusedRecord;
				CalculationFee_HuangdaoTotalRecord huangdao = this.Model.CalculationFee_HuangdaoTotal.FocusedRecord;
				CalculationFee_ChenyangTotalRecord chengyang = this.Model.CalculationFee_ChenyangTotal.FocusedRecord;
				huangdao.SetParentRecord(this.Model.CalculationFee.FocusedRecord);
				chengyang.SetParentRecord(this.Model.CalculationFee.FocusedRecord);
				// 费用赋值
				huangdao.DeliveryFee = result.HuangdaoTotal.DeliveryFee;
				huangdao.PickupFee = result.HuangdaoTotal.PickupFee;
				huangdao.TotalFreight = result.HuangdaoTotal.TotalFreight;
				huangdao.RealFreight = result.HuangdaoTotal.RealFreight;
				chengyang.DeliveryFee = result.ChenyangTotal.DeliveryFee;
				chengyang.PickupFee = result.ChenyangTotal.PickupFee;
				chengyang.TotalFreight = result.ChenyangTotal.TotalFreight;
				chengyang.RealFreight = result.ChenyangTotal.RealFreight;
				record.TotalAmount = result.TotalAmount;
				record.RealAmount = result.RealAmount;
				record.UintPrice = result.UintPrice;
				//this.Model.CalculationFee_ChenyangTotal.ClearCache();
				//this.Model.CalculationFee_HuangdaoTotal.ClearCache();

			}
			else
			{
				throw new Exception("请选择数据！");
			}

		}

		public class Cost
		{
			public string DocNo ;
			public long DocID;
			public int DocType;
			public double Amount;
        }
		// 手动费用分摊

		public List<CostsharingDTOData> SetSharing(object sender, EventArgs e)
		{
			List<CostsharingDTOData> costsharingDTOs = new List<CostsharingDTOData>();
			List<Cost> costs = (List<Cost>)this.CurrentState["NewCosts"];
			if (costs != null) 
			{
                foreach (Cost cost in costs)
                {
                    CostsharingDTOData costsharing = new CostsharingDTOData();
                    costsharing.DocID = cost.DocID;
                    costsharing.DocNo = cost.DocNo;
                    costsharing.DocType = cost.DocType;
                    costsharing.Amount = cost.Amount;
                    costsharingDTOs.Add(costsharing);
                }
                
            }

            return costsharingDTOs;
			
		}
        public (CalculationFeeData data, CalculationFeeTotalLineData dataH, CalculationFeeTotalLineData dataC) SetData(object sender, EventArgs e)
        {
            CalculationFeeData data = new CalculationFeeData();
            data.Sup = Convert.ToInt64(this.Sup0.Key);
            data.NumberOfTrucks = Convert.ToInt32(this.NumberOfTrucks0.Value);
            data.PricingMethod = (int)this.Model.CalculationFee.FocusedRecord.PricingMethod;
            data.ShipDate = Convert.ToDateTime(this.ShipDate0.Value);
            data.Contain = Convert.ToBoolean(this.Contain0.Value);
			data.Address = this.Model.CalculationFee.FocusedRecord.Address;
            data.Province = (long)this.Model.CalculationFee.FocusedRecord.Province.GetValueOrDefault(0);
            data.City = (long)this.Model.CalculationFee.FocusedRecord.City.GetValueOrDefault(0);
            data.County = (long)this.Model.CalculationFee.FocusedRecord.County.GetValueOrDefault(0);
            data.DescriLocation = this.Model.CalculationFee.FocusedRecord.DescriLocation;
			data.Remark = this.Model.CalculationFee.FocusedRecord.Remark;
            CalculationFeeTotalLineData huang = new CalculationFeeTotalLineData();
            CalculationFeeTotalLineData cheng = new CalculationFeeTotalLineData();
            huang.RealBulk = Convert.ToDouble(this.RealBulk0.Value);
            huang.RealWeight = Convert.ToDouble(this.RealWeight0.Value);
            huang.DeliveryFee = Convert.ToDouble(this.DeliveryFee0.Value);
            huang.DischargeFee = Convert.ToDouble(this.DischargeFee295.Value);
            huang.PickupFee = Convert.ToDouble(this.PickupFee0.Value);
            huang.OtherFee = Convert.ToDouble(this.OtherFee129.Value);
            huang.TotalFreight = Convert.ToDouble(this.TotalFreight192.Value);
			cheng.RealBulk = (double)this.Model.CalculationFee_ChenyangTotal.FocusedRecord.RealBulk;
            cheng.RealWeight = Convert.ToDouble(this.RealWeight1.Value);
            cheng.DeliveryFee = Convert.ToDouble(this.DeliveryFee1.Value);
            cheng.DischargeFee = Convert.ToDouble(this.DischargeFee296.Value);
            cheng.PickupFee = Convert.ToDouble(this.PickupFee1.Value);
            cheng.OtherFee = Convert.ToDouble(this.OtherFee130.Value);
            cheng.TotalFreight = Convert.ToDouble(this.TotalFreight193.Value);
            data.TotalAmount = (double)this.Model.CalculationFee.FocusedRecord.TotalAmount;
            data.RealAmount = (double)this.Model.CalculationFee.FocusedRecord.RealAmount;
            return (data, huang, cheng);
        }
        public List<CalculationFeeLineData> SetDataLine(object sender, EventArgs e)
		{
			IUIRecordCollection records = (IUIRecordCollection)this.Model.CalculationFee_CalculationFeeLine.Records;
			if (records.Count > 0)
			{
				List<CalculationFeeLineData> lines = new List<CalculationFeeLineData>();
				foreach (CalculationFee_CalculationFeeLineRecord line in records)
				{
					CalculationFeeLineData dataline = new CalculationFeeLineData();
					dataline.RealDeliveryFactory = line.RealDeliveryFactory.Value;
					dataline.RealPricingMethod = line.RealPricingMethod.Value;
					// 计价数量
					dataline.PricingQty = (double)line.PricingQty;
					// 销售数量
					dataline.Qty = (double)line.Qty;
                    // 计价方式判断
                    #region 计价单位
                    // 包车
                    if (line.RealPricingMethod == 0)
					{
						dataline.PricingUom = 1002006191000011;	
					}
					// 体积
					else if (line.RealPricingMethod == 1)
					{
						dataline.PricingUom= (long)line.BulkUom.GetValueOrDefault(0);
					}
					// 重量
					else
					{
						dataline.PricingUom = (long)line.WeightUom.GetValueOrDefault(0);
					}
					#endregion					
					dataline.Item = (long)line.Item.GetValueOrDefault(0) ;									
					dataline.WeightUom = (long)line.WeightUom.GetValueOrDefault(0);					
					dataline.BulkUom = (long)line.BulkUom.GetValueOrDefault(0);
					dataline.DocType = (int)line.DocType;
					dataline.DocID = (long)line.DocID.GetValueOrDefault(0);
					dataline.DocNo = line.DocNo;
					dataline.LineID = (long)line.LineID.GetValueOrDefault(0);
					lines.Add(dataline);
                }
                return lines;
			}
			return null;
		}
		private void ManualCostsharing0_Click_Extend(object sender, EventArgs e)
		{
			List<Cost> costs = new List<Cost>();
			List<string> docs = new List<string>();
			IUIRecordCollection records = this.Model.CalculationFee_CalculationFeeLine.Records;
			if (records.Count > 0)
			{
				foreach (CalculationFee_CalculationFeeLineRecord line in records)
				{
					if (!docs.Contains(line.DocNo))
					{
						docs.Add(line.DocNo);
						Cost cost = new Cost
						{
							DocNo = line.DocNo,
							DocID = (long)line.DocID,
							DocType = (int)line.DocType,
							Amount = Convert.ToDouble(this.RealAmount1.Value),
						};
						costs.Add(cost);
					}
				}
			}

			this.CurrentState["Costs"] = costs;

			this.ShowAtlasModalDialog(
									"e10e8c94-b8d6-40c1-98d3-38034456c854",
									"手动费用分摊", "872", "448",
									this.TaskId.ToString(),
									null, true, false, false);
		}
		private void SaveClick0_Click_Extend(object sender, EventArgs e)
		{
			IUIRecordCollection records = (IUIRecordCollection)this.Model.CalculationFee_CalculationFeeLine.Records;
			if (records.Count > 0)
			{
				CustLogisticsBP.Proxy.CreateRecordOperationProxy proxy = new CustLogisticsBP.Proxy.CreateRecordOperationProxy();
				proxy.Data = SetData(sender, e).data;
				proxy.DataC = SetData(sender, e).dataC;
				proxy.DataH = SetData(sender, e).dataH;
				proxy.Line = SetDataLine(sender, e);				
				proxy.Costsharing = SetSharing(sender, e);
				bool status = proxy.Do();
			}
		}
		private void Costsharing0_Click_Extend(object sender, EventArgs e)
		{
			List<Cost> costs = (List<Cost>)this.CurrentState["NewCosts"];
			if (costs.Count > 0)
			{

			}
			else {
				throw new Exception("未取到值,请分配费用后再试！");
			}
		}

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{	
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
            // 出货计划走扩展字段
            // 调出单走存储地点地址扩展出来
            // 派车数量
            CalculationFeeRecord record = this.Model.CalculationFee.FocusedRecord;
			record.NumberOfTrucks = 1;
			// 物流商
			if (this.CurrentSessionState["sup"] != null)
			{
				long sup = (long)this.CurrentSessionState["sup"];
				string sup_name = (string)this.CurrentSessionState["sup_name"];
				string sup_code = (string)this.CurrentSessionState["sup_code"];
				record.Sup = sup;
				record.Sup_Code = sup_code;
				record.Sup_Name = sup_name;
			}
			// 配送日期
			if (this.CurrentSessionState.ContainsKey("date"))
			{
				DateTime shipdate = (DateTime)this.CurrentSessionState["date"];
				record.ShipDate = shipdate;
			}
			else
			{
				DateTime shipdate = DateTime.Now.Date.AddDays(1);
				record.ShipDate = shipdate;
			}
			// 包含
			if (this.CurrentSessionState.ContainsKey("contain"))
			{
				if ((bool)this.CurrentSessionState["contain"] == false) record.Contain = false;
				else record.Contain = true;
			}
            // 省市区县查找赋值
			if (this.CurrentSessionState.ContainsKey("coun"))
			{
				string coun = (string)this.CurrentSessionState["coun"];
                #region 数据库查询省市区县
                DataSet ds = new DataSet();
                StringBuilder str = new StringBuilder();
                string queryFcoun = @"SELECT
								c.ID AS cid,
								c.Code AS ccode,
								c1.Name AS cname,
								b.ID AS tid,
								b.Code AS tcode,
								b1.Name AS tname, 
								p.ID AS pid,
								p.Code AS pcode,
								p1.Name AS pname
							FROM
								Base_County c
								INNER JOIN  Base_County_Trl c1 ON c.ID = c1.ID AND c.Effective_IsEffective = 1 
								INNER JOIN Base_City b ON c.City = b.ID AND b.Effective_IsEffective = 1
								INNER JOIN Base_City_Trl b1 ON b1.ID = b.ID
								INNER JOIN Base_Province p ON p.ID = b.Province AND p.Effective_IsEffective = 1
								INNER JOIN Base_Province_Trl p1 ON p.ID = p1.ID 
								WHERE c.Code = '" + coun + "'";
                str.Append(queryFcoun);
                DataAccessor.RunSQL(DataAccessor.GetConn(), str.ToString(), null, out ds);
                record.County = Convert.ToInt64(ds.Tables[0].Rows[0]["cid"]);
                record.County_Code = (string)ds.Tables[0].Rows[0]["ccode"];
                record.County_Name = (string)ds.Tables[0].Rows[0]["cname"];
                record.City = Convert.ToInt64(ds.Tables[0].Rows[0]["tid"]);
                record.City_Code = (string)ds.Tables[0].Rows[0]["tcode"];
                record.City_Name = (string)ds.Tables[0].Rows[0]["tname"];
                record.Province = Convert.ToInt64(ds.Tables[0].Rows[0]["pid"]);
                record.Province_Code = (string)ds.Tables[0].Rows[0]["pcode"];
                record.Province_Name = (string)ds.Tables[0].Rows[0]["pname"];

				#endregion
				if (this.CurrentSessionState.ContainsKey("desc"))
				{
					record.DescriLocation = (string)this.CurrentSessionState["desc"];
                    record.Address = record.Province_Name + record.City_Name + record.County_Name + record.DescriLocation;
                }
                else
				{ 
					 record.Address = record.Province_Name + record.City_Name + record.County_Name;
				}
               
            }
            else if (this.CurrentSessionState.ContainsKey("city"))
            {
                string city = (string)this.CurrentSessionState["city"];
                #region 数据库查询省市区县
                DataSet ds = new DataSet();
                StringBuilder str = new StringBuilder();
                string queryFcity = @"SELECT
								b.ID AS tid,
								b.Code AS tcode,
								b1.Name AS tname, 
								p.ID AS pid,
								p.Code AS pcode,
								p1.Name AS pname
							FROM
								Base_City b 
								INNER JOIN Base_City_Trl b1 ON b1.ID = b.ID
								INNER JOIN Base_Province p ON p.ID = b.Province AND p.Effective_IsEffective = 1
								INNER JOIN Base_Province_Trl p1 ON p.ID = p1.ID 
								WHERE b.Code = '" + city + "'"; 
                str.Append(queryFcity);
                DataAccessor.RunSQL(DataAccessor.GetConn(), str.ToString(), null, out ds);
                record.City = Convert.ToInt64(ds.Tables[0].Rows[0]["tid"]);
                record.City_Code = (string)ds.Tables[0].Rows[0]["tcode"];
                record.City_Name = (string)ds.Tables[0].Rows[0]["tname"];
                record.Province = Convert.ToInt64(ds.Tables[0].Rows[0]["pid"]);
                record.Province_Code = (string)ds.Tables[0].Rows[0]["pcode"];
                record.Province_Name = (string)ds.Tables[0].Rows[0]["pname"];
                #endregion
                if (this.CurrentSessionState.ContainsKey("desc"))
                {
                    record.DescriLocation = (string)this.CurrentSessionState["desc"];
                    record.Address = record.Province_Name + record.City_Name + record.DescriLocation;
                }
				else
                {
                    record.Address = record.Province_Name + record.City_Name;
                }
                

            }
            else if(this.CurrentSessionState.ContainsKey("pro"))
            {
                string pro = (string)this.CurrentSessionState["pro"];
                #region 数据库查询省市区县
                DataSet ds = new DataSet();
                StringBuilder str = new StringBuilder();
                string queryFpro = @"SELECT
								p.ID AS pid,
								p.Code AS pcode,
								p1.Name AS pname
							FROM
								Base_Province p
								INNER JOIN Base_Province_Trl p1 ON p.ID = p1.ID 
								WHERE p.Code = '" + pro + "'";
                str.Append(queryFpro);
                DataAccessor.RunSQL(DataAccessor.GetConn(), str.ToString(), null, out ds);
                record.Province = Convert.ToInt64(ds.Tables[0].Rows[0]["pid"]);
                record.Province_Code = (string)ds.Tables[0].Rows[0]["pcode"];
                record.Province_Name = (string)ds.Tables[0].Rows[0]["pname"];

                #endregion
                if (this.CurrentSessionState.ContainsKey("desc"))
                {
                    record.DescriLocation = (string)this.CurrentSessionState["desc"];
                    record.Address = record.Province_Name + record.DescriLocation;
                } 
				else
                {
                    record.Address = record.Province_Name;
                }
               

            }

        }

        public void AfterCreateChildControls()
        {
            
            //开启个性化     
			UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable((BaseWebForm)this, true);
            // 界面联动
            AllotQtyChangedCallBack();
			// 行变更，头数值自动计算
			Register_CallBack_Fee_DoCustomerAction();
			// 金额联动
			AllAmountChangedCallBack();
		}
		// 合计金额、结算金额联动
        private void AllAmountChangedCallBack()
        {
            //结合控件            
			UFSoft.UBF.UI.WebControls.Association.AssociationControl ac = new AssociationControl();   
			UFSoft.UBF.UI.WebControls.Association.AssociationControl ac1 = new AssociationControl();
            UFSoft.UBF.UI.WebControls.Association.AssociationControl ac2 = new AssociationControl();
            UFSoft.UBF.UI.WebControls.Association.AssociationControl ac3 = new AssociationControl();

            //设定触发源             
            ac.SourceServerControl = this.TotalFreight192; 
            ac1.SourceServerControl = this.TotalFreight193;

            ac2.SourceServerControl = this.RealFreight179;
            ac3.SourceServerControl = this.RealFreight180;
            //设定事件名称，经验证区分大小写，可查看portal\js\对应控件.js             
            ac.SourceControl.EventName = "OnValueChanged";
            ac1.SourceControl.EventName = "OnValueChanged";
            ac2.SourceControl.EventName = "OnValueChanged";
            ac3.SourceControl.EventName = "OnValueChanged";
            //查看事件的方法             
            //UFSoft.UBF.UI.WebControls.Association.UFCheckBoxEventName               
            //客户端刷新框架             
            ClientCallBackFrm cF = new ClientCallBackFrm();             
		   //加入相关控件（才可取其值）             
			cF.ParameterControls.Add(this.TotalFreight192);  
			cF.ParameterControls.Add(this.TotalFreight193); 
            cF.ParameterControls.Add(this.RealFreight179); 
            cF.ParameterControls.Add(this.RealFreight180); 
			cF.Add(ac);
			cF.Add(ac1);
			cF.Add(ac2);
			cF.Add(ac3);
			//加事件             
			cF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(TotalAmountChange);
        }

        private object TotalAmountChange(CustomerActionEventArgs args)
        {
            //通过args.ArgHash,取得控件值,可通过监视args.ArgsHash察看所含值             
			//callbackform中，通过ParameterControls.Add入的控件，才可用argshash得到其值             
			UFSoft.UBF.UI.ControlModel.IUFFldNumberControl f1 = (IUFFldNumberControl)this.TotalFreight192;  
			UFSoft.UBF.UI.ControlModel.IUFFldNumberControl f2 = (IUFFldNumberControl)this.TotalFreight193;
            UFSoft.UBF.UI.ControlModel.IUFFldNumberControl f3 = (IUFFldNumberControl)this.RealFreight179;
            UFSoft.UBF.UI.ControlModel.IUFFldNumberControl f4 = (IUFFldNumberControl)this.RealFreight180;
            object value1 = args.ArgsHash[f1.ClientID];  
			object value2 = args.ArgsHash[f2.ClientID];
            object value3 = args.ArgsHash[f3.ClientID];
            object value4 = args.ArgsHash[f4.ClientID];

            //用于设置控件值，建立适配器，才能改变它的值             
            UFWebClientNumberAdapter a1 = new UFWebClientNumberAdapter(this.TotalAmount0);
			UFWebClientNumberAdapter a2 = new UFWebClientNumberAdapter(this.RealAmount1);

			decimal result = Convert.ToDecimal(value1) +  Convert.ToDecimal(value2);
            decimal result1 = Convert.ToDecimal(value3) +  Convert.ToDecimal(value4);
			a1.Value = result.ToString();
			a2.Value = result1.ToString();
			//加入client端实例，与上面的赋值属性对应             
			args.ArgsResult.Add(a1.ClientInstanceWithValue);
			args.ArgsResult.Add(a2.ClientInstanceWithValue);
			          
			return args;
            
        }

        private void AllotQtyChangedCallBack()
		{
			AssociationControl gridCellDataChangedASC = new AssociationControl();       //基本固定代码
			gridCellDataChangedASC.SourceServerControl = this.DataGrid0;
			gridCellDataChangedASC.SourceControl.EventName = "OnCellDataChanged";
			//CallBack处理方案
			((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("RealPricingMethod");

			ClientCallBackFrm gridCellDataChangedCBF = new ClientCallBackFrm();
			gridCellDataChangedCBF.ParameterControls.Add(this.DataGrid0);

			gridCellDataChangedCBF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(AllotQtyChange);
			gridCellDataChangedCBF.Add(gridCellDataChangedASC);
			this.Controls.Add(gridCellDataChangedCBF);



		}
		///<summary>
		/// 表格的CallBack处理方式，返回结果
		///</summary>
		///<param name="args"></param>
		///<returns></returns>
		private object AllotQtyChange(CustomerActionEventArgs args)
		{
			this.Model.CalculationFee.ClearErrorMessage();
			UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid0);
			//UFWebClientGridAdapter head = new UFWebClientGridAdapter(this.Card7);

			//取表格数据（当前行）
			ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows]; //基本固定代码
			int curIndex = int.Parse(list[0].ToString());
			Hashtable table = (Hashtable)((ArrayList)args.ArgsHash[this.DataGrid0.ClientID])[curIndex];
			int basis = int.Parse(table["RealPricingMethod"].ToString()); //行计价依据
			string uom_bulk = table["BulkUom_Name"].ToString();
			string uom_weight = table["WeightUom_Name"].ToString();
			string uom_vehicle = "辆";

			// 选择计价依据后，计价单位变更，行合计变更
			switch (basis)
			{
				// 0: 包车 1:体积 2:重量
				case 0:
					grid.CellValue.Add(new object[] { curIndex, "PricingUom",
						new string[] { uom_vehicle.ToString(), uom_vehicle.ToString(), uom_vehicle.ToString() } });
					grid.CellValue.Add(new object[] { curIndex, "PricingQty",
						new string[] { "1", "1","1"} });
					break;
				case 1:
					grid.CellValue.Add(new object[] { curIndex, "PricingUom",
						new string[] { uom_bulk.ToString(), uom_bulk.ToString(), uom_bulk.ToString() } });
					grid.CellValue.Add(new object[] { curIndex, "PricingQty",
						new string[] { table["IBulk"].ToString(), table["IBulk"].ToString(), table["IBulk"].ToString() } });

					break;
				case 2:
					grid.CellValue.Add(new object[] { curIndex, "PricingUom",
						new string[] { uom_weight.ToString(), uom_weight.ToString(), uom_weight.ToString() } });
					grid.CellValue.Add(new object[] { curIndex, "PricingQty",
						new string[] { table["Weight"].ToString(), table["Weight"].ToString(), table["Weight"].ToString() } });
					break;
				default:
					grid.CellValue.Add(new object[] { curIndex, "PricingUom",
						new string[] { uom_bulk.ToString(), uom_bulk.ToString(), uom_bulk.ToString() } });
					grid.CellValue.Add(new object[] { curIndex, "PricingQty",
						new string[] { table["IBulk"].ToString(), table["IBulk"].ToString(), table["IBulk"].ToString() } });
					break;
			}
			args.ArgsResult.Add(grid.ClientInstanceWithValue);
			return args;
		}

		private void Register_CallBack_Fee_DoCustomerAction()
		{
			//结合控件b
			AssociationControl[] ac = new AssociationControl[] { new AssociationControl(), new AssociationControl() };
			//设定触发源（可以设定多个，如多事件触发） 
			ac[0].SourceServerControl = (UFSoft.UBF.UI.ControlModel.IUFDataGrid)this.DataGrid0;
			ac[1].SourceServerControl = (UFSoft.UBF.UI.ControlModel.IUFDataGrid)this.DataGrid0;
			//设定事件名称，经验证区分大小写，可查看portal\js\对应控件.js
			//事件名参考\Portal\js\DataGrid.js， 节点             
			//DataGrid事件，OnBeforeCellFocusEnter等验证能触发，也有很多不能触发             
			ac[0].SourceControl.EventName = "OnCellDataChanged";
			//由于OnAfterRowDeleted不能触发（即删行时计算，所以改为删行后，焦点在第一列，触发）             
			ac[1].SourceControl.EventName = "OnCellFocusEnter";             
			//查看事件的方法 
			//UFSoft.UBF.UI.WebControls.Association.UFDateGridEventName.OnAfterRowDeleted             
			//OnAfterRowAdded：自动增行触发             
			//OnCellFocusEnter：Cell获得焦点时触发   
			//加入触发事件的列名，先转成Adapter                                                                                                                                                                   //事件名参考\Portal\js\DataGrid.js，<!--DataGrid控件事件名称常量定义-->节点  //DataGrid事件，OnBeforeCellFocusEnter等验证能触发，也有很多不能触发 ac[0].SourceControl.EventName ="OnCellDataChanged";
			//由于OnAfterRowDeleted不能触发（即删行时计算，所以改为删行后，焦点在第一列，触发） 
			//ac[1].SourceControl.EventName ="OnCellFocusEnter"; 
			//查看事件的方法 
			//UFSoft.UBF.UI.WebControls.Association.UFDateGridEventName.OnAfterRowDeleted 
			//OnAfterRowAdded：自动增行触发  
			//OnCellFocusEnter：Cell获得焦点时触发   
			//加入触发事件的列名，先转成Adapter
			UFWebClientGridAdapter[] adapter = new UFWebClientGridAdapter[] { null, null };
			//值改变的触发列 
			adapter[0] = ((UFWebClientGridAdapter)ac[0].SourceControl);
			adapter[0].FireEventCols.Add("RealPricingMethod");
			adapter[1] = ((UFWebClientGridAdapter)ac[0].SourceControl);
			adapter[1].FireEventCols.Add("RealDeliveryFactory");
			//获取焦点的触发列 
			//adapter[1] = ((UFWebClientGridAdapter)ac[1].SourceControl);
			//adapter[1].FireEventCols.Add("LineTotal");
			//客户端刷新框架 
			ClientCallBackFrm cF = new ClientCallBackFrm(); 
			//加入相关控件（才可取其值） 
			cF.ParameterControls.Add((IUFControl)this.DataGrid0);
			cF.Add(ac[0]);
			cF.Add(ac[1]);
			//加事件 
			cF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(CallBack_Fee_DoCustomerAction);
			cF.Add(ac[0]);

			this.Controls.Add(cF);

		}

		//段3：事件执行内容。 
		private object CallBack_Fee_DoCustomerAction(CustomerActionEventArgs args)
		{
			//说明 
			//取参值，可通过监视args.ArgsHash得出所需及所有的值 
			//callbackform中，通过ParameterControls.Add入的控件，才可用argshash得到其值  
			//curIndex为当前datagrid行，u_M_p0_DataGrid8_ALL_GRIDDATA_FocusRow以此取值 
			//可以用args.ArgsHas方法，取焦点行：args.ArgsHash[this.DataGrid8.ClientID + "_ALL_GRIDDATA_FocusRow"]; 
			//取值示例,hashtable
			//(Hashtable)((ArrayList)args.ArgsHash[this.DataGrid2.ClientID])[curIndex]; 
			//合计值 
			decimal Hbulk = 0;
			decimal Hweight = 0;
			decimal Cbulk = 0;
			decimal Cweight = 0;

			//所有值 
			ArrayList al1 = ((ArrayList)args.ArgsHash[this.DataGrid0.ClientID]); //计算所有值之和 
			for (int i = 0; i < al1.Count; i++)
			{
				Hashtable ht1 = (Hashtable)al1[i];
				if (ht1["RealPricingMethod"].ToString() == "1")
				{
					if((string)ht1["RealDeliveryFactory"] == "0") Hbulk += Convert.ToDecimal(ht1["PricingQty"]);
					else Cbulk += Convert.ToDecimal(ht1["PricingQty"]);
				}
				else if (ht1["RealPricingMethod"].ToString() == "2")
				{
					if ((string)ht1["RealDeliveryFactory"] == "0") Hweight += Convert.ToDecimal(ht1["PricingQty"]);
					else Cweight += Convert.ToDecimal(ht1["PricingQty"]);
				}

			}
			// 黄岛
			UFWebClientNumberAdapter Hbt = new UFWebClientNumberAdapter(this.TotalBulk0);
			UFWebClientNumberAdapter Hwt = new UFWebClientNumberAdapter(this.TotalWeight0);
			Hbt.Value = Hbulk.ToString();
			Hwt.Value = Hweight.ToString();
			UFWebClientNumberAdapter Hbr = new UFWebClientNumberAdapter(this.RealBulk0);
			UFWebClientNumberAdapter Hwr = new UFWebClientNumberAdapter(this.RealWeight0);
			Hbr.Value = Hbulk.ToString();
			Hwr.Value = Hweight.ToString();
			args.ArgsResult.Add(Hbt.ClientInstanceWithValue);
			args.ArgsResult.Add(Hwt.ClientInstanceWithValue);
			args.ArgsResult.Add(Hbr.ClientInstanceWithValue);
			args.ArgsResult.Add(Hwr.ClientInstanceWithValue);

			// 城阳
			UFWebClientNumberAdapter Cbt = new UFWebClientNumberAdapter(this.TotalBulk2);
			UFWebClientNumberAdapter Cwt = new UFWebClientNumberAdapter(this.TotalWeight1);
			Cbt.Value = Cbulk.ToString();
			Cwt.Value = Cweight.ToString();
			UFWebClientNumberAdapter Cbr = new UFWebClientNumberAdapter(this.RealBulk1);
			UFWebClientNumberAdapter Cwr = new UFWebClientNumberAdapter(this.RealWeight1);
			Cbr.Value = Cbulk.ToString();
			Cwr.Value = Cweight.ToString();
			args.ArgsResult.Add(Cbt.ClientInstanceWithValue);
			args.ArgsResult.Add(Cwt.ClientInstanceWithValue);
			args.ArgsResult.Add(Cbr.ClientInstanceWithValue);
			args.ArgsResult.Add(Cwr.ClientInstanceWithValue);

			return args;
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