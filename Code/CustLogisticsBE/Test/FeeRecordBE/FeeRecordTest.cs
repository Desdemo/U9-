
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE.TestSuite{

	/// <summary>
	/// FeeRecord Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class FeeRecordTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void FeeRecordCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateFeeRecord
										obj  = UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(FeeRecord).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord.EntityList list = UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveFeeRecord	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord).ToString() + "> failed.");
			}
		*/
		}
	}
}

