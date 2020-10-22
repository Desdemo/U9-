


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 动态价格数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class DynamicPriceDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public DynamicPriceDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
		
		
		
		
					DynamicPriceType =UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum.GetFromValue(0); 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 动态价格数据传输对象.Key.ID
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
		/// 动态价格数据传输对象.Sys.创建时间
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
		/// 动态价格数据传输对象.Sys.创建人
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
		/// 动态价格数据传输对象.Sys.修改时间
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
		/// 动态价格数据传输对象.Sys.修改人
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
		/// 动态价格数据传输对象.Sys.事务版本
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
		/// 编码 (该属性可为空,且无默认值)
		/// 动态价格数据传输对象.Misc.编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Code
		{
			get	
			{	
				return (System.String)base.GetValue("Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Code",value);
			}
		}
				/// <summary>
		/// 单位 (该属性可为空,且无默认值)
		/// 动态价格数据传输对象.Misc.单位
		/// </summary>
		/// <value>UFIDA.U9.Base.UOM.UOM</value>
		public UFIDA.U9.Base.UOM.UOM Uom
		{
			get	
			{	
				return (UFIDA.U9.Base.UOM.UOM)base.GetValue("Uom",typeof(UFIDA.U9.Base.UOM.UOM));
			}

			 set	
			{
				base.SetValue("Uom",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 动态价格数据传输对象.Misc.备注
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
		/// 动态价格行 (该属性可为空,且无默认值)
		/// 动态价格数据传输对象.Misc.动态价格行
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTO> DynamicPriceLine
		{
			get	
			{	
				return (List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTO>)base.GetValue("DynamicPriceLine",typeof(List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTO>));
			}

			 set	
			{
				base.SetValue("DynamicPriceLine",value);
			}
		}
				/// <summary>
		/// 动态价格类型 (该属性可为空,但有默认值)
		/// 动态价格数据传输对象.Misc.动态价格类型
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum DynamicPriceType
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum)base.GetValue("DynamicPriceType",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum));
			}

			 set	
			{
				base.SetValue("DynamicPriceType",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
											
		#endregion 

		#region ModelResource
		/// <summary>
		/// 动态价格数据传输对象的显示名称资源--已经废弃，不使用.
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
		/// 编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Code　{ get { return "";　}　}
		/// <summary>
		/// 单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Remark　{ get { return "";　}　}
		/// <summary>
		/// 动态价格行的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DynamicPriceLine　{ get { return "";　}　}
		/// <summary>
		/// 动态价格类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DynamicPriceType　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(DynamicPriceDTOData data)
		{
		











		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(DynamicPriceDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(DynamicPriceDTOData data,IDictionary dict)
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

			this.Code = data.Code;

			{
			if (data.Uom!=null)
			{
				UFIDA.U9.Base.UOM.UOM child = dict[data.Uom] as UFIDA.U9.Base.UOM.UOM ;
				if (child == null)
				{
					if (data.Uom.ID>0)
					{
						if (data.Uom.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.UOM.UOM)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Uom.ID,data.Uom.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Uom.SysEntityType,null,data.Uom.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Uom.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Uom, dict);
				}
				this.Uom = child ;
			}
			else
				this.Uom = null ;
			}

			this.Remark = data.Remark;

	
			if (data.DynamicPriceLine != null)
			{	
				List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTO> listDynamicPriceLine = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTO>();
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData obj in data.DynamicPriceLine ){

					UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTO child = dict[obj] as UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTO;
					if (child == null)
					{
						child = new UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTO();
						child.FromEntityData(obj,dict);
					}
					//值对象应该是依赖主创建的.但此处可能不是.
					listDynamicPriceLine.Add(child);
				
				}
				this.DynamicPriceLine = listDynamicPriceLine;
			}

			this.DynamicPriceType = UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum.GetFromValue(data.DynamicPriceType);

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public DynamicPriceDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public DynamicPriceDTOData ToEntityData(DynamicPriceDTOData data, IDictionary dict){
			if (data == null)
				data = new DynamicPriceDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (DynamicPriceDTOData)dict[this];
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

			data.Code = this.Code;

			if (this.Uom!=null)
			{
				data.Uom=this.Uom.ToEntityData(null,dict);
			}

			data.Remark = this.Remark;

	
			if (this.DynamicPriceLine != null)
			{	
				List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData> listDynamicPriceLine = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData>();
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTO obj in this.DynamicPriceLine ){
					if (obj==null) continue ;

					UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData old = dict[obj] as UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData;
					listDynamicPriceLine.Add((old != null) ? old : obj.ToEntityData(null,dict));
				
				}
				data.DynamicPriceLine = listDynamicPriceLine;
			}

			if (this.DynamicPriceType!=null)
			{
				data.DynamicPriceType = this.DynamicPriceType.Value;
			}

			return data ;
		}

		#endregion	
	}	
	
}