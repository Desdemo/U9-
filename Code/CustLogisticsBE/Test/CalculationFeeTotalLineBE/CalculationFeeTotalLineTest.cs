
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE.TestSuite{

	/// <summary>
	/// CalculationFeeTotalLine Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class CalculationFeeTotalLineTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void CalculationFeeTotalLineCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateCalculationFeeTotalLine
										obj  = UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(CalculationFeeTotalLine).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityList list = UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveCalculationFeeTotalLine	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine).ToString() + "> failed.");
			}
		*/
		}
	}
}

