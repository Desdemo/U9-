namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.DataAccess;

    /// <summary>
    /// QueryOperation partial 
    /// </summary>	
    public partial class QueryOperation
    {
        internal BaseStrategy Select()
        {
            return new QueryOperationImpementStrategy();
        }
    }

    #region  implement strategy	
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class QueryOperationImpementStrategy : BaseStrategy
    {
        public QueryOperationImpementStrategy() { }

        public override object Do(object obj)
        {
            QueryOperation bpObj = (QueryOperation)obj;

            //get business operation context is as follows
            //IContext context = ContextManager.Context	



            //auto generating code end,underside is user custom code
            //and if you Implement replace this Exception Code...
            // throw new NotImplementedException();
            // 供应商 日期 工厂 送货位置  包含
            // 两种查询方式 
            // 1、 按照地址 
            CustLogisticsBE.CalculationFee cal = bpObj.Data;
            if (cal != null)
            {
                List<string> condition_shipplan = new List<string>();
                List<string> condition_transout = new List<string>();
                // 物流供应商
                string SupCode = cal.Sup.Code; 
                string query_s_sup = "l.Supplier_Code =  '" + SupCode + "'";
                string query_t_sup = "sup1.Code =  '" + SupCode + "' ";
                condition_shipplan.Add(query_s_sup);
                condition_transout.Add(query_t_sup);
                // 地址(待定)
                //Int64 LocationID = cal.Address.ID;
                //string query_s_location = "c.OfficeSite = " + LocationID;
                //string query_t_location = "lt.ID =  " + LocationID;
                //condition_shipplan.Add(query_s_location);
                //condition_transout.Add(query_t_location);
                // 包含计算过订单
                if (!cal.Contain)
                {
                    string query_t_con = " t.DescFlexField_PubDescSeg18 = '' ";
                    string query_s_con = " p.DescFlexField_PubDescSeg18 = '' ";
                    condition_shipplan.Add(query_t_con);
                    condition_transout.Add(query_s_con);
                }
                // 出货日期
                string date = date = Convert.ToDateTime(cal.ShipDate).ToString("yyyy-MM-dd");
                string query_s_date = " CONVERT(VARCHAR, l.PlanDate , 23) = '" + date + "'";
                string query_t_date = " CONVERT(VARCHAR, s.PlanSendDate, 23) = '" + date + "'";
                condition_shipplan.Add(query_s_date);
                condition_transout.Add(query_t_date);
                // 数据库查询
                DataSet ds = new DataSet();
                StringBuilder str = new StringBuilder();
                // 出货计划查询
                string base_shipplan = @" SELECT
										l.ShipOrg AS ShipOrg,
										org.Code AS OrgCode,
										orgt.Name AS OrgName,
										p.DocNo AS DocNo,
										p.ID AS DocNoID,
										l.ID AS DocLineID,
										l.PlanDate AS ShipDate,
										l.Supplier_Supplier AS SupID,
										l.Supplier_Code AS SupCode,
										sup.Name AS SupName,
										l.ItemInfo_ItemID AS Item,
										l.ItemInfo_ItemCode AS Item_Code,
										l.ItemInfo_ItemName AS Item_Name,
										l.PlanQtyTU AS Qty,
										l.PriceUom AS PriceUom,
										uo.Code AS PriceUom_Code,
										u.Name AS PriceUom_Name,
										l.Volume AS lBulk,
										l.Weight AS Weight,
										l.VolumeUom AS BulkUom,
										uom2.Code AS BulkUom_Code,
										uom.Name AS BulkUom_Name,
										l.WeightUom AS WeightUom,
										uom3.Code AS WeightUom_Code,
										uom1.Name AS WeightUom_Name,
										c.OfficeSite AS Address,
										l.ShipToSite_Code AS Address_Code,
										a.Name AS Address_Name 
									FROM
										SM_ShipPlanLine AS l
										LEFT JOIN SM_ShipPlan AS p ON p.ID = l.ShipPlan
										LEFT JOIN CBO_Supplier_Trl AS sup ON sup.ID = l.Supplier_Supplier
										LEFT JOIN CBO_CustomerSite AS c ON c.Code = l.ShipToSite_Code
										LEFT JOIN Base_UOM_Trl AS u ON l.PriceUom = u.ID
										LEFT JOIN Base_UOM AS uo ON l.PriceUom = uo.ID
										LEFT JOIN Base_Location_Trl AS a ON a.ID = c.OfficeSite
										LEFT JOIN CBO_ItemMaster AS item ON item.ID = l.ItemInfo_ItemID
										LEFT JOIN Base_UOM_Trl uom ON uom.ID = item.BulkUom
										LEFT JOIN Base_UOM_Trl uom1 ON uom1.ID = item.WeightUom
										LEFT JOIN Base_UOM uom2 ON uom2.ID = item.BulkUom
										LEFT JOIN Base_UOM uom3 ON uom3.ID = item.WeightUom
										LEFT JOIN CBO_ReceivalTerm AS r ON r.ID = c.Paymentterm 
										LEFT JOIN Base_Organization AS org ON l.ShipOrg = org.ID
										LEFT JOIN Base_Organization_Trl AS orgt ON l.ShipOrg = orgt.ID 
										";
                // 调出单查询
                string base_transout = @"SELECT
										l.TransOutOrg AS ShipOrg,
										org.Code AS OrgCode,
										orgt.Name AS OrgName,
										t.DocNo AS DocNo,
										t.ID AS DocNoID,
										s.ID AS DocLineID,
										s.PlanSendDate AS ShipDate,
										s.Carrier AS SupID,
										sup1.Code AS SupCode,
										sup.Name AS SupName,
										s.ItemInfo_ItemID AS Item,
										s.ItemInfo_ItemCode AS Item_Code,
										s.ItemInfo_ItemName AS Item_Name,
										s.PriceUOMQty AS Qty,
										s.PriceUOM AS PriceUom,
										u.Code AS PriceUom_Code,
										ul.Name AS PriceUom_Name,
										s.StoreBulk AS IBulk,
										s.StoreWeight AS Weight,
										s.VolumeUom AS BulkID,
										u2.Code AS BulkCode,
										ul2.Name AS BulkName,
										s.WeightUom AS WeightUomID,
										u3.Code AS WeightUomCode,
										ul3.Name AS WeightUomName,
										lt.ID AS Address,
										loc.Code AS Address_Code,
										lt.Name AS Address_Name
									FROM
										InvDoc_TransOutSubLine AS s 
										LEFT JOIN InvDoc_TransOutLine l ON l.ID = s.TransOutLine 
										LEFT JOIN InvDoc_TransferOut AS t ON l.TransferOut = t.ID 
										LEFT JOIN Base_UOM_Trl ul ON ul.ID = s.PriceUOM
										LEFT JOIN Base_UOM u ON u.ID = s.PriceUOM
										LEFT JOIN Base_UOM_Trl ul2 ON ul2.ID = s.VolumeUom
										LEFT JOIN Base_UOM u2 ON u2.ID = s.VolumeUom
										LEFT JOIN Base_UOM_Trl ul3 ON ul3.ID = s.WeightUom
										LEFT JOIN Base_UOM u3 ON u3.ID = s.WeightUom
										LEFT JOIN CBO_Wh w ON w.ID = s.TransInWh 
										left JOIN Base_Location_Trl lt ON lt.ID = w.Location 
										left JOIN Base_Location loc ON loc.ID = w.Location 
										LEFT JOIN CBO_Supplier_Trl AS sup ON sup.ID = s.Carrier 
										LEFT JOIN CBO_Supplier AS sup1 ON sup1.ID = s.Carrier  
										LEFT JOIN Base_Organization AS org ON l.TransOutOrg = org.ID 
										LEFT JOIN Base_Organization_Trl AS orgt ON l.TransOutOrg = orgt.ID				
										";
                string Qtransout = " WHERE s.Carrier != '' AND sup.SysMLFlag = 'zh-CN' AND ul.SysMLFlag = 'zh-CN'  AND orgt.SysMLFlag = 'zh-CN'  ";
                string uion = " UNION ALL ";
                string Qshipplan = " where  u.SysMLFlag = 'zh-CN'AND sup.SysMLFlag = 'zh-CN' AND orgt.SysMLFlag = 'zh-CN'  ";

                foreach (string con in condition_shipplan)
                {
                    Qshipplan = Qshipplan + " and " + con;
                }
                foreach (string con in condition_transout)
                {
                    Qtransout = Qtransout + " and " + con;
                }

                #region 提货工厂过滤
                //if ((string)this.DeliveryFactory0.Value != "")
                //{
                //	// Loaction :1001611210000092 黄岛
                //	//			 1001611210000089 城阳
                //	// Org:	1001611210000834  黄岛
                //	//		1001611210000609 城阳 
                //	// 黄岛 
                //	if ((string)this.DeliveryFactory0.Value == "0")
                //	{
                //		condition_shipplan = condition_shipplan + " and l.ShipOrg = 1001611210000834 ";
                //		conditong_transout = conditong_transout + " and l.TransOutOrg = 1001611210000834 ";
                //	}
                //	// 城阳
                //	else
                //	{
                //		condition_shipplan = condition_shipplan + " and l.ShipOrg = 1001611210000609 ";
                //		conditong_transout = conditong_transout + "  and l.TransOutOrg = 1001611210000609";
                //	}
                //}
                #endregion
                str.Append(base_shipplan);
                str.Append(Qshipplan);
                str.Append(uion);
                str.Append(base_transout);
                str.Append(Qtransout);
                DataAccessor.RunSQL(DataAccessor.GetConn(), str.ToString(), null, out ds);
              
                List<CustLogisticsBE.CalculationFeeLineDTO> lines = new List<CustLogisticsBE.CalculationFeeLineDTO>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    CustLogisticsBE.CalculationFeeLineDTO line = new CustLogisticsBE.CalculationFeeLineDTO();
                    // 单号
                    line.DocNo = Convert.ToString(dr["DocNo"]);
                    line.DocID = Convert.ToInt64(dr["DocNoID"]);
                    // 来源单据类型
                    if (line.DocNo.StartsWith("SH")) line.DocType = CustLogisticsBE.DocTypeEnum.ShipPlan;
                    else line.DocType = CustLogisticsBE.DocTypeEnum.TransferOut;
                    //// 行ID
                    line.LineID = Convert.ToInt64(dr["DocLineID"]);
                    //// 送货工厂
                    if ((string)dr["OrgCode"] == "H1004H") line.RealDeliveryFactory = CustLogisticsBE.DeliveryFactoryEnum.H1004H;
                    else line.RealDeliveryFactory = CustLogisticsBE.DeliveryFactoryEnum.C1003C;
                    //// 料品
                    line.Item = CBO.SCM.Item.ItemMaster.Finder.FindByID(Convert.ToInt64(dr["Item"]));

                    // 数量
                    line.Qty = Convert.ToInt32(dr["Qty"]);
                    // 重量
                    line.Weight = (double)line.Item.Weight * line.Qty;
                    // 体积
                    line.IBulk = (double)line.Item.ItemBulk * line.Qty;
                    //// 销售单位
                    line.SalesUom = line.Item.SalesUOM;
                    // 体积单位
                    line.BulkUom = line.Item.BulkUom;
                    line.WeightUom = line.Item.WeightUom;
                    // 计价依据枚举
                    line.RealPricingMethod = cal.PricingMethod;
                    switch (cal.PricingMethod.Value)
                    {
                        // 0: 包车 1:体积 2:重量
                        case 0:
                            line.PricingUom = UFIDA.U9.Base.UOM.UOM.Finder.Find("Name = '辆'");
                            line.PricingQty = 1;
                            break;
                        case 1:
                            line.PricingUom = line.BulkUom;
                            line.PricingQty = line.IBulk;
                            break;
                        case 2:
                            line.PricingUom = line.WeightUom;
                            line.PricingQty = line.Weight;
                            break;
                        default:
                            line.PricingUom = line.BulkUom;
                            line.PricingQty = line.IBulk;
                            break;
                    }
                    lines.Add(line);
                }
                return lines;
            }
            return null;
        }
    }

    #endregion


}