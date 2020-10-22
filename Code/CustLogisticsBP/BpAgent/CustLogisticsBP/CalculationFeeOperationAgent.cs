








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.BLT.CustLogisticsBP.ICalculationFeeOperation")]
    public interface ICalculationFeeOperation
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
		UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTOData Do(IContext context, out IList<MessageBase> outMessages ,UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data, List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> dataline, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataH, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataC);
    }
	[Serializable]    
    public class CalculationFeeOperationProxy : OperationProxyBase//, UFIDA.U9.Cust.BLT.CustLogisticsBP.Proxy.ICalculationFeeOperation
    {
	#region Fields	
				private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data ;
						private List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> dataline ;
						private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataH ;
						private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataC ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 费用计算 (该属性可为空,且无默认值)
		/// 费用计算操作.Misc.费用计算
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
						

		/// <summary>
		/// 费用计算行 (该属性可为空,且无默认值)
		/// 费用计算操作.Misc.费用计算行
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> Dataline
		{
			get	
			{	
				return this.dataline;
			}

			set	
			{	
				this.dataline = value;	
			}
		}		
						

		/// <summary>
		/// 黄岛费用合计 (该属性可为空,且无默认值)
		/// 费用计算操作.Misc.黄岛费用合计
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData DataH
		{
			get	
			{	
				return this.dataH;
			}

			set	
			{	
				this.dataH = value;	
			}
		}		
						

		/// <summary>
		/// 城阳费用合计 (该属性可为空,且无默认值)
		/// 费用计算操作.Misc.城阳费用合计
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData DataC
		{
			get	
			{	
				return this.dataC;
			}

			set	
			{	
				this.dataC = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public CalculationFeeOperationProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTOData Do()
        {
  			InitKeyList() ;
 			UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTOData result = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTOData)InvokeAgent<UFIDA.U9.Cust.BLT.CustLogisticsBP.Proxy.ICalculationFeeOperation>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ICalculationFeeOperation channel = oChannel as ICalculationFeeOperation;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, data, dataline, dataH, dataC);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTOData GetRealResult(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTOData result)
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



