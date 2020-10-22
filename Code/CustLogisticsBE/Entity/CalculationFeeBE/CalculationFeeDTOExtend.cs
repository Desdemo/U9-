



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE {

	public partial class CalculationFeeDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CalculationFeeDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , UFIDA.U9.CBO.SCM.Supplier.Supplier sup  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum deliveryFactory  , UFIDA.U9.Base.Location.Location address  , System.DateTime shipDate  , UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum pricingMethod  , System.Double totalAmount  , System.Double realAmount  , System.Double uintPrice  , System.String remark  , System.Boolean contain  , System.Int32 numberOfTrucks  , List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO> calculationFeeLine  , UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine huangdaoTotal  , UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine chenyangTotal  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.Sup = sup;
			this.DeliveryFactory = deliveryFactory;
			this.Address = address;
			this.ShipDate = shipDate;
			this.PricingMethod = pricingMethod;
			this.TotalAmount = totalAmount;
			this.RealAmount = realAmount;
			this.UintPrice = uintPrice;
			this.Remark = remark;
			this.Contain = contain;
			this.NumberOfTrucks = numberOfTrucks;
			this.CalculationFeeLine = calculationFeeLine;
			this.HuangdaoTotal = huangdaoTotal;
			this.ChenyangTotal = chenyangTotal;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
