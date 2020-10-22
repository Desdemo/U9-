
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE.TestSuite{

	/// <summary>
	/// DynamicPriceLine Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class DynamicPriceLineTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void DynamicPriceLineCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateDynamicPriceLine
					
					obj  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.Create() ;
					UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine n_dynamicpriceline =UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine.Create(obj) ;


					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(DynamicPriceLine).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.EntityList list = UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveDynamicPriceLine	
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

