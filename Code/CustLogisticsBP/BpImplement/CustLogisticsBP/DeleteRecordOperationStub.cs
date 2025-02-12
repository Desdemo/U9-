﻿







namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using System.IO;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
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
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,List<System.Int64> data);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class DeleteRecordOperationStub : OperationStubBase, IDeleteRecordOperation
    {
        #region IDeleteRecordOperation Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, List<System.Int64> data)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, data);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, List<System.Int64> data)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.BLT.CustLogisticsBP.DeleteRecordOperation");                
                DeleteRecordOperation objectRef = new DeleteRecordOperation();
	
				objectRef.Data = data;

				//处理返回类型.
				System.Boolean result = objectRef.Do();
				return result ;
						return result;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.BLT.CustLogisticsBP.DeleteRecordOperation");
            }
        }
	#endregion
    }
}
