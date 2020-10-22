namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ServiceModel.Channels;
    using System.Text;
    using UFIDA.U9.Cust.BLT.CustLogisticsBE;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Util.Security;
    using ISession = UFSoft.UBF.Business.ISession;

    /// <summary>
    /// CreateRecordOperation partial 
    /// </summary>	
    public partial class CreateRecordOperation 
	{	
		internal BaseStrategy Select()
		{
			return new CreateRecordOperationImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CreateRecordOperationImpementStrategy : BaseStrategy
	{
		public CreateRecordOperationImpementStrategy() { }

		public override object Do(object obj)
		{						
			CreateRecordOperation bpObj = (CreateRecordOperation)obj;

			//get business operation context is as follows
			//IContext context = ContextManager.Context	

			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			// 1、先校验  有就更新 没有就创建
			if (bpObj != null)
			{ 
				CalculationFee calculation = bpObj.Data;
                CalculationFeeTotalLine huang = bpObj.DataH;
                CalculationFeeTotalLine cheng = bpObj.DataC;
                ArrayList docs = new ArrayList();
				Dictionary<int, int> types = new Dictionary<int, int> { { 0, 0 }, { 1, 0 } };
				using (ISession session = Session.Open())
				{
                    #region 费用记录表
                    FeeRecord fee = FeeRecord.Create();
					fee.Supplier = calculation.Sup;
					fee.IBulk = (decimal)(huang.RealBulk + cheng.RealBulk);
					fee.Weight = (decimal)(huang.RealWeight + cheng.RealWeight);
					fee.PickupFee = (decimal)(huang.PickupFee + cheng.PickupFee);
					fee.DischargeFee = (decimal)(huang.DischargeFee + cheng.DischargeFee);
					fee.DeliveryFee = (decimal)(huang.DeliveryFee + cheng.DeliveryFee);
					fee.OtherFee = (decimal)(huang.OtherFee + cheng.OtherFee);
					fee.StandardShipping = (decimal)(huang.TotalFreight + cheng.TotalFreight);
					fee.TotalFreight = (decimal)calculation.TotalAmount;
					fee.RealFreight = (decimal)calculation.RealAmount;
					fee.Remark = calculation.Remark;
					fee.Province = calculation.Province;
                    fee.City = calculation.City;
                    fee.County = calculation.County;
                    fee.DescribeAddress = calculation.DescriLocation;
                    fee.FullAddress = calculation.Address;
					fee.AverageCost = (decimal)calculation.UintPrice;
					fee.ShipDate = calculation.ShipDate;
					// 业务类型判断
					fee.BusinessType = BusinessTypeEnum.Normal;
                    // 行信息合计
                    foreach (CalculationFeeLine line in bpObj.Line)
                    {
                        #region  根据料品判断商品类别和数量
                        if (line.Item.Name.Contains("液袋"))
                        {
                            types[0] = types[0] + (int)line.Qty;
                        }
                        else
                        {
                            types[1] = types[1] + (int)line.Qty;
                        }
                        #endregion
                        #region 单号、跟单
                        // 单位：取第一行单位
                        if (fee.WeightUom == null)
                        {
                            fee.WeightUom = line.WeightUom;
                            fee.BulkUom = line.BulkUom;
                        }

                        // 来源单据类型：出货计划
                        if (line.DocType.Value == 1)
                        {
                            // 出货计划查找
                            SM.ShipPlan.ShipPlanLine planline = SM.ShipPlan.ShipPlanLine.Finder.FindByID(line.LineID);
                            if (planline != null)
                            {
                                if (!docs.Contains(planline.SrcDocNo))
                                {
                                    docs.Add(planline.SrcDocNo);
                                }
                                UFIDA.U9.SM.SO.SO so = SM.SO.SO.Finder.Find("DocNo='" + planline.SrcDocNo + "'");
                                if (so != null)
                                {
                                    // 跟单
                                    if (fee.Salesman == "")
                                    {
                                        fee.Salesman = so.Seller.Name;
                                        fee.ContactPhone = so.DescFlexField.PubDescSeg7;
                                        fee.CustomerContact = so.DescFlexField.PubDescSeg6;
                                    }
                                }
                            }
                        }
                        else
                        {
                            // 联系人、电话
                            if (fee.CustomerContact == null)
                            {
                                InvDoc.TransferOut.TransOutSubLine subline = InvDoc.TransferOut.TransOutSubLine.Finder.FindByID(line.LineID);
                                if (subline != null)
                                {
                                    string contactCode = subline.TransInWh.DescFlexField.PrivateDescSeg3;
                                    Base.Contact.Contact contact = Base.Contact.Contact.Finder.Find("Code='" + contactCode + "'");
                                    if (contact != null)
                                    {
                                        fee.CustomerContact = contact.Name;
                                        if (contact.DefaultMobilNum == "")
                                        {
                                            fee.ContactPhone = contact.DefaultPhoneNum;
                                        }
                                        else
                                        {
                                            fee.ContactPhone = contact.DefaultMobilNum;
                                        }
                                    }
                                }
                            }
                            // 调出单查询
                            InvDoc.TransferOut.TransferOut transfer = InvDoc.TransferOut.TransferOut.Finder.Find("DocNo='" + line.DocNo + "'");
                            if (transfer != null)
                            {
                                #region 异地库备货
                                // 扩展字段为订单号
                                string docno = transfer.DescFlexField.PubDescSeg16;
                                if (docno != null)
                                {
                                    if (!docs.Contains(docno))
                                    {
                                        docs.Add(docno);
                                    }
                                    // 查询销售订单
                                    UFIDA.U9.SM.SO.SO so = SM.SO.SO.Finder.Find("DocNo='" + docno + "'");
                                    if (so != null)
                                    {
                                        // 跟单
                                        if (fee.Salesman == "")
                                        {
                                            fee.Salesman = so.Seller.Name;
                                        }
                                    }

                                }
                                // todo:工厂间调拨是否设置
                                else
                                {
                                    throw new Exception("调出单:" + transfer.DocNo + "未找到对应的订单号，请检查");
                                }
                                #endregion
                            }
                        }
                        #endregion
                    }
                    // 单号
                    foreach (string doc in docs)
                    {
                        fee.SaleNo = fee.SaleNo + doc;
                    }
                    // 商品类别
                    if (types[0] > 0 && types[1] > 0)
                    {
                        fee.ProductCategory = ProductCategoryEnum.EnumValue;
                    }
                    else if (types[0] > 0 && types[1] == 0)
                    {
                        fee.ProductCategory = ProductCategoryEnum.Liquid;
                    }
                    else
                    {
                        fee.ProductCategory = ProductCategoryEnum.Accessories;
                    }
                    // 数量
                    if (types[0] > 0)
                    {
                        fee.Qty = types[0];
                    }
                    else
                    {
                        fee.Qty = types[1];
                    }
                    fee.AverageCost = fee.RealFreight / fee.Qty;
                    #endregion
                    
                    session.Commit();
					return true;
				}
			}
			return false;
		}

    }

	#endregion
	
	
}