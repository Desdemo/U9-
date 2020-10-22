





namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 手动费用分摊操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ManualCostsharingOperation
	{
	    #region Fields
		private List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTO> data;
		
	    #endregion
		
	    #region constructor
		public ManualCostsharingOperation()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 数据	
		/// 手动费用分摊操作.Misc.数据
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTO> Data
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
		public System.Boolean Do()
		{	
		    BaseStrategy selector = Select();	
				System.Boolean result =  (System.Boolean)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
