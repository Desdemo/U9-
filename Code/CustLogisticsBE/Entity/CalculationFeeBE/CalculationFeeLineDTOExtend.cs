



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE {

	public partial class CalculationFeeLineDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CalculationFeeLineDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.String docNo  , System.Int64 docID  , System.Int64 lineID  , UFIDA.U9.CBO.SCM.Item.ItemMaster item  , System.Double qty  , UFIDA.U9.Base.UOM.UOM salesUom  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum realDeliveryFactory  , UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum realPricingMethod  , System.Double iBulk  , UFIDA.U9.Base.UOM.UOM bulkUom  , System.Double weight  , UFIDA.U9.Base.UOM.UOM weightUom  , System.Double pricingQty  , UFIDA.U9.Base.UOM.UOM pricingUom  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum docType  , UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTO calculationFee  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.DocNo = docNo;
			this.DocID = docID;
			this.LineID = lineID;
			this.Item = item;
			this.Qty = qty;
			this.SalesUom = salesUom;
			this.RealDeliveryFactory = realDeliveryFactory;
			this.RealPricingMethod = realPricingMethod;
			this.IBulk = iBulk;
			this.BulkUom = bulkUom;
			this.Weight = weight;
			this.WeightUom = weightUom;
			this.PricingQty = pricingQty;
			this.PricingUom = pricingUom;
			this.DocType = docType;
			this.CalculationFee = calculationFee;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
