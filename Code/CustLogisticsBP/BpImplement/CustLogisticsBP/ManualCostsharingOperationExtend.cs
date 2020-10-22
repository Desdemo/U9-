namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	using System;
	using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.BLT.CustLogisticsBE;
    using UFIDA.U9.SM.QuantityEngine;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ManualCostsharingOperation partial 
	/// </summary>	
	public partial class ManualCostsharingOperation 
	{	
		internal BaseStrategy Select()
		{
			return new ManualCostsharingOperationImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ManualCostsharingOperationImpementStrategy : BaseStrategy
	{
		public ManualCostsharingOperationImpementStrategy() { }

		public override object Do(object obj)
		{						
			ManualCostsharingOperation bpObj = (ManualCostsharingOperation)obj;

			//get business operation context is as follows
			//IContext context = ContextManager.Context	

			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			if (bpObj != null)
			{
				if (bpObj.Data.Count >= 1)
				{
					using (ISession session = Session.Open())
					{
						foreach (CostsharingDTO ship in bpObj.Data)
						{
							// 先查找关联表 有就更新,没有就创建
							// 查找 出货计划单/调出单 回写金额
							// 看有没有回写的
							FeeRecordLinked linked = FeeRecordLinked.Finder.Find("SrcDocID = " + ship.DocID);
							if (linked != null)
							{
								linked.Amount = ship.Amount;
								if (linked.DeliveryID != 0)
								{
									UFIDA.U9.InvDoc.DeliveryTask.DeliveryTask delivery = InvDoc.DeliveryTask.DeliveryTask.Finder.FindByID(linked.DeliveryID);
									if (delivery != null)
									{
										delivery.ApplyLoadFee = (decimal)ship.Amount;
										delivery.ApplyTotalFee = (decimal)ship.Amount;
										delivery.AffirmLoadFee = (decimal)ship.Amount;
										delivery.AffirmTotalFee = (decimal)ship.Amount;
									}
								}
							}
							else
							{
								linked = FeeRecordLinked.Create();
								linked.SrcType = ship.DocType;
								linked.SrcDocID = ship.DocID;
								linked.Amount = ship.Amount;
								linked.SrcDocNo = ship.DocNo;
								// 1为出货计划
								if (ship.DocType.Value == 1)
								{
									SM.ShipPlan.ShipPlan shipPlan;
									if (ship.DocID != 0)
									{
										shipPlan = SM.ShipPlan.ShipPlan.Finder.FindByID(ship.DocID);
									}
									else
									{
										shipPlan = SM.ShipPlan.ShipPlan.Finder.Find("DocNo ='" + ship.DocNo + "'");
									}
									if (shipPlan != null)
									{
										// 运费回写
										shipPlan.DescFlexField.PubDescSeg18 = ship.Amount.ToString();
										//shipPlan.SetValue("DescFlexField_PubDescSeg18",ship.Amount);

									}
								}
								// 调出单
								else
								{
									InvDoc.TransferOut.TransferOut transfer = InvDoc.TransferOut.TransferOut.Finder.Find("DocNo = '" + ship.DocNo + "'");
									if (transfer != null)
									{
										//transfer.DescFlexField.PubDescSeg18 = ship.Amount.ToString();
                                        transfer.SetValue("DescFlexField_PubDescSeg18",ship.Amount.ToString());

									}
								}
							}
							session.Commit();
						}
					}
				}
				return true;
			}
			else
			{
				return false;
			}
		}		
	}

	#endregion
	
	
}