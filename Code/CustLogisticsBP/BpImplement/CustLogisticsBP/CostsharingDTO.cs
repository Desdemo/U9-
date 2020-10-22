


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	/// <summary>
	/// 费用分摊DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CostsharingDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CostsharingDTO(){
			initData();
		}
		private void initData()
		{
					DocID = 0; 
					DocType =UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.GetFromValue(0); 
		
					Amount = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 单据ID (该属性可为空,但有默认值)
		/// 费用分摊DTO.Misc.单据ID
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
		/// 单据类型 (该属性可为空,但有默认值)
		/// 费用分摊DTO.Misc.单据类型
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
		/// 单号 (该属性可为空,且无默认值)
		/// 费用分摊DTO.Misc.单号
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
		/// 金额 (该属性可为空,但有默认值)
		/// 费用分摊DTO.Misc.金额
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
		
		#endregion	
		#region Multi_Fields
				
		#endregion 

		#region ModelResource
		/// <summary>
		/// 费用分摊DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 单据ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocID　{ get { return "";　}　}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocType　{ get { return "";　}　}
		/// <summary>
		/// 单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Amount　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CostsharingDTOData data)
		{
		




		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CostsharingDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CostsharingDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.DocID = data.DocID;

			this.DocType = UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.GetFromValue(data.DocType);

			this.DocNo = data.DocNo;

			this.Amount = data.Amount;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CostsharingDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CostsharingDTOData ToEntityData(CostsharingDTOData data, IDictionary dict){
			if (data == null)
				data = new CostsharingDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CostsharingDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.DocID = this.DocID;

			if (this.DocType!=null)
			{
				data.DocType = this.DocType.Value;
			}

			data.DocNo = this.DocNo;

			data.Amount = this.Amount;

			return data ;
		}

		#endregion	
	}	
	
}