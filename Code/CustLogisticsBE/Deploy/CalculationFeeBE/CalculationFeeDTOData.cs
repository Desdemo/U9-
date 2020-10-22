



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用计算数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CalculationFeeDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                          
            knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Supplier.SupplierData));                          
            knownTypes.Add(typeof(UFIDA.U9.Base.Location.LocationData));                                                                                                                     
            knownTypes.Add(typeof(List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData>));             
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
		public CalculationFeeDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion= 0; 
				
					DeliveryFactory= -1; 
				
		
					PricingMethod= 0; 
							TotalAmount= 0; 
							RealAmount= 0; 
							UintPrice= 0; 
				
					Contain=false; 
					NumberOfTrucks= 1; 
				
		
		
		
		
		
		
		

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
	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        			if (this.CalculationFeeLine!=null)
			{
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData objdata in this.CalculationFeeLine)
				{
					objdata.DoSerializeKeyList(dict);
				}
			}
				        	        	        	        	        	        	        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public CalculationFeeDTOData(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , UFIDA.U9.CBO.SCM.Supplier.SupplierData sup  , System.Int32 deliveryFactory  , UFIDA.U9.Base.Location.LocationData address  , System.DateTime shipDate  , System.Int32 pricingMethod  , System.Double totalAmount  , System.Double realAmount  , System.Double uintPrice  , System.String remark  , System.Boolean contain  , System.Int32 numberOfTrucks  , List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> calculationFeeLine  , UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData huangdaoTotal  , UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData chenyangTotal  , UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineData setLocation  , UFIDA.U9.Base.Location.ProvinceData province  , UFIDA.U9.Base.Location.CityData city  , UFIDA.U9.Base.Location.CountyData county  , System.String descriLocation  )
		{
			initData();
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.Sup = sup;
			this.DeliveryFactory = deliveryFactory;
			this.Address = address;
			this.ShipDate = shipDate;
			this.PricingMethod = pricingMethod;
			this.TotalAmount = totalAmount;
			this.RealAmount = realAmount;
			this.UintPrice = uintPrice;
			this.Remark = remark;
			this.Contain = contain;
			this.NumberOfTrucks = numberOfTrucks;
			this.CalculationFeeLine = calculationFeeLine;
			this.HuangdaoTotal = huangdaoTotal;
			this.ChenyangTotal = chenyangTotal;
			this.SetLocation = setLocation;
			this.Province = province;
			this.City = city;
			this.County = county;
			this.DescriLocation = descriLocation;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// ID
		/// 费用计算数据传输对象.Key.ID
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
		/// 费用计算数据传输对象.Sys.创建时间
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
		/// 费用计算数据传输对象.Sys.创建人
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
		/// 费用计算数据传输对象.Sys.修改时间
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
		/// 费用计算数据传输对象.Sys.修改人
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
		/// 费用计算数据传输对象.Sys.事务版本
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
		/// 供应商
		/// 费用计算数据传输对象.Misc.供应商
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
		/// 提货工厂
		/// 费用计算数据传输对象.Misc.提货工厂
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_deliveryFactory ;
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
		/// 送货地址
		/// 费用计算数据传输对象.Misc.送货地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.Location.LocationData m_address ;
		public UFIDA.U9.Base.Location.LocationData Address
		{
			get	
			{	
				return m_address ;
			}
			set	
			{	
				m_address = value ;	
			}
		}
			
		

		/// <summary>
		/// 配送日期
		/// 费用计算数据传输对象.Misc.配送日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_shipDate ;
		public System.DateTime ShipDate
		{
			get	
			{	
				return m_shipDate ;
			}
			set	
			{	
				m_shipDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 计价方式
		/// 费用计算数据传输对象.Misc.计价方式
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_pricingMethod ;
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
		/// 合计金额
		/// 费用计算数据传输对象.Misc.合计金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_totalAmount ;
		public System.Double TotalAmount
		{
			get	
			{	
				return m_totalAmount ;
			}
			set	
			{	
				m_totalAmount = value ;	
			}
		}
			
		

		/// <summary>
		/// 结算金额
		/// 费用计算数据传输对象.Misc.结算金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_realAmount ;
		public System.Double RealAmount
		{
			get	
			{	
				return m_realAmount ;
			}
			set	
			{	
				m_realAmount = value ;	
			}
		}
			
		

		/// <summary>
		/// 单价
		/// 费用计算数据传输对象.Misc.单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_uintPrice ;
		public System.Double UintPrice
		{
			get	
			{	
				return m_uintPrice ;
			}
			set	
			{	
				m_uintPrice = value ;	
			}
		}
			
		

		/// <summary>
		/// 备注
		/// 费用计算数据传输对象.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_remark ;
		public System.String Remark
		{
			get	
			{	
				return m_remark ;
			}
			set	
			{	
				m_remark = value ;	
			}
		}
			
		

		/// <summary>
		/// 包含
		/// 费用计算数据传输对象.Misc.包含
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Boolean m_contain ;
		public System.Boolean Contain
		{
			get	
			{	
				return m_contain ;
			}
			set	
			{	
				m_contain = value ;	
			}
		}
			
		

		/// <summary>
		/// 派车数量
		/// 费用计算数据传输对象.Misc.派车数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_numberOfTrucks ;
		public System.Int32 NumberOfTrucks
		{
			get	
			{	
				return m_numberOfTrucks ;
			}
			set	
			{	
				m_numberOfTrucks = value ;	
			}
		}
			
		

		/// <summary>
		/// 费用计算行
		/// 费用计算数据传输对象.Misc.费用计算行
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> m_calculationFeeLine ;
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> CalculationFeeLine
		{
			get	
			{	
				if (m_calculationFeeLine == null )
				{
					List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData> n_m_list = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData>() ;
					m_calculationFeeLine = n_m_list ;
				}
				return m_calculationFeeLine ;
			}
			set	
			{	
				m_calculationFeeLine = value ;	
			}
		}
			
		

		/// <summary>
		/// 黄岛合计
		/// 费用计算数据传输对象.Misc.黄岛合计
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData m_huangdaoTotal ;
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData HuangdaoTotal
		{
			get	
			{	
				return m_huangdaoTotal ;
			}
			set	
			{	
				m_huangdaoTotal = value ;	
			}
		}
			
		

		/// <summary>
		/// 城阳合计
		/// 费用计算数据传输对象.Misc.城阳合计
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData m_chenyangTotal ;
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData ChenyangTotal
		{
			get	
			{	
				return m_chenyangTotal ;
			}
			set	
			{	
				m_chenyangTotal = value ;	
			}
		}
			
		

		/// <summary>
		/// 设定地址
		/// 费用计算数据传输对象.Misc.设定地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineData m_setLocation ;
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineData SetLocation
		{
			get	
			{	
				return m_setLocation ;
			}
			set	
			{	
				m_setLocation = value ;	
			}
		}
			
		

		/// <summary>
		/// 省
		/// 费用计算数据传输对象.Misc.省
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.Location.ProvinceData m_province ;
		public UFIDA.U9.Base.Location.ProvinceData Province
		{
			get	
			{	
				return m_province ;
			}
			set	
			{	
				m_province = value ;	
			}
		}
			
		

		/// <summary>
		/// 市
		/// 费用计算数据传输对象.Misc.市
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.Location.CityData m_city ;
		public UFIDA.U9.Base.Location.CityData City
		{
			get	
			{	
				return m_city ;
			}
			set	
			{	
				m_city = value ;	
			}
		}
			
		

		/// <summary>
		/// 属性
		/// 费用计算数据传输对象.Misc.属性
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.Location.CountyData m_county ;
		public UFIDA.U9.Base.Location.CountyData County
		{
			get	
			{	
				return m_county ;
			}
			set	
			{	
				m_county = value ;	
			}
		}
			
		

		/// <summary>
		/// 详细地址
		/// 费用计算数据传输对象.Misc.详细地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_descriLocation ;
		public System.String DescriLocation
		{
			get	
			{	
				return m_descriLocation ;
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

	
