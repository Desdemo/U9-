



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE {

	public partial class CalculationFeeTotalLineDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CalculationFeeTotalLineDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.Double totalBulk  , System.Double totalWeight  , System.Double realBulk  , System.Double realWeight  , System.Double pickupFee  , System.Double deliveryFee  , System.Double dischargeFee  , System.Double otherFee  , System.Double totalFreight  , System.Double realFreight  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.TotalBulk = totalBulk;
			this.TotalWeight = totalWeight;
			this.RealBulk = realBulk;
			this.RealWeight = realWeight;
			this.PickupFee = pickupFee;
			this.DeliveryFee = deliveryFee;
			this.DischargeFee = dischargeFee;
			this.OtherFee = otherFee;
			this.TotalFreight = totalFreight;
			this.RealFreight = realFreight;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
