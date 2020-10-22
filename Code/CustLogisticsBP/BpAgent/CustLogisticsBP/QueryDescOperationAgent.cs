








namespace UFIDA.U9.Cust.BLT.CustLogisticsBP.Proxy
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.IO;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF.Service;
	using UFSoft.UBF.Service.Base ;

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.BLT.CustLogisticsBP.IQueryDescOperation")]
    public interface IQueryDescOperation
    {
		[OperationContract()]
		List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> Do(UFSoft.UBF.Service.ISVContext context ,UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data);
    }
	[Serializable]    
    public class QueryDescOperationProxy : OperationProxyBase//, UFIDA.U9.Cust.BLT.CustLogisticsBP.Proxy.IQueryDescOperation
    {
	#region Fields	
				private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 传入参数 (该属性可为空,且无默认值)
		/// 根据扩展字段查询操作.Misc.传入参数
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData Data
		{
			get	
			{	
				return this.data;
			}

			set	
			{	
				this.data = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public QueryDescOperationProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> result = (List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData>)InvokeAgent<UFIDA.U9.Cust.BLT.CustLogisticsBP.Proxy.IQueryDescOperation>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IQueryDescOperation channel = oChannel as IQueryDescOperation;
            if (channel != null)
            {
				UFSoft.UBF.Service.ISVContext isvContext =  GetISVContext(context);
				return channel.Do(isvContext , data);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> GetRealResult(List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> result)
		{
								return result ;
			}
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
					
		}
		#endregion 

    }
}



