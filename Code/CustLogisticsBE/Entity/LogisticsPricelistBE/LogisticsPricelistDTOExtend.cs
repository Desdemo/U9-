



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE {

	public partial class LogisticsPricelistDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public LogisticsPricelistDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.String code  , System.String name  , UFIDA.U9.CBO.SCM.Supplier.Supplier sup  , UFIDA.U9.Base.Currency.Currency currency  , List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTO> logisticsPricelistLine  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.Code = code;
			this.Name = name;
			this.Sup = sup;
			this.Currency = currency;
			this.LogisticsPricelistLine = logisticsPricelistLine;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
