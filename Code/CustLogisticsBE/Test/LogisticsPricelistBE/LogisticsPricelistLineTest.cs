
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE.TestSuite{

	/// <summary>
	/// LogisticsPricelistLine Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class LogisticsPricelistLineTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void LogisticsPricelistLineCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateLogisticsPricelistLine
					
					obj  = UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.Create() ;
					UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine n_logisticspricelistline =UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine.Create(obj) ;


					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(LogisticsPricelistLine).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityList list = UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveLogisticsPricelistLine	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist).ToString() + "> failed.");
			}
		*/
		}
	}
}

