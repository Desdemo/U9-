








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.BLT.CustLogisticsBP.IQueryOperation")]
    public interface IQueryOperation
    {
		[ServiceKnownType(typeof(ApplicationContext))]
		[ServiceKnownType(typeof(PlatformContext))]
		[ServiceKnownType(typeof(ThreadContext))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.BusinessException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.EntityNotExistException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.AttributeInValidException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Business.AttrsContainerException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Exceptions.MessageBase))]
			[FaultContract(typeof(UFSoft.UBF.Service.ServiceLostException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceExceptionDetail))]
		[FaultContract(typeof(ExceptionBase))]
		[FaultContract(typeof(Exception))]
		[OperationContract()]
		List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> Do(IContext context, out IList<MessageBase> outMessages ,UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data);
    }
	[Serializable]    
    public class QueryOperationProxy : OperationProxyBase//, UFIDA.U9.Cust.BLT.CustLogisticsBP.Proxy.IQueryOperation
    {
	#region Fields	
				private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 传入参数 (该属性可为空,且无默认值)
		/// 查询操作.Misc.传入参数
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
        public QueryOperationProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> result = (List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData>)InvokeAgent<UFIDA.U9.Cust.BLT.CustLogisticsBP.Proxy.IQueryOperation>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IQueryOperation channel = oChannel as IQueryOperation;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, data);
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



