using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	
	/// <summary>
	/// 实体: 费用计算
	/// 
	/// </summary>
	[Serializable]	
	public  partial class CalculationFee : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public CalculationFee(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static CalculationFee Create() {
			CalculationFee entity = (CalculationFee)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																											 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected CalculationFee(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static CalculationFee CreateDefault() {
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
		public static CalculationFee CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class CalculationFee EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new CalculationFee GetEntity()
			{
				return (CalculationFee)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<CalculationFee> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<CalculationFee>{
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
		    //private CalculationFee ContainerEntity ;
		    public  new CalculationFee ContainerEntity 
		    {
				get { return  (CalculationFee)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(CalculationFee container)
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
			/// 费用计算.Key.ID
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
			/// 费用计算.Sys.创建时间
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
			/// 费用计算.Sys.创建人
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
			/// 费用计算.Sys.修改时间
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
			/// 费用计算.Sys.修改人
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
			/// 费用计算.Sys.事务版本
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
			/// 供应商 (该属性可为空,且无默认值)
			/// 费用计算.Misc.供应商
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier Sup
			{
				get
				{
					if (SupKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Supplier.Supplier value =  (UFIDA.U9.CBO.SCM.Supplier.Supplier)SupKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_SupKey ;
		/// <summary>
		/// EntityKey 属性
		/// 供应商 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.供应商
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey SupKey
		{
			get 
			{
				object obj = base.GetValue("Sup") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SupKey==null || m_SupKey.ID != key )
					m_SupKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_SupKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提货工厂 (该属性可为空,但有默认值)
			/// 费用计算.Misc.提货工厂
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum DeliveryFactory
			{
				get
				{

					UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum.GetFromValue(base.GetValue("DeliveryFactory"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 送货地址 (该属性可为空,且无默认值)
			/// 费用计算.Misc.送货地址
			/// </summary>
			/// <value></value>
			public  System.String Address
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Address");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 配送日期 (该属性可为空,且无默认值)
			/// 费用计算.Misc.配送日期
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
			/// 计价方式 (该属性可为空,但有默认值)
			/// 费用计算.Misc.计价方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum PricingMethod
			{
				get
				{

					UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.GetFromValue(base.GetValue("PricingMethod"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 合计金额 (该属性可为空,但有默认值)
			/// 费用计算.Misc.合计金额
			/// </summary>
			/// <value></value>
			public  System.Double TotalAmount
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("TotalAmount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 结算金额 (该属性可为空,但有默认值)
			/// 费用计算.Misc.结算金额
			/// </summary>
			/// <value></value>
			public  System.Double RealAmount
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("RealAmount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单价 (该属性可为空,但有默认值)
			/// 费用计算.Misc.单价
			/// </summary>
			/// <value></value>
			public  System.Double UintPrice
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("UintPrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 费用计算.Misc.备注
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
			/// 包含 (该属性可为空,但有默认值)
			/// 费用计算.Misc.包含
			/// </summary>
			/// <value></value>
			public  System.Boolean Contain
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("Contain");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 派车数量 (该属性可为空,但有默认值)
			/// 费用计算.Misc.派车数量
			/// </summary>
			/// <value></value>
			public  System.Int32 NumberOfTrucks
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("NumberOfTrucks");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 黄岛合计 (该属性可为空,且无默认值)
			/// 费用计算.Misc.黄岛合计
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine HuangdaoTotal
			{
				get
				{
					if (HuangdaoTotalKey == null)
						return null ;
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine value =  (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)HuangdaoTotalKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey m_HuangdaoTotalKey ;
		/// <summary>
		/// EntityKey 属性
		/// 黄岛合计 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.黄岛合计
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey HuangdaoTotalKey
		{
			get 
			{
				object obj = base.GetValue("HuangdaoTotal") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_HuangdaoTotalKey==null || m_HuangdaoTotalKey.ID != key )
					m_HuangdaoTotalKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey(key); 
				return m_HuangdaoTotalKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 城阳合计 (该属性可为空,且无默认值)
			/// 费用计算.Misc.城阳合计
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine ChenyangTotal
			{
				get
				{
					if (ChenyangTotalKey == null)
						return null ;
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine value =  (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)ChenyangTotalKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey m_ChenyangTotalKey ;
		/// <summary>
		/// EntityKey 属性
		/// 城阳合计 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.城阳合计
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey ChenyangTotalKey
		{
			get 
			{
				object obj = base.GetValue("ChenyangTotal") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ChenyangTotalKey==null || m_ChenyangTotalKey.ID != key )
					m_ChenyangTotalKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey(key); 
				return m_ChenyangTotalKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 设定地址 (该属性可为空,且无默认值)
			/// 费用计算.Misc.设定地址
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine SetLocation
			{
				get
				{
					if (SetLocationKey == null)
						return null ;
					UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine value =  (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine)SetLocationKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine.EntityKey m_SetLocationKey ;
		/// <summary>
		/// EntityKey 属性
		/// 设定地址 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.设定地址
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine.EntityKey SetLocationKey
		{
			get 
			{
				object obj = base.GetValue("SetLocation") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SetLocationKey==null || m_SetLocationKey.ID != key )
					m_SetLocationKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine.EntityKey(key); 
				return m_SetLocationKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 省 (该属性可为空,且无默认值)
			/// 费用计算.Misc.省
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
		/// 省 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.省
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
			/// 市 (该属性可为空,且无默认值)
			/// 费用计算.Misc.市
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
		/// 市 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.市
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
			/// 费用计算.Misc.区县
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
		/// 费用计算.Misc.区县
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
			/// 费用计算.Misc.详细地址
			/// </summary>
			/// <value></value>
			public  System.String DescriLocation
			{
				get
				{
					System.String value  = (System.String)base.GetValue("DescriLocation");
					return value;
						}
			}
		



		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine> m_CalculationFeeLine  ;
			/// <summary>
			/// 费用计算行 (该属性可为空,且无默认值)
			/// 费用计算.Misc.费用计算行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine> CalculationFeeLine
			{
				get
				{
					if (m_CalculationFeeLine == null)
						m_CalculationFeeLine = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine>();
					m_CalculationFeeLine.Clear();	
					foreach (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine child in ContainerEntity.CalculationFeeLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_CalculationFeeLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine child in ContainerEntity.CalculationFeeLine.DelLists)
					{
						m_CalculationFeeLine.Add(child);
					}
					return m_CalculationFeeLine;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 费用计算.Key.ID
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
		/// 费用计算.Sys.创建时间
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
		/// 费用计算.Sys.创建人
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
		/// 费用计算.Sys.修改时间
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
		/// 费用计算.Sys.修改人
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
		/// 费用计算.Sys.事务版本
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
		/// 供应商 (该属性可为空,且无默认值)
		/// 费用计算.Misc.供应商
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier Sup
		{
			get
			{
				object  obj = this.GetRelation("Sup");
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
				
				this.SetRelation("Sup", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_SupKey ;
		/// <summary>
		/// 供应商 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.供应商
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey SupKey
		{
			get 
			{
				object obj = base.GetValue("Sup") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SupKey==null || m_SupKey.ID != key )
					m_SupKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_SupKey ;
			}
			set
			{	
				if (SupKey==value)
					return ;
				this.SetRelation("Sup", null);
				m_SupKey = value ;
				if (value != null) 
				{
					base.SetValue("Sup",value.ID);
				}
				else
					base.SetValue("Sup",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 提货工厂 (该属性可为空,但有默认值)
		/// 费用计算.Misc.提货工厂
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum DeliveryFactory
		{
			get
			{

				UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum.GetFromValue(base.GetValue("DeliveryFactory"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("DeliveryFactory",UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum.Empty.Value);
				else
					base.SetValue("DeliveryFactory",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 送货地址 (该属性可为空,且无默认值)
		/// 费用计算.Misc.送货地址
		/// </summary>
		/// <value></value>
			public  System.String Address
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Address");
				return value;
				}
				set
			{
				
								base.SetValue("Address", value);
						 
			}
		}
	



		
			/// <summary>
		/// 配送日期 (该属性可为空,且无默认值)
		/// 费用计算.Misc.配送日期
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
		/// 计价方式 (该属性可为空,但有默认值)
		/// 费用计算.Misc.计价方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum PricingMethod
		{
			get
			{

				UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.GetFromValue(base.GetValue("PricingMethod"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("PricingMethod",UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.Empty.Value);
				else
					base.SetValue("PricingMethod",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 合计金额 (该属性可为空,但有默认值)
		/// 费用计算.Misc.合计金额
		/// </summary>
		/// <value></value>
			public  System.Double TotalAmount
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("TotalAmount");
				return value;
				}
				set
			{
				
								base.SetValue("TotalAmount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 结算金额 (该属性可为空,但有默认值)
		/// 费用计算.Misc.结算金额
		/// </summary>
		/// <value></value>
			public  System.Double RealAmount
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("RealAmount");
				return value;
				}
				set
			{
				
								base.SetValue("RealAmount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// 费用计算.Misc.单价
		/// </summary>
		/// <value></value>
			public  System.Double UintPrice
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("UintPrice");
				return value;
				}
				set
			{
				
								base.SetValue("UintPrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 费用计算.Misc.备注
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
		/// 包含 (该属性可为空,但有默认值)
		/// 费用计算.Misc.包含
		/// </summary>
		/// <value></value>
			public  System.Boolean Contain
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("Contain");
				return value;
				}
				set
			{
				
								base.SetValue("Contain", value);
						 
			}
		}
	



		
			/// <summary>
		/// 派车数量 (该属性可为空,但有默认值)
		/// 费用计算.Misc.派车数量
		/// </summary>
		/// <value></value>
			public  System.Int32 NumberOfTrucks
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("NumberOfTrucks");
				return value;
				}
				set
			{
				
								base.SetValue("NumberOfTrucks", value);
						 
			}
		}
	



		
			/// <summary>
		/// 黄岛合计 (该属性可为空,且无默认值)
		/// 费用计算.Misc.黄岛合计
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine HuangdaoTotal
		{
			get
			{
				object  obj = this.GetRelation("HuangdaoTotal");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine value  = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("HuangdaoTotal", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey m_HuangdaoTotalKey ;
		/// <summary>
		/// 黄岛合计 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.黄岛合计
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey HuangdaoTotalKey
		{
			get 
			{
				object obj = base.GetValue("HuangdaoTotal") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_HuangdaoTotalKey==null || m_HuangdaoTotalKey.ID != key )
					m_HuangdaoTotalKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey(key); 
				return m_HuangdaoTotalKey ;
			}
			set
			{	
				if (HuangdaoTotalKey==value)
					return ;
				this.SetRelation("HuangdaoTotal", null);
				m_HuangdaoTotalKey = value ;
				if (value != null) 
				{
					base.SetValue("HuangdaoTotal",value.ID);
				}
				else
					base.SetValue("HuangdaoTotal",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 城阳合计 (该属性可为空,且无默认值)
		/// 费用计算.Misc.城阳合计
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine ChenyangTotal
		{
			get
			{
				object  obj = this.GetRelation("ChenyangTotal");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine value  = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ChenyangTotal", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey m_ChenyangTotalKey ;
		/// <summary>
		/// 城阳合计 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.城阳合计
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey ChenyangTotalKey
		{
			get 
			{
				object obj = base.GetValue("ChenyangTotal") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ChenyangTotalKey==null || m_ChenyangTotalKey.ID != key )
					m_ChenyangTotalKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine.EntityKey(key); 
				return m_ChenyangTotalKey ;
			}
			set
			{	
				if (ChenyangTotalKey==value)
					return ;
				this.SetRelation("ChenyangTotal", null);
				m_ChenyangTotalKey = value ;
				if (value != null) 
				{
					base.SetValue("ChenyangTotal",value.ID);
				}
				else
					base.SetValue("ChenyangTotal",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 设定地址 (该属性可为空,且无默认值)
		/// 费用计算.Misc.设定地址
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine SetLocation
		{
			get
			{
				object  obj = this.GetRelation("SetLocation");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine value  = (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SetLocation", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine.EntityKey m_SetLocationKey ;
		/// <summary>
		/// 设定地址 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.设定地址
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine.EntityKey SetLocationKey
		{
			get 
			{
				object obj = base.GetValue("SetLocation") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SetLocationKey==null || m_SetLocationKey.ID != key )
					m_SetLocationKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine.EntityKey(key); 
				return m_SetLocationKey ;
			}
			set
			{	
				if (SetLocationKey==value)
					return ;
				this.SetRelation("SetLocation", null);
				m_SetLocationKey = value ;
				if (value != null) 
				{
					base.SetValue("SetLocation",value.ID);
				}
				else
					base.SetValue("SetLocation",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 省 (该属性可为空,且无默认值)
		/// 费用计算.Misc.省
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
		/// 省 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.省
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
		/// 市 (该属性可为空,且无默认值)
		/// 费用计算.Misc.市
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
		/// 市 的Key (该属性可为空,且无默认值)
		/// 费用计算.Misc.市
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
		/// 费用计算.Misc.区县
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
		/// 费用计算.Misc.区县
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
		/// 费用计算.Misc.详细地址
		/// </summary>
		/// <value></value>
			public  System.String DescriLocation
		{
			get
			{
				System.String value  = (System.String)base.GetValue("DescriLocation");
				return value;
				}
				set
			{
				
								base.SetValue("DescriLocation", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine.EntityList m_CalculationFeeLine  ;
		/// <summary>
		/// 费用计算行 (该属性可为空,且无默认值)
		/// 费用计算.Misc.费用计算行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine.EntityList CalculationFeeLine
		{
			get
			{
				if (m_CalculationFeeLine == null)
					m_CalculationFeeLine = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine.EntityList("CalculationFee",this,"CalculationFeeLine",(IList)this.GetRelation("CalculationFeeLine"));
				else
					m_CalculationFeeLine.InnerList = (IList)this.GetRelation("CalculationFeeLine");
				return m_CalculationFeeLine;
			}
		}
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Sup")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Sup　{ get { return EntityRes.GetResource("Sup");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DeliveryFactory")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DeliveryFactory　{ get { return EntityRes.GetResource("DeliveryFactory");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Address")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Address　{ get { return EntityRes.GetResource("Address");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipDate　{ get { return EntityRes.GetResource("ShipDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PricingMethod")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PricingMethod　{ get { return EntityRes.GetResource("PricingMethod");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TotalAmount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TotalAmount　{ get { return EntityRes.GetResource("TotalAmount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RealAmount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RealAmount　{ get { return EntityRes.GetResource("RealAmount");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Contain")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Contain　{ get { return EntityRes.GetResource("Contain");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NumberOfTrucks")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NumberOfTrucks　{ get { return EntityRes.GetResource("NumberOfTrucks");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CalculationFeeLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CalculationFeeLine　{ get { return EntityRes.GetResource("CalculationFeeLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("HuangdaoTotal")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_HuangdaoTotal　{ get { return EntityRes.GetResource("HuangdaoTotal");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ChenyangTotal")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ChenyangTotal　{ get { return EntityRes.GetResource("ChenyangTotal");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SetLocation")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SetLocation　{ get { return EntityRes.GetResource("SetLocation");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Province")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Province　{ get { return EntityRes.GetResource("Province");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescriLocation")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescriLocation　{ get { return EntityRes.GetResource("DescriLocation");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "CalculationFee";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee";　}　}
		
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
			/// 属性: 供应商 的名称
			/// </summary>
			public static string Sup　{ get { return "Sup";　}　}
				
			/// <summary>
			/// 属性: 提货工厂 的名称
			/// </summary>
			public static string DeliveryFactory　{ get { return "DeliveryFactory";　}　}
				
			/// <summary>
			/// 属性: 送货地址 的名称
			/// </summary>
			public static string Address　{ get { return "Address";　}　}
				
			/// <summary>
			/// 属性: 配送日期 的名称
			/// </summary>
			public static string ShipDate　{ get { return "ShipDate";　}　}
				
			/// <summary>
			/// 属性: 计价方式 的名称
			/// </summary>
			public static string PricingMethod　{ get { return "PricingMethod";　}　}
				
			/// <summary>
			/// 属性: 合计金额 的名称
			/// </summary>
			public static string TotalAmount　{ get { return "TotalAmount";　}　}
				
			/// <summary>
			/// 属性: 结算金额 的名称
			/// </summary>
			public static string RealAmount　{ get { return "RealAmount";　}　}
				
			/// <summary>
			/// 属性: 单价 的名称
			/// </summary>
			public static string UintPrice　{ get { return "UintPrice";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Remark　{ get { return "Remark";　}　}
				
			/// <summary>
			/// 属性: 包含 的名称
			/// </summary>
			public static string Contain　{ get { return "Contain";　}　}
				
			/// <summary>
			/// 属性: 派车数量 的名称
			/// </summary>
			public static string NumberOfTrucks　{ get { return "NumberOfTrucks";　}　}
				
			/// <summary>
			/// 属性: 费用计算行 的名称
			/// </summary>
			public static string CalculationFeeLine　{ get { return "CalculationFeeLine";　}　}
				
			/// <summary>
			/// 属性: 黄岛合计 的名称
			/// </summary>
			public static string HuangdaoTotal　{ get { return "HuangdaoTotal";　}　}
				
			/// <summary>
			/// 属性: 城阳合计 的名称
			/// </summary>
			public static string ChenyangTotal　{ get { return "ChenyangTotal";　}　}
				
			/// <summary>
			/// 属性: 设定地址 的名称
			/// </summary>
			public static string SetLocation　{ get { return "SetLocation";　}　}
				
			/// <summary>
			/// 属性: 省 的名称
			/// </summary>
			public static string Province　{ get { return "Province";　}　}
				
			/// <summary>
			/// 属性: 市 的名称
			/// </summary>
			public static string City　{ get { return "City";　}　}
				
			/// <summary>
			/// 属性: 区县 的名称
			/// </summary>
			public static string County　{ get { return "County";　}　}
				
			/// <summary>
			/// 属性: 详细地址 的名称
			/// </summary>
			public static string DescriLocation　{ get { return "DescriLocation";　}　}
		
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
			this.exdMultiLangAttrs.Add("Sup","Sup");
			this.exdMultiLangAttrs.Add("DeliveryFactory","DeliveryFactory");
			this.exdMultiLangAttrs.Add("Address","Address");
			this.exdMultiLangAttrs.Add("ShipDate","ShipDate");
			this.exdMultiLangAttrs.Add("PricingMethod","PricingMethod");
			this.exdMultiLangAttrs.Add("TotalAmount","TotalAmount");
			this.exdMultiLangAttrs.Add("RealAmount","RealAmount");
			this.exdMultiLangAttrs.Add("UintPrice","UintPrice");
			this.exdMultiLangAttrs.Add("Remark","Remark");
			this.exdMultiLangAttrs.Add("Contain","Contain");
			this.exdMultiLangAttrs.Add("NumberOfTrucks","NumberOfTrucks");
			this.exdMultiLangAttrs.Add("HuangdaoTotal","HuangdaoTotal");
			this.exdMultiLangAttrs.Add("ChenyangTotal","ChenyangTotal");
			this.exdMultiLangAttrs.Add("SetLocation","SetLocation");
			this.exdMultiLangAttrs.Add("Province","Province");
			this.exdMultiLangAttrs.Add("City","City");
			this.exdMultiLangAttrs.Add("County","County");
			this.exdMultiLangAttrs.Add("DescriLocation","DescriLocation");
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
		private void DeSerializeKey(CalculationFeeData data)
		{
		
			

			

			

			

			

			

			if (data.Sup == -1 && data.Sup_SKey!=null)
				data.Sup = data.Sup_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			if (data.HuangdaoTotal == -1 && data.HuangdaoTotal_SKey!=null)
				data.HuangdaoTotal = data.HuangdaoTotal_SKey.GetEntity().ID ;
	

			if (data.ChenyangTotal == -1 && data.ChenyangTotal_SKey!=null)
				data.ChenyangTotal = data.ChenyangTotal_SKey.GetEntity().ID ;
	

			if (data.SetLocation == -1 && data.SetLocation_SKey!=null)
				data.SetLocation = data.SetLocation_SKey.GetEntity().ID ;
	

			if (data.Province == -1 && data.Province_SKey!=null)
				data.Province = data.Province_SKey.GetEntity().ID ;
	

			if (data.City == -1 && data.City_SKey!=null)
				data.City = data.City_SKey.GetEntity().ID ;
	

			if (data.County == -1 && data.County_SKey!=null)
				data.County = data.County_SKey.GetEntity().ID ;
	

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			CalculationFeeData data = dto as CalculationFeeData ;
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
		public void FromEntityData(CalculationFeeData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CalculationFeeData data,IDictionary dict)
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
		
								this.SetTypeValue("Sup",data.Sup);
		
								this.SetTypeValue("Address",data.Address);
		
								this.SetTypeValue("ShipDate",data.ShipDate);
		
								this.SetTypeValue("TotalAmount",data.TotalAmount);
		
								this.SetTypeValue("RealAmount",data.RealAmount);
		
								this.SetTypeValue("UintPrice",data.UintPrice);
		
								this.SetTypeValue("Remark",data.Remark);
		
								this.SetTypeValue("Contain",data.Contain);
		
								this.SetTypeValue("NumberOfTrucks",data.NumberOfTrucks);
		
								this.SetTypeValue("HuangdaoTotal",data.HuangdaoTotal);
		
								this.SetTypeValue("ChenyangTotal",data.ChenyangTotal);
		
								this.SetTypeValue("SetLocation",data.SetLocation);
		
								this.SetTypeValue("Province",data.Province);
		
								this.SetTypeValue("City",data.City);
		
								this.SetTypeValue("County",data.County);
		
								this.SetTypeValue("DescriLocation",data.DescriLocation);
		
			#endregion 

			#region 组件内属性
	
					this.SetTypeValue("DeliveryFactory",data.DeliveryFactory);
	     

					this.SetTypeValue("PricingMethod",data.PricingMethod);
	     

					if (data.CalculationFeeLine != null)
			{	
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData obj in data.CalculationFeeLine )
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine child = dict[obj] as UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.CalculationFeeLine.Remove(child);
						this.CalculationFeeLine.DelLists.Add(child);
					}
					else
						this.CalculationFeeLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CalculationFeeData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CalculationFeeData ToEntityData(CalculationFeeData data, IDictionary dict){
			if (data == null)
				data = new CalculationFeeData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("Sup");
				if (obj != null)
					data.Sup=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Address");
				if (obj != null)
					data.Address=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipDate");
				if (obj != null)
					data.ShipDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TotalAmount");
				if (obj != null)
					data.TotalAmount=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RealAmount");
				if (obj != null)
					data.RealAmount=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UintPrice");
				if (obj != null)
					data.UintPrice=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Remark");
				if (obj != null)
					data.Remark=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Contain");
				if (obj != null)
					data.Contain=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NumberOfTrucks");
				if (obj != null)
					data.NumberOfTrucks=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("HuangdaoTotal");
				if (obj != null)
					data.HuangdaoTotal=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ChenyangTotal");
				if (obj != null)
					data.ChenyangTotal=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SetLocation");
				if (obj != null)
					data.SetLocation=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Province");
				if (obj != null)
					data.Province=(System.Int64)obj;
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
				object obj =this.GetValue("DescriLocation");
				if (obj != null)
					data.DescriLocation=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object obj =this.GetValue("DeliveryFactory");
				if (obj != null)
					data.DeliveryFactory=System.Int32.Parse(obj.ToString());
			}
	
			{
				object obj =this.GetValue("PricingMethod");
				if (obj != null)
					data.PricingMethod=System.Int32.Parse(obj.ToString());
			}
	
			if (this.CalculationFeeLine != null)
			{	
				List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData> listCalculationFeeLine = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine obj in this.CalculationFeeLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData old = dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine"+obj.ID.ToString()] as UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData;
					listCalculationFeeLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.CalculationFeeLine = listCalculationFeeLine;
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