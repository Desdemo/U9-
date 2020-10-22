



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE {

	public partial class DynamicPriceLineDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public DynamicPriceLineDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.Int32 no  , System.Double unitPrice  , System.Double start  , System.Double cutoff  , System.Double total  , System.String remark  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceDTO dynamicPrice  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.No = no;
			this.UnitPrice = unitPrice;
			this.Start = start;
			this.Cutoff = cutoff;
			this.Total = total;
			this.Remark = remark;
			this.DynamicPrice = dynamicPrice;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
