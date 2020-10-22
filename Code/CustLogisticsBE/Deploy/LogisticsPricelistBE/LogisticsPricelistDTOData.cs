



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 物流价目表数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class LogisticsPricelistDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                                                    
            knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Supplier.SupplierData));             
            knownTypes.Add(typeof(UFIDA.U9.Base.Currency.CurrencyData));             
            knownTypes.Add(typeof(List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData>)); 
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public LogisticsPricelistDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion= 0; 
				
		
		
		
		

			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
		#region Do SerializeKey -ForDTODataType
		//只为处理集合型EntityKey。原因集合型EntityKey由于使用臫的集合对象，无法实现数据共享.-UBF专用.
		public void DoSerializeKeyList(IDictionary dict)
		{
			if (dict == null ) dict = new Hashtable() ;
			if (dict[this] != null)
				return ;
			dict[this] = this;
	        	        	        	        	        	        	        	        	        	        	        			if (this.LogisticsPricelistLine!=null)
			{
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData objdata in this.LogisticsPricelistLine)
				{
					objdata.DoSerializeKeyList(dict);
				}
			}
			
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public LogisticsPricelistDTOData(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.String code  , System.String name  , UFIDA.U9.CBO.SCM.Supplier.SupplierData sup  , UFIDA.U9.Base.Currency.CurrencyData currency  , List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData> logisticsPricelistLine  )
		{
			initData();
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.Code = code;
			this.Name = name;
			this.Sup = sup;
			this.Currency = currency;
			this.LogisticsPricelistLine = logisticsPricelistLine;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// ID
		/// 物流价目表数据传输对象.Key.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
			
		

		/// <summary>
		/// 创建时间
		/// 物流价目表数据传输对象.Sys.创建时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_createdOn ;
		public System.DateTime CreatedOn
		{
			get	
			{	
				return m_createdOn ;
			}
			set	
			{	
				m_createdOn = value ;	
			}
		}
			
		

		/// <summary>
		/// 创建人
		/// 物流价目表数据传输对象.Sys.创建人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_createdBy ;
		public System.String CreatedBy
		{
			get	
			{	
				return m_createdBy ;
			}
			set	
			{	
				m_createdBy = value ;	
			}
		}
			
		

		/// <summary>
		/// 修改时间
		/// 物流价目表数据传输对象.Sys.修改时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_modifiedOn ;
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return m_modifiedOn ;
			}
			set	
			{	
				m_modifiedOn = value ;	
			}
		}
			
		

		/// <summary>
		/// 修改人
		/// 物流价目表数据传输对象.Sys.修改人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_modifiedBy ;
		public System.String ModifiedBy
		{
			get	
			{	
				return m_modifiedBy ;
			}
			set	
			{	
				m_modifiedBy = value ;	
			}
		}
			
		

		/// <summary>
		/// 事务版本
		/// 物流价目表数据传输对象.Sys.事务版本
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sysVersion ;
		public System.Int64 SysVersion
		{
			get	
			{	
				return m_sysVersion ;
			}
			set	
			{	
				m_sysVersion = value ;	
			}
		}
			
		

		/// <summary>
		/// 编码
		/// 物流价目表数据传输对象.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_code ;
		public System.String Code
		{
			get	
			{	
				return m_code ;
			}
			set	
			{	
				m_code = value ;	
			}
		}
			
		

		/// <summary>
		/// 名称
		/// 物流价目表数据传输对象.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_name ;
		public System.String Name
		{
			get	
			{	
				return m_name ;
			}
			set	
			{	
				m_name = value ;	
			}
		}
			
		

		/// <summary>
		/// 物流商
		/// 物流价目表数据传输对象.Misc.物流商
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.CBO.SCM.Supplier.SupplierData m_sup ;
		public UFIDA.U9.CBO.SCM.Supplier.SupplierData Sup
		{
			get	
			{	
				return m_sup ;
			}
			set	
			{	
				m_sup = value ;	
			}
		}
			
		

		/// <summary>
		/// 结算币种
		/// 物流价目表数据传输对象.Misc.结算币种
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.Currency.CurrencyData m_currency ;
		public UFIDA.U9.Base.Currency.CurrencyData Currency
		{
			get	
			{	
				return m_currency ;
			}
			set	
			{	
				m_currency = value ;	
			}
		}
			
		

		/// <summary>
		/// 实体
		/// 物流价目表数据传输对象.Misc.实体
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData> m_logisticsPricelistLine ;
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData> LogisticsPricelistLine
		{
			get	
			{	
				if (m_logisticsPricelistLine == null )
				{
					List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData> n_m_list = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData>() ;
					m_logisticsPricelistLine = n_m_list ;
				}
				return m_logisticsPricelistLine ;
			}
			set	
			{	
				m_logisticsPricelistLine = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																						
		#endregion 
	} 	
}

	
