


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用记录数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class FeeRecordDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public FeeRecordDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
					BusinessType =UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum.GetFromValue(0); 
		
		
		
		
		
		
					Qty = 0; 
					ProductCategory =UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum.GetFromValue(0); 
		
					IBulk = 0; 
					Weight = 0; 
		
		
					PickupFee = 0; 
					DeliveryFee = 0; 
					DischargeFee = 0; 
					OtherFee = 0; 
					StandardShipping = 0; 
					TotalFreight = 0; 
					RealFreight = 0; 
					AverageCost = 0; 
					UintPrice = 0; 
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 费用记录数据传输对象.Key.ID
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
		/// 费用记录数据传输对象.Sys.创建时间
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
		/// 费用记录数据传输对象.Sys.创建人
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
		/// 费用记录数据传输对象.Sys.修改时间
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
		/// 费用记录数据传输对象.Sys.修改人
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
		/// 费用记录数据传输对象.Sys.事务版本
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
		/// 业务类型 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.业务类型
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum BusinessType
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum)base.GetValue("BusinessType",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum));
			}

			 set	
			{
				base.SetValue("BusinessType",value);
			}
		}
				/// <summary>
		/// 跟单 (该属性可为空,且无默认值)
		/// 费用记录数据传输对象.Misc.跟单
		/// </summary>
		/// <value>System.String</value>
		public System.String Salesman
		{
			get	
			{	
				return (System.String)base.GetValue("Salesman",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Salesman",value);
			}
		}
				/// <summary>
		/// 客户联系人 (该属性可为空,且无默认值)
		/// 费用记录数据传输对象.Misc.客户联系人
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerContact
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerContact",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerContact",value);
			}
		}
				/// <summary>
		/// 客户电话 (该属性可为空,且无默认值)
		/// 费用记录数据传输对象.Misc.客户电话
		/// </summary>
		/// <value>System.String</value>
		public System.String ContactPhone
		{
			get	
			{	
				return (System.String)base.GetValue("ContactPhone",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ContactPhone",value);
			}
		}
				/// <summary>
		/// 出货日期 (该属性可为空,且无默认值)
		/// 费用记录数据传输对象.Misc.出货日期
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
		/// 订单号 (该属性可为空,且无默认值)
		/// 费用记录数据传输对象.Misc.订单号
		/// </summary>
		/// <value>System.String</value>
		public System.String SaleNo
		{
			get	
			{	
				return (System.String)base.GetValue("SaleNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SaleNo",value);
			}
		}
				/// <summary>
		/// 承运商 (该属性可为空,且无默认值)
		/// 费用记录数据传输对象.Misc.承运商
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Supplier.Supplier</value>
		public UFIDA.U9.CBO.SCM.Supplier.Supplier Supplier
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Supplier.Supplier)base.GetValue("Supplier",typeof(UFIDA.U9.CBO.SCM.Supplier.Supplier));
			}

			 set	
			{
				base.SetValue("Supplier",value);
			}
		}
				/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.数量
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
		/// 商品类别 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.商品类别
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum ProductCategory
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum)base.GetValue("ProductCategory",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum));
			}

			 set	
			{
				base.SetValue("ProductCategory",value);
			}
		}
				/// <summary>
		/// 省份 (该属性可为空,且无默认值)
		/// 费用记录数据传输对象.Misc.省份
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
		/// 体积 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.体积
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
		/// 重量 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.重量
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
		/// 体积单位 (该属性可为空,且无默认值)
		/// 费用记录数据传输对象.Misc.体积单位
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
		/// 重量单位 (该属性可为空,且无默认值)
		/// 费用记录数据传输对象.Misc.重量单位
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
		/// 提货费 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.提货费
		/// </summary>
		/// <value>System.Double</value>
		public System.Double PickupFee
		{
			get	
			{	
				return (System.Double)base.GetValue("PickupFee",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("PickupFee",value);
			}
		}
				/// <summary>
		/// 送货费 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.送货费
		/// </summary>
		/// <value>System.Double</value>
		public System.Double DeliveryFee
		{
			get	
			{	
				return (System.Double)base.GetValue("DeliveryFee",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("DeliveryFee",value);
			}
		}
				/// <summary>
		/// 卸货费 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.卸货费
		/// </summary>
		/// <value>System.Double</value>
		public System.Double DischargeFee
		{
			get	
			{	
				return (System.Double)base.GetValue("DischargeFee",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("DischargeFee",value);
			}
		}
				/// <summary>
		/// 其他费用 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.其他费用
		/// </summary>
		/// <value>System.Double</value>
		public System.Double OtherFee
		{
			get	
			{	
				return (System.Double)base.GetValue("OtherFee",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("OtherFee",value);
			}
		}
				/// <summary>
		/// 标准运费 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.标准运费
		/// </summary>
		/// <value>System.Double</value>
		public System.Double StandardShipping
		{
			get	
			{	
				return (System.Double)base.GetValue("StandardShipping",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("StandardShipping",value);
			}
		}
				/// <summary>
		/// 费用合计 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.费用合计
		/// </summary>
		/// <value>System.Double</value>
		public System.Double TotalFreight
		{
			get	
			{	
				return (System.Double)base.GetValue("TotalFreight",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("TotalFreight",value);
			}
		}
				/// <summary>
		/// 结算价格 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.结算价格
		/// </summary>
		/// <value>System.Double</value>
		public System.Double RealFreight
		{
			get	
			{	
				return (System.Double)base.GetValue("RealFreight",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("RealFreight",value);
			}
		}
				/// <summary>
		/// 平均费用 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.平均费用
		/// </summary>
		/// <value>System.Double</value>
		public System.Double AverageCost
		{
			get	
			{	
				return (System.Double)base.GetValue("AverageCost",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("AverageCost",value);
			}
		}
				/// <summary>
		/// 执行单价 (该属性可为空,但有默认值)
		/// 费用记录数据传输对象.Misc.执行单价
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
		/// 费用记录数据传输对象.Misc.备注
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
		/// 城市 (该属性可为空,且无默认值)
		/// 费用记录数据传输对象.Misc.城市
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
		/// 费用记录数据传输对象.Misc.区县
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
		/// 费用记录数据传输对象.Misc.详细地址
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
		/// 送货地址 (该属性可为空,且无默认值)
		/// 费用记录数据传输对象.Misc.送货地址
		/// </summary>
		/// <value>System.String</value>
		public System.String FullAddress
		{
			get	
			{	
				return (System.String)base.GetValue("FullAddress",typeof(System.String));
			}

			 set	
			{
				base.SetValue("FullAddress",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																																		
		#endregion 

		#region ModelResource
		/// <summary>
		/// 费用记录数据传输对象的显示名称资源--已经废弃，不使用.
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
		/// 业务类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessType　{ get { return "";　}　}
		/// <summary>
		/// 跟单的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Salesman　{ get { return "";　}　}
		/// <summary>
		/// 客户联系人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact　{ get { return "";　}　}
		/// <summary>
		/// 客户电话的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ContactPhone　{ get { return "";　}　}
		/// <summary>
		/// 出货日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipDate　{ get { return "";　}　}
		/// <summary>
		/// 订单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SaleNo　{ get { return "";　}　}
		/// <summary>
		/// 承运商的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier　{ get { return "";　}　}
		/// <summary>
		/// 数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Qty　{ get { return "";　}　}
		/// <summary>
		/// 商品类别的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ProductCategory　{ get { return "";　}　}
		/// <summary>
		/// 省份的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Province　{ get { return "";　}　}
		/// <summary>
		/// 体积的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IBulk　{ get { return "";　}　}
		/// <summary>
		/// 重量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Weight　{ get { return "";　}　}
		/// <summary>
		/// 体积单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BulkUom　{ get { return "";　}　}
		/// <summary>
		/// 重量单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WeightUom　{ get { return "";　}　}
		/// <summary>
		/// 提货费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PickupFee　{ get { return "";　}　}
		/// <summary>
		/// 送货费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DeliveryFee　{ get { return "";　}　}
		/// <summary>
		/// 卸货费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DischargeFee　{ get { return "";　}　}
		/// <summary>
		/// 其他费用的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OtherFee　{ get { return "";　}　}
		/// <summary>
		/// 标准运费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_StandardShipping　{ get { return "";　}　}
		/// <summary>
		/// 费用合计的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalFreight　{ get { return "";　}　}
		/// <summary>
		/// 结算价格的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RealFreight　{ get { return "";　}　}
		/// <summary>
		/// 平均费用的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AverageCost　{ get { return "";　}　}
		/// <summary>
		/// 执行单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UintPrice　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Remark　{ get { return "";　}　}
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
		/// 送货地址的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FullAddress　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(FeeRecordDTOData data)
		{
		


































		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(FeeRecordDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(FeeRecordDTOData data,IDictionary dict)
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

			this.BusinessType = UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum.GetFromValue(data.BusinessType);

			this.Salesman = data.Salesman;

			this.CustomerContact = data.CustomerContact;

			this.ContactPhone = data.ContactPhone;

			this.ShipDate = data.ShipDate;

			this.SaleNo = data.SaleNo;

			{
			if (data.Supplier!=null)
			{
				UFIDA.U9.CBO.SCM.Supplier.Supplier child = dict[data.Supplier] as UFIDA.U9.CBO.SCM.Supplier.Supplier ;
				if (child == null)
				{
					if (data.Supplier.ID>0)
					{
						if (data.Supplier.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.SCM.Supplier.Supplier)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Supplier.ID,data.Supplier.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.SCM.Supplier.Supplier)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Supplier.SysEntityType,null,data.Supplier.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.SCM.Supplier.Supplier)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Supplier.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Supplier, dict);
				}
				this.Supplier = child ;
			}
			else
				this.Supplier = null ;
			}

			this.Qty = data.Qty;

			this.ProductCategory = UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum.GetFromValue(data.ProductCategory);

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

			this.IBulk = data.IBulk;

			this.Weight = data.Weight;

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

			this.PickupFee = data.PickupFee;

			this.DeliveryFee = data.DeliveryFee;

			this.DischargeFee = data.DischargeFee;

			this.OtherFee = data.OtherFee;

			this.StandardShipping = data.StandardShipping;

			this.TotalFreight = data.TotalFreight;

			this.RealFreight = data.RealFreight;

			this.AverageCost = data.AverageCost;

			this.UintPrice = data.UintPrice;

			this.Remark = data.Remark;

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

			this.FullAddress = data.FullAddress;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public FeeRecordDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public FeeRecordDTOData ToEntityData(FeeRecordDTOData data, IDictionary dict){
			if (data == null)
				data = new FeeRecordDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (FeeRecordDTOData)dict[this];
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

			if (this.BusinessType!=null)
			{
				data.BusinessType = this.BusinessType.Value;
			}

			data.Salesman = this.Salesman;

			data.CustomerContact = this.CustomerContact;

			data.ContactPhone = this.ContactPhone;

			data.ShipDate = this.ShipDate;

			data.SaleNo = this.SaleNo;

			if (this.Supplier!=null)
			{
				data.Supplier=this.Supplier.ToEntityData(null,dict);
			}

			data.Qty = this.Qty;

			if (this.ProductCategory!=null)
			{
				data.ProductCategory = this.ProductCategory.Value;
			}

			if (this.Province!=null)
			{
				data.Province=this.Province.ToEntityData(null,dict);
			}

			data.IBulk = this.IBulk;

			data.Weight = this.Weight;

			if (this.BulkUom!=null)
			{
				data.BulkUom=this.BulkUom.ToEntityData(null,dict);
			}

			if (this.WeightUom!=null)
			{
				data.WeightUom=this.WeightUom.ToEntityData(null,dict);
			}

			data.PickupFee = this.PickupFee;

			data.DeliveryFee = this.DeliveryFee;

			data.DischargeFee = this.DischargeFee;

			data.OtherFee = this.OtherFee;

			data.StandardShipping = this.StandardShipping;

			data.TotalFreight = this.TotalFreight;

			data.RealFreight = this.RealFreight;

			data.AverageCost = this.AverageCost;

			data.UintPrice = this.UintPrice;

			data.Remark = this.Remark;

			if (this.City!=null)
			{
				data.City=this.City.ToEntityData(null,dict);
			}

			if (this.County!=null)
			{
				data.County=this.County.ToEntityData(null,dict);
			}

			data.DescribeAddress = this.DescribeAddress;

			data.FullAddress = this.FullAddress;

			return data ;
		}

		#endregion	
	}	
	
}