
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE.TestSuite{

	/// <summary>
	/// FeeRecordLinked Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class FeeRecordLinkedTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void FeeRecordLinkedCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateFeeRecordLinked
										obj  = UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(FeeRecordLinked).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked.EntityList list = UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveFeeRecordLinked	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked).ToString() + "> failed.");
			}
		*/
		}
	}
}

