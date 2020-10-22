

namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.IO;
	using NUnit.Framework;
	
	/// <summary>
	/// Business operation test
	/// </summary> 
	[TestFixture]		
	public class CreateRecordOperationTest
	{
		private Proxy.CreateRecordOperationProxy obj = new Proxy.CreateRecordOperationProxy();

		public CreateRecordOperationTest()
		{
		}
		#region AutoTestCode ...
		[Test]
		public void TestDo()
		{
			obj.Do() ;  
		
		}
		#endregion 				
	}
	
}