


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用计算合计行数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CalculationFeeTotalLineDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CalculationFeeTotalLineDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
					TotalBulk = 0; 
					TotalWeight = 0; 
					RealBulk = 0; 
					RealWeight = 0; 
					PickupFee = 0; 
					DeliveryFee = 0; 
					DischargeFee = 0; 
					OtherFee = 0; 
					TotalFreight = 0; 
					RealFreight = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 费用计算合计行数据传输对象.Key.ID
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
		/// 费用计算合计行数据传输对象.Sys.创建时间
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
		/// 费用计算合计行数据传输对象.Sys.创建人
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
		/// 费用计算合计行数据传输对象.Sys.修改时间
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
		/// 费用计算合计行数据传输对象.Sys.修改人
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
		/// 费用计算合计行数据传输对象.Sys.事务版本
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
		/// 合计体积 (该属性可为空,但有默认值)
		/// 费用计算合计行数据传输对象.Misc.合计体积
		/// </summary>
		/// <value>System.Double</value>
		public System.Double TotalBulk
		{
			get	
			{	
				return (System.Double)base.GetValue("TotalBulk",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("TotalBulk",value);
			}
		}
				/// <summary>
		/// 合计重量 (该属性可为空,但有默认值)
		/// 费用计算合计行数据传输对象.Misc.合计重量
		/// </summary>
		/// <value>System.Double</value>
		public System.Double TotalWeight
		{
			get	
			{	
				return (System.Double)base.GetValue("TotalWeight",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("TotalWeight",value);
			}
		}
				/// <summary>
		/// 实际体积 (该属性可为空,但有默认值)
		/// 费用计算合计行数据传输对象.Misc.实际体积
		/// </summary>
		/// <value>System.Double</value>
		public System.Double RealBulk
		{
			get	
			{	
				return (System.Double)base.GetValue("RealBulk",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("RealBulk",value);
			}
		}
				/// <summary>
		/// 实际重量 (该属性可为空,但有默认值)
		/// 费用计算合计行数据传输对象.Misc.实际重量
		/// </summary>
		/// <value>System.Double</value>
		public System.Double RealWeight
		{
			get	
			{	
				return (System.Double)base.GetValue("RealWeight",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("RealWeight",value);
			}
		}
				/// <summary>
		/// 提货费 (该属性可为空,但有默认值)
		/// 费用计算合计行数据传输对象.Misc.提货费
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
		/// 费用计算合计行数据传输对象.Misc.送货费
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
		/// 费用计算合计行数据传输对象.Misc.卸货费
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
		/// 费用计算合计行数据传输对象.Misc.其他费用
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
		/// 合计费用 (该属性可为空,但有默认值)
		/// 费用计算合计行数据传输对象.Misc.合计费用
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
		/// 实际费用 (该属性可为空,但有默认值)
		/// 费用计算合计行数据传输对象.Misc.实际费用
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
		
		#endregion	
		#region Multi_Fields
																
		#endregion 

		#region ModelResource
		/// <summary>
		/// 费用计算合计行数据传输对象的显示名称资源--已经废弃，不使用.
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
		/// 合计体积的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalBulk　{ get { return "";　}　}
		/// <summary>
		/// 合计重量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalWeight　{ get { return "";　}　}
		/// <summary>
		/// 实际体积的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RealBulk　{ get { return "";　}　}
		/// <summary>
		/// 实际重量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RealWeight　{ get { return "";　}　}
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
		/// 合计费用的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalFreight　{ get { return "";　}　}
		/// <summary>
		/// 实际费用的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RealFreight　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CalculationFeeTotalLineDTOData data)
		{
		
















		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CalculationFeeTotalLineDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CalculationFeeTotalLineDTOData data,IDictionary dict)
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

			this.TotalBulk = data.TotalBulk;

			this.TotalWeight = data.TotalWeight;

			this.RealBulk = data.RealBulk;

			this.RealWeight = data.RealWeight;

			this.PickupFee = data.PickupFee;

			this.DeliveryFee = data.DeliveryFee;

			this.DischargeFee = data.DischargeFee;

			this.OtherFee = data.OtherFee;

			this.TotalFreight = data.TotalFreight;

			this.RealFreight = data.RealFreight;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CalculationFeeTotalLineDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CalculationFeeTotalLineDTOData ToEntityData(CalculationFeeTotalLineDTOData data, IDictionary dict){
			if (data == null)
				data = new CalculationFeeTotalLineDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CalculationFeeTotalLineDTOData)dict[this];
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

			data.TotalBulk = this.TotalBulk;

			data.TotalWeight = this.TotalWeight;

			data.RealBulk = this.RealBulk;

			data.RealWeight = this.RealWeight;

			data.PickupFee = this.PickupFee;

			data.DeliveryFee = this.DeliveryFee;

			data.DischargeFee = this.DischargeFee;

			data.OtherFee = this.OtherFee;

			data.TotalFreight = this.TotalFreight;

			data.RealFreight = this.RealFreight;

			return data ;
		}

		#endregion	
	}	
	
}