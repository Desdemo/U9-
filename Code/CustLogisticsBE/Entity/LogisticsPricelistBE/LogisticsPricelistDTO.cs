


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 物流价目表数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class LogisticsPricelistDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public LogisticsPricelistDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 物流价目表数据传输对象.Key.ID
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
		/// 物流价目表数据传输对象.Sys.创建时间
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
		/// 物流价目表数据传输对象.Sys.创建人
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
		/// 物流价目表数据传输对象.Sys.修改时间
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
		/// 物流价目表数据传输对象.Sys.修改人
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
		/// 物流价目表数据传输对象.Sys.事务版本
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
		/// 物流价目表数据传输对象.Misc.编码
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
		/// 名称 (该属性可为空,且无默认值)
		/// 物流价目表数据传输对象.Misc.名称
		/// </summary>
		/// <value>System.String</value>
		public System.String Name
		{
			get	
			{	
				return (System.String)base.GetValue("Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Name",value);
			}
		}
				/// <summary>
		/// 物流商 (该属性可为空,且无默认值)
		/// 物流价目表数据传输对象.Misc.物流商
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
		/// 结算币种 (该属性可为空,且无默认值)
		/// 物流价目表数据传输对象.Misc.结算币种
		/// </summary>
		/// <value>UFIDA.U9.Base.Currency.Currency</value>
		public UFIDA.U9.Base.Currency.Currency Currency
		{
			get	
			{	
				return (UFIDA.U9.Base.Currency.Currency)base.GetValue("Currency",typeof(UFIDA.U9.Base.Currency.Currency));
			}

			 set	
			{
				base.SetValue("Currency",value);
			}
		}
				/// <summary>
		/// 实体 (该属性可为空,且无默认值)
		/// 物流价目表数据传输对象.Misc.实体
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTO> LogisticsPricelistLine
		{
			get	
			{	
				return (List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTO>)base.GetValue("LogisticsPricelistLine",typeof(List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTO>));
			}

			 set	
			{
				base.SetValue("LogisticsPricelistLine",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
											
		#endregion 

		#region ModelResource
		/// <summary>
		/// 物流价目表数据传输对象的显示名称资源--已经废弃，不使用.
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
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Name　{ get { return "";　}　}
		/// <summary>
		/// 物流商的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Sup　{ get { return "";　}　}
		/// <summary>
		/// 结算币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency　{ get { return "";　}　}
		/// <summary>
		/// 实体的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LogisticsPricelistLine　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(LogisticsPricelistDTOData data)
		{
		











		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(LogisticsPricelistDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(LogisticsPricelistDTOData data,IDictionary dict)
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

			this.Name = data.Name;

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

			{
			if (data.Currency!=null)
			{
				UFIDA.U9.Base.Currency.Currency child = dict[data.Currency] as UFIDA.U9.Base.Currency.Currency ;
				if (child == null)
				{
					if (data.Currency.ID>0)
					{
						if (data.Currency.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.Currency.Currency)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Currency.ID,data.Currency.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.Currency.Currency)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Currency.SysEntityType,null,data.Currency.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.Currency.Currency)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Currency.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Currency, dict);
				}
				this.Currency = child ;
			}
			else
				this.Currency = null ;
			}

	
			if (data.LogisticsPricelistLine != null)
			{	
				List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTO> listLogisticsPricelistLine = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTO>();
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData obj in data.LogisticsPricelistLine ){

					UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTO child = dict[obj] as UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTO;
					if (child == null)
					{
						child = new UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTO();
						child.FromEntityData(obj,dict);
					}
					//值对象应该是依赖主创建的.但此处可能不是.
					listLogisticsPricelistLine.Add(child);
				
				}
				this.LogisticsPricelistLine = listLogisticsPricelistLine;
			}

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public LogisticsPricelistDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public LogisticsPricelistDTOData ToEntityData(LogisticsPricelistDTOData data, IDictionary dict){
			if (data == null)
				data = new LogisticsPricelistDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (LogisticsPricelistDTOData)dict[this];
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

			data.Name = this.Name;

			if (this.Sup!=null)
			{
				data.Sup=this.Sup.ToEntityData(null,dict);
			}

			if (this.Currency!=null)
			{
				data.Currency=this.Currency.ToEntityData(null,dict);
			}

	
			if (this.LogisticsPricelistLine != null)
			{	
				List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData> listLogisticsPricelistLine = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData>();
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTO obj in this.LogisticsPricelistLine ){
					if (obj==null) continue ;

					UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData old = dict[obj] as UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData;
					listLogisticsPricelistLine.Add((old != null) ? old : obj.ToEntityData(null,dict));
				
				}
				data.LogisticsPricelistLine = listLogisticsPricelistLine;
			}

			return data ;
		}

		#endregion	
	}	
	
}