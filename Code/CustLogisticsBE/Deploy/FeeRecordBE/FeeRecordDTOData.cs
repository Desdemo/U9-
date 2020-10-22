



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用记录数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class FeeRecordDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                                                                                                        
            knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Supplier.SupplierData));                                       
            knownTypes.Add(typeof(UFIDA.U9.Base.Location.ProvinceData));                                       
            knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));             
            knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));                                                                                                                                               
            knownTypes.Add(typeof(UFIDA.U9.Base.Location.CityData));             
            knownTypes.Add(typeof(UFIDA.U9.Base.Location.CountyData));                           
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public FeeRecordDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion= 0; 
							BusinessType= 0; 
				
		
		
		
		
		
					Qty= 0; 
							ProductCategory= 0; 
				
					IBulk= 0; 
							Weight= 0; 
				
		
					PickupFee= 0; 
							DeliveryFee= 0; 
							DischargeFee= 0; 
							OtherFee= 0; 
							StandardShipping= 0; 
							TotalFreight= 0; 
							RealFreight= 0; 
							AverageCost= 0; 
							UintPrice= 0; 
				
		
		
		
		

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
	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public FeeRecordDTOData(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.Int32 businessType  , System.String salesman  , System.String customerContact  , System.String contactPhone  , System.DateTime shipDate  , System.String saleNo  , UFIDA.U9.CBO.SCM.Supplier.SupplierData supplier  , System.Double qty  , System.Int32 productCategory  , UFIDA.U9.Base.Location.ProvinceData province  , System.Double iBulk  , System.Double weight  , UFIDA.U9.Base.UOM.UOMData bulkUom  , UFIDA.U9.Base.UOM.UOMData weightUom  , System.Double pickupFee  , System.Double deliveryFee  , System.Double dischargeFee  , System.Double otherFee  , System.Double standardShipping  , System.Double totalFreight  , System.Double realFreight  , System.Double averageCost  , System.Double uintPrice  , System.String remark  , UFIDA.U9.Base.Location.CityData city  , UFIDA.U9.Base.Location.CountyData county  , System.String describeAddress  , System.String fullAddress  )
		{
			initData();
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.BusinessType = businessType;
			this.Salesman = salesman;
			this.CustomerContact = customerContact;
			this.ContactPhone = contactPhone;
			this.ShipDate = shipDate;
			this.SaleNo = saleNo;
			this.Supplier = supplier;
			this.Qty = qty;
			this.ProductCategory = productCategory;
			this.Province = province;
			this.IBulk = iBulk;
			this.Weight = weight;
			this.BulkUom = bulkUom;
			this.WeightUom = weightUom;
			this.PickupFee = pickupFee;
			this.DeliveryFee = deliveryFee;
			this.DischargeFee = dischargeFee;
			this.OtherFee = otherFee;
			this.StandardShipping = standardShipping;
			this.TotalFreight = totalFreight;
			this.RealFreight = realFreight;
			this.AverageCost = averageCost;
			this.UintPrice = uintPrice;
			this.Remark = remark;
			this.City = city;
			this.County = county;
			this.DescribeAddress = describeAddress;
			this.FullAddress = fullAddress;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// ID
		/// 费用记录数据传输对象.Key.ID
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
		/// 费用记录数据传输对象.Sys.创建时间
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
		/// 费用记录数据传输对象.Sys.创建人
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
		/// 费用记录数据传输对象.Sys.修改时间
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
		/// 费用记录数据传输对象.Sys.修改人
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
		/// 费用记录数据传输对象.Sys.事务版本
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
		/// 业务类型
		/// 费用记录数据传输对象.Misc.业务类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_businessType ;
		public System.Int32 BusinessType
		{
			get	
			{	
				return m_businessType ;
			}
			set	
			{	
				m_businessType = value ;	
			}
		}
			
		

		/// <summary>
		/// 跟单
		/// 费用记录数据传输对象.Misc.跟单
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_salesman ;
		public System.String Salesman
		{
			get	
			{	
				return m_salesman ;
			}
			set	
			{	
				m_salesman = value ;	
			}
		}
			
		

		/// <summary>
		/// 客户联系人
		/// 费用记录数据传输对象.Misc.客户联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerContact ;
		public System.String CustomerContact
		{
			get	
			{	
				return m_customerContact ;
			}
			set	
			{	
				m_customerContact = value ;	
			}
		}
			
		

		/// <summary>
		/// 客户电话
		/// 费用记录数据传输对象.Misc.客户电话
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_contactPhone ;
		public System.String ContactPhone
		{
			get	
			{	
				return m_contactPhone ;
			}
			set	
			{	
				m_contactPhone = value ;	
			}
		}
			
		

		/// <summary>
		/// 出货日期
		/// 费用记录数据传输对象.Misc.出货日期
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
		/// 订单号
		/// 费用记录数据传输对象.Misc.订单号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_saleNo ;
		public System.String SaleNo
		{
			get	
			{	
				return m_saleNo ;
			}
			set	
			{	
				m_saleNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 承运商
		/// 费用记录数据传输对象.Misc.承运商
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.CBO.SCM.Supplier.SupplierData m_supplier ;
		public UFIDA.U9.CBO.SCM.Supplier.SupplierData Supplier
		{
			get	
			{	
				return m_supplier ;
			}
			set	
			{	
				m_supplier = value ;	
			}
		}
			
		

		/// <summary>
		/// 数量
		/// 费用记录数据传输对象.Misc.数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_qty ;
		public System.Double Qty
		{
			get	
			{	
				return m_qty ;
			}
			set	
			{	
				m_qty = value ;	
			}
		}
			
		

		/// <summary>
		/// 商品类别
		/// 费用记录数据传输对象.Misc.商品类别
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_productCategory ;
		public System.Int32 ProductCategory
		{
			get	
			{	
				return m_productCategory ;
			}
			set	
			{	
				m_productCategory = value ;	
			}
		}
			
		

		/// <summary>
		/// 省份
		/// 费用记录数据传输对象.Misc.省份
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
		/// 体积
		/// 费用记录数据传输对象.Misc.体积
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_iBulk ;
		public System.Double IBulk
		{
			get	
			{	
				return m_iBulk ;
			}
			set	
			{	
				m_iBulk = value ;	
			}
		}
			
		

		/// <summary>
		/// 重量
		/// 费用记录数据传输对象.Misc.重量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_weight ;
		public System.Double Weight
		{
			get	
			{	
				return m_weight ;
			}
			set	
			{	
				m_weight = value ;	
			}
		}
			
		

		/// <summary>
		/// 体积单位
		/// 费用记录数据传输对象.Misc.体积单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.UOM.UOMData m_bulkUom ;
		public UFIDA.U9.Base.UOM.UOMData BulkUom
		{
			get	
			{	
				return m_bulkUom ;
			}
			set	
			{	
				m_bulkUom = value ;	
			}
		}
			
		

		/// <summary>
		/// 重量单位
		/// 费用记录数据传输对象.Misc.重量单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.UOM.UOMData m_weightUom ;
		public UFIDA.U9.Base.UOM.UOMData WeightUom
		{
			get	
			{	
				return m_weightUom ;
			}
			set	
			{	
				m_weightUom = value ;	
			}
		}
			
		

		/// <summary>
		/// 提货费
		/// 费用记录数据传输对象.Misc.提货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_pickupFee ;
		public System.Double PickupFee
		{
			get	
			{	
				return m_pickupFee ;
			}
			set	
			{	
				m_pickupFee = value ;	
			}
		}
			
		

		/// <summary>
		/// 送货费
		/// 费用记录数据传输对象.Misc.送货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_deliveryFee ;
		public System.Double DeliveryFee
		{
			get	
			{	
				return m_deliveryFee ;
			}
			set	
			{	
				m_deliveryFee = value ;	
			}
		}
			
		

		/// <summary>
		/// 卸货费
		/// 费用记录数据传输对象.Misc.卸货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_dischargeFee ;
		public System.Double DischargeFee
		{
			get	
			{	
				return m_dischargeFee ;
			}
			set	
			{	
				m_dischargeFee = value ;	
			}
		}
			
		

		/// <summary>
		/// 其他费用
		/// 费用记录数据传输对象.Misc.其他费用
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_otherFee ;
		public System.Double OtherFee
		{
			get	
			{	
				return m_otherFee ;
			}
			set	
			{	
				m_otherFee = value ;	
			}
		}
			
		

		/// <summary>
		/// 标准运费
		/// 费用记录数据传输对象.Misc.标准运费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_standardShipping ;
		public System.Double StandardShipping
		{
			get	
			{	
				return m_standardShipping ;
			}
			set	
			{	
				m_standardShipping = value ;	
			}
		}
			
		

		/// <summary>
		/// 费用合计
		/// 费用记录数据传输对象.Misc.费用合计
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_totalFreight ;
		public System.Double TotalFreight
		{
			get	
			{	
				return m_totalFreight ;
			}
			set	
			{	
				m_totalFreight = value ;	
			}
		}
			
		

		/// <summary>
		/// 结算价格
		/// 费用记录数据传输对象.Misc.结算价格
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_realFreight ;
		public System.Double RealFreight
		{
			get	
			{	
				return m_realFreight ;
			}
			set	
			{	
				m_realFreight = value ;	
			}
		}
			
		

		/// <summary>
		/// 平均费用
		/// 费用记录数据传输对象.Misc.平均费用
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_averageCost ;
		public System.Double AverageCost
		{
			get	
			{	
				return m_averageCost ;
			}
			set	
			{	
				m_averageCost = value ;	
			}
		}
			
		

		/// <summary>
		/// 执行单价
		/// 费用记录数据传输对象.Misc.执行单价
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
		/// 费用记录数据传输对象.Misc.备注
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
		/// 城市
		/// 费用记录数据传输对象.Misc.城市
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
		/// 费用记录数据传输对象.Misc.区县
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
		/// 费用记录数据传输对象.Misc.详细地址
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
		/// 送货地址
		/// 费用记录数据传输对象.Misc.送货地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_fullAddress ;
		public System.String FullAddress
		{
			get	
			{	
				return m_fullAddress ;
			}
			set	
			{	
				m_fullAddress = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																																																																				
		#endregion 
	} 	
}

	
