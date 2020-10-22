
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用计算 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class CalculationFeeData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Supplier.SupplierData));
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData>));
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData));
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData));
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Location.ProvinceData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Location.CityData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Location.CountyData));
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public CalculationFeeData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     							DeliveryFactory= -1; 			     			
	     			
	     							PricingMethod= 0; 			     							TotalAmount= 0; 			     							RealAmount= 0; 			     							UintPrice= 0; 			     			
	     							Contain=false; 
	     							NumberOfTrucks= 1; 			     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			


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
			get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 提货工厂
		/// 费用计算.Misc.提货工厂
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_deliveryFactory;
		public System.Int32 DeliveryFactory
		{
			get	
			{	
				return m_deliveryFactory ;
			}
			set	
			{	
				m_deliveryFactory = value ;
			}
		}		

			        					/// <summary>
		/// 计价方式
		/// 费用计算.Misc.计价方式
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_pricingMethod;
		public System.Int32 PricingMethod
		{
			get	
			{	
				return m_pricingMethod ;
			}
			set	
			{	
				m_pricingMethod = value ;
			}
		}		

			        					/// <summary>
		/// 费用计算行
		/// 费用计算.Misc.费用计算行
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> m_calculationFeeLine;
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> CalculationFeeLine
		{
			get	
			{	
				if (m_calculationFeeLine == null)
				{
					List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> m_list = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData>() ;
					m_calculationFeeLine = m_list;
				}
				return m_calculationFeeLine ;
			}
			set	
			{	
				m_calculationFeeLine = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 费用计算.Key.ID
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
		/// 费用计算.Sys.创建时间
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
		/// 费用计算.Sys.创建人
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
		/// 费用计算.Sys.修改时间
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
		/// 费用计算.Sys.修改人
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
		/// 费用计算.Sys.事务版本
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_sup_SKey ;
		/// <summary>
		/// 供应商 序列化Key属性。（传递跨组织序列列字段）
		/// 费用计算.Misc.供应商
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
		/// 供应商
		/// 费用计算.Misc.供应商
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
		

				/// <summary>
		/// 送货地址
		/// 费用计算.Misc.送货地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_address ;
		public System.String Address
		{
			get	
			{	
				return m_address  ;
			}
			set	
			{	
				m_address = value ;	
			}
		}
		

				/// <summary>
		/// 配送日期
		/// 费用计算.Misc.配送日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_shipDate ;
		public System.DateTime ShipDate
		{
			get	
			{	
				return m_shipDate  ;
			}
			set	
			{	
				m_shipDate = value ;	
			}
		}
		

				/// <summary>
		/// 合计金额
		/// 费用计算.Misc.合计金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_totalAmount ;
		public System.Double TotalAmount
		{
			get	
			{	
				return m_totalAmount  ;
			}
			set	
			{	
				m_totalAmount = value ;	
			}
		}
		

				/// <summary>
		/// 结算金额
		/// 费用计算.Misc.结算金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_realAmount ;
		public System.Double RealAmount
		{
			get	
			{	
				return m_realAmount  ;
			}
			set	
			{	
				m_realAmount = value ;	
			}
		}
		

				/// <summary>
		/// 单价
		/// 费用计算.Misc.单价
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
		

				/// <summary>
		/// 备注
		/// 费用计算.Misc.备注
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
		/// 包含
		/// 费用计算.Misc.包含
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Boolean m_contain ;
		public System.Boolean Contain
		{
			get	
			{	
				return m_contain  ;
			}
			set	
			{	
				m_contain = value ;	
			}
		}
		

				/// <summary>
		/// 派车数量
		/// 费用计算.Misc.派车数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_numberOfTrucks ;
		public System.Int32 NumberOfTrucks
		{
			get	
			{	
				return m_numberOfTrucks  ;
			}
			set	
			{	
				m_numberOfTrucks = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_huangdaoTotal_SKey ;
		/// <summary>
		/// 黄岛合计 序列化Key属性。（传递跨组织序列列字段）
		/// 费用计算.Misc.黄岛合计
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey HuangdaoTotal_SKey
		{
			get 
			{
				return m_huangdaoTotal_SKey ;					
			}
			set
			{
				 m_huangdaoTotal_SKey = value ;	
			}
		}
		/// <summary>
		/// 黄岛合计
		/// 费用计算.Misc.黄岛合计
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 HuangdaoTotal
		{
			get	
			{	
				if (HuangdaoTotal_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return HuangdaoTotal_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					HuangdaoTotal_SKey = null ;
				else
				{
					if (HuangdaoTotal_SKey == null )
						HuangdaoTotal_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine") ;
					else
						HuangdaoTotal_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_chenyangTotal_SKey ;
		/// <summary>
		/// 城阳合计 序列化Key属性。（传递跨组织序列列字段）
		/// 费用计算.Misc.城阳合计
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey ChenyangTotal_SKey
		{
			get 
			{
				return m_chenyangTotal_SKey ;					
			}
			set
			{
				 m_chenyangTotal_SKey = value ;	
			}
		}
		/// <summary>
		/// 城阳合计
		/// 费用计算.Misc.城阳合计
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 ChenyangTotal
		{
			get	
			{	
				if (ChenyangTotal_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return ChenyangTotal_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					ChenyangTotal_SKey = null ;
				else
				{
					if (ChenyangTotal_SKey == null )
						ChenyangTotal_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine") ;
					else
						ChenyangTotal_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_setLocation_SKey ;
		/// <summary>
		/// 设定地址 序列化Key属性。（传递跨组织序列列字段）
		/// 费用计算.Misc.设定地址
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey SetLocation_SKey
		{
			get 
			{
				return m_setLocation_SKey ;					
			}
			set
			{
				 m_setLocation_SKey = value ;	
			}
		}
		/// <summary>
		/// 设定地址
		/// 费用计算.Misc.设定地址
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 SetLocation
		{
			get	
			{	
				if (SetLocation_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return SetLocation_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					SetLocation_SKey = null ;
				else
				{
					if (SetLocation_SKey == null )
						SetLocation_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine") ;
					else
						SetLocation_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_province_SKey ;
		/// <summary>
		/// 省 序列化Key属性。（传递跨组织序列列字段）
		/// 费用计算.Misc.省
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
		/// 省
		/// 费用计算.Misc.省
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
		/// 市 序列化Key属性。（传递跨组织序列列字段）
		/// 费用计算.Misc.市
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
		/// 市
		/// 费用计算.Misc.市
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
		/// 费用计算.Misc.区县
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
		/// 费用计算.Misc.区县
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
		/// 费用计算.Misc.详细地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_descriLocation ;
		public System.String DescriLocation
		{
			get	
			{	
				return m_descriLocation  ;
			}
			set	
			{	
				m_descriLocation = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
																									
		#endregion 		
	}	

}

