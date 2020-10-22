
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 物流价目表行 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class LogisticsPricelistLineData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Location.LocationData));
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceData));
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Location.ProvinceData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Location.CityData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Location.CountyData));
                        
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public LogisticsPricelistLineData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     							No= 0; 			     							DeliveryFactory= 0; 			     			
	     							PricingMethod= 0; 			     			
	     							UintPrice= 0; 			     			
	     							DeliveryPickup= 0; 			     							DeliveryCharges= 0; 			     							FreePickup= 0; 			     							FreeDelivery= 0; 			     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			


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
			get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        			
			private UFSoft.UBF.Business.BusinessEntity.EntityKey m_logisticsPricelist_SKey ;
			/// <summary>
			/// 物流价目表 序列化Key属性。（传递跨组织序列列字段）
			/// 物流价目表行.Misc.物流价目表
			/// </summary>
			[DataMember(IsRequired=false)]
			public UFSoft.UBF.Business.BusinessEntity.EntityKey LogisticsPricelist_SKey
			{
				get 
				{
					return m_logisticsPricelist_SKey ;					
				}
				set
				{
					m_logisticsPricelist_SKey = value ;	
				}
			}
		/// <summary>
		/// 物流价目表
		/// 物流价目表行.Misc.物流价目表
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistData m_logisticsPricelist;
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistData LogisticsPricelist
		{
			get	
			{	
				return m_logisticsPricelist ;
			}
			set	
			{	
				m_logisticsPricelist = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 物流价目表行.Key.ID
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
		/// 物流价目表行.Sys.创建时间
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
		/// 物流价目表行.Sys.创建人
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
		/// 物流价目表行.Sys.修改时间
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
		/// 物流价目表行.Sys.修改人
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
		/// 物流价目表行.Sys.事务版本
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
		/// 物流价目表行.Misc.序号
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
		/// 提货工厂
		/// 物流价目表行.Misc.提货工厂
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_deliveryFactory ;
		public System.Int32 DeliveryFactory
		{
			get	
			{	
				return m_deliveryFactory  ;
			}
			set	
			{	
				m_deliveryFactory = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_address_SKey ;
		/// <summary>
		/// 送货地址 序列化Key属性。（传递跨组织序列列字段）
		/// 物流价目表行.Misc.送货地址
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Address_SKey
		{
			get 
			{
				return m_address_SKey ;					
			}
			set
			{
				 m_address_SKey = value ;	
			}
		}
		/// <summary>
		/// 送货地址
		/// 物流价目表行.Misc.送货地址
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Address
		{
			get	
			{	
				if (Address_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Address_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Address_SKey = null ;
				else
				{
					if (Address_SKey == null )
						Address_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Location.Location") ;
					else
						Address_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 计价方式
		/// 物流价目表行.Misc.计价方式
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_pricingMethod ;
		public System.Int32 PricingMethod
		{
			get	
			{	
				return m_pricingMethod  ;
			}
			set	
			{	
				m_pricingMethod = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_pricingUom_SKey ;
		/// <summary>
		/// 计价单位 序列化Key属性。（传递跨组织序列列字段）
		/// 物流价目表行.Misc.计价单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey PricingUom_SKey
		{
			get 
			{
				return m_pricingUom_SKey ;					
			}
			set
			{
				 m_pricingUom_SKey = value ;	
			}
		}
		/// <summary>
		/// 计价单位
		/// 物流价目表行.Misc.计价单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 PricingUom
		{
			get	
			{	
				if (PricingUom_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return PricingUom_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					PricingUom_SKey = null ;
				else
				{
					if (PricingUom_SKey == null )
						PricingUom_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.UOM.UOM") ;
					else
						PricingUom_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 单价
		/// 物流价目表行.Misc.单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_uintPrice ;
		public System.Double UintPrice
		{
			get	
			{	
				return m_uintPrice  ;
			}
			set	
			{	
				m_uintPrice = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_dynamicPrice_SKey ;
		/// <summary>
		/// 动态价格 序列化Key属性。（传递跨组织序列列字段）
		/// 物流价目表行.Misc.动态价格
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
		/// 物流价目表行.Misc.动态价格
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 DynamicPrice
		{
			get	
			{	
				if (DynamicPrice_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return DynamicPrice_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					DynamicPrice_SKey = null ;
				else
				{
					if (DynamicPrice_SKey == null )
						DynamicPrice_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice") ;
					else
						DynamicPrice_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 提货费
		/// 物流价目表行.Misc.提货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_deliveryPickup ;
		public System.Double DeliveryPickup
		{
			get	
			{	
				return m_deliveryPickup  ;
			}
			set	
			{	
				m_deliveryPickup = value ;	
			}
		}
		

				/// <summary>
		/// 送货费
		/// 物流价目表行.Misc.送货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_deliveryCharges ;
		public System.Double DeliveryCharges
		{
			get	
			{	
				return m_deliveryCharges  ;
			}
			set	
			{	
				m_deliveryCharges = value ;	
			}
		}
		

				/// <summary>
		/// 免提标准
		/// 物流价目表行.Misc.免提标准
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_freePickup ;
		public System.Double FreePickup
		{
			get	
			{	
				return m_freePickup  ;
			}
			set	
			{	
				m_freePickup = value ;	
			}
		}
		

				/// <summary>
		/// 免送标准
		/// 物流价目表行.Misc.免送标准
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_freeDelivery ;
		public System.Double FreeDelivery
		{
			get	
			{	
				return m_freeDelivery  ;
			}
			set	
			{	
				m_freeDelivery = value ;	
			}
		}
		

				/// <summary>
		/// 运输时间
		/// 物流价目表行.Misc.运输时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_transportationTime ;
		public System.String TransportationTime
		{
			get	
			{	
				return m_transportationTime  ;
			}
			set	
			{	
				m_transportationTime = value ;	
			}
		}
		

				/// <summary>
		/// 备注
		/// 物流价目表行.Misc.备注
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_province_SKey ;
		/// <summary>
		/// 省/自治区 序列化Key属性。（传递跨组织序列列字段）
		/// 物流价目表行.Misc.省/自治区
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Province_SKey
		{
			get 
			{
				return m_province_SKey ;					
			}
			set
			{
				 m_province_SKey = value ;	
			}
		}
		/// <summary>
		/// 省/自治区
		/// 物流价目表行.Misc.省/自治区
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Province
		{
			get	
			{	
				if (Province_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Province_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Province_SKey = null ;
				else
				{
					if (Province_SKey == null )
						Province_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Location.Province") ;
					else
						Province_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_city_SKey ;
		/// <summary>
		/// 城市 序列化Key属性。（传递跨组织序列列字段）
		/// 物流价目表行.Misc.城市
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey City_SKey
		{
			get 
			{
				return m_city_SKey ;					
			}
			set
			{
				 m_city_SKey = value ;	
			}
		}
		/// <summary>
		/// 城市
		/// 物流价目表行.Misc.城市
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 City
		{
			get	
			{	
				if (City_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return City_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					City_SKey = null ;
				else
				{
					if (City_SKey == null )
						City_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Location.City") ;
					else
						City_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_county_SKey ;
		/// <summary>
		/// 区县 序列化Key属性。（传递跨组织序列列字段）
		/// 物流价目表行.Misc.区县
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey County_SKey
		{
			get 
			{
				return m_county_SKey ;					
			}
			set
			{
				 m_county_SKey = value ;	
			}
		}
		/// <summary>
		/// 区县
		/// 物流价目表行.Misc.区县
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 County
		{
			get	
			{	
				if (County_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return County_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					County_SKey = null ;
				else
				{
					if (County_SKey == null )
						County_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Location.County") ;
					else
						County_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 详细地址
		/// 物流价目表行.Misc.详细地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_describeAddress ;
		public System.String DescribeAddress
		{
			get	
			{	
				return m_describeAddress  ;
			}
			set	
			{	
				m_describeAddress = value ;	
			}
		}
		

				/// <summary>
		/// 地址
		/// 物流价目表行.Misc.地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_formatAddress ;
		public System.String FormatAddress
		{
			get	
			{	
				return m_formatAddress  ;
			}
			set	
			{	
				m_formatAddress = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
																									
		#endregion 		
	}	

}

