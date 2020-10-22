








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.BLT.CustLogisticsBP.IDeleteRecordOperation")]
    public interface IDeleteRecordOperation
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
		System.Boolean Do(IContext context, out IList<MessageBase> outMessages ,List<System.Int64> data);
    }
	[Serializable]    
    public class DeleteRecordOperationProxy : OperationProxyBase//, UFIDA.U9.Cust.BLT.CustLogisticsBP.Proxy.IDeleteRecordOperation
    {
	#region Fields	
				private List<System.Int64> data ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// ID集合 (该属性可为空,且无默认值)
		/// 删除关联表操作.Misc.ID集合
		/// </summary>
		/// <value></value>
		public List<System.Int64> Data
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
        public DeleteRecordOperationProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.Boolean Do()
        {
  			InitKeyList() ;
 			System.Boolean result = (System.Boolean)InvokeAgent<UFIDA.U9.Cust.BLT.CustLogisticsBP.Proxy.IDeleteRecordOperation>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IDeleteRecordOperation channel = oChannel as IDeleteRecordOperation;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, data);
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
					
		}
		#endregion 

    }
}



