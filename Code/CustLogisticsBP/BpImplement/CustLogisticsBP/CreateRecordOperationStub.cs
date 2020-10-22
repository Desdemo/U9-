







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
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data, List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTOData> costsharing, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataH, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataC, List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> line);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CreateRecordOperationStub : OperationStubBase, ICreateRecordOperation
    {
        #region ICreateRecordOperation Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data, List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTOData> costsharing, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataH, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataC, List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> line)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, data, costsharing, dataH, dataC, line);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData data, List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTOData> costsharing, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataH, UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData dataC, List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> line)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.BLT.CustLogisticsBP.CreateRecordOperation");                
                CreateRecordOperation objectRef = new CreateRecordOperation();
					
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
		
				if (costsharing != null)
				{
					DeSerializeKey(costsharing);
					List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTO> listCostsharing = new List<UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTO>();
					foreach (UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTOData obj in costsharing)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTO child = new UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listCostsharing.Add(child);
					}
					objectRef.Costsharing = listCostsharing;
				}
				DeSerializeKey(dataH);
				if (dataH != null)
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine temp = null;
					if (dataH.ID > 0)
					{
						if (dataH.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							temp = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey(dataH.ID).GetEntity();
						if (temp == null)//创建实体, 不在当前的Session中.
							temp= (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(dataH.SysEntityType, null, dataH.ID, false);
					}
					else
					{
						temp = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(dataH.SysEntityType, null, null, false);
					}
					temp.FromEntityData(dataH);
					objectRef.DataH = temp;
				}
						DeSerializeKey(dataC);
				if (dataC != null)
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine temp = null;
					if (dataC.ID > 0)
					{
						if (dataC.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							temp = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey(dataC.ID).GetEntity();
						if (temp == null)//创建实体, 不在当前的Session中.
							temp= (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(dataC.SysEntityType, null, dataC.ID, false);
					}
					else
					{
						temp = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(dataC.SysEntityType, null, null, false);
					}
					temp.FromEntityData(dataC);
					objectRef.DataC = temp;
				}
		
				if (line != null)
				{
					DeSerializeKey(line);
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine.EntityList listLine = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine.EntityList();
					foreach (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData obj in line)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine child = null;
						if (obj.ID > 0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine.EntityKey(obj.ID).GetEntity();
							if (child == null)
								child =  (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType, null, obj.ID, false);
						}
						else
						{
							child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType, null, null, false);					 
						}
						child.FromEntityData(obj);
						listLine.Add(child);
									}
					objectRef.Line = listLine;
				}

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
				FinallyInvoke("UFIDA.U9.Cust.BLT.CustLogisticsBP.CreateRecordOperation");
            }
        }
	#endregion
    }
}
