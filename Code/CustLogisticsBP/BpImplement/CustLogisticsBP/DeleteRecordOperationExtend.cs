namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
    using UFIDA.U9.Cust.BLT.CustLogisticsBE;
    using UFIDA.U9.SM.SMBE.PreShipBE.PreShipDealSN;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;

	/// <summary>
	/// DeleteRecordOperation partial 
	/// </summary>	
	public partial class DeleteRecordOperation 
	{	
		internal BaseStrategy Select()
		{
			return new DeleteRecordOperationImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class DeleteRecordOperationImpementStrategy : BaseStrategy
	{
		public DeleteRecordOperationImpementStrategy() { }

		public override object Do(object obj)
		{						
			DeleteRecordOperation bpObj = (DeleteRecordOperation)obj;

			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			if (bpObj.Data.Count > 0)
			{
				
				return true;
            }


			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}