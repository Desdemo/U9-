using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	
	/// <summary>
	/// 实体: 费用计算行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class CalculationFeeLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public CalculationFeeLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static CalculationFeeLine Create(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee parentEntity) {
			CalculationFeeLine entity = (CalculationFeeLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.CalculationFee = parentEntity ;
			parentEntity.CalculationFeeLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected CalculationFeeLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static CalculationFeeLine CreateDefault(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee parentEntity) {
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
            get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class CalculationFeeLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new CalculationFeeLine GetEntity()
			{
				return (CalculationFeeLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<CalculationFeeLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<CalculationFeeLine>{
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
		    //private CalculationFeeLine ContainerEntity ;
		    public  new CalculationFeeLine ContainerEntity 
		    {
				get { return  (CalculationFeeLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(CalculationFeeLine container)
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
			/// 费用计算行.Key.ID
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
			/// 费用计算行.Sys.创建时间
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
			/// 费用计算行.Sys.创建人
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
			/// 费用计算行.Sys.修改时间
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
			/// 费用计算行.Sys.修改人
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
			/// 费用计算行.Sys.事务版本
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
			/// 单号 (该属性可为空,且无默认值)
			/// 费用计算行.Misc.单号
			/// </summary>
			/// <value></value>
			public  System.String DocNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("DocNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单号ID (该属性可为空,但有默认值)
			/// 费用计算行.Misc.单号ID
			/// </summary>
			/// <value></value>
			public  System.Int64 DocID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("DocID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行ID (该属性可为空,但有默认值)
			/// 费用计算行.Misc.行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 LineID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("LineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 料品 (该属性可为空,且无默认值)
			/// 费用计算行.Misc.料品
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Item
			{
				get
				{
					if (ItemKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)ItemKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemKey ;
		/// <summary>
		/// EntityKey 属性
		/// 料品 的Key (该属性可为空,且无默认值)
		/// 费用计算行.Misc.料品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemKey
		{
			get 
			{
				object obj = base.GetValue("Item") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemKey==null || m_ItemKey.ID != key )
					m_ItemKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 销售数量 (该属性可为空,但有默认值)
			/// 费用计算行.Misc.销售数量
			/// </summary>
			/// <value></value>
			public  System.Double Qty
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("Qty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 销售单位 (该属性可为空,且无默认值)
			/// 费用计算行.Misc.销售单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM SalesUom
			{
				get
				{
					if (SalesUomKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)SalesUomKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_SalesUomKey ;
		/// <summary>
		/// EntityKey 属性
		/// 销售单位 的Key (该属性可为空,且无默认值)
		/// 费用计算行.Misc.销售单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey SalesUomKey
		{
			get 
			{
				object obj = base.GetValue("SalesUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SalesUomKey==null || m_SalesUomKey.ID != key )
					m_SalesUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_SalesUomKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实际提货工厂 (该属性可为空,但有默认值)
			/// 费用计算行.Misc.实际提货工厂
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum RealDeliveryFactory
			{
				get
				{

					UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum.GetFromValue(base.GetValue("RealDeliveryFactory"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实际计价方式 (该属性可为空,但有默认值)
			/// 费用计算行.Misc.实际计价方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum RealPricingMethod
			{
				get
				{

					UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.GetFromValue(base.GetValue("RealPricingMethod"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 体积 (该属性可为空,但有默认值)
			/// 费用计算行.Misc.体积
			/// </summary>
			/// <value></value>
			public  System.Double IBulk
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("IBulk");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 体积单位 (该属性可为空,且无默认值)
			/// 费用计算行.Misc.体积单位
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
		/// 费用计算行.Misc.体积单位
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
			/// 重量 (该属性可为空,但有默认值)
			/// 费用计算行.Misc.重量
			/// </summary>
			/// <value></value>
			public  System.Double Weight
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("Weight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 重量单位 (该属性可为空,且无默认值)
			/// 费用计算行.Misc.重量单位
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
		/// 费用计算行.Misc.重量单位
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
			/// 计价数量 (该属性可为空,但有默认值)
			/// 费用计算行.Misc.计价数量
			/// </summary>
			/// <value></value>
			public  System.Double PricingQty
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("PricingQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 计价单位 (该属性可为空,且无默认值)
			/// 费用计算行.Misc.计价单位
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
		/// 费用计算行.Misc.计价单位
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
			/// 单据类型 (该属性可为空,但有默认值)
			/// 费用计算行.Misc.单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum DocType
			{
				get
				{

					UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.GetFromValue(base.GetValue("DocType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 费用计算 (该属性可为空,且无默认值)
			/// 费用计算行.Misc.费用计算
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee CalculationFee
			{
				get
				{
					if (CalculationFeeKey == null)
						return null ;
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee value =  (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee)CalculationFeeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.EntityKey m_CalculationFeeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 费用计算 的Key (该属性可为空,且无默认值)
		/// 费用计算行.Misc.费用计算
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.EntityKey CalculationFeeKey
		{
			get 
			{
				object obj = base.GetValue("CalculationFee") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CalculationFeeKey==null || m_CalculationFeeKey.ID != key )
					m_CalculationFeeKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.EntityKey(key); 
				return m_CalculationFeeKey ;
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
		/// 费用计算行.Key.ID
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
		/// 费用计算行.Sys.创建时间
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
		/// 费用计算行.Sys.创建人
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
		/// 费用计算行.Sys.修改时间
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
		/// 费用计算行.Sys.修改人
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
		/// 费用计算行.Sys.事务版本
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
		/// 单号 (该属性可为空,且无默认值)
		/// 费用计算行.Misc.单号
		/// </summary>
		/// <value></value>
			public  System.String DocNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("DocNo");
				return value;
				}
				set
			{
				
								base.SetValue("DocNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 单号ID (该属性可为空,但有默认值)
		/// 费用计算行.Misc.单号ID
		/// </summary>
		/// <value></value>
			public  System.Int64 DocID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("DocID");
				return value;
				}
				set
			{
				
								base.SetValue("DocID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 行ID (该属性可为空,但有默认值)
		/// 费用计算行.Misc.行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 LineID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("LineID");
				return value;
				}
				set
			{
				
								base.SetValue("LineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 料品 (该属性可为空,且无默认值)
		/// 费用计算行.Misc.料品
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Item
		{
			get
			{
				object  obj = this.GetRelation("Item");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Item.ItemMaster value  = (UFIDA.U9.CBO.SCM.Item.ItemMaster)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Item", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemKey ;
		/// <summary>
		/// 料品 的Key (该属性可为空,且无默认值)
		/// 费用计算行.Misc.料品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemKey
		{
			get 
			{
				object obj = base.GetValue("Item") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemKey==null || m_ItemKey.ID != key )
					m_ItemKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemKey ;
			}
			set
			{	
				if (ItemKey==value)
					return ;
				this.SetRelation("Item", null);
				m_ItemKey = value ;
				if (value != null) 
				{
					base.SetValue("Item",value.ID);
				}
				else
					base.SetValue("Item",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 销售数量 (该属性可为空,但有默认值)
		/// 费用计算行.Misc.销售数量
		/// </summary>
		/// <value></value>
			public  System.Double Qty
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("Qty");
				return value;
				}
				set
			{
				
								base.SetValue("Qty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 销售单位 (该属性可为空,且无默认值)
		/// 费用计算行.Misc.销售单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM SalesUom
		{
			get
			{
				object  obj = this.GetRelation("SalesUom");
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
				
				this.SetRelation("SalesUom", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_SalesUomKey ;
		/// <summary>
		/// 销售单位 的Key (该属性可为空,且无默认值)
		/// 费用计算行.Misc.销售单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey SalesUomKey
		{
			get 
			{
				object obj = base.GetValue("SalesUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SalesUomKey==null || m_SalesUomKey.ID != key )
					m_SalesUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_SalesUomKey ;
			}
			set
			{	
				if (SalesUomKey==value)
					return ;
				this.SetRelation("SalesUom", null);
				m_SalesUomKey = value ;
				if (value != null) 
				{
					base.SetValue("SalesUom",value.ID);
				}
				else
					base.SetValue("SalesUom",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 实际提货工厂 (该属性可为空,但有默认值)
		/// 费用计算行.Misc.实际提货工厂
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum RealDeliveryFactory
		{
			get
			{

				UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum.GetFromValue(base.GetValue("RealDeliveryFactory"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("RealDeliveryFactory",UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum.Empty.Value);
				else
					base.SetValue("RealDeliveryFactory",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 实际计价方式 (该属性可为空,但有默认值)
		/// 费用计算行.Misc.实际计价方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum RealPricingMethod
		{
			get
			{

				UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.GetFromValue(base.GetValue("RealPricingMethod"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("RealPricingMethod",UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum.Empty.Value);
				else
					base.SetValue("RealPricingMethod",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 体积 (该属性可为空,但有默认值)
		/// 费用计算行.Misc.体积
		/// </summary>
		/// <value></value>
			public  System.Double IBulk
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("IBulk");
				return value;
				}
				set
			{
				
								base.SetValue("IBulk", value);
						 
			}
		}
	



		
			/// <summary>
		/// 体积单位 (该属性可为空,且无默认值)
		/// 费用计算行.Misc.体积单位
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
		/// 费用计算行.Misc.体积单位
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
		/// 重量 (该属性可为空,但有默认值)
		/// 费用计算行.Misc.重量
		/// </summary>
		/// <value></value>
			public  System.Double Weight
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("Weight");
				return value;
				}
				set
			{
				
								base.SetValue("Weight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 重量单位 (该属性可为空,且无默认值)
		/// 费用计算行.Misc.重量单位
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
		/// 费用计算行.Misc.重量单位
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
		/// 计价数量 (该属性可为空,但有默认值)
		/// 费用计算行.Misc.计价数量
		/// </summary>
		/// <value></value>
			public  System.Double PricingQty
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("PricingQty");
				return value;
				}
				set
			{
				
								base.SetValue("PricingQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 计价单位 (该属性可为空,且无默认值)
		/// 费用计算行.Misc.计价单位
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
		/// 费用计算行.Misc.计价单位
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
		/// 单据类型 (该属性可为空,但有默认值)
		/// 费用计算行.Misc.单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum DocType
		{
			get
			{

				UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.GetFromValue(base.GetValue("DocType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("DocType",UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.Empty.Value);
				else
					base.SetValue("DocType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 费用计算 (该属性可为空,且无默认值)
		/// 费用计算行.Misc.费用计算
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee CalculationFee
		{
			get
			{
				object  obj = this.GetRelation("CalculationFee");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee value  = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("CalculationFee", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.EntityKey m_CalculationFeeKey ;
		/// <summary>
		/// 费用计算 的Key (该属性可为空,且无默认值)
		/// 费用计算行.Misc.费用计算
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.EntityKey CalculationFeeKey
		{
			get 
			{
				object obj = base.GetValue("CalculationFee") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CalculationFeeKey==null || m_CalculationFeeKey.ID != key )
					m_CalculationFeeKey = new UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee.EntityKey(key); 
				return m_CalculationFeeKey ;
			}
			set
			{	
				if (CalculationFeeKey==value)
					return ;
				this.SetRelation("CalculationFee", null);
				m_CalculationFeeKey = value ;
				if (value != null) 
				{
					base.SetValue("CalculationFee",value.ID);
				}
				else
					base.SetValue("CalculationFee",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocNo　{ get { return EntityRes.GetResource("DocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocID　{ get { return EntityRes.GetResource("DocID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("LineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_LineID　{ get { return EntityRes.GetResource("LineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Item")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Item　{ get { return EntityRes.GetResource("Item");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Qty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Qty　{ get { return EntityRes.GetResource("Qty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SalesUom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SalesUom　{ get { return EntityRes.GetResource("SalesUom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RealDeliveryFactory")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RealDeliveryFactory　{ get { return EntityRes.GetResource("RealDeliveryFactory");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RealPricingMethod")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RealPricingMethod　{ get { return EntityRes.GetResource("RealPricingMethod");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IBulk")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IBulk　{ get { return EntityRes.GetResource("IBulk");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BulkUom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BulkUom　{ get { return EntityRes.GetResource("BulkUom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Weight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Weight　{ get { return EntityRes.GetResource("Weight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("WeightUom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_WeightUom　{ get { return EntityRes.GetResource("WeightUom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PricingQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PricingQty　{ get { return EntityRes.GetResource("PricingQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PricingUom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PricingUom　{ get { return EntityRes.GetResource("PricingUom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocType　{ get { return EntityRes.GetResource("DocType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CalculationFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CalculationFee　{ get { return EntityRes.GetResource("CalculationFee");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "CalculationFeeLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine";　}　}
		
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
			/// 属性: 单号 的名称
			/// </summary>
			public static string DocNo　{ get { return "DocNo";　}　}
				
			/// <summary>
			/// 属性: 单号ID 的名称
			/// </summary>
			public static string DocID　{ get { return "DocID";　}　}
				
			/// <summary>
			/// 属性: 行ID 的名称
			/// </summary>
			public static string LineID　{ get { return "LineID";　}　}
				
			/// <summary>
			/// 属性: 料品 的名称
			/// </summary>
			public static string Item　{ get { return "Item";　}　}
				
			/// <summary>
			/// 属性: 销售数量 的名称
			/// </summary>
			public static string Qty　{ get { return "Qty";　}　}
				
			/// <summary>
			/// 属性: 销售单位 的名称
			/// </summary>
			public static string SalesUom　{ get { return "SalesUom";　}　}
				
			/// <summary>
			/// 属性: 实际提货工厂 的名称
			/// </summary>
			public static string RealDeliveryFactory　{ get { return "RealDeliveryFactory";　}　}
				
			/// <summary>
			/// 属性: 实际计价方式 的名称
			/// </summary>
			public static string RealPricingMethod　{ get { return "RealPricingMethod";　}　}
				
			/// <summary>
			/// 属性: 体积 的名称
			/// </summary>
			public static string IBulk　{ get { return "IBulk";　}　}
				
			/// <summary>
			/// 属性: 体积单位 的名称
			/// </summary>
			public static string BulkUom　{ get { return "BulkUom";　}　}
				
			/// <summary>
			/// 属性: 重量 的名称
			/// </summary>
			public static string Weight　{ get { return "Weight";　}　}
				
			/// <summary>
			/// 属性: 重量单位 的名称
			/// </summary>
			public static string WeightUom　{ get { return "WeightUom";　}　}
				
			/// <summary>
			/// 属性: 计价数量 的名称
			/// </summary>
			public static string PricingQty　{ get { return "PricingQty";　}　}
				
			/// <summary>
			/// 属性: 计价单位 的名称
			/// </summary>
			public static string PricingUom　{ get { return "PricingUom";　}　}
				
			/// <summary>
			/// 属性: 单据类型 的名称
			/// </summary>
			public static string DocType　{ get { return "DocType";　}　}
				
			/// <summary>
			/// 属性: 费用计算 的名称
			/// </summary>
			public static string CalculationFee　{ get { return "CalculationFee";　}　}
		
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
			this.exdMultiLangAttrs.Add("DocNo","DocNo");
			this.exdMultiLangAttrs.Add("DocID","DocID");
			this.exdMultiLangAttrs.Add("LineID","LineID");
			this.exdMultiLangAttrs.Add("Item","Item");
			this.exdMultiLangAttrs.Add("Qty","Qty");
			this.exdMultiLangAttrs.Add("SalesUom","SalesUom");
			this.exdMultiLangAttrs.Add("RealDeliveryFactory","RealDeliveryFactory");
			this.exdMultiLangAttrs.Add("RealPricingMethod","RealPricingMethod");
			this.exdMultiLangAttrs.Add("IBulk","IBulk");
			this.exdMultiLangAttrs.Add("BulkUom","BulkUom");
			this.exdMultiLangAttrs.Add("Weight","Weight");
			this.exdMultiLangAttrs.Add("WeightUom","WeightUom");
			this.exdMultiLangAttrs.Add("PricingQty","PricingQty");
			this.exdMultiLangAttrs.Add("PricingUom","PricingUom");
			this.exdMultiLangAttrs.Add("DocType","DocType");
			this.exdMultiLangAttrs.Add("CalculationFee","CalculationFee");
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
		private void DeSerializeKey(CalculationFeeLineData data)
		{
		
			

			

			

			

			

			

			

			

			

			if (data.Item == -1 && data.Item_SKey!=null)
				data.Item = data.Item_SKey.GetEntity().ID ;
	

			

			if (data.SalesUom == -1 && data.SalesUom_SKey!=null)
				data.SalesUom = data.SalesUom_SKey.GetEntity().ID ;
	

			

			if (data.BulkUom == -1 && data.BulkUom_SKey!=null)
				data.BulkUom = data.BulkUom_SKey.GetEntity().ID ;
	

			

			if (data.WeightUom == -1 && data.WeightUom_SKey!=null)
				data.WeightUom = data.WeightUom_SKey.GetEntity().ID ;
	

			

			if (data.PricingUom == -1 && data.PricingUom_SKey!=null)
				data.PricingUom = data.PricingUom_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			CalculationFeeLineData data = dto as CalculationFeeLineData ;
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
		public void FromEntityData(CalculationFeeLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CalculationFeeLineData data,IDictionary dict)
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
		
								this.SetTypeValue("DocNo",data.DocNo);
		
								this.SetTypeValue("DocID",data.DocID);
		
								this.SetTypeValue("LineID",data.LineID);
		
								this.SetTypeValue("Item",data.Item);
		
								this.SetTypeValue("Qty",data.Qty);
		
								this.SetTypeValue("SalesUom",data.SalesUom);
		
								this.SetTypeValue("IBulk",data.IBulk);
		
								this.SetTypeValue("BulkUom",data.BulkUom);
		
								this.SetTypeValue("Weight",data.Weight);
		
								this.SetTypeValue("WeightUom",data.WeightUom);
		
								this.SetTypeValue("PricingQty",data.PricingQty);
		
								this.SetTypeValue("PricingUom",data.PricingUom);
		
			#endregion 

			#region 组件内属性
	
					this.SetTypeValue("RealDeliveryFactory",data.RealDeliveryFactory);
	     

					this.SetTypeValue("RealPricingMethod",data.RealPricingMethod);
	     

					this.SetTypeValue("DocType",data.DocType);
	     

					if (data.CalculationFee!=null)
			{
				UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee child = dict[data.CalculationFee] as UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee ;
				if (child == null)
				{
					if (data.CalculationFee.ID>0)
					{
						if (data.CalculationFee.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.CalculationFee.ID,data.CalculationFee.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.CalculationFee.SysEntityType,null,data.CalculationFee.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.CalculationFee.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.CalculationFee,dict);
				}
				this.CalculationFee = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CalculationFeeLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CalculationFeeLineData ToEntityData(CalculationFeeLineData data, IDictionary dict){
			if (data == null)
				data = new CalculationFeeLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("DocNo");
				if (obj != null)
					data.DocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DocID");
				if (obj != null)
					data.DocID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("LineID");
				if (obj != null)
					data.LineID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Item");
				if (obj != null)
					data.Item=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Qty");
				if (obj != null)
					data.Qty=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SalesUom");
				if (obj != null)
					data.SalesUom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IBulk");
				if (obj != null)
					data.IBulk=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BulkUom");
				if (obj != null)
					data.BulkUom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Weight");
				if (obj != null)
					data.Weight=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("WeightUom");
				if (obj != null)
					data.WeightUom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PricingQty");
				if (obj != null)
					data.PricingQty=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PricingUom");
				if (obj != null)
					data.PricingUom=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object obj =this.GetValue("RealDeliveryFactory");
				if (obj != null)
					data.RealDeliveryFactory=System.Int32.Parse(obj.ToString());
			}
	
			{
				object obj =this.GetValue("RealPricingMethod");
				if (obj != null)
					data.RealPricingMethod=System.Int32.Parse(obj.ToString());
			}
	
			{
				object obj =this.GetValue("DocType");
				if (obj != null)
					data.DocType=System.Int32.Parse(obj.ToString());
			}
	
			{
				object oID = this.GetValue("CalculationFee");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData _CalculationFee = dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFee"+oID.ToString()] as UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData;			
					data.CalculationFee = (_CalculationFee != null) ? _CalculationFee : (this.CalculationFee==null?null:this.CalculationFee.ToEntityData(null,dict));
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