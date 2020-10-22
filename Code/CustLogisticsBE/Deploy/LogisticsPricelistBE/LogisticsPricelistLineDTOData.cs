



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 物流价目表行数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLineDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class LogisticsPricelistLineDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                                                    
            knownTypes.Add(typeof(UFIDA.U9.Base.Location.LocationData));                          
            knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));                          
            knownTypes.Add(typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceData));                                                                                           
            knownTypes.Add(typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTOData));             
            knownTypes.Add(typeof(UFIDA.U9.Base.Location.ProvinceData));             
            knownTypes.Add(typeof(UFIDA.U9.Base.Location.CityData));             
            knownTypes.Add(typeof(UFIDA.U9.Base.Location.CountyData));                           
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public LogisticsPricelistLineDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion= 0; 
							No= 0; 
							DeliveryFactory= 0; 
				
					PricingMethod= 0; 
				
					UintPrice= 0; 
				
					DeliveryPickup= 0; 
							DeliveryCharges= 0; 
							FreePickup= 0; 
							FreeDelivery= 0; 
				
		
		
		
		
		
		
		

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
	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        			if (this.LogisticsPricelist != null) 
			{
				this.LogisticsPricelist.DoSerializeKeyList(dict);
			}
	        	        	        	        	        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public LogisticsPricelistLineDTOData(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.Int32 no  , System.Int32 deliveryFactory  , UFIDA.U9.Base.Location.LocationData address  , System.Int32 pricingMethod  , UFIDA.U9.Base.UOM.UOMData pricingUom  , System.Double uintPrice  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceData dynamicPrice  , System.Double deliveryPickup  , System.Double deliveryCharges  , System.Double freePickup  , System.Double freeDelivery  , System.String transportationTime  , System.String remark  , UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTOData logisticsPricelist  , UFIDA.U9.Base.Location.ProvinceData province  , UFIDA.U9.Base.Location.CityData city  , UFIDA.U9.Base.Location.CountyData county  , System.String describeAddress  , System.String formatAddress  )
		{
			initData();
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.No = no;
			this.DeliveryFactory = deliveryFactory;
			this.Address = address;
			this.PricingMethod = pricingMethod;
			this.PricingUom = pricingUom;
			this.UintPrice = uintPrice;
			this.DynamicPrice = dynamicPrice;
			this.DeliveryPickup = deliveryPickup;
			this.DeliveryCharges = deliveryCharges;
			this.FreePickup = freePickup;
			this.FreeDelivery = freeDelivery;
			this.TransportationTime = transportationTime;
			this.Remark = remark;
			this.LogisticsPricelist = logisticsPricelist;
			this.Province = province;
			this.City = city;
			this.County = county;
			this.DescribeAddress = describeAddress;
			this.FormatAddress = formatAddress;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// ID
		/// 物流价目表行数据传输对象.Key.ID
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
		/// 物流价目表行数据传输对象.Sys.创建时间
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
		/// 物流价目表行数据传输对象.Sys.创建人
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
		/// 物流价目表行数据传输对象.Sys.修改时间
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
		/// 物流价目表行数据传输对象.Sys.修改人
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
		/// 物流价目表行数据传输对象.Sys.事务版本
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
		/// 序号
		/// 物流价目表行数据传输对象.Misc.序号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_no ;
		public System.Int32 No
		{
			get	
			{	
				return m_no ;
			}
			set	
			{	
				m_no = value ;	
			}
		}
			
		

		/// <summary>
		/// 提货工厂
		/// 物流价目表行数据传输对象.Misc.提货工厂
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
		/// 物流价目表行数据传输对象.Misc.送货地址
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
		/// 计价方式
		/// 物流价目表行数据传输对象.Misc.计价方式
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
		/// 计价单位
		/// 物流价目表行数据传输对象.Misc.计价单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.UOM.UOMData m_pricingUom ;
		public UFIDA.U9.Base.UOM.UOMData PricingUom
		{
			get	
			{	
				return m_pricingUom ;
			}
			set	
			{	
				m_pricingUom = value ;	
			}
		}
			
		

		/// <summary>
		/// 单价
		/// 物流价目表行数据传输对象.Misc.单价
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
		/// 动态价格
		/// 物流价目表行数据传输对象.Misc.动态价格
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceData m_dynamicPrice ;
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
			
		

		/// <summary>
		/// 提货费
		/// 物流价目表行数据传输对象.Misc.提货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_deliveryPickup ;
		public System.Double DeliveryPickup
		{
			get	
			{	
				return m_deliveryPickup ;
			}
			set	
			{	
				m_deliveryPickup = value ;	
			}
		}
			
		

		/// <summary>
		/// 送货费
		/// 物流价目表行数据传输对象.Misc.送货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_deliveryCharges ;
		public System.Double DeliveryCharges
		{
			get	
			{	
				return m_deliveryCharges ;
			}
			set	
			{	
				m_deliveryCharges = value ;	
			}
		}
			
		

		/// <summary>
		/// 免提标准
		/// 物流价目表行数据传输对象.Misc.免提标准
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_freePickup ;
		public System.Double FreePickup
		{
			get	
			{	
				return m_freePickup ;
			}
			set	
			{	
				m_freePickup = value ;	
			}
		}
			
		

		/// <summary>
		/// 免送标准
		/// 物流价目表行数据传输对象.Misc.免送标准
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_freeDelivery ;
		public System.Double FreeDelivery
		{
			get	
			{	
				return m_freeDelivery ;
			}
			set	
			{	
				m_freeDelivery = value ;	
			}
		}
			
		

		/// <summary>
		/// 运输时间
		/// 物流价目表行数据传输对象.Misc.运输时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_transportationTime ;
		public System.String TransportationTime
		{
			get	
			{	
				return m_transportationTime ;
			}
			set	
			{	
				m_transportationTime = value ;	
			}
		}
			
		

		/// <summary>
		/// 备注
		/// 物流价目表行数据传输对象.Misc.备注
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
		/// 物流价目表
		/// 物流价目表行数据传输对象.Misc.物流价目表
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTOData m_logisticsPricelist ;
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistDTOData LogisticsPricelist
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
			
		

		/// <summary>
		/// 省/自治区
		/// 物流价目表行数据传输对象.Misc.省/自治区
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
		/// 城市
		/// 物流价目表行数据传输对象.Misc.城市
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
		/// 区县
		/// 物流价目表行数据传输对象.Misc.区县
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
		/// 物流价目表行数据传输对象.Misc.详细地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_describeAddress ;
		public System.String DescribeAddress
		{
			get	
			{	
				return m_describeAddress ;
			}
			set	
			{	
				m_describeAddress = value ;	
			}
		}
			
		

		/// <summary>
		/// 地址
		/// 物流价目表行数据传输对象.Misc.地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_formatAddress ;
		public System.String FormatAddress
		{
			get	
			{	
				return m_formatAddress ;
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

	
