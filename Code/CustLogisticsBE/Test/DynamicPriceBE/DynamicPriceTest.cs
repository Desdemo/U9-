
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE.TestSuite{

	/// <summary>
	/// DynamicPrice Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class DynamicPriceTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void DynamicPriceCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateDynamicPrice
										obj  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(DynamicPrice).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.EntityList list = UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveDynamicPrice	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice).ToString() + "> failed.");
			}
		*/
		}
	}
}

