


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 物流价目表行数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class LogisticsPricelistLineDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public LogisticsPricelistLineDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
					No = 0; 
					DeliveryFactory =UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum.GetFromValue(0); 
		
					PricingMethod =UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.GetFromValue(0); 
		
					UintPrice = 0; 
		
					DeliveryPickup = 0; 
					DeliveryCharges = 0; 
					FreePickup = 0; 
					FreeDelivery = 0; 
		
		
		
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 物流价目表行数据传输对象.Key.ID
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
		/// 物流价目表行数据传输对象.Sys.创建时间
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
		/// 物流价目表行数据传输对象.Sys.创建人
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
		/// 物流价目表行数据传输对象.Sys.修改时间
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
		/// 物流价目表行数据传输对象.Sys.修改人
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
		/// 物流价目表行数据传输对象.Sys.事务版本
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
		/// 序号 (该属性可为空,但有默认值)
		/// 物流价目表行数据传输对象.Misc.序号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 No
		{
			get	
			{	
				return (System.Int32)base.GetValue("No",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("No",value);
			}
		}
				/// <summary>
		/// 提货工厂 (该属性可为空,但有默认值)
		/// 物流价目表行数据传输对象.Misc.提货工厂
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
		/// 物流价目表行数据传输对象.Misc.送货地址
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
		/// 计价方式 (该属性可为空,但有默认值)
		/// 物流价目表行数据传输对象.Misc.计价方式
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
		/// 计价单位 (该属性可为空,且无默认值)
		/// 物流价目表行数据传输对象.Misc.计价单位
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
		/// 单价 (该属性可为空,但有默认值)
		/// 物流价目表行数据传输对象.Misc.单价
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
		/// 动态价格 (该属性可为空,且无默认值)
		/// 物流价目表行数据传输对象.Misc.动态价格
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice DynamicPrice
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice)base.GetValue("DynamicPrice",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice));
			}

			 set	
			{
				base.SetValue("DynamicPrice",value);
			}
		}
				/// <summary>
		/// 提货费 (该属性可为空,但有默认值)
		/// 物流价目表行数据传输对象.Misc.提货费
		/// </summary>
		/// <value>System.Double</value>
		public System.Double DeliveryPickup
		{
			get	
			{	
				return (System.Double)base.GetValue("DeliveryPickup",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("DeliveryPickup",value);
			}
		}
				/// <summary>
		/// 送货费 (该属性可为空,但有默认值)
		/// 物流价目表行数据传输对象.Misc.送货费
		/// </summary>
		/// <value>System.Double</value>
		public System.Double DeliveryCharges
		{
			get	
			{	
				return (System.Double)base.GetValue("DeliveryCharges",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("DeliveryCharges",value);
			}
		}
				/// <summary>
		/// 免提标准 (该属性可为空,但有默认值)
		/// 物流价目表行数据传输对象.Misc.免提标准
		/// </summary>
		/// <value>System.Double</value>
		public System.Double FreePickup
		{
			get	
			{	
				return (System.Double)base.GetValue("FreePickup",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("FreePickup",value);
			}
		}
				/// <summary>
		/// 免送标准 (该属性可为空,但有默认值)
		/// 物流价目表行数据传输对象.Misc.免送标准
		/// </summary>
		/// <value>System.Double</value>
		public System.Double FreeDelivery
		{
			get	
			{	
				return (System.Double)base.GetValue("FreeDelivery",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("FreeDelivery",value);
			}
		}
				/// <summary>
		/// 运输时间 (该属性可为空,且无默认值)
		/// 物流价目表行数据传输对象.Misc.运输时间
		/// </summary>
		/// <value>System.String</value>
		public System.String TransportationTime
		{
			get	
			{	
				return (System.String)base.GetValue("TransportationTime",typeof(System.String));
			}

			 set	
			{
				base.SetValue("TransportationTime",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 物流价目表行数据传输对象.Misc.备注
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
		/// 物流价目表 (该属性可为空,且无默认值)
		/// 物流价目表行数据传输对象.Misc.物流价目表
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTO</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTO LogisticsPricelist
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTO)base.GetValue("LogisticsPricelist",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTO));
			}

			 set	
			{
				base.SetValue("LogisticsPricelist",value);
			}
		}
				/// <summary>
		/// 省/自治区 (该属性可为空,且无默认值)
		/// 物流价目表行数据传输对象.Misc.省/自治区
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
		/// 城市 (该属性可为空,且无默认值)
		/// 物流价目表行数据传输对象.Misc.城市
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
		/// 区县 (该属性可为空,且无默认值)
		/// 物流价目表行数据传输对象.Misc.区县
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
		/// 物流价目表行数据传输对象.Misc.详细地址
		/// </summary>
		/// <value>System.String</value>
		public System.String DescribeAddress
		{
			get	
			{	
				return (System.String)base.GetValue("DescribeAddress",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DescribeAddress",value);
			}
		}
				/// <summary>
		/// 地址 (该属性可为空,且无默认值)
		/// 物流价目表行数据传输对象.Misc.地址
		/// </summary>
		/// <value>System.String</value>
		public System.String FormatAddress
		{
			get	
			{	
				return (System.String)base.GetValue("FormatAddress",typeof(System.String));
			}

			 set	
			{
				base.SetValue("FormatAddress",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																									
		#endregion 

		#region ModelResource
		/// <summary>
		/// 物流价目表行数据传输对象的显示名称资源--已经废弃，不使用.
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
		/// 序号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_No　{ get { return "";　}　}
		/// <summary>
		/// 提货工厂的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DeliveryFactory　{ get { return "";　}　}
		/// <summary>
		/// 送货地址的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Address　{ get { return "";　}　}
		/// <summary>
		/// 计价方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PricingMethod　{ get { return "";　}　}
		/// <summary>
		/// 计价单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PricingUom　{ get { return "";　}　}
		/// <summary>
		/// 单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UintPrice　{ get { return "";　}　}
		/// <summary>
		/// 动态价格的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DynamicPrice　{ get { return "";　}　}
		/// <summary>
		/// 提货费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DeliveryPickup　{ get { return "";　}　}
		/// <summary>
		/// 送货费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DeliveryCharges　{ get { return "";　}　}
		/// <summary>
		/// 免提标准的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FreePickup　{ get { return "";　}　}
		/// <summary>
		/// 免送标准的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FreeDelivery　{ get { return "";　}　}
		/// <summary>
		/// 运输时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TransportationTime　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Remark　{ get { return "";　}　}
		/// <summary>
		/// 物流价目表的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LogisticsPricelist　{ get { return "";　}　}
		/// <summary>
		/// 省/自治区的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Province　{ get { return "";　}　}
		/// <summary>
		/// 城市的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_City　{ get { return "";　}　}
		/// <summary>
		/// 区县的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_County　{ get { return "";　}　}
		/// <summary>
		/// 详细地址的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DescribeAddress　{ get { return "";　}　}
		/// <summary>
		/// 地址的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FormatAddress　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(LogisticsPricelistLineDTOData data)
		{
		

























		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(LogisticsPricelistLineDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(LogisticsPricelistLineDTOData data,IDictionary dict)
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

			this.No = data.No;

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

			this.PricingMethod = UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.GetFromValue(data.PricingMethod);

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

			this.UintPrice = data.UintPrice;

			{
			if (data.DynamicPrice!=null)
			{
				UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice child = dict[data.DynamicPrice] as UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice ;
				if (child == null)
				{
					if (data.DynamicPrice.ID>0)
					{
						if (data.DynamicPrice.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.DynamicPrice.ID,data.DynamicPrice.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.DynamicPrice.SysEntityType,null,data.DynamicPrice.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.DynamicPrice.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.DynamicPrice, dict);
				}
				this.DynamicPrice = child ;
			}
			else
				this.DynamicPrice = null ;
			}

			this.DeliveryPickup = data.DeliveryPickup;

			this.DeliveryCharges = data.DeliveryCharges;

			this.FreePickup = data.FreePickup;

			this.FreeDelivery = data.FreeDelivery;

			this.TransportationTime = data.TransportationTime;

			this.Remark = data.Remark;

			if (data.LogisticsPricelist!=null)
			{
				UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTO temp = dict[data.LogisticsPricelist] as UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTO ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTO();
					temp.FromEntityData(data.LogisticsPricelist,dict);
				}
				this.LogisticsPricelist = temp ;
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

			this.DescribeAddress = data.DescribeAddress;

			this.FormatAddress = data.FormatAddress;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public LogisticsPricelistLineDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public LogisticsPricelistLineDTOData ToEntityData(LogisticsPricelistLineDTOData data, IDictionary dict){
			if (data == null)
				data = new LogisticsPricelistLineDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (LogisticsPricelistLineDTOData)dict[this];
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

			data.No = this.No;

			if (this.DeliveryFactory!=null)
			{
				data.DeliveryFactory = this.DeliveryFactory.Value;
			}

			if (this.Address!=null)
			{
				data.Address=this.Address.ToEntityData(null,dict);
			}

			if (this.PricingMethod!=null)
			{
				data.PricingMethod = this.PricingMethod.Value;
			}

			if (this.PricingUom!=null)
			{
				data.PricingUom=this.PricingUom.ToEntityData(null,dict);
			}

			data.UintPrice = this.UintPrice;

			if (this.DynamicPrice!=null)
			{
				data.DynamicPrice=this.DynamicPrice.ToEntityData(null,dict);
			}

			data.DeliveryPickup = this.DeliveryPickup;

			data.DeliveryCharges = this.DeliveryCharges;

			data.FreePickup = this.FreePickup;

			data.FreeDelivery = this.FreeDelivery;

			data.TransportationTime = this.TransportationTime;

			data.Remark = this.Remark;

			if (this.LogisticsPricelist!=null)
			{
				data.LogisticsPricelist=this.LogisticsPricelist.ToEntityData(null,dict);
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

			data.DescribeAddress = this.DescribeAddress;

			data.FormatAddress = this.FormatAddress;

			return data ;
		}

		#endregion	
	}	
	
}