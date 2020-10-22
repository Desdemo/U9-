using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	
	/// <summary>
	/// 实体: 费用计算合计行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class CalculationFeeTotalLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public CalculationFeeTotalLine(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static CalculationFeeTotalLine Create() {
			CalculationFeeTotalLine entity = (CalculationFeeTotalLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																			 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected CalculationFeeTotalLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static CalculationFeeTotalLine CreateDefault() {
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
		public static CalculationFeeTotalLine CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class CalculationFeeTotalLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new CalculationFeeTotalLine GetEntity()
			{
				return (CalculationFeeTotalLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<CalculationFeeTotalLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<CalculationFeeTotalLine>{
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
		    //private CalculationFeeTotalLine ContainerEntity ;
		    public  new CalculationFeeTotalLine ContainerEntity 
		    {
				get { return  (CalculationFeeTotalLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(CalculationFeeTotalLine container)
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
			/// 费用计算合计行.Key.ID
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
			/// 费用计算合计行.Sys.创建时间
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
			/// 费用计算合计行.Sys.创建人
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
			/// 费用计算合计行.Sys.修改时间
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
			/// 费用计算合计行.Sys.修改人
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
			/// 费用计算合计行.Sys.事务版本
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
			/// 合计体积 (该属性可为空,但有默认值)
			/// 费用计算合计行.Misc.合计体积
			/// </summary>
			/// <value></value>
			public  System.Double TotalBulk
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("TotalBulk");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 合计重量 (该属性可为空,但有默认值)
			/// 费用计算合计行.Misc.合计重量
			/// </summary>
			/// <value></value>
			public  System.Double TotalWeight
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("TotalWeight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实际体积 (该属性可为空,但有默认值)
			/// 费用计算合计行.Misc.实际体积
			/// </summary>
			/// <value></value>
			public  System.Double RealBulk
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("RealBulk");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实际重量 (该属性可为空,但有默认值)
			/// 费用计算合计行.Misc.实际重量
			/// </summary>
			/// <value></value>
			public  System.Double RealWeight
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("RealWeight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提货费 (该属性可为空,但有默认值)
			/// 费用计算合计行.Misc.提货费
			/// </summary>
			/// <value></value>
			public  System.Double PickupFee
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("PickupFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 送货费 (该属性可为空,但有默认值)
			/// 费用计算合计行.Misc.送货费
			/// </summary>
			/// <value></value>
			public  System.Double DeliveryFee
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("DeliveryFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 卸货费 (该属性可为空,但有默认值)
			/// 费用计算合计行.Misc.卸货费
			/// </summary>
			/// <value></value>
			public  System.Double DischargeFee
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("DischargeFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 其他费用 (该属性可为空,但有默认值)
			/// 费用计算合计行.Misc.其他费用
			/// </summary>
			/// <value></value>
			public  System.Double OtherFee
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("OtherFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 合计费用 (该属性可为空,但有默认值)
			/// 费用计算合计行.Misc.合计费用
			/// </summary>
			/// <value></value>
			public  System.Double TotalFreight
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("TotalFreight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实际费用 (该属性可为空,但有默认值)
			/// 费用计算合计行.Misc.实际费用
			/// </summary>
			/// <value></value>
			public  System.Double RealFreight
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("RealFreight");
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
		/// 费用计算合计行.Key.ID
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
		/// 费用计算合计行.Sys.创建时间
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
		/// 费用计算合计行.Sys.创建人
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
		/// 费用计算合计行.Sys.修改时间
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
		/// 费用计算合计行.Sys.修改人
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
		/// 费用计算合计行.Sys.事务版本
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
		/// 合计体积 (该属性可为空,但有默认值)
		/// 费用计算合计行.Misc.合计体积
		/// </summary>
		/// <value></value>
			public  System.Double TotalBulk
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("TotalBulk");
				return value;
				}
				set
			{
				
								base.SetValue("TotalBulk", value);
						 
			}
		}
	



		
			/// <summary>
		/// 合计重量 (该属性可为空,但有默认值)
		/// 费用计算合计行.Misc.合计重量
		/// </summary>
		/// <value></value>
			public  System.Double TotalWeight
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("TotalWeight");
				return value;
				}
				set
			{
				
								base.SetValue("TotalWeight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 实际体积 (该属性可为空,但有默认值)
		/// 费用计算合计行.Misc.实际体积
		/// </summary>
		/// <value></value>
			public  System.Double RealBulk
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("RealBulk");
				return value;
				}
				set
			{
				
								base.SetValue("RealBulk", value);
						 
			}
		}
	



		
			/// <summary>
		/// 实际重量 (该属性可为空,但有默认值)
		/// 费用计算合计行.Misc.实际重量
		/// </summary>
		/// <value></value>
			public  System.Double RealWeight
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("RealWeight");
				return value;
				}
				set
			{
				
								base.SetValue("RealWeight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 提货费 (该属性可为空,但有默认值)
		/// 费用计算合计行.Misc.提货费
		/// </summary>
		/// <value></value>
			public  System.Double PickupFee
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("PickupFee");
				return value;
				}
				set
			{
				
								base.SetValue("PickupFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 送货费 (该属性可为空,但有默认值)
		/// 费用计算合计行.Misc.送货费
		/// </summary>
		/// <value></value>
			public  System.Double DeliveryFee
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("DeliveryFee");
				return value;
				}
				set
			{
				
								base.SetValue("DeliveryFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 卸货费 (该属性可为空,但有默认值)
		/// 费用计算合计行.Misc.卸货费
		/// </summary>
		/// <value></value>
			public  System.Double DischargeFee
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("DischargeFee");
				return value;
				}
				set
			{
				
								base.SetValue("DischargeFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 其他费用 (该属性可为空,但有默认值)
		/// 费用计算合计行.Misc.其他费用
		/// </summary>
		/// <value></value>
			public  System.Double OtherFee
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("OtherFee");
				return value;
				}
				set
			{
				
								base.SetValue("OtherFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 合计费用 (该属性可为空,但有默认值)
		/// 费用计算合计行.Misc.合计费用
		/// </summary>
		/// <value></value>
			public  System.Double TotalFreight
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("TotalFreight");
				return value;
				}
				set
			{
				
								base.SetValue("TotalFreight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 实际费用 (该属性可为空,但有默认值)
		/// 费用计算合计行.Misc.实际费用
		/// </summary>
		/// <value></value>
			public  System.Double RealFreight
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("RealFreight");
				return value;
				}
				set
			{
				
								base.SetValue("RealFreight", value);
						 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TotalBulk")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TotalBulk　{ get { return EntityRes.GetResource("TotalBulk");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TotalWeight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TotalWeight　{ get { return EntityRes.GetResource("TotalWeight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RealBulk")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RealBulk　{ get { return EntityRes.GetResource("RealBulk");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RealWeight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RealWeight　{ get { return EntityRes.GetResource("RealWeight");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TotalFreight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TotalFreight　{ get { return EntityRes.GetResource("TotalFreight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RealFreight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RealFreight　{ get { return EntityRes.GetResource("RealFreight");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "CalculationFeeTotalLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine";　}　}
		
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
			/// 属性: 合计体积 的名称
			/// </summary>
			public static string TotalBulk　{ get { return "TotalBulk";　}　}
				
			/// <summary>
			/// 属性: 合计重量 的名称
			/// </summary>
			public static string TotalWeight　{ get { return "TotalWeight";　}　}
				
			/// <summary>
			/// 属性: 实际体积 的名称
			/// </summary>
			public static string RealBulk　{ get { return "RealBulk";　}　}
				
			/// <summary>
			/// 属性: 实际重量 的名称
			/// </summary>
			public static string RealWeight　{ get { return "RealWeight";　}　}
				
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
			/// 属性: 合计费用 的名称
			/// </summary>
			public static string TotalFreight　{ get { return "TotalFreight";　}　}
				
			/// <summary>
			/// 属性: 实际费用 的名称
			/// </summary>
			public static string RealFreight　{ get { return "RealFreight";　}　}
		
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
			this.exdMultiLangAttrs.Add("TotalBulk","TotalBulk");
			this.exdMultiLangAttrs.Add("TotalWeight","TotalWeight");
			this.exdMultiLangAttrs.Add("RealBulk","RealBulk");
			this.exdMultiLangAttrs.Add("RealWeight","RealWeight");
			this.exdMultiLangAttrs.Add("PickupFee","PickupFee");
			this.exdMultiLangAttrs.Add("DeliveryFee","DeliveryFee");
			this.exdMultiLangAttrs.Add("DischargeFee","DischargeFee");
			this.exdMultiLangAttrs.Add("OtherFee","OtherFee");
			this.exdMultiLangAttrs.Add("TotalFreight","TotalFreight");
			this.exdMultiLangAttrs.Add("RealFreight","RealFreight");
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
		private void DeSerializeKey(CalculationFeeTotalLineData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			CalculationFeeTotalLineData data = dto as CalculationFeeTotalLineData ;
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
		public void FromEntityData(CalculationFeeTotalLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CalculationFeeTotalLineData data,IDictionary dict)
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
		
								this.SetTypeValue("TotalBulk",data.TotalBulk);
		
								this.SetTypeValue("TotalWeight",data.TotalWeight);
		
								this.SetTypeValue("RealBulk",data.RealBulk);
		
								this.SetTypeValue("RealWeight",data.RealWeight);
		
								this.SetTypeValue("PickupFee",data.PickupFee);
		
								this.SetTypeValue("DeliveryFee",data.DeliveryFee);
		
								this.SetTypeValue("DischargeFee",data.DischargeFee);
		
								this.SetTypeValue("OtherFee",data.OtherFee);
		
								this.SetTypeValue("TotalFreight",data.TotalFreight);
		
								this.SetTypeValue("RealFreight",data.RealFreight);
		
			#endregion 

			#region 组件内属性
	
			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CalculationFeeTotalLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CalculationFeeTotalLineData ToEntityData(CalculationFeeTotalLineData data, IDictionary dict){
			if (data == null)
				data = new CalculationFeeTotalLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("TotalBulk");
				if (obj != null)
					data.TotalBulk=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TotalWeight");
				if (obj != null)
					data.TotalWeight=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RealBulk");
				if (obj != null)
					data.RealBulk=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RealWeight");
				if (obj != null)
					data.RealWeight=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PickupFee");
				if (obj != null)
					data.PickupFee=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DeliveryFee");
				if (obj != null)
					data.DeliveryFee=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DischargeFee");
				if (obj != null)
					data.DischargeFee=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OtherFee");
				if (obj != null)
					data.OtherFee=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TotalFreight");
				if (obj != null)
					data.TotalFreight=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RealFreight");
				if (obj != null)
					data.RealFreight=(System.Double)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	

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