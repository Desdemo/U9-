





namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 费用计算操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CalculationFeeOperation
	{
	    #region Fields
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee data;
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine.EntityList dataline;
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine dataH;
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine dataC;
		
	    #endregion
		
	    #region constructor
		public CalculationFeeOperation()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 费用计算	
		/// 费用计算操作.Misc.费用计算
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee Data
		{
			get
			{
				return this.data;
			}
			set
			{
				data = value;
			}
		}
		/// <summary>
		/// 费用计算行	
		/// 费用计算操作.Misc.费用计算行
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine.EntityList Dataline
		{
			get
			{
				return this.dataline;
			}
			set
			{
				dataline = value;
			}
		}
		/// <summary>
		/// 黄岛费用合计	
		/// 费用计算操作.Misc.黄岛费用合计
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine DataH
		{
			get
			{
				return this.dataH;
			}
			set
			{
				dataH = value;
			}
		}
		/// <summary>
		/// 城阳费用合计	
		/// 费用计算操作.Misc.城阳费用合计
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine DataC
		{
			get
			{
				return this.dataC;
			}
			set
			{
				dataC = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTO result =  (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
