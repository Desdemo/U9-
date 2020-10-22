





namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 根据扩展字段查询操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class QueryDescOperation
	{
	    #region Fields
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee data;
		
	    #endregion
		
	    #region constructor
		public QueryDescOperation()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 传入参数	
		/// 根据扩展字段查询操作.Misc.传入参数
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
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO> result =  (List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
