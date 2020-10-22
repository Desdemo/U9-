
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE.TestSuite{

	/// <summary>
	/// CalculationFee Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class CalculationFeeTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void CalculationFeeCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateCalculationFee
										obj  = UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(CalculationFee).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.EntityList list = UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveCalculationFee	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee).ToString() + "> failed.");
			}
		*/
		}
	}
}

