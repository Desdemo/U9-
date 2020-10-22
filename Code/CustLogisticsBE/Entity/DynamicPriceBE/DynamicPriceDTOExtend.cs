



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE {

	public partial class DynamicPriceDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public DynamicPriceDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.String code  , UFIDA.U9.Base.UOM.UOM uom  , System.String remark  , List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTO> dynamicPriceLine  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum dynamicPriceType  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.Code = code;
			this.Uom = uom;
			this.Remark = remark;
			this.DynamicPriceLine = dynamicPriceLine;
			this.DynamicPriceType = dynamicPriceType;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
