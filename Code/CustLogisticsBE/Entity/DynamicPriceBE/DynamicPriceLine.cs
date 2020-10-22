using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	
	/// <summary>
	/// 实体: 动态价格行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class DynamicPriceLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public DynamicPriceLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static DynamicPriceLine Create(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice parentEntity) {
			DynamicPriceLine entity = (DynamicPriceLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.DynamicPrice = parentEntity ;
			parentEntity.DynamicPriceLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected DynamicPriceLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static DynamicPriceLine CreateDefault(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice parentEntity) {
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
            get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class DynamicPriceLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new DynamicPriceLine GetEntity()
			{
				return (DynamicPriceLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<DynamicPriceLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<DynamicPriceLine>{
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
		    //private DynamicPriceLine ContainerEntity ;
		    public  new DynamicPriceLine ContainerEntity 
		    {
				get { return  (DynamicPriceLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(DynamicPriceLine container)
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
			/// 动态价格行.Key.ID
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
			/// 动态价格行.Sys.创建时间
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
			/// 动态价格行.Sys.创建人
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
			/// 动态价格行.Sys.修改时间
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
			/// 动态价格行.Sys.修改人
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
			/// 动态价格行.Sys.事务版本
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
			/// 动态价格行.Misc.序号
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
			/// 单价 (该属性可为空,但有默认值)
			/// 动态价格行.Misc.单价
			/// </summary>
			/// <value></value>
			public  System.Double UnitPrice
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("UnitPrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开始 (该属性可为空,但有默认值)
			/// 动态价格行.Misc.开始
			/// </summary>
			/// <value></value>
			public  System.Double Start
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("Start");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 结束 (该属性可为空,但有默认值)
			/// 动态价格行.Misc.结束
			/// </summary>
			/// <value></value>
			public  System.Double Cutoff
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("Cutoff");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 区间合计 (该属性可为空,但有默认值)
			/// 动态价格行.Misc.区间合计
			/// </summary>
			/// <value></value>
			public  System.Double Total
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("Total");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 动态价格行.Misc.备注
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
			/// 动态价格 (该属性可为空,且无默认值)
			/// 动态价格行.Misc.动态价格
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
		/// 动态价格行.Misc.动态价格
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
		/// 动态价格行.Key.ID
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
		/// 动态价格行.Sys.创建时间
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
		/// 动态价格行.Sys.创建人
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
		/// 动态价格行.Sys.修改时间
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
		/// 动态价格行.Sys.修改人
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
		/// 动态价格行.Sys.事务版本
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
		/// 动态价格行.Misc.序号
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
		/// 单价 (该属性可为空,但有默认值)
		/// 动态价格行.Misc.单价
		/// </summary>
		/// <value></value>
			public  System.Double UnitPrice
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("UnitPrice");
				return value;
				}
				set
			{
				
								base.SetValue("UnitPrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 开始 (该属性可为空,但有默认值)
		/// 动态价格行.Misc.开始
		/// </summary>
		/// <value></value>
			public  System.Double Start
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("Start");
				return value;
				}
				set
			{
				
								base.SetValue("Start", value);
						 
			}
		}
	



		
			/// <summary>
		/// 结束 (该属性可为空,但有默认值)
		/// 动态价格行.Misc.结束
		/// </summary>
		/// <value></value>
			public  System.Double Cutoff
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("Cutoff");
				return value;
				}
				set
			{
				
								base.SetValue("Cutoff", value);
						 
			}
		}
	



		
			/// <summary>
		/// 区间合计 (该属性可为空,但有默认值)
		/// 动态价格行.Misc.区间合计
		/// </summary>
		/// <value></value>
			public  System.Double Total
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("Total");
				return value;
				}
				set
			{
				
								base.SetValue("Total", value);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 动态价格行.Misc.备注
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
		/// 动态价格 (该属性可为空,且无默认值)
		/// 动态价格行.Misc.动态价格
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
				internal set
			{
				
				this.SetRelation("DynamicPrice", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice.EntityKey m_DynamicPriceKey ;
		/// <summary>
		/// 动态价格 的Key (该属性可为空,且无默认值)
		/// 动态价格行.Misc.动态价格
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UnitPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UnitPrice　{ get { return EntityRes.GetResource("UnitPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Start")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Start　{ get { return EntityRes.GetResource("Start");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Cutoff")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Cutoff　{ get { return EntityRes.GetResource("Cutoff");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Total")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Total　{ get { return EntityRes.GetResource("Total");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Remark")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Remark　{ get { return EntityRes.GetResource("Remark");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DynamicPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DynamicPrice　{ get { return EntityRes.GetResource("DynamicPrice");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "DynamicPriceLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine";　}　}
		
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
			/// 属性: 单价 的名称
			/// </summary>
			public static string UnitPrice　{ get { return "UnitPrice";　}　}
				
			/// <summary>
			/// 属性: 开始 的名称
			/// </summary>
			public static string Start　{ get { return "Start";　}　}
				
			/// <summary>
			/// 属性: 结束 的名称
			/// </summary>
			public static string Cutoff　{ get { return "Cutoff";　}　}
				
			/// <summary>
			/// 属性: 区间合计 的名称
			/// </summary>
			public static string Total　{ get { return "Total";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Remark　{ get { return "Remark";　}　}
				
			/// <summary>
			/// 属性: 动态价格 的名称
			/// </summary>
			public static string DynamicPrice　{ get { return "DynamicPrice";　}　}
		
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
			this.exdMultiLangAttrs.Add("UnitPrice","UnitPrice");
			this.exdMultiLangAttrs.Add("Start","Start");
			this.exdMultiLangAttrs.Add("Cutoff","Cutoff");
			this.exdMultiLangAttrs.Add("Total","Total");
			this.exdMultiLangAttrs.Add("Remark","Remark");
			this.exdMultiLangAttrs.Add("DynamicPrice","DynamicPrice");
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
		private void DeSerializeKey(DynamicPriceLineData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			DynamicPriceLineData data = dto as DynamicPriceLineData ;
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
		public void FromEntityData(DynamicPriceLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(DynamicPriceLineData data,IDictionary dict)
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
		
								this.SetTypeValue("UnitPrice",data.UnitPrice);
		
								this.SetTypeValue("Start",data.Start);
		
								this.SetTypeValue("Cutoff",data.Cutoff);
		
								this.SetTypeValue("Total",data.Total);
		
								this.SetTypeValue("Remark",data.Remark);
		
			#endregion 

			#region 组件内属性
	
					if (data.DynamicPrice!=null)
			{
				UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice child = dict[data.DynamicPrice] as UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice ;
				if (child == null)
				{
					if (data.DynamicPrice.ID>0)
					{
						if (data.DynamicPrice.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.DynamicPrice.ID,data.DynamicPrice.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.DynamicPrice.SysEntityType,null,data.DynamicPrice.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.DynamicPrice.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.DynamicPrice,dict);
				}
				this.DynamicPrice = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public DynamicPriceLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public DynamicPriceLineData ToEntityData(DynamicPriceLineData data, IDictionary dict){
			if (data == null)
				data = new DynamicPriceLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("UnitPrice");
				if (obj != null)
					data.UnitPrice=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Start");
				if (obj != null)
					data.Start=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Cutoff");
				if (obj != null)
					data.Cutoff=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Total");
				if (obj != null)
					data.Total=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Remark");
				if (obj != null)
					data.Remark=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("DynamicPrice");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceData _DynamicPrice = dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice"+oID.ToString()] as UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceData;			
					data.DynamicPrice = (_DynamicPrice != null) ? _DynamicPrice : (this.DynamicPrice==null?null:this.DynamicPrice.ToEntityData(null,dict));
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