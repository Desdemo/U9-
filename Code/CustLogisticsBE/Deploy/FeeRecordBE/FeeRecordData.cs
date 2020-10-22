
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用记录 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class FeeRecordData : UFSoft.UBF.Business.DataTransObjectBase
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
		public FeeRecordData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     							BusinessType= 0; 			     			
	     			
	     			
	     			
	     			
	     			
	     							Qty=0m; 
	     							ProductCategory= 0; 			     			
	     							IBulk=0m; 
	     							Weight=0m; 
	     			
	     			
	     							PickupFee=0m; 
	     							DeliveryFee=0m; 
	     							DischargeFee=0m; 
	     							OtherFee=0m; 
	     							StandardShipping=0m; 
	     							TotalFreight=0m; 
	     							RealFreight=0m; 
	     							AverageCost=0m; 
	     							UintPrice=0m; 
	     			
	     			
	     			
	     			
	     			


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
			get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 商品类别
		/// 费用记录.Misc.商品类别
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_productCategory;
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

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 费用记录.Key.ID
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
		/// 费用记录.Sys.创建时间
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
		/// 费用记录.Sys.创建人
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
		/// 费用记录.Sys.修改时间
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
		/// 费用记录.Sys.修改人
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
		/// 费用记录.Sys.事务版本
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
		/// 业务类型
		/// 费用记录.Misc.业务类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_businessType ;
		public System.Int32 BusinessType
		{
			get	
			{	
				return m_businessType  ;
			}
			set	
			{	
				m_businessType = value ;	
			}
		}
		

				/// <summary>
		/// 跟单
		/// 费用记录.Misc.跟单
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_salesman ;
		public System.String Salesman
		{
			get	
			{	
				return m_salesman  ;
			}
			set	
			{	
				m_salesman = value ;	
			}
		}
		

				/// <summary>
		/// 客户联系人
		/// 费用记录.Misc.客户联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerContact ;
		public System.String CustomerContact
		{
			get	
			{	
				return m_customerContact  ;
			}
			set	
			{	
				m_customerContact = value ;	
			}
		}
		

				/// <summary>
		/// 客户电话
		/// 费用记录.Misc.客户电话
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_contactPhone ;
		public System.String ContactPhone
		{
			get	
			{	
				return m_contactPhone  ;
			}
			set	
			{	
				m_contactPhone = value ;	
			}
		}
		

				/// <summary>
		/// 出货日期
		/// 费用记录.Misc.出货日期
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
		/// 订单号
		/// 费用记录.Misc.订单号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_saleNo ;
		public System.String SaleNo
		{
			get	
			{	
				return m_saleNo  ;
			}
			set	
			{	
				m_saleNo = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_supplier_SKey ;
		/// <summary>
		/// 承运商 序列化Key属性。（传递跨组织序列列字段）
		/// 费用记录.Misc.承运商
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Supplier_SKey
		{
			get 
			{
				return m_supplier_SKey ;					
			}
			set
			{
				 m_supplier_SKey = value ;	
			}
		}
		/// <summary>
		/// 承运商
		/// 费用记录.Misc.承运商
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Supplier
		{
			get	
			{	
				if (Supplier_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Supplier_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Supplier_SKey = null ;
				else
				{
					if (Supplier_SKey == null )
						Supplier_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Supplier.Supplier") ;
					else
						Supplier_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 数量
		/// 费用记录.Misc.数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_qty ;
		public System.Decimal Qty
		{
			get	
			{	
				return m_qty  ;
			}
			set	
			{	
				m_qty = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_province_SKey ;
		/// <summary>
		/// 省份 序列化Key属性。（传递跨组织序列列字段）
		/// 费用记录.Misc.省份
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
		/// 省份
		/// 费用记录.Misc.省份
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
		

				/// <summary>
		/// 体积
		/// 费用记录.Misc.体积
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_iBulk ;
		public System.Decimal IBulk
		{
			get	
			{	
				return m_iBulk  ;
			}
			set	
			{	
				m_iBulk = value ;	
			}
		}
		

				/// <summary>
		/// 重量
		/// 费用记录.Misc.重量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_weight ;
		public System.Decimal Weight
		{
			get	
			{	
				return m_weight  ;
			}
			set	
			{	
				m_weight = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_bulkUom_SKey ;
		/// <summary>
		/// 体积单位 序列化Key属性。（传递跨组织序列列字段）
		/// 费用记录.Misc.体积单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey BulkUom_SKey
		{
			get 
			{
				return m_bulkUom_SKey ;					
			}
			set
			{
				 m_bulkUom_SKey = value ;	
			}
		}
		/// <summary>
		/// 体积单位
		/// 费用记录.Misc.体积单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 BulkUom
		{
			get	
			{	
				if (BulkUom_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return BulkUom_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					BulkUom_SKey = null ;
				else
				{
					if (BulkUom_SKey == null )
						BulkUom_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.UOM.UOM") ;
					else
						BulkUom_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_weightUom_SKey ;
		/// <summary>
		/// 重量单位 序列化Key属性。（传递跨组织序列列字段）
		/// 费用记录.Misc.重量单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey WeightUom_SKey
		{
			get 
			{
				return m_weightUom_SKey ;					
			}
			set
			{
				 m_weightUom_SKey = value ;	
			}
		}
		/// <summary>
		/// 重量单位
		/// 费用记录.Misc.重量单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 WeightUom
		{
			get	
			{	
				if (WeightUom_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return WeightUom_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					WeightUom_SKey = null ;
				else
				{
					if (WeightUom_SKey == null )
						WeightUom_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.UOM.UOM") ;
					else
						WeightUom_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 提货费
		/// 费用记录.Misc.提货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_pickupFee ;
		public System.Decimal PickupFee
		{
			get	
			{	
				return m_pickupFee  ;
			}
			set	
			{	
				m_pickupFee = value ;	
			}
		}
		

				/// <summary>
		/// 送货费
		/// 费用记录.Misc.送货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_deliveryFee ;
		public System.Decimal DeliveryFee
		{
			get	
			{	
				return m_deliveryFee  ;
			}
			set	
			{	
				m_deliveryFee = value ;	
			}
		}
		

				/// <summary>
		/// 卸货费
		/// 费用记录.Misc.卸货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_dischargeFee ;
		public System.Decimal DischargeFee
		{
			get	
			{	
				return m_dischargeFee  ;
			}
			set	
			{	
				m_dischargeFee = value ;	
			}
		}
		

				/// <summary>
		/// 其他费用
		/// 费用记录.Misc.其他费用
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_otherFee ;
		public System.Decimal OtherFee
		{
			get	
			{	
				return m_otherFee  ;
			}
			set	
			{	
				m_otherFee = value ;	
			}
		}
		

				/// <summary>
		/// 标准运费
		/// 费用记录.Misc.标准运费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_standardShipping ;
		public System.Decimal StandardShipping
		{
			get	
			{	
				return m_standardShipping  ;
			}
			set	
			{	
				m_standardShipping = value ;	
			}
		}
		

				/// <summary>
		/// 费用合计
		/// 费用记录.Misc.费用合计
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_totalFreight ;
		public System.Decimal TotalFreight
		{
			get	
			{	
				return m_totalFreight  ;
			}
			set	
			{	
				m_totalFreight = value ;	
			}
		}
		

				/// <summary>
		/// 结算价格
		/// 费用记录.Misc.结算价格
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_realFreight ;
		public System.Decimal RealFreight
		{
			get	
			{	
				return m_realFreight  ;
			}
			set	
			{	
				m_realFreight = value ;	
			}
		}
		

				/// <summary>
		/// 平均费用
		/// 费用记录.Misc.平均费用
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_averageCost ;
		public System.Decimal AverageCost
		{
			get	
			{	
				return m_averageCost  ;
			}
			set	
			{	
				m_averageCost = value ;	
			}
		}
		

				/// <summary>
		/// 执行单价
		/// 费用记录.Misc.执行单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_uintPrice ;
		public System.Decimal UintPrice
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
		/// 费用记录.Misc.备注
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_city_SKey ;
		/// <summary>
		/// 城市 序列化Key属性。（传递跨组织序列列字段）
		/// 费用记录.Misc.城市
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
		/// 费用记录.Misc.城市
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
		/// 费用记录.Misc.区县
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
		/// 费用记录.Misc.区县
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
		/// 费用记录.Misc.详细地址
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
		/// 送货地址
		/// 费用记录.Misc.送货地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_fullAddress ;
		public System.String FullAddress
		{
			get	
			{	
				return m_fullAddress  ;
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

