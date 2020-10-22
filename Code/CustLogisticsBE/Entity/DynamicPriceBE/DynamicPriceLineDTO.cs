


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 动态价格行数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class DynamicPriceLineDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public DynamicPriceLineDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
					No = 0; 
					UnitPrice = 0; 
					Start = 0; 
					Cutoff = 0; 
					Total = 0; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 动态价格行数据传输对象.Key.ID
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
		/// 动态价格行数据传输对象.Sys.创建时间
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
		/// 动态价格行数据传输对象.Sys.创建人
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
		/// 动态价格行数据传输对象.Sys.修改时间
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
		/// 动态价格行数据传输对象.Sys.修改人
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
		/// 动态价格行数据传输对象.Sys.事务版本
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
		/// 动态价格行数据传输对象.Misc.序号
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
		/// 单价 (该属性可为空,但有默认值)
		/// 动态价格行数据传输对象.Misc.单价
		/// </summary>
		/// <value>System.Double</value>
		public System.Double UnitPrice
		{
			get	
			{	
				return (System.Double)base.GetValue("UnitPrice",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("UnitPrice",value);
			}
		}
				/// <summary>
		/// 开始 (该属性可为空,但有默认值)
		/// 动态价格行数据传输对象.Misc.开始
		/// </summary>
		/// <value>System.Double</value>
		public System.Double Start
		{
			get	
			{	
				return (System.Double)base.GetValue("Start",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("Start",value);
			}
		}
				/// <summary>
		/// 结束 (该属性可为空,但有默认值)
		/// 动态价格行数据传输对象.Misc.结束
		/// </summary>
		/// <value>System.Double</value>
		public System.Double Cutoff
		{
			get	
			{	
				return (System.Double)base.GetValue("Cutoff",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("Cutoff",value);
			}
		}
				/// <summary>
		/// 区间合计 (该属性可为空,但有默认值)
		/// 动态价格行数据传输对象.Misc.区间合计
		/// </summary>
		/// <value>System.Double</value>
		public System.Double Total
		{
			get	
			{	
				return (System.Double)base.GetValue("Total",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("Total",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 动态价格行数据传输对象.Misc.备注
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
		/// 动态价格 (该属性可为空,且无默认值)
		/// 动态价格行数据传输对象.Misc.动态价格
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceDTO</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceDTO DynamicPrice
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceDTO)base.GetValue("DynamicPrice",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceDTO));
			}

			 set	
			{
				base.SetValue("DynamicPrice",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
													
		#endregion 

		#region ModelResource
		/// <summary>
		/// 动态价格行数据传输对象的显示名称资源--已经废弃，不使用.
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
		/// 单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UnitPrice　{ get { return "";　}　}
		/// <summary>
		/// 开始的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Start　{ get { return "";　}　}
		/// <summary>
		/// 结束的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Cutoff　{ get { return "";　}　}
		/// <summary>
		/// 区间合计的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Total　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Remark　{ get { return "";　}　}
		/// <summary>
		/// 动态价格的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DynamicPrice　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(DynamicPriceLineDTOData data)
		{
		













		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(DynamicPriceLineDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(DynamicPriceLineDTOData data,IDictionary dict)
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

			this.UnitPrice = data.UnitPrice;

			this.Start = data.Start;

			this.Cutoff = data.Cutoff;

			this.Total = data.Total;

			this.Remark = data.Remark;

			if (data.DynamicPrice!=null)
			{
				UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceDTO temp = dict[data.DynamicPrice] as UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceDTO ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceDTO();
					temp.FromEntityData(data.DynamicPrice,dict);
				}
				this.DynamicPrice = temp ;
			}
		

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public DynamicPriceLineDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public DynamicPriceLineDTOData ToEntityData(DynamicPriceLineDTOData data, IDictionary dict){
			if (data == null)
				data = new DynamicPriceLineDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (DynamicPriceLineDTOData)dict[this];
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

			data.UnitPrice = this.UnitPrice;

			data.Start = this.Start;

			data.Cutoff = this.Cutoff;

			data.Total = this.Total;

			data.Remark = this.Remark;

			if (this.DynamicPrice!=null)
			{
				data.DynamicPrice=this.DynamicPrice.ToEntityData(null,dict);
			}
		

			return data ;
		}

		#endregion	
	}	
	
}