


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用记录关联数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class FeeRecordLinkedDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public FeeRecordLinkedDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
					SrcType =UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.GetFromValue(0); 
					SrcDocID = 0; 
					Amount = 0; 
					DeliveryID = 0; 
					SrcDocNo  ="0";
					DeliveryNo  ="0";

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 费用记录关联数据传输对象.Key.ID
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
		/// 费用记录关联数据传输对象.Sys.创建时间
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
		/// 费用记录关联数据传输对象.Sys.创建人
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
		/// 费用记录关联数据传输对象.Sys.修改时间
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
		/// 费用记录关联数据传输对象.Sys.修改人
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
		/// 费用记录关联数据传输对象.Sys.事务版本
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
		/// 来源单据类型 (该属性可为空,但有默认值)
		/// 费用记录关联数据传输对象.Misc.来源单据类型
		/// </summary>
		/// <value>UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum</value>
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum SrcType
		{
			get	
			{	
				return (UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum)base.GetValue("SrcType",typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum));
			}

			 set	
			{
				base.SetValue("SrcType",value);
			}
		}
				/// <summary>
		/// 来源单据ID (该属性可为空,但有默认值)
		/// 费用记录关联数据传输对象.Misc.来源单据ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcDocID
		{
			get	
			{	
				return (System.Int64)base.GetValue("SrcDocID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SrcDocID",value);
			}
		}
				/// <summary>
		/// 金额 (该属性可为空,但有默认值)
		/// 费用记录关联数据传输对象.Misc.金额
		/// </summary>
		/// <value>System.Double</value>
		public System.Double Amount
		{
			get	
			{	
				return (System.Double)base.GetValue("Amount",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("Amount",value);
			}
		}
				/// <summary>
		/// 配送单ID (该属性可为空,但有默认值)
		/// 费用记录关联数据传输对象.Misc.配送单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 DeliveryID
		{
			get	
			{	
				return (System.Int64)base.GetValue("DeliveryID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("DeliveryID",value);
			}
		}
				/// <summary>
		/// 来源单据号 (该属性可为空,但有默认值)
		/// 费用记录关联数据传输对象.Misc.来源单据号
		/// </summary>
		/// <value>System.String</value>
		public System.String SrcDocNo
		{
			get	
			{	
				return (System.String)base.GetValue("SrcDocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SrcDocNo",value);
			}
		}
				/// <summary>
		/// 配送单号 (该属性可为空,但有默认值)
		/// 费用记录关联数据传输对象.Misc.配送单号
		/// </summary>
		/// <value>System.String</value>
		public System.String DeliveryNo
		{
			get	
			{	
				return (System.String)base.GetValue("DeliveryNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DeliveryNo",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
												
		#endregion 

		#region ModelResource
		/// <summary>
		/// 费用记录关联数据传输对象的显示名称资源--已经废弃，不使用.
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
		/// 来源单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcType　{ get { return "";　}　}
		/// <summary>
		/// 来源单据ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcDocID　{ get { return "";　}　}
		/// <summary>
		/// 金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Amount　{ get { return "";　}　}
		/// <summary>
		/// 配送单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DeliveryID　{ get { return "";　}　}
		/// <summary>
		/// 来源单据号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcDocNo　{ get { return "";　}　}
		/// <summary>
		/// 配送单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DeliveryNo　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(FeeRecordLinkedDTOData data)
		{
		












		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(FeeRecordLinkedDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(FeeRecordLinkedDTOData data,IDictionary dict)
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

			this.SrcType = UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.GetFromValue(data.SrcType);

			this.SrcDocID = data.SrcDocID;

			this.Amount = data.Amount;

			this.DeliveryID = data.DeliveryID;

			this.SrcDocNo = data.SrcDocNo;

			this.DeliveryNo = data.DeliveryNo;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public FeeRecordLinkedDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public FeeRecordLinkedDTOData ToEntityData(FeeRecordLinkedDTOData data, IDictionary dict){
			if (data == null)
				data = new FeeRecordLinkedDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (FeeRecordLinkedDTOData)dict[this];
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

			if (this.SrcType!=null)
			{
				data.SrcType = this.SrcType.Value;
			}

			data.SrcDocID = this.SrcDocID;

			data.Amount = this.Amount;

			data.DeliveryID = this.DeliveryID;

			data.SrcDocNo = this.SrcDocNo;

			data.DeliveryNo = this.DeliveryNo;

			return data ;
		}

		#endregion	
	}	
	
}