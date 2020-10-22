using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	
	/// <summary>
	/// 实体: 物流价目表行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class LogisticsPricelistLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public LogisticsPricelistLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static LogisticsPricelistLine Create(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist parentEntity) {
			LogisticsPricelistLine entity = (LogisticsPricelistLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.LogisticsPricelist = parentEntity ;
			parentEntity.LogisticsPricelistLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected LogisticsPricelistLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return false ;}
		}
		#endregion

		#region Create Default 
	    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
        [Obsolete("仅用于开发的测试用例时期.正式版返回NULL.不可使用.")]
		public  static LogisticsPricelistLine CreateDefault(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist parentEntity) {
		#if Test		
			return CreateDefault_Extend(parentEntity);
		#else 
		    return null;
		#endif
		}
	
		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class LogisticsPricelistLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new LogisticsPricelistLine GetEntity()
			{
				return (LogisticsPricelistLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<LogisticsPricelistLine> 
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









			/// <summary>
			/// 业务主键查询参数类型
			/// </summary>
			public class BusinessKeyParameter
			{
				private UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum m_DeliveryFactory ;
				public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum DeliveryFactory
				{
					get { return m_DeliveryFactory ;}
					set { m_DeliveryFactory = value ;}
				}
				private UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum m_PricingMethod ;
				public  UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum PricingMethod
				{
					get { return m_PricingMethod ;}
					set { m_PricingMethod = value ;}
				}
				private UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityKey m_LogisticsPricelist ;
				public  UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityKey LogisticsPricelist
				{
					get { return m_LogisticsPricelist ;}
					set { m_LogisticsPricelist = value ;}
				}
				private System.String m_FormatAddress ;
				public  System.String FormatAddress
				{
					get { return m_FormatAddress ;}
					set { m_FormatAddress = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public LogisticsPricelistLine FindByBusinessKey(  UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum deliveryFactory  , UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum pricingMethod  , UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityKey logisticsPricelist  , System.String formatAddress  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.DeliveryFactory = deliveryFactory ;
				
				parameter.PricingMethod = pricingMethod ;
				
				parameter.LogisticsPricelist = logisticsPricelist ;
				
				parameter.FormatAddress = formatAddress ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public LogisticsPricelistLine FindByBusinessKey(  UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum deliveryFactory  , UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum pricingMethod  , UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist logisticsPricelist  , System.String formatAddress  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
								parameter.DeliveryFactory = deliveryFactory ;								parameter.PricingMethod = pricingMethod ;				
				parameter.LogisticsPricelist = logisticsPricelist==null?null:logisticsPricelist.Key ;
								parameter.FormatAddress = formatAddress ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public LogisticsPricelistLine FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*4);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("DeliveryFactory = @DeliveryFactory");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DeliveryFactory",parameter.DeliveryFactory.Value));												
				

				sbuilder.Append(" and PricingMethod = @PricingMethod");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("PricingMethod",parameter.PricingMethod.Value));												
				
				if (parameter.LogisticsPricelist==null)
				{
					sbuilder.Append(" and LogisticsPricelist is null ");
				}
				else
				{
					sbuilder.Append(" and LogisticsPricelist = @LogisticsPricelist");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("LogisticsPricelist",parameter.LogisticsPricelist.ID));
				}								
				
				if (System.String.IsNullOrEmpty(parameter.FormatAddress))
				{
					sbuilder.Append(" and FormatAddress is null ");
				}
				else
				{
					sbuilder.Append(" and FormatAddress = @FormatAddress");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("FormatAddress",parameter.FormatAddress));
				}
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_BLT_CustLogisticsBE_LogisticsPricelistLine_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum m_PricingMethod ;
				public  UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum PricingMethod
				{
					get { return m_PricingMethod ;}
					set { m_PricingMethod = value ;}
				}				private UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum m_DeliveryFactory ;
				public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum DeliveryFactory
				{
					get { return m_DeliveryFactory ;}
					set { m_DeliveryFactory = value ;}
				}				private UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityKey m_LogisticsPricelist ;
				public  UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityKey LogisticsPricelist
				{
					get { return m_LogisticsPricelist ;}
					set { m_LogisticsPricelist = value ;}
				}				private System.String m_FormatAddress ;
				public  System.String FormatAddress
				{
					get { return m_FormatAddress ;}
					set { m_FormatAddress = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_BLT_CustLogisticsBE_LogisticsPricelistLine_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public LogisticsPricelistLine FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*4);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("PricingMethod = @PricingMethod");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("PricingMethod",parameter.PricingMethod.Value));				
				sbuilder.Append(" and DeliveryFactory = @DeliveryFactory");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DeliveryFactory",parameter.DeliveryFactory.Value));				
				if (parameter.LogisticsPricelist==null)
				{
					sbuilder.Append("  and  LogisticsPricelist is null ");
				}
				else
				{
					sbuilder.Append(" and LogisticsPricelist = @LogisticsPricelist");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("LogisticsPricelist",parameter.LogisticsPricelist.ID));
				}				
				if (System.String.IsNullOrEmpty(parameter.FormatAddress))
				{
					sbuilder.Append("  and  FormatAddress is null ");
				}
				else
				{
					sbuilder.Append(" and FormatAddress = @FormatAddress");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("FormatAddress",parameter.FormatAddress));
				}				
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<LogisticsPricelistLine>{
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
			    get { return false ;}
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
		    //private LogisticsPricelistLine ContainerEntity ;
		    public  new LogisticsPricelistLine ContainerEntity 
		    {
				get { return  (LogisticsPricelistLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(LogisticsPricelistLine container)
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
			/// 物流价目表行.Key.ID
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
			/// 物流价目表行.Sys.创建时间
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
			/// 物流价目表行.Sys.创建人
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
			/// 物流价目表行.Sys.修改时间
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
			/// 物流价目表行.Sys.修改人
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
			/// 物流价目表行.Sys.事务版本
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
			/// 序号 (该属性可为空,但有默认值)
			/// 物流价目表行.Misc.序号
			/// </summary>
			/// <value></value>
			public  System.Int32 No
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("No");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提货工厂 (该属性可为空,但有默认值)
			/// 物流价目表行.Misc.提货工厂
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
			/// 物流价目表行.Misc.送货地址
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Location.Location Address
			{
				get
				{
					if (AddressKey == null)
						return null ;
					UFIDA.U9.Base.Location.Location value =  (UFIDA.U9.Base.Location.Location)AddressKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Location.Location.EntityKey m_AddressKey ;
		/// <summary>
		/// EntityKey 属性
		/// 送货地址 的Key (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.送货地址
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Location.EntityKey AddressKey
		{
			get 
			{
				object obj = base.GetValue("Address") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_AddressKey==null || m_AddressKey.ID != key )
					m_AddressKey = new UFIDA.U9.Base.Location.Location.EntityKey(key); 
				return m_AddressKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 计价方式 (该属性可为空,但有默认值)
			/// 物流价目表行.Misc.计价方式
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
			/// 计价单位 (该属性可为空,且无默认值)
			/// 物流价目表行.Misc.计价单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM PricingUom
			{
				get
				{
					if (PricingUomKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)PricingUomKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_PricingUomKey ;
		/// <summary>
		/// EntityKey 属性
		/// 计价单位 的Key (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.计价单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey PricingUomKey
		{
			get 
			{
				object obj = base.GetValue("PricingUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PricingUomKey==null || m_PricingUomKey.ID != key )
					m_PricingUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_PricingUomKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单价 (该属性可为空,但有默认值)
			/// 物流价目表行.Misc.单价
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
			/// 动态价格 (该属性可为空,且无默认值)
			/// 物流价目表行.Misc.动态价格
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice DynamicPrice
			{
				get
				{
					if (DynamicPriceKey == null)
						return null ;
					UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice value =  (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice)DynamicPriceKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.EntityKey m_DynamicPriceKey ;
		/// <summary>
		/// EntityKey 属性
		/// 动态价格 的Key (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.动态价格
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.EntityKey DynamicPriceKey
		{
			get 
			{
				object obj = base.GetValue("DynamicPrice") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DynamicPriceKey==null || m_DynamicPriceKey.ID != key )
					m_DynamicPriceKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.EntityKey(key); 
				return m_DynamicPriceKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提货费 (该属性可为空,但有默认值)
			/// 物流价目表行.Misc.提货费
			/// </summary>
			/// <value></value>
			public  System.Double DeliveryPickup
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("DeliveryPickup");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 送货费 (该属性可为空,但有默认值)
			/// 物流价目表行.Misc.送货费
			/// </summary>
			/// <value></value>
			public  System.Double DeliveryCharges
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("DeliveryCharges");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 免提标准 (该属性可为空,但有默认值)
			/// 物流价目表行.Misc.免提标准
			/// </summary>
			/// <value></value>
			public  System.Double FreePickup
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("FreePickup");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 免送标准 (该属性可为空,但有默认值)
			/// 物流价目表行.Misc.免送标准
			/// </summary>
			/// <value></value>
			public  System.Double FreeDelivery
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("FreeDelivery");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 运输时间 (该属性可为空,且无默认值)
			/// 物流价目表行.Misc.运输时间
			/// </summary>
			/// <value></value>
			public  System.String TransportationTime
			{
				get
				{
					System.String value  = (System.String)base.GetValue("TransportationTime");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 物流价目表行.Misc.备注
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
			/// 物流价目表 (该属性可为空,且无默认值)
			/// 物流价目表行.Misc.物流价目表
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist LogisticsPricelist
			{
				get
				{
					if (LogisticsPricelistKey == null)
						return null ;
					UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist value =  (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist)LogisticsPricelistKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityKey m_LogisticsPricelistKey ;
		/// <summary>
		/// EntityKey 属性
		/// 物流价目表 的Key (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.物流价目表
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityKey LogisticsPricelistKey
		{
			get 
			{
				object obj = base.GetValue("LogisticsPricelist") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_LogisticsPricelistKey==null || m_LogisticsPricelistKey.ID != key )
					m_LogisticsPricelistKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityKey(key); 
				return m_LogisticsPricelistKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 省/自治区 (该属性可为空,且无默认值)
			/// 物流价目表行.Misc.省/自治区
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
		/// 省/自治区 的Key (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.省/自治区
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
			/// 城市 (该属性可为空,且无默认值)
			/// 物流价目表行.Misc.城市
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
		/// 物流价目表行.Misc.城市
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
			/// 物流价目表行.Misc.区县
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
		/// 物流价目表行.Misc.区县
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
			/// 物流价目表行.Misc.详细地址
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
			/// 地址 (该属性可为空,且无默认值)
			/// 物流价目表行.Misc.地址
			/// </summary>
			/// <value></value>
			public  System.String FormatAddress
			{
				get
				{
					System.String value  = (System.String)base.GetValue("FormatAddress");
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
		/// 物流价目表行.Key.ID
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
		/// 物流价目表行.Sys.创建时间
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
		/// 物流价目表行.Sys.创建人
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
		/// 物流价目表行.Sys.修改时间
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
		/// 物流价目表行.Sys.修改人
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
		/// 物流价目表行.Sys.事务版本
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
		/// 序号 (该属性可为空,但有默认值)
		/// 物流价目表行.Misc.序号
		/// </summary>
		/// <value></value>
			public  System.Int32 No
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("No");
				return value;
				}
				set
			{
				
								base.SetValue("No", value);
						 
			}
		}
	



		
			/// <summary>
		/// 提货工厂 (该属性可为空,但有默认值)
		/// 物流价目表行.Misc.提货工厂
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
		/// 物流价目表行.Misc.送货地址
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Location.Location Address
		{
			get
			{
				object  obj = this.GetRelation("Address");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Location.Location value  = (UFIDA.U9.Base.Location.Location)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Address", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Location.Location.EntityKey m_AddressKey ;
		/// <summary>
		/// 送货地址 的Key (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.送货地址
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Location.EntityKey AddressKey
		{
			get 
			{
				object obj = base.GetValue("Address") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_AddressKey==null || m_AddressKey.ID != key )
					m_AddressKey = new UFIDA.U9.Base.Location.Location.EntityKey(key); 
				return m_AddressKey ;
			}
			set
			{	
				if (AddressKey==value)
					return ;
				this.SetRelation("Address", null);
				m_AddressKey = value ;
				if (value != null) 
				{
					base.SetValue("Address",value.ID);
				}
				else
					base.SetValue("Address",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 计价方式 (该属性可为空,但有默认值)
		/// 物流价目表行.Misc.计价方式
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
		/// 计价单位 (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.计价单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM PricingUom
		{
			get
			{
				object  obj = this.GetRelation("PricingUom");
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
				
				this.SetRelation("PricingUom", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_PricingUomKey ;
		/// <summary>
		/// 计价单位 的Key (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.计价单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey PricingUomKey
		{
			get 
			{
				object obj = base.GetValue("PricingUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PricingUomKey==null || m_PricingUomKey.ID != key )
					m_PricingUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_PricingUomKey ;
			}
			set
			{	
				if (PricingUomKey==value)
					return ;
				this.SetRelation("PricingUom", null);
				m_PricingUomKey = value ;
				if (value != null) 
				{
					base.SetValue("PricingUom",value.ID);
				}
				else
					base.SetValue("PricingUom",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// 物流价目表行.Misc.单价
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
		/// 动态价格 (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.动态价格
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice DynamicPrice
		{
			get
			{
				object  obj = this.GetRelation("DynamicPrice");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice value  = (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("DynamicPrice", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.EntityKey m_DynamicPriceKey ;
		/// <summary>
		/// 动态价格 的Key (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.动态价格
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.EntityKey DynamicPriceKey
		{
			get 
			{
				object obj = base.GetValue("DynamicPrice") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DynamicPriceKey==null || m_DynamicPriceKey.ID != key )
					m_DynamicPriceKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.EntityKey(key); 
				return m_DynamicPriceKey ;
			}
			set
			{	
				if (DynamicPriceKey==value)
					return ;
				this.SetRelation("DynamicPrice", null);
				m_DynamicPriceKey = value ;
				if (value != null) 
				{
					base.SetValue("DynamicPrice",value.ID);
				}
				else
					base.SetValue("DynamicPrice",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 提货费 (该属性可为空,但有默认值)
		/// 物流价目表行.Misc.提货费
		/// </summary>
		/// <value></value>
			public  System.Double DeliveryPickup
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("DeliveryPickup");
				return value;
				}
				set
			{
				
								base.SetValue("DeliveryPickup", value);
						 
			}
		}
	



		
			/// <summary>
		/// 送货费 (该属性可为空,但有默认值)
		/// 物流价目表行.Misc.送货费
		/// </summary>
		/// <value></value>
			public  System.Double DeliveryCharges
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("DeliveryCharges");
				return value;
				}
				set
			{
				
								base.SetValue("DeliveryCharges", value);
						 
			}
		}
	



		
			/// <summary>
		/// 免提标准 (该属性可为空,但有默认值)
		/// 物流价目表行.Misc.免提标准
		/// </summary>
		/// <value></value>
			public  System.Double FreePickup
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("FreePickup");
				return value;
				}
				set
			{
				
								base.SetValue("FreePickup", value);
						 
			}
		}
	



		
			/// <summary>
		/// 免送标准 (该属性可为空,但有默认值)
		/// 物流价目表行.Misc.免送标准
		/// </summary>
		/// <value></value>
			public  System.Double FreeDelivery
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("FreeDelivery");
				return value;
				}
				set
			{
				
								base.SetValue("FreeDelivery", value);
						 
			}
		}
	



		
			/// <summary>
		/// 运输时间 (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.运输时间
		/// </summary>
		/// <value></value>
			public  System.String TransportationTime
		{
			get
			{
				System.String value  = (System.String)base.GetValue("TransportationTime");
				return value;
				}
				set
			{
				
								base.SetValue("TransportationTime", value);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.备注
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
		/// 物流价目表 (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.物流价目表
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist LogisticsPricelist
		{
			get
			{
				object  obj = this.GetRelation("LogisticsPricelist");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist value  = (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("LogisticsPricelist", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityKey m_LogisticsPricelistKey ;
		/// <summary>
		/// 物流价目表 的Key (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.物流价目表
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityKey LogisticsPricelistKey
		{
			get 
			{
				object obj = base.GetValue("LogisticsPricelist") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_LogisticsPricelistKey==null || m_LogisticsPricelistKey.ID != key )
					m_LogisticsPricelistKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist.EntityKey(key); 
				return m_LogisticsPricelistKey ;
			}
			set
			{	
				if (LogisticsPricelistKey==value)
					return ;
				this.SetRelation("LogisticsPricelist", null);
				m_LogisticsPricelistKey = value ;
				if (value != null) 
				{
					base.SetValue("LogisticsPricelist",value.ID);
				}
				else
					base.SetValue("LogisticsPricelist",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 省/自治区 (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.省/自治区
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
		/// 省/自治区 的Key (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.省/自治区
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
		/// 城市 (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.城市
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
		/// 物流价目表行.Misc.城市
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
		/// 物流价目表行.Misc.区县
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
		/// 物流价目表行.Misc.区县
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
		/// 物流价目表行.Misc.详细地址
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
		/// 地址 (该属性可为空,且无默认值)
		/// 物流价目表行.Misc.地址
		/// </summary>
		/// <value></value>
			public  System.String FormatAddress
		{
			get
			{
				System.String value  = (System.String)base.GetValue("FormatAddress");
				return value;
				}
				set
			{
				
								base.SetValue("FormatAddress", value);
						 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("No")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_No　{ get { return EntityRes.GetResource("No");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PricingMethod")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PricingMethod　{ get { return EntityRes.GetResource("PricingMethod");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PricingUom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PricingUom　{ get { return EntityRes.GetResource("PricingUom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UintPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UintPrice　{ get { return EntityRes.GetResource("UintPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DynamicPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DynamicPrice　{ get { return EntityRes.GetResource("DynamicPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DeliveryPickup")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DeliveryPickup　{ get { return EntityRes.GetResource("DeliveryPickup");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DeliveryCharges")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DeliveryCharges　{ get { return EntityRes.GetResource("DeliveryCharges");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FreePickup")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FreePickup　{ get { return EntityRes.GetResource("FreePickup");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FreeDelivery")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FreeDelivery　{ get { return EntityRes.GetResource("FreeDelivery");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TransportationTime")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TransportationTime　{ get { return EntityRes.GetResource("TransportationTime");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Remark")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Remark　{ get { return EntityRes.GetResource("Remark");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("LogisticsPricelist")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_LogisticsPricelist　{ get { return EntityRes.GetResource("LogisticsPricelist");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescribeAddress")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescribeAddress　{ get { return EntityRes.GetResource("DescribeAddress");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FormatAddress")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FormatAddress　{ get { return EntityRes.GetResource("FormatAddress");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "LogisticsPricelistLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine";　}　}
		
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
			/// 属性: 序号 的名称
			/// </summary>
			public static string No　{ get { return "No";　}　}
				
			/// <summary>
			/// 属性: 提货工厂 的名称
			/// </summary>
			public static string DeliveryFactory　{ get { return "DeliveryFactory";　}　}
				
			/// <summary>
			/// 属性: 送货地址 的名称
			/// </summary>
			public static string Address　{ get { return "Address";　}　}
				
			/// <summary>
			/// 属性: 计价方式 的名称
			/// </summary>
			public static string PricingMethod　{ get { return "PricingMethod";　}　}
				
			/// <summary>
			/// 属性: 计价单位 的名称
			/// </summary>
			public static string PricingUom　{ get { return "PricingUom";　}　}
				
			/// <summary>
			/// 属性: 单价 的名称
			/// </summary>
			public static string UintPrice　{ get { return "UintPrice";　}　}
				
			/// <summary>
			/// 属性: 动态价格 的名称
			/// </summary>
			public static string DynamicPrice　{ get { return "DynamicPrice";　}　}
				
			/// <summary>
			/// 属性: 提货费 的名称
			/// </summary>
			public static string DeliveryPickup　{ get { return "DeliveryPickup";　}　}
				
			/// <summary>
			/// 属性: 送货费 的名称
			/// </summary>
			public static string DeliveryCharges　{ get { return "DeliveryCharges";　}　}
				
			/// <summary>
			/// 属性: 免提标准 的名称
			/// </summary>
			public static string FreePickup　{ get { return "FreePickup";　}　}
				
			/// <summary>
			/// 属性: 免送标准 的名称
			/// </summary>
			public static string FreeDelivery　{ get { return "FreeDelivery";　}　}
				
			/// <summary>
			/// 属性: 运输时间 的名称
			/// </summary>
			public static string TransportationTime　{ get { return "TransportationTime";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Remark　{ get { return "Remark";　}　}
				
			/// <summary>
			/// 属性: 物流价目表 的名称
			/// </summary>
			public static string LogisticsPricelist　{ get { return "LogisticsPricelist";　}　}
				
			/// <summary>
			/// 属性: 省/自治区 的名称
			/// </summary>
			public static string Province　{ get { return "Province";　}　}
				
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
			/// 属性: 地址 的名称
			/// </summary>
			public static string FormatAddress　{ get { return "FormatAddress";　}　}
		
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
			this.exdMultiLangAttrs.Add("No","No");
			this.exdMultiLangAttrs.Add("DeliveryFactory","DeliveryFactory");
			this.exdMultiLangAttrs.Add("Address","Address");
			this.exdMultiLangAttrs.Add("PricingMethod","PricingMethod");
			this.exdMultiLangAttrs.Add("PricingUom","PricingUom");
			this.exdMultiLangAttrs.Add("UintPrice","UintPrice");
			this.exdMultiLangAttrs.Add("DynamicPrice","DynamicPrice");
			this.exdMultiLangAttrs.Add("DeliveryPickup","DeliveryPickup");
			this.exdMultiLangAttrs.Add("DeliveryCharges","DeliveryCharges");
			this.exdMultiLangAttrs.Add("FreePickup","FreePickup");
			this.exdMultiLangAttrs.Add("FreeDelivery","FreeDelivery");
			this.exdMultiLangAttrs.Add("TransportationTime","TransportationTime");
			this.exdMultiLangAttrs.Add("Remark","Remark");
			this.exdMultiLangAttrs.Add("LogisticsPricelist","LogisticsPricelist");
			this.exdMultiLangAttrs.Add("Province","Province");
			this.exdMultiLangAttrs.Add("City","City");
			this.exdMultiLangAttrs.Add("County","County");
			this.exdMultiLangAttrs.Add("DescribeAddress","DescribeAddress");
			this.exdMultiLangAttrs.Add("FormatAddress","FormatAddress");
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
		private void DeSerializeKey(LogisticsPricelistLineData data)
		{
		
			

			

			

			

			

			

			

			

			if (data.Address == -1 && data.Address_SKey!=null)
				data.Address = data.Address_SKey.GetEntity().ID ;
	

			

			if (data.PricingUom == -1 && data.PricingUom_SKey!=null)
				data.PricingUom = data.PricingUom_SKey.GetEntity().ID ;
	

			

			if (data.DynamicPrice == -1 && data.DynamicPrice_SKey!=null)
				data.DynamicPrice = data.DynamicPrice_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

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
			LogisticsPricelistLineData data = dto as LogisticsPricelistLineData ;
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
		public void FromEntityData(LogisticsPricelistLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(LogisticsPricelistLineData data,IDictionary dict)
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
		
								this.SetTypeValue("No",data.No);
		
									this.SetTypeValue("DeliveryFactory",data.DeliveryFactory);
		
								this.SetTypeValue("Address",data.Address);
		
									this.SetTypeValue("PricingMethod",data.PricingMethod);
		
								this.SetTypeValue("PricingUom",data.PricingUom);
		
								this.SetTypeValue("UintPrice",data.UintPrice);
		
								this.SetTypeValue("DynamicPrice",data.DynamicPrice);
		
								this.SetTypeValue("DeliveryPickup",data.DeliveryPickup);
		
								this.SetTypeValue("DeliveryCharges",data.DeliveryCharges);
		
								this.SetTypeValue("FreePickup",data.FreePickup);
		
								this.SetTypeValue("FreeDelivery",data.FreeDelivery);
		
								this.SetTypeValue("TransportationTime",data.TransportationTime);
		
								this.SetTypeValue("Remark",data.Remark);
		
								this.SetTypeValue("Province",data.Province);
		
								this.SetTypeValue("City",data.City);
		
								this.SetTypeValue("County",data.County);
		
								this.SetTypeValue("DescribeAddress",data.DescribeAddress);
		
								this.SetTypeValue("FormatAddress",data.FormatAddress);
		
			#endregion 

			#region 组件内属性
	
					if (data.LogisticsPricelist!=null)
			{
				UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist child = dict[data.LogisticsPricelist] as UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist ;
				if (child == null)
				{
					if (data.LogisticsPricelist.ID>0)
					{
						if (data.LogisticsPricelist.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.LogisticsPricelist.ID,data.LogisticsPricelist.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.LogisticsPricelist.SysEntityType,null,data.LogisticsPricelist.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.LogisticsPricelist.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.LogisticsPricelist,dict);
				}
				this.LogisticsPricelist = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public LogisticsPricelistLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public LogisticsPricelistLineData ToEntityData(LogisticsPricelistLineData data, IDictionary dict){
			if (data == null)
				data = new LogisticsPricelistLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("No");
				if (obj != null)
					data.No=(System.Int32)obj;
			}
	     
	    
			{
				object obj = this.GetValue("DeliveryFactory") ;
				if (obj != null)
					data.DeliveryFactory=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Address");
				if (obj != null)
					data.Address=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("PricingMethod") ;
				if (obj != null)
					data.PricingMethod=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("PricingUom");
				if (obj != null)
					data.PricingUom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UintPrice");
				if (obj != null)
					data.UintPrice=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DynamicPrice");
				if (obj != null)
					data.DynamicPrice=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DeliveryPickup");
				if (obj != null)
					data.DeliveryPickup=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DeliveryCharges");
				if (obj != null)
					data.DeliveryCharges=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FreePickup");
				if (obj != null)
					data.FreePickup=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FreeDelivery");
				if (obj != null)
					data.FreeDelivery=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TransportationTime");
				if (obj != null)
					data.TransportationTime=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Remark");
				if (obj != null)
					data.Remark=(System.String)obj;
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
				object obj =this.GetValue("DescribeAddress");
				if (obj != null)
					data.DescribeAddress=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FormatAddress");
				if (obj != null)
					data.FormatAddress=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("LogisticsPricelist");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistData _LogisticsPricelist = dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist"+oID.ToString()] as UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelistData;			
					data.LogisticsPricelist = (_LogisticsPricelist != null) ? _LogisticsPricelist : (this.LogisticsPricelist==null?null:this.LogisticsPricelist.ToEntityData(null,dict));
				}
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