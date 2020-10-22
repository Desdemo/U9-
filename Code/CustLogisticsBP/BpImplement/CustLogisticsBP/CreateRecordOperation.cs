





namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 保存记录操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateRecordOperation
	{
	    #region Fields
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee data;
		private List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTO> costsharing;
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine dataH;
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine dataC;
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine.EntityList line;
		
	    #endregion
		
	    #region constructor
		public CreateRecordOperation()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 数据	
		/// 保存记录操作.Misc.数据
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
		/// 费用关联	
		/// 保存记录操作.Misc.费用关联
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTO> Costsharing
		{
			get
			{
				return this.costsharing;
			}
			set
			{
				costsharing = value;
			}
		}
		/// <summary>
		/// 黄岛合计	
		/// 保存记录操作.Misc.黄岛合计
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
		/// 城阳合计	
		/// 保存记录操作.Misc.城阳合计
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
		/// <summary>
		/// 行合计	
		/// 保存记录操作.Misc.行合计
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine.EntityList Line
		{
			get
			{
				return this.line;
			}
			set
			{
				line = value;
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
