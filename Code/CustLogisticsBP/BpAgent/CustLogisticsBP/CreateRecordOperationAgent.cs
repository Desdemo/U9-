








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.BLT.CustLogisticsBP.ICreateRecordOperation")]
    public interface ICreateRecordOperation
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
		System.Boolean Do(IContext context, out IList<MessageBase> outMessages ,UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data, List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTOData> costsharing, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataH, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataC, List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> line);
    }
	[Serializable]    
    public class CreateRecordOperationProxy : OperationProxyBase//, UFIDA.U9.Cust.BLT.CustLogisticsBP.Proxy.ICreateRecordOperation
    {
	#region Fields	
				private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data ;
						private List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTOData> costsharing ;
						private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataH ;
						private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataC ;
						private List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> line ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 数据 (该属性可为空,且无默认值)
		/// 保存记录操作.Misc.数据
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
		/// 费用关联 (该属性可为空,且无默认值)
		/// 保存记录操作.Misc.费用关联
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTOData> Costsharing
		{
			get	
			{	
				return this.costsharing;
			}

			set	
			{	
				this.costsharing = value;	
			}
		}		
						

		/// <summary>
		/// 黄岛合计 (该属性可为空,且无默认值)
		/// 保存记录操作.Misc.黄岛合计
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
		/// 城阳合计 (该属性可为空,且无默认值)
		/// 保存记录操作.Misc.城阳合计
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
						

		/// <summary>
		/// 行合计 (该属性可为空,且无默认值)
		/// 保存记录操作.Misc.行合计
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> Line
		{
			get	
			{	
				return this.line;
			}

			set	
			{	
				this.line = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public CreateRecordOperationProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.Boolean Do()
        {
  			InitKeyList() ;
 			System.Boolean result = (System.Boolean)InvokeAgent<UFIDA.U9.Cust.BLT.CustLogisticsBP.Proxy.ICreateRecordOperation>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ICreateRecordOperation channel = oChannel as ICreateRecordOperation;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, data, costsharing, dataH, dataC, line);
	    }
            return  false;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private System.Boolean GetRealResult(System.Boolean result)
		{

				return result ;
		}
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
											{
				if (Costsharing!=null)
				{
					foreach(UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTOData objdata in Costsharing)
					{
						objdata.DoSerializeKeyList(dict);
					}
				}
			}
																	
		}
		#endregion 

    }
}



