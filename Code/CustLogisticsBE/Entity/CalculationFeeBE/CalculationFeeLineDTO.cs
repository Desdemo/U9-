


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用计算行数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CalculationFeeLineDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CalculationFeeLineDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
		
					DocID = 0; 
					LineID = 0; 
		
					Qty = 0; 
		
					RealDeliveryFactory =UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum.GetFromValue(-1); 
					RealPricingMethod =UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.GetFromValue(0); 
					IBulk = 0; 
		
					Weight = 0; 
		
					PricingQty = 0; 
		
					DocType =UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.GetFromValue(0); 
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 费用计算行数据传输对象.Key.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ID",value);
			}
		}
				/// <summary>
		/// 创建时间 (该属性可为空,且无默认值)
		/// 费用计算行数据传输对象.Sys.创建时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime CreatedOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("CreatedOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("CreatedOn",value);
			}
		}
				/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 费用计算行数据传输对象.Sys.创建人
		/// </summary>
		/// <value>System.String</value>
		public System.String CreatedBy
		{
			get	
			{	
				return (System.String)base.GetValue("CreatedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CreatedBy",value);
			}
		}
				/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 费用计算行数据传输对象.Sys.修改时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ModifiedOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ModifiedOn",value);
			}
		}
				/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 费用计算行数据传输对象.Sys.修改人
		/// </summary>
		/// <value>System.String</value>
		public System.String ModifiedBy
		{
			get	
			{	
				return (System.String)base.GetValue("ModifiedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ModifiedBy",value);
			}
		}
				/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 费用计算行数据传输对象.Sys.事务版本
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SysVersion
		{
			get	
			{	
				return (System.Int64)base.GetValue("SysVersion",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SysVersion",value);
			}
		}
				/// <summary>
		/// 单号 (该属性可为空,且无默认值)
		/// 费用计算行数据传输对象.Misc.单号
		/// </summary>
		/// <value>System.String</value>
		public System.String DocNo
		{
			get	
			{	
				return (System.String)base.GetValue("DocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocNo",value);
			}
		}
				/// <summary>
		/// 单号ID (该属性可为空,但有默认值)
		/// 费用计算行数据传输对象.Misc.单号ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 DocID
		{
			get	
			{	
				return (System.Int64)base.GetValue("DocID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("DocID",value);
			}
		}
				/// <summary>
		/// 行ID (该属性可为空,但有默认值)
		/// 费用计算行数据传输对象.Misc.行ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 LineID
		{
			get	
			{	
				return (System.Int64)base.GetValue("LineID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("LineID",value);
			}
		}
				/// <summary>
		/// 料品 (该属性可为空,且无默认值)
		/// 费用计算行数据传输对象.Misc.料品
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemMaster</value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster Item
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemMaster)base.GetValue("Item",typeof(UFIDA.U9.CBO.SCM.Item.ItemMaster));
			}

			 set	
			{
				base.SetValue("Item",value);
			}
		}
				/// <summary>
		/// 销售数量 (该属性可为空,但有默认值)
		/// 费用计算行数据传输对象.Misc.销售数量
		/// </summary>
		/// <value>System.Double</value>
		public System.Double Qty
		{
			get	
			{	
				return (System.Double)base.GetValue("Qty",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("Qty",value);
			}
		}
				/// <summary>
		/// 销售单位 (该属性可为空,且无默认值)
		/// 费用计算行数据传输对象.Misc.销售单位
		/// </summary>
		/// <value>UFIDA.U9.Base.UOM.UOM</value>
		public UFIDA.U9.Base.UOM.UOM SalesUom
		{
			get	
			{	
				return (UFIDA.U9.Base.UOM.UOM)base.GetValue("SalesUom",typeof(UFIDA.U9.Base.UOM.UOM));
			}

			 set	
			{
				base.SetValue("SalesUom",value);
			}
		}
				/// <summary>
		/// 实际提货工厂 (该属性可为空,但有默认值)
		/// 费用计算行数据传输对象.Misc.实际提货工厂
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum RealDeliveryFactory
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum)base.GetValue("RealDeliveryFactory",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum));
			}

			 set	
			{
				base.SetValue("RealDeliveryFactory",value);
			}
		}
				/// <summary>
		/// 实际计价方式 (该属性可为空,但有默认值)
		/// 费用计算行数据传输对象.Misc.实际计价方式
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum RealPricingMethod
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum)base.GetValue("RealPricingMethod",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum));
			}

			 set	
			{
				base.SetValue("RealPricingMethod",value);
			}
		}
				/// <summary>
		/// 体积 (该属性可为空,但有默认值)
		/// 费用计算行数据传输对象.Misc.体积
		/// </summary>
		/// <value>System.Double</value>
		public System.Double IBulk
		{
			get	
			{	
				return (System.Double)base.GetValue("IBulk",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("IBulk",value);
			}
		}
				/// <summary>
		/// 体积单位 (该属性可为空,且无默认值)
		/// 费用计算行数据传输对象.Misc.体积单位
		/// </summary>
		/// <value>UFIDA.U9.Base.UOM.UOM</value>
		public UFIDA.U9.Base.UOM.UOM BulkUom
		{
			get	
			{	
				return (UFIDA.U9.Base.UOM.UOM)base.GetValue("BulkUom",typeof(UFIDA.U9.Base.UOM.UOM));
			}

			 set	
			{
				base.SetValue("BulkUom",value);
			}
		}
				/// <summary>
		/// 重量 (该属性可为空,但有默认值)
		/// 费用计算行数据传输对象.Misc.重量
		/// </summary>
		/// <value>System.Double</value>
		public System.Double Weight
		{
			get	
			{	
				return (System.Double)base.GetValue("Weight",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("Weight",value);
			}
		}
				/// <summary>
		/// 重量单位 (该属性可为空,且无默认值)
		/// 费用计算行数据传输对象.Misc.重量单位
		/// </summary>
		/// <value>UFIDA.U9.Base.UOM.UOM</value>
		public UFIDA.U9.Base.UOM.UOM WeightUom
		{
			get	
			{	
				return (UFIDA.U9.Base.UOM.UOM)base.GetValue("WeightUom",typeof(UFIDA.U9.Base.UOM.UOM));
			}

			 set	
			{
				base.SetValue("WeightUom",value);
			}
		}
				/// <summary>
		/// 计价数量 (该属性可为空,但有默认值)
		/// 费用计算行数据传输对象.Misc.计价数量
		/// </summary>
		/// <value>System.Double</value>
		public System.Double PricingQty
		{
			get	
			{	
				return (System.Double)base.GetValue("PricingQty",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("PricingQty",value);
			}
		}
				/// <summary>
		/// 计价单位 (该属性可为空,且无默认值)
		/// 费用计算行数据传输对象.Misc.计价单位
		/// </summary>
		/// <value>UFIDA.U9.Base.UOM.UOM</value>
		public UFIDA.U9.Base.UOM.UOM PricingUom
		{
			get	
			{	
				return (UFIDA.U9.Base.UOM.UOM)base.GetValue("PricingUom",typeof(UFIDA.U9.Base.UOM.UOM));
			}

			 set	
			{
				base.SetValue("PricingUom",value);
			}
		}
				/// <summary>
		/// 单据类型 (该属性可为空,但有默认值)
		/// 费用计算行数据传输对象.Misc.单据类型
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum DocType
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum)base.GetValue("DocType",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum));
			}

			 set	
			{
				base.SetValue("DocType",value);
			}
		}
				/// <summary>
		/// 费用计算 (该属性可为空,且无默认值)
		/// 费用计算行数据传输对象.Misc.费用计算
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTO</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTO CalculationFee
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTO)base.GetValue("CalculationFee",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTO));
			}

			 set	
			{
				base.SetValue("CalculationFee",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																						
		#endregion 

		#region ModelResource
		/// <summary>
		/// 费用计算行数据传输对象的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 创建时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedOn　{ get { return "";　}　}
		/// <summary>
		/// 创建人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
		/// <summary>
		/// 修改时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ModifiedOn　{ get { return "";　}　}
		/// <summary>
		/// 修改人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ModifiedBy　{ get { return "";　}　}
		/// <summary>
		/// 事务版本的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SysVersion　{ get { return "";　}　}
		/// <summary>
		/// 单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 单号ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocID　{ get { return "";　}　}
		/// <summary>
		/// 行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LineID　{ get { return "";　}　}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Item　{ get { return "";　}　}
		/// <summary>
		/// 销售数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Qty　{ get { return "";　}　}
		/// <summary>
		/// 销售单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SalesUom　{ get { return "";　}　}
		/// <summary>
		/// 实际提货工厂的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RealDeliveryFactory　{ get { return "";　}　}
		/// <summary>
		/// 实际计价方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RealPricingMethod　{ get { return "";　}　}
		/// <summary>
		/// 体积的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IBulk　{ get { return "";　}　}
		/// <summary>
		/// 体积单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BulkUom　{ get { return "";　}　}
		/// <summary>
		/// 重量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Weight　{ get { return "";　}　}
		/// <summary>
		/// 重量单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WeightUom　{ get { return "";　}　}
		/// <summary>
		/// 计价数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PricingQty　{ get { return "";　}　}
		/// <summary>
		/// 计价单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PricingUom　{ get { return "";　}　}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocType　{ get { return "";　}　}
		/// <summary>
		/// 费用计算的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CalculationFee　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CalculationFeeLineDTOData data)
		{
		






















		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CalculationFeeLineDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CalculationFeeLineDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ID = data.ID;

			this.CreatedOn = data.CreatedOn;

			this.CreatedBy = data.CreatedBy;

			this.ModifiedOn = data.ModifiedOn;

			this.ModifiedBy = data.ModifiedBy;

			this.SysVersion = data.SysVersion;

			this.DocNo = data.DocNo;

			this.DocID = data.DocID;

			this.LineID = data.LineID;

			{
			if (data.Item!=null)
			{
				UFIDA.U9.CBO.SCM.Item.ItemMaster child = dict[data.Item] as UFIDA.U9.CBO.SCM.Item.ItemMaster ;
				if (child == null)
				{
					if (data.Item.ID>0)
					{
						if (data.Item.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Item.ID,data.Item.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Item.SysEntityType,null,data.Item.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Item.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Item, dict);
				}
				this.Item = child ;
			}
			else
				this.Item = null ;
			}

			this.Qty = data.Qty;

			{
			if (data.SalesUom!=null)
			{
				UFIDA.U9.Base.UOM.UOM child = dict[data.SalesUom] as UFIDA.U9.Base.UOM.UOM ;
				if (child == null)
				{
					if (data.SalesUom.ID>0)
					{
						if (data.SalesUom.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.UOM.UOM)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.SalesUom.ID,data.SalesUom.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SalesUom.SysEntityType,null,data.SalesUom.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SalesUom.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.SalesUom, dict);
				}
				this.SalesUom = child ;
			}
			else
				this.SalesUom = null ;
			}

			this.RealDeliveryFactory = UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum.GetFromValue(data.RealDeliveryFactory);

			this.RealPricingMethod = UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.GetFromValue(data.RealPricingMethod);

			this.IBulk = data.IBulk;

			{
			if (data.BulkUom!=null)
			{
				UFIDA.U9.Base.UOM.UOM child = dict[data.BulkUom] as UFIDA.U9.Base.UOM.UOM ;
				if (child == null)
				{
					if (data.BulkUom.ID>0)
					{
						if (data.BulkUom.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.UOM.UOM)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.BulkUom.ID,data.BulkUom.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BulkUom.SysEntityType,null,data.BulkUom.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BulkUom.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.BulkUom, dict);
				}
				this.BulkUom = child ;
			}
			else
				this.BulkUom = null ;
			}

			this.Weight = data.Weight;

			{
			if (data.WeightUom!=null)
			{
				UFIDA.U9.Base.UOM.UOM child = dict[data.WeightUom] as UFIDA.U9.Base.UOM.UOM ;
				if (child == null)
				{
					if (data.WeightUom.ID>0)
					{
						if (data.WeightUom.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.UOM.UOM)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.WeightUom.ID,data.WeightUom.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.WeightUom.SysEntityType,null,data.WeightUom.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.WeightUom.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.WeightUom, dict);
				}
				this.WeightUom = child ;
			}
			else
				this.WeightUom = null ;
			}

			this.PricingQty = data.PricingQty;

			{
			if (data.PricingUom!=null)
			{
				UFIDA.U9.Base.UOM.UOM child = dict[data.PricingUom] as UFIDA.U9.Base.UOM.UOM ;
				if (child == null)
				{
					if (data.PricingUom.ID>0)
					{
						if (data.PricingUom.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.UOM.UOM)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.PricingUom.ID,data.PricingUom.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.PricingUom.SysEntityType,null,data.PricingUom.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.PricingUom.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.PricingUom, dict);
				}
				this.PricingUom = child ;
			}
			else
				this.PricingUom = null ;
			}

			this.DocType = UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.GetFromValue(data.DocType);

			if (data.CalculationFee!=null)
			{
				UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTO temp = dict[data.CalculationFee] as UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTO ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTO();
					temp.FromEntityData(data.CalculationFee,dict);
				}
				this.CalculationFee = temp ;
			}
		

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CalculationFeeLineDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CalculationFeeLineDTOData ToEntityData(CalculationFeeLineDTOData data, IDictionary dict){
			if (data == null)
				data = new CalculationFeeLineDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CalculationFeeLineDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ID = this.ID;

			data.CreatedOn = this.CreatedOn;

			data.CreatedBy = this.CreatedBy;

			data.ModifiedOn = this.ModifiedOn;

			data.ModifiedBy = this.ModifiedBy;

			data.SysVersion = this.SysVersion;

			data.DocNo = this.DocNo;

			data.DocID = this.DocID;

			data.LineID = this.LineID;

			if (this.Item!=null)
			{
				data.Item=this.Item.ToEntityData(null,dict);
			}

			data.Qty = this.Qty;

			if (this.SalesUom!=null)
			{
				data.SalesUom=this.SalesUom.ToEntityData(null,dict);
			}

			if (this.RealDeliveryFactory!=null)
			{
				data.RealDeliveryFactory = this.RealDeliveryFactory.Value;
			}

			if (this.RealPricingMethod!=null)
			{
				data.RealPricingMethod = this.RealPricingMethod.Value;
			}

			data.IBulk = this.IBulk;

			if (this.BulkUom!=null)
			{
				data.BulkUom=this.BulkUom.ToEntityData(null,dict);
			}

			data.Weight = this.Weight;

			if (this.WeightUom!=null)
			{
				data.WeightUom=this.WeightUom.ToEntityData(null,dict);
			}

			data.PricingQty = this.PricingQty;

			if (this.PricingUom!=null)
			{
				data.PricingUom=this.PricingUom.ToEntityData(null,dict);
			}

			if (this.DocType!=null)
			{
				data.DocType = this.DocType.Value;
			}

			if (this.CalculationFee!=null)
			{
				data.CalculationFee=this.CalculationFee.ToEntityData(null,dict);
			}
		

			return data ;
		}

		#endregion	
	}	
	
}