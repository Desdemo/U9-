using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	
	/// <summary>
	/// 实体: 动态价格
	/// 
	/// </summary>
	[Serializable]	
	public  partial class DynamicPrice : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public DynamicPrice(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static DynamicPrice Create() {
			DynamicPrice entity = (DynamicPrice)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																							 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected DynamicPrice(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static DynamicPrice CreateDefault() {
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
		public static DynamicPrice CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class DynamicPrice EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new DynamicPrice GetEntity()
			{
				return (DynamicPrice)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<DynamicPrice> 
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
				private System.String m_Code ;
				public  System.String Code
				{
					get { return m_Code ;}
					set { m_Code = value ;}
				}
				private UFIDA.U9.Base.UOM.UOM.EntityKey m_Uom ;
				public  UFIDA.U9.Base.UOM.UOM.EntityKey Uom
				{
					get { return m_Uom ;}
					set { m_Uom = value ;}
				}
				private UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum m_DynamicPriceType ;
				public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum DynamicPriceType
				{
					get { return m_DynamicPriceType ;}
					set { m_DynamicPriceType = value ;}
				}
				private UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum m_EffectField ;
				public  UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum EffectField
				{
					get { return m_EffectField ;}
					set { m_EffectField = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public DynamicPrice FindByBusinessKey(  System.String code  , UFIDA.U9.Base.UOM.UOM.EntityKey uom  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum dynamicPriceType  , UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum effectField  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Code = code ;
				
				parameter.Uom = uom ;
				
				parameter.DynamicPriceType = dynamicPriceType ;
				
				parameter.EffectField = effectField ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public DynamicPrice FindByBusinessKey(  System.String code  , UFIDA.U9.Base.UOM.UOM uom  , UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum dynamicPriceType  , UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum effectField  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
								parameter.Code = code ;				
				parameter.Uom = uom==null?null:uom.Key ;
								parameter.DynamicPriceType = dynamicPriceType ;								parameter.EffectField = effectField ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public DynamicPrice FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*4);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				
				if (System.String.IsNullOrEmpty(parameter.Code))
				{
					sbuilder.Append("Code is null ");
				}
				else
				{
					sbuilder.Append("Code = @Code");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("Code",parameter.Code));
				}								
				
				if (parameter.Uom==null)
				{
					sbuilder.Append(" and Uom is null ");
				}
				else
				{
					sbuilder.Append(" and Uom = @Uom");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("Uom",parameter.Uom.ID));
				}								
				

				sbuilder.Append(" and DynamicPriceType = @DynamicPriceType");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DynamicPriceType",parameter.DynamicPriceType.Value));												
				

				sbuilder.Append(" and EffectField = @EffectField");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("EffectField",parameter.EffectField.Value));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_BLT_CustLogisticsBE_DynamicPrice_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private System.String m_Code ;
				public  System.String Code
				{
					get { return m_Code ;}
					set { m_Code = value ;}
				}				private UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum m_DynamicPriceType ;
				public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum DynamicPriceType
				{
					get { return m_DynamicPriceType ;}
					set { m_DynamicPriceType = value ;}
				}				private UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum m_EffectField ;
				public  UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum EffectField
				{
					get { return m_EffectField ;}
					set { m_EffectField = value ;}
				}				private UFIDA.U9.Base.UOM.UOM.EntityKey m_Uom ;
				public  UFIDA.U9.Base.UOM.UOM.EntityKey Uom
				{
					get { return m_Uom ;}
					set { m_Uom = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_BLT_CustLogisticsBE_DynamicPrice_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public DynamicPrice FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*4);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				if (System.String.IsNullOrEmpty(parameter.Code))
				{
					sbuilder.Append("  Code is null ");
				}
				else
				{
					sbuilder.Append("Code = @Code");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("Code",parameter.Code));
				}				
				sbuilder.Append(" and DynamicPriceType = @DynamicPriceType");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DynamicPriceType",parameter.DynamicPriceType.Value));				
				sbuilder.Append(" and EffectField = @EffectField");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("EffectField",parameter.EffectField.Value));				
				if (parameter.Uom==null)
				{
					sbuilder.Append("  and  Uom is null ");
				}
				else
				{
					sbuilder.Append(" and Uom = @Uom");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("Uom",parameter.Uom.ID));
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<DynamicPrice>{
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
		    //private DynamicPrice ContainerEntity ;
		    public  new DynamicPrice ContainerEntity 
		    {
				get { return  (DynamicPrice)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(DynamicPrice container)
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
			/// 动态价格.Key.ID
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
			/// 动态价格.Sys.创建时间
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
			/// 动态价格.Sys.创建人
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
			/// 动态价格.Sys.修改时间
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
			/// 动态价格.Sys.修改人
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
			/// 动态价格.Sys.事务版本
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
			/// 编码 (该属性可为空,且无默认值)
			/// 动态价格.Misc.编码
			/// </summary>
			/// <value></value>
			public  System.String Code
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Code");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单位 (该属性可为空,且无默认值)
			/// 动态价格.Misc.单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM Uom
			{
				get
				{
					if (UomKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)UomKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_UomKey ;
		/// <summary>
		/// EntityKey 属性
		/// 单位 的Key (该属性可为空,且无默认值)
		/// 动态价格.Misc.单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey UomKey
		{
			get 
			{
				object obj = base.GetValue("Uom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_UomKey==null || m_UomKey.ID != key )
					m_UomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_UomKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 动态价格.Misc.备注
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
			/// 动态价格类型 (该属性可为空,但有默认值)
			/// 动态价格.Misc.动态价格类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum DynamicPriceType
			{
				get
				{

					UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum.GetFromValue(base.GetValue("DynamicPriceType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 作用字段 (该属性可为空,但有默认值)
			/// 动态价格.Misc.作用字段
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum EffectField
			{
				get
				{

					UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum.GetFromValue(base.GetValue("EffectField"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 名称 (该属性可为空,且无默认值)
			/// 动态价格.Misc.名称
			/// </summary>
			/// <value></value>
			public  System.String Name
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Name");
					return value;
						}
			}
		



		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine> m_DynamicPriceLine  ;
			/// <summary>
			/// 动态价格行 (该属性可为空,且无默认值)
			/// 动态价格.Misc.动态价格行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine> DynamicPriceLine
			{
				get
				{
					if (m_DynamicPriceLine == null)
						m_DynamicPriceLine = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine>();
					m_DynamicPriceLine.Clear();	
					foreach (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine child in ContainerEntity.DynamicPriceLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_DynamicPriceLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine child in ContainerEntity.DynamicPriceLine.DelLists)
					{
						m_DynamicPriceLine.Add(child);
					}
					return m_DynamicPriceLine;
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
		/// 动态价格.Key.ID
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
		/// 动态价格.Sys.创建时间
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
		/// 动态价格.Sys.创建人
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
		/// 动态价格.Sys.修改时间
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
		/// 动态价格.Sys.修改人
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
		/// 动态价格.Sys.事务版本
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
		/// 编码 (该属性可为空,且无默认值)
		/// 动态价格.Misc.编码
		/// </summary>
		/// <value></value>
			public  System.String Code
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Code");
				return value;
				}
				set
			{
				
								base.SetValue("Code", value);
						 
			}
		}
	



		
			/// <summary>
		/// 单位 (该属性可为空,且无默认值)
		/// 动态价格.Misc.单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM Uom
		{
			get
			{
				object  obj = this.GetRelation("Uom");
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
				
				this.SetRelation("Uom", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_UomKey ;
		/// <summary>
		/// 单位 的Key (该属性可为空,且无默认值)
		/// 动态价格.Misc.单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey UomKey
		{
			get 
			{
				object obj = base.GetValue("Uom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_UomKey==null || m_UomKey.ID != key )
					m_UomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_UomKey ;
			}
			set
			{	
				if (UomKey==value)
					return ;
				this.SetRelation("Uom", null);
				m_UomKey = value ;
				if (value != null) 
				{
					base.SetValue("Uom",value.ID);
				}
				else
					base.SetValue("Uom",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 动态价格.Misc.备注
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
		/// 动态价格类型 (该属性可为空,但有默认值)
		/// 动态价格.Misc.动态价格类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum DynamicPriceType
		{
			get
			{

				UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum.GetFromValue(base.GetValue("DynamicPriceType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("DynamicPriceType",UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum.Empty.Value);
				else
					base.SetValue("DynamicPriceType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 作用字段 (该属性可为空,但有默认值)
		/// 动态价格.Misc.作用字段
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum EffectField
		{
			get
			{

				UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum.GetFromValue(base.GetValue("EffectField"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("EffectField",UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum.Empty.Value);
				else
					base.SetValue("EffectField",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 名称 (该属性可为空,且无默认值)
		/// 动态价格.Misc.名称
		/// </summary>
		/// <value></value>
			public  System.String Name
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Name");
				return value;
				}
				set
			{
				
								base.SetValue("Name", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine.EntityList m_DynamicPriceLine  ;
		/// <summary>
		/// 动态价格行 (该属性可为空,且无默认值)
		/// 动态价格.Misc.动态价格行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine.EntityList DynamicPriceLine
		{
			get
			{
				if (m_DynamicPriceLine == null)
					m_DynamicPriceLine = new UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine.EntityList("DynamicPrice",this,"DynamicPriceLine",(IList)this.GetRelation("DynamicPriceLine"));
				else
					m_DynamicPriceLine.InnerList = (IList)this.GetRelation("DynamicPriceLine");
				return m_DynamicPriceLine;
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Code")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Code　{ get { return EntityRes.GetResource("Code");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Uom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Uom　{ get { return EntityRes.GetResource("Uom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Remark")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Remark　{ get { return EntityRes.GetResource("Remark");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DynamicPriceLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DynamicPriceLine　{ get { return EntityRes.GetResource("DynamicPriceLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DynamicPriceType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DynamicPriceType　{ get { return EntityRes.GetResource("DynamicPriceType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("EffectField")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_EffectField　{ get { return EntityRes.GetResource("EffectField");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Name")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Name　{ get { return EntityRes.GetResource("Name");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "DynamicPrice";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice";　}　}
		
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
			/// 属性: 编码 的名称
			/// </summary>
			public static string Code　{ get { return "Code";　}　}
				
			/// <summary>
			/// 属性: 单位 的名称
			/// </summary>
			public static string Uom　{ get { return "Uom";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Remark　{ get { return "Remark";　}　}
				
			/// <summary>
			/// 属性: 动态价格行 的名称
			/// </summary>
			public static string DynamicPriceLine　{ get { return "DynamicPriceLine";　}　}
				
			/// <summary>
			/// 属性: 动态价格类型 的名称
			/// </summary>
			public static string DynamicPriceType　{ get { return "DynamicPriceType";　}　}
				
			/// <summary>
			/// 属性: 作用字段 的名称
			/// </summary>
			public static string EffectField　{ get { return "EffectField";　}　}
				
			/// <summary>
			/// 属性: 名称 的名称
			/// </summary>
			public static string Name　{ get { return "Name";　}　}
		
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
			this.exdMultiLangAttrs.Add("Code","Code");
			this.exdMultiLangAttrs.Add("Uom","Uom");
			this.exdMultiLangAttrs.Add("Remark","Remark");
			this.exdMultiLangAttrs.Add("DynamicPriceType","DynamicPriceType");
			this.exdMultiLangAttrs.Add("EffectField","EffectField");
			this.exdMultiLangAttrs.Add("Name","Name");
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
		private void DeSerializeKey(DynamicPriceData data)
		{
		
			

			

			

			

			

			

			

			if (data.Uom == -1 && data.Uom_SKey!=null)
				data.Uom = data.Uom_SKey.GetEntity().ID ;
	

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			DynamicPriceData data = dto as DynamicPriceData ;
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
		public void FromEntityData(DynamicPriceData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(DynamicPriceData data,IDictionary dict)
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
		
								this.SetTypeValue("Code",data.Code);
		
								this.SetTypeValue("Uom",data.Uom);
		
								this.SetTypeValue("Remark",data.Remark);
		
								this.SetTypeValue("Name",data.Name);
		
			#endregion 

			#region 组件内属性
	
					if (data.DynamicPriceLine != null)
			{	
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineData obj in data.DynamicPriceLine )
				{
					UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine child = dict[obj] as UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.DynamicPriceLine.Remove(child);
						this.DynamicPriceLine.DelLists.Add(child);
					}
					else
						this.DynamicPriceLine.Add(child);
				}
			}
	     

					this.SetTypeValue("DynamicPriceType",data.DynamicPriceType);
	     

					this.SetTypeValue("EffectField",data.EffectField);
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public DynamicPriceData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public DynamicPriceData ToEntityData(DynamicPriceData data, IDictionary dict){
			if (data == null)
				data = new DynamicPriceData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPrice"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("Code");
				if (obj != null)
					data.Code=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Uom");
				if (obj != null)
					data.Uom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Remark");
				if (obj != null)
					data.Remark=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Name");
				if (obj != null)
					data.Name=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.DynamicPriceLine != null)
			{	
				List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineData> listDynamicPriceLine = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine obj in this.DynamicPriceLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineData old = dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLine"+obj.ID.ToString()] as UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineData;
					listDynamicPriceLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.DynamicPriceLine = listDynamicPriceLine;
			}	
			{
				object obj =this.GetValue("DynamicPriceType");
				if (obj != null)
					data.DynamicPriceType=System.Int32.Parse(obj.ToString());
			}
	
			{
				object obj =this.GetValue("EffectField");
				if (obj != null)
					data.EffectField=System.Int32.Parse(obj.ToString());
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