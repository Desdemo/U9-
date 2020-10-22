
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 动态价格行 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class DynamicPriceLineData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceData));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public DynamicPriceLineData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     							No= 0; 			     							UnitPrice= 0; 			     							Start= 0; 			     							Cutoff= 0; 			     							Total= 0; 			     			
	     			


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
			get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        			
			private UFSoft.UBF.Business.BusinessEntity.EntityKey m_dynamicPrice_SKey ;
			/// <summary>
			/// 动态价格 序列化Key属性。（传递跨组织序列列字段）
			/// 动态价格行.Misc.动态价格
			/// </summary>
			[DataMember(IsRequired=false)]
			public UFSoft.UBF.Business.BusinessEntity.EntityKey DynamicPrice_SKey
			{
				get 
				{
					return m_dynamicPrice_SKey ;					
				}
				set
				{
					m_dynamicPrice_SKey = value ;	
				}
			}
		/// <summary>
		/// 动态价格
		/// 动态价格行.Misc.动态价格
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceData m_dynamicPrice;
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceData DynamicPrice
		{
			get	
			{	
				return m_dynamicPrice ;
			}
			set	
			{	
				m_dynamicPrice = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 动态价格行.Key.ID
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
		/// 动态价格行.Sys.创建时间
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
		/// 动态价格行.Sys.创建人
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
		/// 动态价格行.Sys.修改时间
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
		/// 动态价格行.Sys.修改人
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
		/// 动态价格行.Sys.事务版本
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
		/// 序号
		/// 动态价格行.Misc.序号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_no ;
		public System.Int32 No
		{
			get	
			{	
				return m_no  ;
			}
			set	
			{	
				m_no = value ;	
			}
		}
		

				/// <summary>
		/// 单价
		/// 动态价格行.Misc.单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_unitPrice ;
		public System.Double UnitPrice
		{
			get	
			{	
				return m_unitPrice  ;
			}
			set	
			{	
				m_unitPrice = value ;	
			}
		}
		

				/// <summary>
		/// 开始
		/// 动态价格行.Misc.开始
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_start ;
		public System.Double Start
		{
			get	
			{	
				return m_start  ;
			}
			set	
			{	
				m_start = value ;	
			}
		}
		

				/// <summary>
		/// 结束
		/// 动态价格行.Misc.结束
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_cutoff ;
		public System.Double Cutoff
		{
			get	
			{	
				return m_cutoff  ;
			}
			set	
			{	
				m_cutoff = value ;	
			}
		}
		

				/// <summary>
		/// 区间合计
		/// 动态价格行.Misc.区间合计
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_total ;
		public System.Double Total
		{
			get	
			{	
				return m_total  ;
			}
			set	
			{	
				m_total = value ;	
			}
		}
		

				/// <summary>
		/// 备注
		/// 动态价格行.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_remark ;
		public System.String Remark
		{
			get	
			{	
				return m_remark  ;
			}
			set	
			{	
				m_remark = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
													
		#endregion 		
	}	

}

