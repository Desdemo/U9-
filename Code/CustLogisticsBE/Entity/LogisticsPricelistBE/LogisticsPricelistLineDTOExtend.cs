



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE {

	public partial class LogisticsPricelistLineDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public LogisticsPricelistLineDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.Int32 no  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum deliveryFactory  , UFIDA.U9.Base.Location.Location address  , UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum pricingMethod  , UFIDA.U9.Base.UOM.UOM pricingUom  , System.Double uintPrice  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice dynamicPrice  , System.Double deliveryPickup  , System.Double deliveryCharges  , System.Double freePickup  , System.Double freeDelivery  , System.String transportationTime  , System.String remark  , UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTO logisticsPricelist  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.No = no;
			this.DeliveryFactory = deliveryFactory;
			this.Address = address;
			this.PricingMethod = pricingMethod;
			this.PricingUom = pricingUom;
			this.UintPrice = uintPrice;
			this.DynamicPrice = dynamicPrice;
			this.DeliveryPickup = deliveryPickup;
			this.DeliveryCharges = deliveryCharges;
			this.FreePickup = freePickup;
			this.FreeDelivery = freeDelivery;
			this.TransportationTime = transportationTime;
			this.Remark = remark;
			this.LogisticsPricelist = logisticsPricelist;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
