





namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 删除关联表操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class DeleteRecordOperation
	{
	    #region Fields
		private List<System.Int64> data;
		
	    #endregion
		
	    #region constructor
		public DeleteRecordOperation()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// ID集合	
		/// 删除关联表操作.Misc.ID集合
		/// </summary>
		/// <value></value>
		public List<System.Int64> Data
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
