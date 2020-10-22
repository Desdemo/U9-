
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 物流价目表 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class LogisticsPricelistData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Supplier.SupplierData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Currency.CurrencyData));
                                        knownTypes.Add(typeof(List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineData>));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public LogisticsPricelistData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     			
	     			
	     			


			//设置组合的集合属性为List<>对象. -目前直接在属性上处理.
			
			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}		
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
        
		#region System Fields
		///<summary>
		/// 实体类型. 
		/// </summary>
		[DataMember(IsRequired=false)]
		public override string SysEntityType
		{
			get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 实体
		/// 物流价目表.Misc.实体
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineData> m_logisticsPricelistLine;
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineData> LogisticsPricelistLine
		{
			get	
			{	
				if (m_logisticsPricelistLine == null)
				{
					List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineData> m_list = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineData>() ;
					m_logisticsPricelistLine = m_list;
				}
				return m_logisticsPricelistLine ;
			}
			set	
			{	
				m_logisticsPricelistLine = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 物流价目表.Key.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD  ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
		

				/// <summary>
		/// 创建时间
		/// 物流价目表.Sys.创建时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_createdOn ;
		public System.DateTime CreatedOn
		{
			get	
			{	
				return m_createdOn  ;
			}
			set	
			{	
				m_createdOn = value ;	
			}
		}
		

				/// <summary>
		/// 创建人
		/// 物流价目表.Sys.创建人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_createdBy ;
		public System.String CreatedBy
		{
			get	
			{	
				return m_createdBy  ;
			}
			set	
			{	
				m_createdBy = value ;	
			}
		}
		

				/// <summary>
		/// 修改时间
		/// 物流价目表.Sys.修改时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_modifiedOn ;
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return m_modifiedOn  ;
			}
			set	
			{	
				m_modifiedOn = value ;	
			}
		}
		

				/// <summary>
		/// 修改人
		/// 物流价目表.Sys.修改人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_modifiedBy ;
		public System.String ModifiedBy
		{
			get	
			{	
				return m_modifiedBy  ;
			}
			set	
			{	
				m_modifiedBy = value ;	
			}
		}
		

				/// <summary>
		/// 事务版本
		/// 物流价目表.Sys.事务版本
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sysVersion ;
		public System.Int64 SysVersion
		{
			get	
			{	
				return m_sysVersion  ;
			}
			set	
			{	
				m_sysVersion = value ;	
			}
		}
		

				/// <summary>
		/// 编码
		/// 物流价目表.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_code ;
		public System.String Code
		{
			get	
			{	
				return m_code  ;
			}
			set	
			{	
				m_code = value ;	
			}
		}
		

				/// <summary>
		/// 名称
		/// 物流价目表.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_name ;
		public System.String Name
		{
			get	
			{	
				return m_name  ;
			}
			set	
			{	
				m_name = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_sup_SKey ;
		/// <summary>
		/// 物流商 序列化Key属性。（传递跨组织序列列字段）
		/// 物流价目表.Misc.物流商
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Sup_SKey
		{
			get 
			{
				return m_sup_SKey ;					
			}
			set
			{
				 m_sup_SKey = value ;	
			}
		}
		/// <summary>
		/// 物流商
		/// 物流价目表.Misc.物流商
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Sup
		{
			get	
			{	
				if (Sup_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Sup_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Sup_SKey = null ;
				else
				{
					if (Sup_SKey == null )
						Sup_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Supplier.Supplier") ;
					else
						Sup_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_currency_SKey ;
		/// <summary>
		/// 结算币种 序列化Key属性。（传递跨组织序列列字段）
		/// 物流价目表.Misc.结算币种
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Currency_SKey
		{
			get 
			{
				return m_currency_SKey ;					
			}
			set
			{
				 m_currency_SKey = value ;	
			}
		}
		/// <summary>
		/// 结算币种
		/// 物流价目表.Misc.结算币种
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Currency
		{
			get	
			{	
				if (Currency_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Currency_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Currency_SKey = null ;
				else
				{
					if (Currency_SKey == null )
						Currency_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Currency.Currency") ;
					else
						Currency_SKey.ID = value ;
				}
			}
		}
		
		#endregion	

		#region Multi_Fields
											
		#endregion 		
	}	

}

