


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用计算数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CalculationFeeDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CalculationFeeDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
		
					DeliveryFactory =UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum.GetFromValue(-1); 
		
		
					PricingMethod =UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.GetFromValue(0); 
					TotalAmount = 0; 
					RealAmount = 0; 
					UintPrice = 0; 
		
					Contain = false; 
					NumberOfTrucks = 1; 
		
		
		
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 费用计算数据传输对象.Key.ID
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
		/// 费用计算数据传输对象.Sys.创建时间
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
		/// 费用计算数据传输对象.Sys.创建人
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
		/// 费用计算数据传输对象.Sys.修改时间
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
		/// 费用计算数据传输对象.Sys.修改人
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
		/// 费用计算数据传输对象.Sys.事务版本
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
		/// 供应商 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.供应商
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Supplier.Supplier</value>
		public UFIDA.U9.CBO.SCM.Supplier.Supplier Sup
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Supplier.Supplier)base.GetValue("Sup",typeof(UFIDA.U9.CBO.SCM.Supplier.Supplier));
			}

			 set	
			{
				base.SetValue("Sup",value);
			}
		}
				/// <summary>
		/// 提货工厂 (该属性可为空,但有默认值)
		/// 费用计算数据传输对象.Misc.提货工厂
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum DeliveryFactory
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum)base.GetValue("DeliveryFactory",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum));
			}

			 set	
			{
				base.SetValue("DeliveryFactory",value);
			}
		}
				/// <summary>
		/// 送货地址 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.送货地址
		/// </summary>
		/// <value>UFIDA.U9.Base.Location.Location</value>
		public UFIDA.U9.Base.Location.Location Address
		{
			get	
			{	
				return (UFIDA.U9.Base.Location.Location)base.GetValue("Address",typeof(UFIDA.U9.Base.Location.Location));
			}

			 set	
			{
				base.SetValue("Address",value);
			}
		}
				/// <summary>
		/// 配送日期 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.配送日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ShipDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ShipDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ShipDate",value);
			}
		}
				/// <summary>
		/// 计价方式 (该属性可为空,但有默认值)
		/// 费用计算数据传输对象.Misc.计价方式
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum PricingMethod
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum)base.GetValue("PricingMethod",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum));
			}

			 set	
			{
				base.SetValue("PricingMethod",value);
			}
		}
				/// <summary>
		/// 合计金额 (该属性可为空,但有默认值)
		/// 费用计算数据传输对象.Misc.合计金额
		/// </summary>
		/// <value>System.Double</value>
		public System.Double TotalAmount
		{
			get	
			{	
				return (System.Double)base.GetValue("TotalAmount",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("TotalAmount",value);
			}
		}
				/// <summary>
		/// 结算金额 (该属性可为空,但有默认值)
		/// 费用计算数据传输对象.Misc.结算金额
		/// </summary>
		/// <value>System.Double</value>
		public System.Double RealAmount
		{
			get	
			{	
				return (System.Double)base.GetValue("RealAmount",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("RealAmount",value);
			}
		}
				/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// 费用计算数据传输对象.Misc.单价
		/// </summary>
		/// <value>System.Double</value>
		public System.Double UintPrice
		{
			get	
			{	
				return (System.Double)base.GetValue("UintPrice",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("UintPrice",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.备注
		/// </summary>
		/// <value>System.String</value>
		public System.String Remark
		{
			get	
			{	
				return (System.String)base.GetValue("Remark",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Remark",value);
			}
		}
				/// <summary>
		/// 包含 (该属性可为空,但有默认值)
		/// 费用计算数据传输对象.Misc.包含
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean Contain
		{
			get	
			{	
				return (System.Boolean)base.GetValue("Contain",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("Contain",value);
			}
		}
				/// <summary>
		/// 派车数量 (该属性可为空,但有默认值)
		/// 费用计算数据传输对象.Misc.派车数量
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 NumberOfTrucks
		{
			get	
			{	
				return (System.Int32)base.GetValue("NumberOfTrucks",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("NumberOfTrucks",value);
			}
		}
				/// <summary>
		/// 费用计算行 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.费用计算行
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO> CalculationFeeLine
		{
			get	
			{	
				return (List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO>)base.GetValue("CalculationFeeLine",typeof(List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO>));
			}

			 set	
			{
				base.SetValue("CalculationFeeLine",value);
			}
		}
				/// <summary>
		/// 黄岛合计 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.黄岛合计
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine HuangdaoTotal
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)base.GetValue("HuangdaoTotal",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine));
			}

			 set	
			{
				base.SetValue("HuangdaoTotal",value);
			}
		}
				/// <summary>
		/// 城阳合计 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.城阳合计
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine ChenyangTotal
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)base.GetValue("ChenyangTotal",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine));
			}

			 set	
			{
				base.SetValue("ChenyangTotal",value);
			}
		}
				/// <summary>
		/// 设定地址 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.设定地址
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine SetLocation
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine)base.GetValue("SetLocation",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine));
			}

			 set	
			{
				base.SetValue("SetLocation",value);
			}
		}
				/// <summary>
		/// 省 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.省
		/// </summary>
		/// <value>UFIDA.U9.Base.Location.Province</value>
		public UFIDA.U9.Base.Location.Province Province
		{
			get	
			{	
				return (UFIDA.U9.Base.Location.Province)base.GetValue("Province",typeof(UFIDA.U9.Base.Location.Province));
			}

			 set	
			{
				base.SetValue("Province",value);
			}
		}
				/// <summary>
		/// 市 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.市
		/// </summary>
		/// <value>UFIDA.U9.Base.Location.City</value>
		public UFIDA.U9.Base.Location.City City
		{
			get	
			{	
				return (UFIDA.U9.Base.Location.City)base.GetValue("City",typeof(UFIDA.U9.Base.Location.City));
			}

			 set	
			{
				base.SetValue("City",value);
			}
		}
				/// <summary>
		/// 属性 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.属性
		/// </summary>
		/// <value>UFIDA.U9.Base.Location.County</value>
		public UFIDA.U9.Base.Location.County County
		{
			get	
			{	
				return (UFIDA.U9.Base.Location.County)base.GetValue("County",typeof(UFIDA.U9.Base.Location.County));
			}

			 set	
			{
				base.SetValue("County",value);
			}
		}
				/// <summary>
		/// 详细地址 (该属性可为空,且无默认值)
		/// 费用计算数据传输对象.Misc.详细地址
		/// </summary>
		/// <value>System.String</value>
		public System.String DescriLocation
		{
			get	
			{	
				return (System.String)base.GetValue("DescriLocation",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DescriLocation",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																									
		#endregion 

		#region ModelResource
		/// <summary>
		/// 费用计算数据传输对象的显示名称资源--已经废弃，不使用.
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
		/// 供应商的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Sup　{ get { return "";　}　}
		/// <summary>
		/// 提货工厂的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DeliveryFactory　{ get { return "";　}　}
		/// <summary>
		/// 送货地址的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Address　{ get { return "";　}　}
		/// <summary>
		/// 配送日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipDate　{ get { return "";　}　}
		/// <summary>
		/// 计价方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PricingMethod　{ get { return "";　}　}
		/// <summary>
		/// 合计金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalAmount　{ get { return "";　}　}
		/// <summary>
		/// 结算金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RealAmount　{ get { return "";　}　}
		/// <summary>
		/// 单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UintPrice　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Remark　{ get { return "";　}　}
		/// <summary>
		/// 包含的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Contain　{ get { return "";　}　}
		/// <summary>
		/// 派车数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_NumberOfTrucks　{ get { return "";　}　}
		/// <summary>
		/// 费用计算行的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CalculationFeeLine　{ get { return "";　}　}
		/// <summary>
		/// 黄岛合计的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_HuangdaoTotal　{ get { return "";　}　}
		/// <summary>
		/// 城阳合计的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ChenyangTotal　{ get { return "";　}　}
		/// <summary>
		/// 设定地址的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SetLocation　{ get { return "";　}　}
		/// <summary>
		/// 省的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Province　{ get { return "";　}　}
		/// <summary>
		/// 市的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_City　{ get { return "";　}　}
		/// <summary>
		/// 属性的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_County　{ get { return "";　}　}
		/// <summary>
		/// 详细地址的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DescriLocation　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CalculationFeeDTOData data)
		{
		

























		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CalculationFeeDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CalculationFeeDTOData data,IDictionary dict)
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

			{
			if (data.Sup!=null)
			{
				UFIDA.U9.CBO.SCM.Supplier.Supplier child = dict[data.Sup] as UFIDA.U9.CBO.SCM.Supplier.Supplier ;
				if (child == null)
				{
					if (data.Sup.ID>0)
					{
						if (data.Sup.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.SCM.Supplier.Supplier)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Sup.ID,data.Sup.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.SCM.Supplier.Supplier)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Sup.SysEntityType,null,data.Sup.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.SCM.Supplier.Supplier)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Sup.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Sup, dict);
				}
				this.Sup = child ;
			}
			else
				this.Sup = null ;
			}

			this.DeliveryFactory = UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum.GetFromValue(data.DeliveryFactory);

			{
			if (data.Address!=null)
			{
				UFIDA.U9.Base.Location.Location child = dict[data.Address] as UFIDA.U9.Base.Location.Location ;
				if (child == null)
				{
					if (data.Address.ID>0)
					{
						if (data.Address.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.Location.Location)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Address.ID,data.Address.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.Location.Location)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Address.SysEntityType,null,data.Address.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.Location.Location)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Address.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Address, dict);
				}
				this.Address = child ;
			}
			else
				this.Address = null ;
			}

			this.ShipDate = data.ShipDate;

			this.PricingMethod = UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.GetFromValue(data.PricingMethod);

			this.TotalAmount = data.TotalAmount;

			this.RealAmount = data.RealAmount;

			this.UintPrice = data.UintPrice;

			this.Remark = data.Remark;

			this.Contain = data.Contain;

			this.NumberOfTrucks = data.NumberOfTrucks;

	
			if (data.CalculationFeeLine != null)
			{	
				List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO> listCalculationFeeLine = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO>();
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData obj in data.CalculationFeeLine ){

					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO child = dict[obj] as UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO;
					if (child == null)
					{
						child = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO();
						child.FromEntityData(obj,dict);
					}
					//值对象应该是依赖主创建的.但此处可能不是.
					listCalculationFeeLine.Add(child);
				
				}
				this.CalculationFeeLine = listCalculationFeeLine;
			}

			{
			if (data.HuangdaoTotal!=null)
			{
				UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine child = dict[data.HuangdaoTotal] as UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine ;
				if (child == null)
				{
					if (data.HuangdaoTotal.ID>0)
					{
						if (data.HuangdaoTotal.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.HuangdaoTotal.ID,data.HuangdaoTotal.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.HuangdaoTotal.SysEntityType,null,data.HuangdaoTotal.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.HuangdaoTotal.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.HuangdaoTotal, dict);
				}
				this.HuangdaoTotal = child ;
			}
			else
				this.HuangdaoTotal = null ;
			}

			{
			if (data.ChenyangTotal!=null)
			{
				UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine child = dict[data.ChenyangTotal] as UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine ;
				if (child == null)
				{
					if (data.ChenyangTotal.ID>0)
					{
						if (data.ChenyangTotal.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.ChenyangTotal.ID,data.ChenyangTotal.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ChenyangTotal.SysEntityType,null,data.ChenyangTotal.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ChenyangTotal.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.ChenyangTotal, dict);
				}
				this.ChenyangTotal = child ;
			}
			else
				this.ChenyangTotal = null ;
			}

			{
			if (data.SetLocation!=null)
			{
				UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine child = dict[data.SetLocation] as UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine ;
				if (child == null)
				{
					if (data.SetLocation.ID>0)
					{
						if (data.SetLocation.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.SetLocation.ID,data.SetLocation.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SetLocation.SysEntityType,null,data.SetLocation.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SetLocation.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.SetLocation, dict);
				}
				this.SetLocation = child ;
			}
			else
				this.SetLocation = null ;
			}

			{
			if (data.Province!=null)
			{
				UFIDA.U9.Base.Location.Province child = dict[data.Province] as UFIDA.U9.Base.Location.Province ;
				if (child == null)
				{
					if (data.Province.ID>0)
					{
						if (data.Province.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.Location.Province)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Province.ID,data.Province.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.Location.Province)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Province.SysEntityType,null,data.Province.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.Location.Province)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Province.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Province, dict);
				}
				this.Province = child ;
			}
			else
				this.Province = null ;
			}

			{
			if (data.City!=null)
			{
				UFIDA.U9.Base.Location.City child = dict[data.City] as UFIDA.U9.Base.Location.City ;
				if (child == null)
				{
					if (data.City.ID>0)
					{
						if (data.City.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.Location.City)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.City.ID,data.City.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.Location.City)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.City.SysEntityType,null,data.City.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.Location.City)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.City.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.City, dict);
				}
				this.City = child ;
			}
			else
				this.City = null ;
			}

			{
			if (data.County!=null)
			{
				UFIDA.U9.Base.Location.County child = dict[data.County] as UFIDA.U9.Base.Location.County ;
				if (child == null)
				{
					if (data.County.ID>0)
					{
						if (data.County.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.Location.County)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.County.ID,data.County.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.Location.County)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.County.SysEntityType,null,data.County.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.Location.County)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.County.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.County, dict);
				}
				this.County = child ;
			}
			else
				this.County = null ;
			}

			this.DescriLocation = data.DescriLocation;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CalculationFeeDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CalculationFeeDTOData ToEntityData(CalculationFeeDTOData data, IDictionary dict){
			if (data == null)
				data = new CalculationFeeDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CalculationFeeDTOData)dict[this];
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

			if (this.Sup!=null)
			{
				data.Sup=this.Sup.ToEntityData(null,dict);
			}

			if (this.DeliveryFactory!=null)
			{
				data.DeliveryFactory = this.DeliveryFactory.Value;
			}

			if (this.Address!=null)
			{
				data.Address=this.Address.ToEntityData(null,dict);
			}

			data.ShipDate = this.ShipDate;

			if (this.PricingMethod!=null)
			{
				data.PricingMethod = this.PricingMethod.Value;
			}

			data.TotalAmount = this.TotalAmount;

			data.RealAmount = this.RealAmount;

			data.UintPrice = this.UintPrice;

			data.Remark = this.Remark;

			data.Contain = this.Contain;

			data.NumberOfTrucks = this.NumberOfTrucks;

	
			if (this.CalculationFeeLine != null)
			{	
				List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> listCalculationFeeLine = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData>();
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTO obj in this.CalculationFeeLine ){
					if (obj==null) continue ;

					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData old = dict[obj] as UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData;
					listCalculationFeeLine.Add((old != null) ? old : obj.ToEntityData(null,dict));
				
				}
				data.CalculationFeeLine = listCalculationFeeLine;
			}

			if (this.HuangdaoTotal!=null)
			{
				data.HuangdaoTotal=this.HuangdaoTotal.ToEntityData(null,dict);
			}

			if (this.ChenyangTotal!=null)
			{
				data.ChenyangTotal=this.ChenyangTotal.ToEntityData(null,dict);
			}

			if (this.SetLocation!=null)
			{
				data.SetLocation=this.SetLocation.ToEntityData(null,dict);
			}

			if (this.Province!=null)
			{
				data.Province=this.Province.ToEntityData(null,dict);
			}

			if (this.City!=null)
			{
				data.City=this.City.ToEntityData(null,dict);
			}

			if (this.County!=null)
			{
				data.County=this.County.ToEntityData(null,dict);
			}

			data.DescriLocation = this.DescriLocation;

			return data ;
		}

		#endregion	
	}	
	
}