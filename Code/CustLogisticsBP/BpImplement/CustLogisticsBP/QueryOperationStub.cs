







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
        List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class QueryOperationStub : OperationStubBase, IQueryOperation
    {
        #region IQueryOperation Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> Do(IContext context ,out IList<MessageBase> outMessages, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, data);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> DoEx(ICommonDataContract commonData, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.BLT.CustLogisticsBP.QueryOperation");                
                QueryOperation objectRef = new QueryOperation();
	
				DeSerializeKey(data);
				if (data != null)
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee temp = null;
					if (data.ID > 0)
					{
						if (data.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							temp = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.EntityKey(data.ID).GetEntity();
						if (temp == null)//创建实体, 不在当前的Session中.
							temp= (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SysEntityType, null, data.ID, false);
					}
					else
					{
						temp = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SysEntityType, null, null, false);
					}
					temp.FromEntityData(data);
					objectRef.Data = temp;
				}
		
				//处理返回类型.
				List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> list = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData>();
				foreach (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.BLT.CustLogisticsBP.QueryOperation");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.BLT.CustLogisticsBP.QueryOperation");
            }
        }
	#endregion
    }
}
