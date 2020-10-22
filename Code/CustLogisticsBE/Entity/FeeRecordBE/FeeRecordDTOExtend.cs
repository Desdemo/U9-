



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE {

	public partial class FeeRecordDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public FeeRecordDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum businessType  , System.String salesman  , String customerContact  , System.String contactPhone  , System.DateTime shipDate  , System.String saleNo  , UFIDA.U9.CBO.SCM.Supplier.Supplier supplier  , System.Double qty  , UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum productCategory  , UFIDA.U9.Base.Location.Province province  , UFIDA.U9.Base.Location.Location location  , System.Double iBulk  , System.Double weight  , UFIDA.U9.Base.UOM.UOM bulkUom  , UFIDA.U9.Base.UOM.UOM weightUom  , System.Double pickupFee  , System.Double deliveryFee  , System.Double dischargeFee  , System.Double otherFee  , System.Double standardShipping  , System.Double totalFreight  , System.Double realFreight  , System.Double averageCost  , System.Double uintPrice  , System.String remark  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.BusinessType = businessType;
			this.Salesman = salesman;
			this.CustomerContact = customerContact;
			this.ContactPhone = contactPhone;
			this.ShipDate = shipDate;
			this.SaleNo = saleNo;
			this.Supplier = supplier;
			this.Qty = qty;
			this.ProductCategory = productCategory;
			this.Province = province;
			this.IBulk = iBulk;
			this.Weight = weight;
			this.BulkUom = bulkUom;
			this.WeightUom = weightUom;
			this.PickupFee = pickupFee;
			this.DeliveryFee = deliveryFee;
			this.DischargeFee = dischargeFee;
			this.OtherFee = otherFee;
			this.StandardShipping = standardShipping;
			this.TotalFreight = totalFreight;
			this.RealFreight = realFreight;
			this.AverageCost = averageCost;
			this.UintPrice = uintPrice;
			this.Remark = remark;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
