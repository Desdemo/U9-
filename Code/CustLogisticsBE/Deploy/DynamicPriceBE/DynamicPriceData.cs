
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 动态价格 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class DynamicPriceData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));
                        
                                        knownTypes.Add(typeof(List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineData>));
                        
                        
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public DynamicPriceData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     			
	     			
	     							DynamicPriceType= 0; 			     							EffectField= 0; 			     			


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
			get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 动态价格行
		/// 动态价格.Misc.动态价格行
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineData> m_dynamicPriceLine;
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineData> DynamicPriceLine
		{
			get	
			{	
				if (m_dynamicPriceLine == null)
				{
					List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineData> m_list = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineData>() ;
					m_dynamicPriceLine = m_list;
				}
				return m_dynamicPriceLine ;
			}
			set	
			{	
				m_dynamicPriceLine = value ;
			}
		}		

			        					/// <summary>
		/// 动态价格类型
		/// 动态价格.Misc.动态价格类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_dynamicPriceType;
		public System.Int32 DynamicPriceType
		{
			get	
			{	
				return m_dynamicPriceType ;
			}
			set	
			{	
				m_dynamicPriceType = value ;
			}
		}		

			        					/// <summary>
		/// 作用字段
		/// 动态价格.Misc.作用字段
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_effectField;
		public System.Int32 EffectField
		{
			get	
			{	
				return m_effectField ;
			}
			set	
			{	
				m_effectField = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 动态价格.Key.ID
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
		/// 动态价格.Sys.创建时间
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
		/// 动态价格.Sys.创建人
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
		/// 动态价格.Sys.修改时间
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
		/// 动态价格.Sys.修改人
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
		/// 动态价格.Sys.事务版本
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
		/// 动态价格.Misc.编码
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_uom_SKey ;
		/// <summary>
		/// 单位 序列化Key属性。（传递跨组织序列列字段）
		/// 动态价格.Misc.单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Uom_SKey
		{
			get 
			{
				return m_uom_SKey ;					
			}
			set
			{
				 m_uom_SKey = value ;	
			}
		}
		/// <summary>
		/// 单位
		/// 动态价格.Misc.单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Uom
		{
			get	
			{	
				if (Uom_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Uom_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Uom_SKey = null ;
				else
				{
					if (Uom_SKey == null )
						Uom_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.UOM.UOM") ;
					else
						Uom_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 备注
		/// 动态价格.Misc.备注
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
		

				/// <summary>
		/// 名称
		/// 动态价格.Misc.名称
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
		
		#endregion	

		#region Multi_Fields
													
		#endregion 		
	}	

}

