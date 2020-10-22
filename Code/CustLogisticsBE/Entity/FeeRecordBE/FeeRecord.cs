using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	
	/// <summary>
	/// 实体: 费用记录
	/// 
	/// </summary>
	[Serializable]	
	public  partial class FeeRecord : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public FeeRecord(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static FeeRecord Create() {
			FeeRecord entity = (FeeRecord)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																																																									 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected FeeRecord(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return true ;}
		}
		#endregion

		#region Create Default 
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Default Instance</returns>
		public static FeeRecord CreateDefault() {
		#if Test		
			return CreateDefault_Extend() ;
		#else 
		    return null;
		#endif
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		public static FeeRecord CreateDefaultComponent(){
		#if Test		
			return CreateDefaultComponent_Extend() ;
		#else 
		    return null;
		#endif
		}

		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class FeeRecord EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new FeeRecord GetEntity()
			{
				return (FeeRecord)base.GetEntity();
			}
			public static bool operator ==(EntityKey obja, EntityKey objb)
			{
				if (object.ReferenceEquals(obja, null))
				{
					if (object.ReferenceEquals(objb, null))
						return true;
					return false;
				}
				return obja.Equals(objb);
			}
			public static bool operator !=(EntityKey obja, EntityKey objb)
			{
				return !(obja == objb);
			}
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
			public override bool Equals(object obj)
			{
				return base.Equals(obj);
			}
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityKey CreateEntityKey()
		{
			return new EntityKey(this.ID);
		}
		/// <summary>
		/// Strong Class EntityKey Property
		/// </summary>
		public new EntityKey Key
		{
			get
			{
				return base.Key as EntityKey;
			}
		}
		#endregion

		#region Finder
		/// <summary>
		/// Strong Class EntityFinder
		/// </summary>
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<FeeRecord> 
		{
		    public EntityFinder():base(CurrentClassKey)
			{
			}
			public new EntityList FindAll(string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(opath, oqlParameters));                
			}
			public new EntityList FindAll(UFSoft.UBF.PL.ObjectQueryOptions options, string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(options,opath, oqlParameters));                
			}









						
		}

		//private static EntityFinder _finder  ;

		/// <summary>
		/// Finder
		/// </summary>
		public static EntityFinder Finder {
			get {
				//if (_finder == null)
				//	_finder =  new EntityFinder() ;
				return new EntityFinder() ;
			}
		}
		#endregion
			
		#region List

		/// <summary>
		/// EntityList
		/// </summary>
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<FeeRecord>{
		    #region constructor 
		    /// <summary>
		    /// EntityList 无参的构造方法,用于其它特殊情况
		    /// </summary>
		    public EntityList()
		    {
		    }

		    /// <summary>
		    /// EntityList Constructor With Collection .主要用于查询返回实体集时使用.
		    /// </summary>
		    public EntityList(IList list) : base(list)
		    { 
		    }
		    
		    /// <summary>
		    ///  EntityList Constructor , used by  peresidence
		    /// </summary>
		    /// <param name="childAttrName">this EntityList's child Attribute Name</param>
		    /// <param name="parentEntity">this EntityList's Parent Entity </param>
		    /// <param name="parentAttrName">Parent Entity's Attribute Name with this EntityList's </param>
		    /// <param name="list">list </param>
		    public EntityList(string childAttrName,UFSoft.UBF.Business.BusinessEntity parentEntity, string parentAttrName, IList list)
			    :base(childAttrName,parentEntity,parentAttrName,list) 
		    { 
			
		    }

		    #endregion 
		    //用于一对多关联.	
		    internal IList InnerList
		    {
		    	//get { return this.innerList; }
		    	set {
		    		if (value != null)
		    		    this.innerList = value; 
		    	}
		    }
		    protected override bool IsMainEntity
		    {
			    get { return true ;}
		    }
		}
		#endregion
		
		#region Typeed OriginalData
		/// <summary>
		/// 当前实体对象的旧数据对象(为上次更新后的数据)
		/// </summary>
		public new EntityOriginal OriginalData
		{
			get {
				return (EntityOriginal)base.OriginalData;
			}
            protected set
            {
				base.OriginalData = value ;
            }
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityOriginal CreateOriginalData()
		{
			return new EntityOriginal(this);
		}
		
		public new partial class EntityOriginal: UFSoft.UBF.Business.Entity.EntityOriginal
		{
		    //private FeeRecord ContainerEntity ;
		    public  new FeeRecord ContainerEntity 
		    {
				get { return  (FeeRecord)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(FeeRecord container)
		    {
				if (container == null )
					throw new ArgumentNullException("container") ;
				ContainerEntity = container ;
				base.innerData = container.OldValues ;
				InitInnerData();
		    }
	




			#region member					
			
			/// <summary>
			///  OrginalData属性。只可读。
			/// ID (该属性不可为空,且无默认值)
			/// 费用记录.Key.ID
			/// </summary>
			/// <value></value>
			public  System.Int64 ID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("ID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建时间 (该属性可为空,且无默认值)
			/// 费用记录.Sys.创建时间
			/// </summary>
			/// <value></value>
			public  System.DateTime CreatedOn
			{
				get
				{
					object obj = base.GetValue("CreatedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建人 (该属性可为空,且无默认值)
			/// 费用记录.Sys.创建人
			/// </summary>
			/// <value></value>
			public  System.String CreatedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CreatedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改时间 (该属性可为空,且无默认值)
			/// 费用记录.Sys.修改时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ModifiedOn
			{
				get
				{
					object obj = base.GetValue("ModifiedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改人 (该属性可为空,且无默认值)
			/// 费用记录.Sys.修改人
			/// </summary>
			/// <value></value>
			public  System.String ModifiedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ModifiedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 事务版本 (该属性可为空,但有默认值)
			/// 费用记录.Sys.事务版本
			/// </summary>
			/// <value></value>
			public  System.Int64 SysVersion
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务类型 (该属性可为空,但有默认值)
			/// 费用记录.Misc.业务类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum BusinessType
			{
				get
				{

					UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum.GetFromValue(base.GetValue("BusinessType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 跟单 (该属性可为空,且无默认值)
			/// 费用记录.Misc.跟单
			/// </summary>
			/// <value></value>
			public  System.String Salesman
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Salesman");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户联系人 (该属性可为空,且无默认值)
			/// 费用记录.Misc.客户联系人
			/// </summary>
			/// <value></value>
			public  System.String CustomerContact
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustomerContact");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户电话 (该属性可为空,且无默认值)
			/// 费用记录.Misc.客户电话
			/// </summary>
			/// <value></value>
			public  System.String ContactPhone
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ContactPhone");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出货日期 (该属性可为空,且无默认值)
			/// 费用记录.Misc.出货日期
			/// </summary>
			/// <value></value>
			public  System.DateTime ShipDate
			{
				get
				{
					object obj = base.GetValue("ShipDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 订单号 (该属性可为空,且无默认值)
			/// 费用记录.Misc.订单号
			/// </summary>
			/// <value></value>
			public  System.String SaleNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SaleNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 承运商 (该属性可为空,且无默认值)
			/// 费用记录.Misc.承运商
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier Supplier
			{
				get
				{
					if (SupplierKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Supplier.Supplier value =  (UFIDA.U9.CBO.SCM.Supplier.Supplier)SupplierKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_SupplierKey ;
		/// <summary>
		/// EntityKey 属性
		/// 承运商 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.承运商
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey SupplierKey
		{
			get 
			{
				object obj = base.GetValue("Supplier") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SupplierKey==null || m_SupplierKey.ID != key )
					m_SupplierKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_SupplierKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 数量 (该属性可为空,但有默认值)
			/// 费用记录.Misc.数量
			/// </summary>
			/// <value></value>
			public  System.Decimal Qty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Qty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 商品类别 (该属性可为空,但有默认值)
			/// 费用记录.Misc.商品类别
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum ProductCategory
			{
				get
				{

					UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum.GetFromValue(base.GetValue("ProductCategory"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 省份 (该属性可为空,且无默认值)
			/// 费用记录.Misc.省份
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Location.Province Province
			{
				get
				{
					if (ProvinceKey == null)
						return null ;
					UFIDA.U9.Base.Location.Province value =  (UFIDA.U9.Base.Location.Province)ProvinceKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Location.Province.EntityKey m_ProvinceKey ;
		/// <summary>
		/// EntityKey 属性
		/// 省份 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.省份
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Province.EntityKey ProvinceKey
		{
			get 
			{
				object obj = base.GetValue("Province") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ProvinceKey==null || m_ProvinceKey.ID != key )
					m_ProvinceKey = new UFIDA.U9.Base.Location.Province.EntityKey(key); 
				return m_ProvinceKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 体积 (该属性可为空,但有默认值)
			/// 费用记录.Misc.体积
			/// </summary>
			/// <value></value>
			public  System.Decimal IBulk
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("IBulk");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 重量 (该属性可为空,但有默认值)
			/// 费用记录.Misc.重量
			/// </summary>
			/// <value></value>
			public  System.Decimal Weight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Weight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 体积单位 (该属性可为空,且无默认值)
			/// 费用记录.Misc.体积单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM BulkUom
			{
				get
				{
					if (BulkUomKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)BulkUomKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_BulkUomKey ;
		/// <summary>
		/// EntityKey 属性
		/// 体积单位 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.体积单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey BulkUomKey
		{
			get 
			{
				object obj = base.GetValue("BulkUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BulkUomKey==null || m_BulkUomKey.ID != key )
					m_BulkUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_BulkUomKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 重量单位 (该属性可为空,且无默认值)
			/// 费用记录.Misc.重量单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM WeightUom
			{
				get
				{
					if (WeightUomKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)WeightUomKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_WeightUomKey ;
		/// <summary>
		/// EntityKey 属性
		/// 重量单位 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.重量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey WeightUomKey
		{
			get 
			{
				object obj = base.GetValue("WeightUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_WeightUomKey==null || m_WeightUomKey.ID != key )
					m_WeightUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_WeightUomKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提货费 (该属性可为空,但有默认值)
			/// 费用记录.Misc.提货费
			/// </summary>
			/// <value></value>
			public  System.Decimal PickupFee
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("PickupFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 送货费 (该属性可为空,但有默认值)
			/// 费用记录.Misc.送货费
			/// </summary>
			/// <value></value>
			public  System.Decimal DeliveryFee
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DeliveryFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 卸货费 (该属性可为空,但有默认值)
			/// 费用记录.Misc.卸货费
			/// </summary>
			/// <value></value>
			public  System.Decimal DischargeFee
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DischargeFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 其他费用 (该属性可为空,但有默认值)
			/// 费用记录.Misc.其他费用
			/// </summary>
			/// <value></value>
			public  System.Decimal OtherFee
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("OtherFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 标准运费 (该属性可为空,但有默认值)
			/// 费用记录.Misc.标准运费
			/// </summary>
			/// <value></value>
			public  System.Decimal StandardShipping
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("StandardShipping");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 费用合计 (该属性可为空,但有默认值)
			/// 费用记录.Misc.费用合计
			/// </summary>
			/// <value></value>
			public  System.Decimal TotalFreight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("TotalFreight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 结算价格 (该属性可为空,但有默认值)
			/// 费用记录.Misc.结算价格
			/// </summary>
			/// <value></value>
			public  System.Decimal RealFreight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("RealFreight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 平均费用 (该属性可为空,但有默认值)
			/// 费用记录.Misc.平均费用
			/// </summary>
			/// <value></value>
			public  System.Decimal AverageCost
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("AverageCost");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 执行单价 (该属性可为空,但有默认值)
			/// 费用记录.Misc.执行单价
			/// </summary>
			/// <value></value>
			public  System.Decimal UintPrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("UintPrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 费用记录.Misc.备注
			/// </summary>
			/// <value></value>
			public  System.String Remark
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Remark");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 城市 (该属性可为空,且无默认值)
			/// 费用记录.Misc.城市
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Location.City City
			{
				get
				{
					if (CityKey == null)
						return null ;
					UFIDA.U9.Base.Location.City value =  (UFIDA.U9.Base.Location.City)CityKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Location.City.EntityKey m_CityKey ;
		/// <summary>
		/// EntityKey 属性
		/// 城市 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.城市
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.City.EntityKey CityKey
		{
			get 
			{
				object obj = base.GetValue("City") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CityKey==null || m_CityKey.ID != key )
					m_CityKey = new UFIDA.U9.Base.Location.City.EntityKey(key); 
				return m_CityKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 区县 (该属性可为空,且无默认值)
			/// 费用记录.Misc.区县
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Location.County County
			{
				get
				{
					if (CountyKey == null)
						return null ;
					UFIDA.U9.Base.Location.County value =  (UFIDA.U9.Base.Location.County)CountyKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Location.County.EntityKey m_CountyKey ;
		/// <summary>
		/// EntityKey 属性
		/// 区县 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.区县
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.County.EntityKey CountyKey
		{
			get 
			{
				object obj = base.GetValue("County") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CountyKey==null || m_CountyKey.ID != key )
					m_CountyKey = new UFIDA.U9.Base.Location.County.EntityKey(key); 
				return m_CountyKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 详细地址 (该属性可为空,且无默认值)
			/// 费用记录.Misc.详细地址
			/// </summary>
			/// <value></value>
			public  System.String DescribeAddress
			{
				get
				{
					System.String value  = (System.String)base.GetValue("DescribeAddress");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 送货地址 (该属性可为空,且无默认值)
			/// 费用记录.Misc.送货地址
			/// </summary>
			/// <value></value>
			public  System.String FullAddress
			{
				get
				{
					System.String value  = (System.String)base.GetValue("FullAddress");
					return value;
						}
			}
		



		

			#endregion

			#region List member						
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 费用记录.Key.ID
		/// </summary>
		/// <value></value>
	 
		public new System.Int64 ID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("ID");
				return value;
				}
				set
			{
				
								base.SetValue("ID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建时间 (该属性可为空,且无默认值)
		/// 费用记录.Sys.创建时间
		/// </summary>
		/// <value></value>
			public  System.DateTime CreatedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("CreatedOn");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 费用记录.Sys.创建人
		/// </summary>
		/// <value></value>
			public  System.String CreatedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CreatedBy");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 费用记录.Sys.修改时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ModifiedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ModifiedOn");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 费用记录.Sys.修改人
		/// </summary>
		/// <value></value>
			public  System.String ModifiedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ModifiedBy");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 费用记录.Sys.事务版本
		/// </summary>
		/// <value></value>
			public  System.Int64 SysVersion
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
				return value;
				}
				set
			{
				
								base.SetValue("SysVersion", value);
						 
			}
		}
	



		
			/// <summary>
		/// 业务类型 (该属性可为空,但有默认值)
		/// 费用记录.Misc.业务类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum BusinessType
		{
			get
			{

				UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum.GetFromValue(base.GetValue("BusinessType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("BusinessType",UFIDA.U9.Cust.BLT.CustLogisticsBE.BusinessTypeEnum.Empty.Value);
				else
					base.SetValue("BusinessType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 跟单 (该属性可为空,且无默认值)
		/// 费用记录.Misc.跟单
		/// </summary>
		/// <value></value>
			public  System.String Salesman
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Salesman");
				return value;
				}
				set
			{
				
								base.SetValue("Salesman", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户联系人 (该属性可为空,且无默认值)
		/// 费用记录.Misc.客户联系人
		/// </summary>
		/// <value></value>
			public  System.String CustomerContact
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustomerContact");
				return value;
				}
				set
			{
				
								base.SetValue("CustomerContact", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户电话 (该属性可为空,且无默认值)
		/// 费用记录.Misc.客户电话
		/// </summary>
		/// <value></value>
			public  System.String ContactPhone
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ContactPhone");
				return value;
				}
				set
			{
				
								base.SetValue("ContactPhone", value);
						 
			}
		}
	



		
			/// <summary>
		/// 出货日期 (该属性可为空,且无默认值)
		/// 费用记录.Misc.出货日期
		/// </summary>
		/// <value></value>
			public  System.DateTime ShipDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ShipDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("ShipDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 订单号 (该属性可为空,且无默认值)
		/// 费用记录.Misc.订单号
		/// </summary>
		/// <value></value>
			public  System.String SaleNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SaleNo");
				return value;
				}
				set
			{
				
								base.SetValue("SaleNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 承运商 (该属性可为空,且无默认值)
		/// 费用记录.Misc.承运商
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier Supplier
		{
			get
			{
				object  obj = this.GetRelation("Supplier");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Supplier.Supplier value  = (UFIDA.U9.CBO.SCM.Supplier.Supplier)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Supplier", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_SupplierKey ;
		/// <summary>
		/// 承运商 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.承运商
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey SupplierKey
		{
			get 
			{
				object obj = base.GetValue("Supplier") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SupplierKey==null || m_SupplierKey.ID != key )
					m_SupplierKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_SupplierKey ;
			}
			set
			{	
				if (SupplierKey==value)
					return ;
				this.SetRelation("Supplier", null);
				m_SupplierKey = value ;
				if (value != null) 
				{
					base.SetValue("Supplier",value.ID);
				}
				else
					base.SetValue("Supplier",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 费用记录.Misc.数量
		/// </summary>
		/// <value></value>
			public  System.Decimal Qty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Qty");
				return value;
				}
				set
			{
				
								base.SetValue("Qty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 商品类别 (该属性可为空,但有默认值)
		/// 费用记录.Misc.商品类别
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum ProductCategory
		{
			get
			{

				UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum.GetFromValue(base.GetValue("ProductCategory"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("ProductCategory",UFIDA.U9.Cust.BLT.CustLogisticsBE.ProductCategoryEnum.Empty.Value);
				else
					base.SetValue("ProductCategory",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 省份 (该属性可为空,且无默认值)
		/// 费用记录.Misc.省份
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Location.Province Province
		{
			get
			{
				object  obj = this.GetRelation("Province");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Location.Province value  = (UFIDA.U9.Base.Location.Province)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Province", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Location.Province.EntityKey m_ProvinceKey ;
		/// <summary>
		/// 省份 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.省份
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Province.EntityKey ProvinceKey
		{
			get 
			{
				object obj = base.GetValue("Province") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ProvinceKey==null || m_ProvinceKey.ID != key )
					m_ProvinceKey = new UFIDA.U9.Base.Location.Province.EntityKey(key); 
				return m_ProvinceKey ;
			}
			set
			{	
				if (ProvinceKey==value)
					return ;
				this.SetRelation("Province", null);
				m_ProvinceKey = value ;
				if (value != null) 
				{
					base.SetValue("Province",value.ID);
				}
				else
					base.SetValue("Province",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 体积 (该属性可为空,但有默认值)
		/// 费用记录.Misc.体积
		/// </summary>
		/// <value></value>
			public  System.Decimal IBulk
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("IBulk");
				return value;
				}
				set
			{
				
								base.SetValue("IBulk", value);
						 
			}
		}
	



		
			/// <summary>
		/// 重量 (该属性可为空,但有默认值)
		/// 费用记录.Misc.重量
		/// </summary>
		/// <value></value>
			public  System.Decimal Weight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Weight");
				return value;
				}
				set
			{
				
								base.SetValue("Weight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 体积单位 (该属性可为空,且无默认值)
		/// 费用记录.Misc.体积单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM BulkUom
		{
			get
			{
				object  obj = this.GetRelation("BulkUom");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.UOM.UOM value  = (UFIDA.U9.Base.UOM.UOM)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("BulkUom", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_BulkUomKey ;
		/// <summary>
		/// 体积单位 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.体积单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey BulkUomKey
		{
			get 
			{
				object obj = base.GetValue("BulkUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BulkUomKey==null || m_BulkUomKey.ID != key )
					m_BulkUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_BulkUomKey ;
			}
			set
			{	
				if (BulkUomKey==value)
					return ;
				this.SetRelation("BulkUom", null);
				m_BulkUomKey = value ;
				if (value != null) 
				{
					base.SetValue("BulkUom",value.ID);
				}
				else
					base.SetValue("BulkUom",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 重量单位 (该属性可为空,且无默认值)
		/// 费用记录.Misc.重量单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM WeightUom
		{
			get
			{
				object  obj = this.GetRelation("WeightUom");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.UOM.UOM value  = (UFIDA.U9.Base.UOM.UOM)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("WeightUom", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_WeightUomKey ;
		/// <summary>
		/// 重量单位 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.重量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey WeightUomKey
		{
			get 
			{
				object obj = base.GetValue("WeightUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_WeightUomKey==null || m_WeightUomKey.ID != key )
					m_WeightUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_WeightUomKey ;
			}
			set
			{	
				if (WeightUomKey==value)
					return ;
				this.SetRelation("WeightUom", null);
				m_WeightUomKey = value ;
				if (value != null) 
				{
					base.SetValue("WeightUom",value.ID);
				}
				else
					base.SetValue("WeightUom",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 提货费 (该属性可为空,但有默认值)
		/// 费用记录.Misc.提货费
		/// </summary>
		/// <value></value>
			public  System.Decimal PickupFee
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("PickupFee");
				return value;
				}
				set
			{
				
								base.SetValue("PickupFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 送货费 (该属性可为空,但有默认值)
		/// 费用记录.Misc.送货费
		/// </summary>
		/// <value></value>
			public  System.Decimal DeliveryFee
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DeliveryFee");
				return value;
				}
				set
			{
				
								base.SetValue("DeliveryFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 卸货费 (该属性可为空,但有默认值)
		/// 费用记录.Misc.卸货费
		/// </summary>
		/// <value></value>
			public  System.Decimal DischargeFee
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DischargeFee");
				return value;
				}
				set
			{
				
								base.SetValue("DischargeFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 其他费用 (该属性可为空,但有默认值)
		/// 费用记录.Misc.其他费用
		/// </summary>
		/// <value></value>
			public  System.Decimal OtherFee
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("OtherFee");
				return value;
				}
				set
			{
				
								base.SetValue("OtherFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 标准运费 (该属性可为空,但有默认值)
		/// 费用记录.Misc.标准运费
		/// </summary>
		/// <value></value>
			public  System.Decimal StandardShipping
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("StandardShipping");
				return value;
				}
				set
			{
				
								base.SetValue("StandardShipping", value);
						 
			}
		}
	



		
			/// <summary>
		/// 费用合计 (该属性可为空,但有默认值)
		/// 费用记录.Misc.费用合计
		/// </summary>
		/// <value></value>
			public  System.Decimal TotalFreight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("TotalFreight");
				return value;
				}
				set
			{
				
								base.SetValue("TotalFreight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 结算价格 (该属性可为空,但有默认值)
		/// 费用记录.Misc.结算价格
		/// </summary>
		/// <value></value>
			public  System.Decimal RealFreight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("RealFreight");
				return value;
				}
				set
			{
				
								base.SetValue("RealFreight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 平均费用 (该属性可为空,但有默认值)
		/// 费用记录.Misc.平均费用
		/// </summary>
		/// <value></value>
			public  System.Decimal AverageCost
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("AverageCost");
				return value;
				}
				set
			{
				
								base.SetValue("AverageCost", value);
						 
			}
		}
	



		
			/// <summary>
		/// 执行单价 (该属性可为空,但有默认值)
		/// 费用记录.Misc.执行单价
		/// </summary>
		/// <value></value>
			public  System.Decimal UintPrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("UintPrice");
				return value;
				}
				set
			{
				
								base.SetValue("UintPrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 费用记录.Misc.备注
		/// </summary>
		/// <value></value>
			public  System.String Remark
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Remark");
				return value;
				}
				set
			{
				
								base.SetValue("Remark", value);
						 
			}
		}
	



		
			/// <summary>
		/// 城市 (该属性可为空,且无默认值)
		/// 费用记录.Misc.城市
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Location.City City
		{
			get
			{
				object  obj = this.GetRelation("City");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Location.City value  = (UFIDA.U9.Base.Location.City)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("City", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Location.City.EntityKey m_CityKey ;
		/// <summary>
		/// 城市 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.城市
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.City.EntityKey CityKey
		{
			get 
			{
				object obj = base.GetValue("City") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CityKey==null || m_CityKey.ID != key )
					m_CityKey = new UFIDA.U9.Base.Location.City.EntityKey(key); 
				return m_CityKey ;
			}
			set
			{	
				if (CityKey==value)
					return ;
				this.SetRelation("City", null);
				m_CityKey = value ;
				if (value != null) 
				{
					base.SetValue("City",value.ID);
				}
				else
					base.SetValue("City",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 区县 (该属性可为空,且无默认值)
		/// 费用记录.Misc.区县
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Location.County County
		{
			get
			{
				object  obj = this.GetRelation("County");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Location.County value  = (UFIDA.U9.Base.Location.County)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("County", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Location.County.EntityKey m_CountyKey ;
		/// <summary>
		/// 区县 的Key (该属性可为空,且无默认值)
		/// 费用记录.Misc.区县
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.County.EntityKey CountyKey
		{
			get 
			{
				object obj = base.GetValue("County") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CountyKey==null || m_CountyKey.ID != key )
					m_CountyKey = new UFIDA.U9.Base.Location.County.EntityKey(key); 
				return m_CountyKey ;
			}
			set
			{	
				if (CountyKey==value)
					return ;
				this.SetRelation("County", null);
				m_CountyKey = value ;
				if (value != null) 
				{
					base.SetValue("County",value.ID);
				}
				else
					base.SetValue("County",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 详细地址 (该属性可为空,且无默认值)
		/// 费用记录.Misc.详细地址
		/// </summary>
		/// <value></value>
			public  System.String DescribeAddress
		{
			get
			{
				System.String value  = (System.String)base.GetValue("DescribeAddress");
				return value;
				}
				set
			{
				
								base.SetValue("DescribeAddress", value);
						 
			}
		}
	



		
			/// <summary>
		/// 送货地址 (该属性可为空,且无默认值)
		/// 费用记录.Misc.送货地址
		/// </summary>
		/// <value></value>
			public  System.String FullAddress
		{
			get
			{
				System.String value  = (System.String)base.GetValue("FullAddress");
				return value;
				}
				set
			{
				
								base.SetValue("FullAddress", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
		#endregion

		#region Be List member						
		#endregion
		
		#region ModelResource 其余去除，保留EntityName
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ID　{ get { return EntityRes.GetResource("ID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedOn　{ get { return EntityRes.GetResource("CreatedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedBy　{ get { return EntityRes.GetResource("CreatedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedOn　{ get { return EntityRes.GetResource("ModifiedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedBy　{ get { return EntityRes.GetResource("ModifiedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SysVersion")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SysVersion　{ get { return EntityRes.GetResource("SysVersion");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BusinessType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BusinessType　{ get { return EntityRes.GetResource("BusinessType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Salesman")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Salesman　{ get { return EntityRes.GetResource("Salesman");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerContact")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerContact　{ get { return EntityRes.GetResource("CustomerContact");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ContactPhone")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ContactPhone　{ get { return EntityRes.GetResource("ContactPhone");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipDate　{ get { return EntityRes.GetResource("ShipDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SaleNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SaleNo　{ get { return EntityRes.GetResource("SaleNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Supplier")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Supplier　{ get { return EntityRes.GetResource("Supplier");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Qty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Qty　{ get { return EntityRes.GetResource("Qty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ProductCategory")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ProductCategory　{ get { return EntityRes.GetResource("ProductCategory");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Province")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Province　{ get { return EntityRes.GetResource("Province");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IBulk")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IBulk　{ get { return EntityRes.GetResource("IBulk");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Weight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Weight　{ get { return EntityRes.GetResource("Weight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BulkUom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BulkUom　{ get { return EntityRes.GetResource("BulkUom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("WeightUom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_WeightUom　{ get { return EntityRes.GetResource("WeightUom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PickupFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PickupFee　{ get { return EntityRes.GetResource("PickupFee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DeliveryFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DeliveryFee　{ get { return EntityRes.GetResource("DeliveryFee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DischargeFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DischargeFee　{ get { return EntityRes.GetResource("DischargeFee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OtherFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OtherFee　{ get { return EntityRes.GetResource("OtherFee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("StandardShipping")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_StandardShipping　{ get { return EntityRes.GetResource("StandardShipping");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TotalFreight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TotalFreight　{ get { return EntityRes.GetResource("TotalFreight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RealFreight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RealFreight　{ get { return EntityRes.GetResource("RealFreight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AverageCost")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AverageCost　{ get { return EntityRes.GetResource("AverageCost");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UintPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UintPrice　{ get { return EntityRes.GetResource("UintPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Remark")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Remark　{ get { return EntityRes.GetResource("Remark");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("City")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_City　{ get { return EntityRes.GetResource("City");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("County")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_County　{ get { return EntityRes.GetResource("County");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescribeAddress")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescribeAddress　{ get { return EntityRes.GetResource("DescribeAddress");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FullAddress")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FullAddress　{ get { return EntityRes.GetResource("FullAddress");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "FeeRecord";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord";　}　}
		
			/// <summary>
			/// 属性: ID 的名称
			/// </summary>
			public static string ID　{ get { return "ID";　}　}
				
			/// <summary>
			/// 属性: 创建时间 的名称
			/// </summary>
			public static string CreatedOn　{ get { return "CreatedOn";　}　}
				
			/// <summary>
			/// 属性: 创建人 的名称
			/// </summary>
			public static string CreatedBy　{ get { return "CreatedBy";　}　}
				
			/// <summary>
			/// 属性: 修改时间 的名称
			/// </summary>
			public static string ModifiedOn　{ get { return "ModifiedOn";　}　}
				
			/// <summary>
			/// 属性: 修改人 的名称
			/// </summary>
			public static string ModifiedBy　{ get { return "ModifiedBy";　}　}
				
			/// <summary>
			/// 属性: 事务版本 的名称
			/// </summary>
			public static string SysVersion　{ get { return "SysVersion";　}　}
				
			/// <summary>
			/// 属性: 业务类型 的名称
			/// </summary>
			public static string BusinessType　{ get { return "BusinessType";　}　}
				
			/// <summary>
			/// 属性: 跟单 的名称
			/// </summary>
			public static string Salesman　{ get { return "Salesman";　}　}
				
			/// <summary>
			/// 属性: 客户联系人 的名称
			/// </summary>
			public static string CustomerContact　{ get { return "CustomerContact";　}　}
				
			/// <summary>
			/// 属性: 客户电话 的名称
			/// </summary>
			public static string ContactPhone　{ get { return "ContactPhone";　}　}
				
			/// <summary>
			/// 属性: 出货日期 的名称
			/// </summary>
			public static string ShipDate　{ get { return "ShipDate";　}　}
				
			/// <summary>
			/// 属性: 订单号 的名称
			/// </summary>
			public static string SaleNo　{ get { return "SaleNo";　}　}
				
			/// <summary>
			/// 属性: 承运商 的名称
			/// </summary>
			public static string Supplier　{ get { return "Supplier";　}　}
				
			/// <summary>
			/// 属性: 数量 的名称
			/// </summary>
			public static string Qty　{ get { return "Qty";　}　}
				
			/// <summary>
			/// 属性: 商品类别 的名称
			/// </summary>
			public static string ProductCategory　{ get { return "ProductCategory";　}　}
				
			/// <summary>
			/// 属性: 省份 的名称
			/// </summary>
			public static string Province　{ get { return "Province";　}　}
				
			/// <summary>
			/// 属性: 体积 的名称
			/// </summary>
			public static string IBulk　{ get { return "IBulk";　}　}
				
			/// <summary>
			/// 属性: 重量 的名称
			/// </summary>
			public static string Weight　{ get { return "Weight";　}　}
				
			/// <summary>
			/// 属性: 体积单位 的名称
			/// </summary>
			public static string BulkUom　{ get { return "BulkUom";　}　}
				
			/// <summary>
			/// 属性: 重量单位 的名称
			/// </summary>
			public static string WeightUom　{ get { return "WeightUom";　}　}
				
			/// <summary>
			/// 属性: 提货费 的名称
			/// </summary>
			public static string PickupFee　{ get { return "PickupFee";　}　}
				
			/// <summary>
			/// 属性: 送货费 的名称
			/// </summary>
			public static string DeliveryFee　{ get { return "DeliveryFee";　}　}
				
			/// <summary>
			/// 属性: 卸货费 的名称
			/// </summary>
			public static string DischargeFee　{ get { return "DischargeFee";　}　}
				
			/// <summary>
			/// 属性: 其他费用 的名称
			/// </summary>
			public static string OtherFee　{ get { return "OtherFee";　}　}
				
			/// <summary>
			/// 属性: 标准运费 的名称
			/// </summary>
			public static string StandardShipping　{ get { return "StandardShipping";　}　}
				
			/// <summary>
			/// 属性: 费用合计 的名称
			/// </summary>
			public static string TotalFreight　{ get { return "TotalFreight";　}　}
				
			/// <summary>
			/// 属性: 结算价格 的名称
			/// </summary>
			public static string RealFreight　{ get { return "RealFreight";　}　}
				
			/// <summary>
			/// 属性: 平均费用 的名称
			/// </summary>
			public static string AverageCost　{ get { return "AverageCost";　}　}
				
			/// <summary>
			/// 属性: 执行单价 的名称
			/// </summary>
			public static string UintPrice　{ get { return "UintPrice";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Remark　{ get { return "Remark";　}　}
				
			/// <summary>
			/// 属性: 城市 的名称
			/// </summary>
			public static string City　{ get { return "City";　}　}
				
			/// <summary>
			/// 属性: 区县 的名称
			/// </summary>
			public static string County　{ get { return "County";　}　}
				
			/// <summary>
			/// 属性: 详细地址 的名称
			/// </summary>
			public static string DescribeAddress　{ get { return "DescribeAddress";　}　}
				
			/// <summary>
			/// 属性: 送货地址 的名称
			/// </summary>
			public static string FullAddress　{ get { return "FullAddress";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																																																				
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetAttrResource(BE_FullName, attrName);
			}

		}
		#endregion 


		#region EntityObjectBuilder 持久化性能优化
        private Dictionary<string, string> multiLangAttrs = null;
        private Dictionary<string, string> exdMultiLangAttrs = null;
        private string col_ID_Name = string.Empty;

        public override  Dictionary<string, string> MultiLangAttrs
        {
			get
			{
				return multiLangAttrs;
			}
        }
        public override  Dictionary<string, string> ExdMultiLangAttrs
        {
			get
			{
				return exdMultiLangAttrs;
			}
        }
        public override string Col_ID_Name
        {
			get
			{
				return col_ID_Name;
			}
        }  
        public override void IniData()
        {
			this.multiLangAttrs = new Dictionary<string, string>();
			this.exdMultiLangAttrs = new Dictionary<string, string>();
	
			this.col_ID_Name ="ID";
			this.exdMultiLangAttrs.Add("ID","ID");
			this.exdMultiLangAttrs.Add("CreatedOn","CreatedOn");
			this.exdMultiLangAttrs.Add("CreatedBy","CreatedBy");
			this.exdMultiLangAttrs.Add("ModifiedOn","ModifiedOn");
			this.exdMultiLangAttrs.Add("ModifiedBy","ModifiedBy");
			this.exdMultiLangAttrs.Add("SysVersion","SysVersion");
			this.exdMultiLangAttrs.Add("BusinessType","BusinessType");
			this.exdMultiLangAttrs.Add("Salesman","Salesman");
			this.exdMultiLangAttrs.Add("CustomerContact","CustomerContact");
			this.exdMultiLangAttrs.Add("ContactPhone","ContactPhone");
			this.exdMultiLangAttrs.Add("ShipDate","ShipDate");
			this.exdMultiLangAttrs.Add("SaleNo","SaleNo");
			this.exdMultiLangAttrs.Add("Supplier","Supplier");
			this.exdMultiLangAttrs.Add("Qty","Qty");
			this.exdMultiLangAttrs.Add("ProductCategory","ProductCategory");
			this.exdMultiLangAttrs.Add("Province","Province");
			this.exdMultiLangAttrs.Add("IBulk","IBulk");
			this.exdMultiLangAttrs.Add("Weight","Weight");
			this.exdMultiLangAttrs.Add("BulkUom","BulkUom");
			this.exdMultiLangAttrs.Add("WeightUom","WeightUom");
			this.exdMultiLangAttrs.Add("PickupFee","PickupFee");
			this.exdMultiLangAttrs.Add("DeliveryFee","DeliveryFee");
			this.exdMultiLangAttrs.Add("DischargeFee","DischargeFee");
			this.exdMultiLangAttrs.Add("OtherFee","OtherFee");
			this.exdMultiLangAttrs.Add("StandardShipping","StandardShipping");
			this.exdMultiLangAttrs.Add("TotalFreight","TotalFreight");
			this.exdMultiLangAttrs.Add("RealFreight","RealFreight");
			this.exdMultiLangAttrs.Add("AverageCost","AverageCost");
			this.exdMultiLangAttrs.Add("UintPrice","UintPrice");
			this.exdMultiLangAttrs.Add("Remark","Remark");
			this.exdMultiLangAttrs.Add("City","City");
			this.exdMultiLangAttrs.Add("County","County");
			this.exdMultiLangAttrs.Add("DescribeAddress","DescribeAddress");
			this.exdMultiLangAttrs.Add("FullAddress","FullAddress");
        }
	#endregion 




		
		
		#region override SetTypeValue method(Use By UICommonCRUD OR Weakly Type Operation)
		public override void SetTypeValue(object propName, object value)
		{
			
			string propstr = propName.ToString();
			switch(propstr)
			{
			
																																																																																																						

				default:
					//调用基类的实现，最终Entity基类为SetValue()
					base.SetTypeValue(propName,value);
					return;
			}
		}
		#endregion


	


		#region EntityData exchange
		
		#region  DeSerializeKey -ForEntityPorpertyType
		//反序化Key到Data的ID中 --由FromEntityData自动调用一次。实际可以分离,由跨组织服务去调用.
		private void DeSerializeKey(FeeRecordData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			

			

			if (data.Supplier == -1 && data.Supplier_SKey!=null)
				data.Supplier = data.Supplier_SKey.GetEntity().ID ;
	

			

			if (data.Province == -1 && data.Province_SKey!=null)
				data.Province = data.Province_SKey.GetEntity().ID ;
	

			

			

			if (data.BulkUom == -1 && data.BulkUom_SKey!=null)
				data.BulkUom = data.BulkUom_SKey.GetEntity().ID ;
	

			if (data.WeightUom == -1 && data.WeightUom_SKey!=null)
				data.WeightUom = data.WeightUom_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			if (data.City == -1 && data.City_SKey!=null)
				data.City = data.City_SKey.GetEntity().ID ;
	

			if (data.County == -1 && data.County_SKey!=null)
				data.County = data.County_SKey.GetEntity().ID ;
	

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			FeeRecordData data = dto as FeeRecordData ;
			if (data == null)
				return ;
            this.FromEntityData(data) ;
        }

        public override UFSoft.UBF.Business.DataTransObjectBase ToEntityDataBase()
        {
            return this.ToEntityData();
        }
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(FeeRecordData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(FeeRecordData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
				
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

								this.SetTypeValue("SysVersion",data.SysVersion);
		
									this.SetTypeValue("BusinessType",data.BusinessType);
		
								this.SetTypeValue("Salesman",data.Salesman);
		
								this.SetTypeValue("CustomerContact",data.CustomerContact);
		
								this.SetTypeValue("ContactPhone",data.ContactPhone);
		
								this.SetTypeValue("ShipDate",data.ShipDate);
		
								this.SetTypeValue("SaleNo",data.SaleNo);
		
								this.SetTypeValue("Supplier",data.Supplier);
		
								this.SetTypeValue("Qty",data.Qty);
		
								this.SetTypeValue("Province",data.Province);
		
								this.SetTypeValue("IBulk",data.IBulk);
		
								this.SetTypeValue("Weight",data.Weight);
		
								this.SetTypeValue("BulkUom",data.BulkUom);
		
								this.SetTypeValue("WeightUom",data.WeightUom);
		
								this.SetTypeValue("PickupFee",data.PickupFee);
		
								this.SetTypeValue("DeliveryFee",data.DeliveryFee);
		
								this.SetTypeValue("DischargeFee",data.DischargeFee);
		
								this.SetTypeValue("OtherFee",data.OtherFee);
		
								this.SetTypeValue("StandardShipping",data.StandardShipping);
		
								this.SetTypeValue("TotalFreight",data.TotalFreight);
		
								this.SetTypeValue("RealFreight",data.RealFreight);
		
								this.SetTypeValue("AverageCost",data.AverageCost);
		
								this.SetTypeValue("UintPrice",data.UintPrice);
		
								this.SetTypeValue("Remark",data.Remark);
		
								this.SetTypeValue("City",data.City);
		
								this.SetTypeValue("County",data.County);
		
								this.SetTypeValue("DescribeAddress",data.DescribeAddress);
		
								this.SetTypeValue("FullAddress",data.FullAddress);
		
			#endregion 

			#region 组件内属性
	
					this.SetTypeValue("ProductCategory",data.ProductCategory);
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public FeeRecordData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public FeeRecordData ToEntityData(FeeRecordData data, IDictionary dict){
			if (data == null)
				data = new FeeRecordData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecord"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("ID");
				if (obj != null)
					data.ID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedOn");
				if (obj != null)
					data.CreatedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedBy");
				if (obj != null)
					data.CreatedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedOn");
				if (obj != null)
					data.ModifiedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedBy");
				if (obj != null)
					data.ModifiedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SysVersion");
				if (obj != null)
					data.SysVersion=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("BusinessType") ;
				if (obj != null)
					data.BusinessType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Salesman");
				if (obj != null)
					data.Salesman=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerContact");
				if (obj != null)
					data.CustomerContact=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ContactPhone");
				if (obj != null)
					data.ContactPhone=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipDate");
				if (obj != null)
					data.ShipDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SaleNo");
				if (obj != null)
					data.SaleNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Supplier");
				if (obj != null)
					data.Supplier=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Qty");
				if (obj != null)
					data.Qty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Province");
				if (obj != null)
					data.Province=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IBulk");
				if (obj != null)
					data.IBulk=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Weight");
				if (obj != null)
					data.Weight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BulkUom");
				if (obj != null)
					data.BulkUom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("WeightUom");
				if (obj != null)
					data.WeightUom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PickupFee");
				if (obj != null)
					data.PickupFee=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DeliveryFee");
				if (obj != null)
					data.DeliveryFee=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DischargeFee");
				if (obj != null)
					data.DischargeFee=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OtherFee");
				if (obj != null)
					data.OtherFee=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("StandardShipping");
				if (obj != null)
					data.StandardShipping=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TotalFreight");
				if (obj != null)
					data.TotalFreight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RealFreight");
				if (obj != null)
					data.RealFreight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AverageCost");
				if (obj != null)
					data.AverageCost=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UintPrice");
				if (obj != null)
					data.UintPrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Remark");
				if (obj != null)
					data.Remark=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("City");
				if (obj != null)
					data.City=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("County");
				if (obj != null)
					data.County=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DescribeAddress");
				if (obj != null)
					data.DescribeAddress=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FullAddress");
				if (obj != null)
					data.FullAddress=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object obj =this.GetValue("ProductCategory");
				if (obj != null)
					data.ProductCategory=System.Int32.Parse(obj.ToString());
			}
	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
        


































			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}