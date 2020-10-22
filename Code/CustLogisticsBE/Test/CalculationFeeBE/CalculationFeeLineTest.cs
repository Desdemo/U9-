
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE.TestSuite{

	/// <summary>
	/// CalculationFeeLine Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class CalculationFeeLineTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void CalculationFeeLineCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateCalculationFeeLine
					
					obj  = UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.Create() ;
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine n_calculationfeeline =UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine.Create(obj) ;


					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(CalculationFeeLine).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.EntityList list = UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveCalculationFeeLine	
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

