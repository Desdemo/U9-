



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsBP {

	public partial class CostsharingDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CostsharingDTO(  System.Int64 docID  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum docType  , System.String docNo  , System.Double amount  )
		{
			this.DocID = docID;
			this.DocType = docType;
			this.DocNo = docNo;
			this.Amount = amount;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
