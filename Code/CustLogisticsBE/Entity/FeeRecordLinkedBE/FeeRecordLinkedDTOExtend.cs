



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE {

	public partial class FeeRecordLinkedDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public FeeRecordLinkedDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum type  , System.Int64 docID  , System.Double amount  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.SrcType = type;
			this.SrcDocID = docID;
			this.Amount = amount;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
