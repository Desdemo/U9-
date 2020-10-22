using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	
	/// <summary>
	/// 实体: 费用记录关联
	/// 
	/// </summary>
	[Serializable]	
	public  partial class FeeRecordLinked : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public FeeRecordLinked(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static FeeRecordLinked Create() {
			FeeRecordLinked entity = (FeeRecordLinked)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																							 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected FeeRecordLinked(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static FeeRecordLinked CreateDefault() {
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
		public static FeeRecordLinked CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class FeeRecordLinked EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new FeeRecordLinked GetEntity()
			{
				return (FeeRecordLinked)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<FeeRecordLinked> 
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
				private System.Int64 m_SrcDocID ;
				public  System.Int64 SrcDocID
				{
					get { return m_SrcDocID ;}
					set { m_SrcDocID = value ;}
				}
				private System.Int64 m_DeliveryID ;
				public  System.Int64 DeliveryID
				{
					get { return m_DeliveryID ;}
					set { m_DeliveryID = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public FeeRecordLinked FindByBusinessKey(  System.Int64 srcDocID  , System.Int64 deliveryID  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.SrcDocID = srcDocID ;
				
				parameter.DeliveryID = deliveryID ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public FeeRecordLinked FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("SrcDocID = @SrcDocID");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("SrcDocID",parameter.SrcDocID));												
				

				sbuilder.Append(" and DeliveryID = @DeliveryID");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DeliveryID",parameter.DeliveryID));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_BLT_CustLogisticsBE_FeeRecordLinked_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private System.Int64 m_SrcDocID ;
				public  System.Int64 SrcDocID
				{
					get { return m_SrcDocID ;}
					set { m_SrcDocID = value ;}
				}				private System.Int64 m_DeliveryID ;
				public  System.Int64 DeliveryID
				{
					get { return m_DeliveryID ;}
					set { m_DeliveryID = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_BLT_CustLogisticsBE_FeeRecordLinked_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public FeeRecordLinked FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("SrcDocID = @SrcDocID");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("SrcDocID",parameter.SrcDocID));				
				sbuilder.Append(" and DeliveryID = @DeliveryID");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DeliveryID",parameter.DeliveryID));				
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<FeeRecordLinked>{
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
		    //private FeeRecordLinked ContainerEntity ;
		    public  new FeeRecordLinked ContainerEntity 
		    {
				get { return  (FeeRecordLinked)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(FeeRecordLinked container)
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
			/// 费用记录关联.Key.ID
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
			/// 费用记录关联.Sys.创建时间
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
			/// 费用记录关联.Sys.创建人
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
			/// 费用记录关联.Sys.修改时间
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
			/// 费用记录关联.Sys.修改人
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
			/// 费用记录关联.Sys.事务版本
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
			/// 来源单据类型 (该属性可为空,但有默认值)
			/// 费用记录关联.Misc.来源单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum SrcType
			{
				get
				{

					UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.GetFromValue(base.GetValue("SrcType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据ID (该属性可为空,但有默认值)
			/// 费用记录关联.Misc.来源单据ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SrcDocID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SrcDocID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 金额 (该属性可为空,但有默认值)
			/// 费用记录关联.Misc.金额
			/// </summary>
			/// <value></value>
			public  System.Double Amount
			{
				get
				{
					System.Double value  = (System.Double)base.GetValue("Amount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 配送单ID (该属性可为空,但有默认值)
			/// 费用记录关联.Misc.配送单ID
			/// </summary>
			/// <value></value>
			public  System.Int64 DeliveryID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("DeliveryID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据号 (该属性可为空,但有默认值)
			/// 费用记录关联.Misc.来源单据号
			/// </summary>
			/// <value></value>
			public  System.String SrcDocNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SrcDocNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 配送单号 (该属性可为空,但有默认值)
			/// 费用记录关联.Misc.配送单号
			/// </summary>
			/// <value></value>
			public  System.String DeliveryNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("DeliveryNo");
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
		/// 费用记录关联.Key.ID
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
		/// 费用记录关联.Sys.创建时间
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
		/// 费用记录关联.Sys.创建人
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
		/// 费用记录关联.Sys.修改时间
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
		/// 费用记录关联.Sys.修改人
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
		/// 费用记录关联.Sys.事务版本
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
		/// 来源单据类型 (该属性可为空,但有默认值)
		/// 费用记录关联.Misc.来源单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum SrcType
		{
			get
			{

				UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum value  = UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.GetFromValue(base.GetValue("SrcType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("SrcType",UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum.Empty.Value);
				else
					base.SetValue("SrcType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 来源单据ID (该属性可为空,但有默认值)
		/// 费用记录关联.Misc.来源单据ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SrcDocID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SrcDocID");
				return value;
				}
				set
			{
				
								base.SetValue("SrcDocID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 金额 (该属性可为空,但有默认值)
		/// 费用记录关联.Misc.金额
		/// </summary>
		/// <value></value>
			public  System.Double Amount
		{
			get
			{
				System.Double value  = (System.Double)base.GetValue("Amount");
				return value;
				}
				set
			{
				
								base.SetValue("Amount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 配送单ID (该属性可为空,但有默认值)
		/// 费用记录关联.Misc.配送单ID
		/// </summary>
		/// <value></value>
			public  System.Int64 DeliveryID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("DeliveryID");
				return value;
				}
				set
			{
				
								base.SetValue("DeliveryID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单据号 (该属性可为空,但有默认值)
		/// 费用记录关联.Misc.来源单据号
		/// </summary>
		/// <value></value>
			public  System.String SrcDocNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SrcDocNo");
				return value;
				}
				set
			{
				
								base.SetValue("SrcDocNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 配送单号 (该属性可为空,但有默认值)
		/// 费用记录关联.Misc.配送单号
		/// </summary>
		/// <value></value>
			public  System.String DeliveryNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("DeliveryNo");
				return value;
				}
				set
			{
				
								base.SetValue("DeliveryNo", value);
						 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcType　{ get { return EntityRes.GetResource("SrcType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocID　{ get { return EntityRes.GetResource("SrcDocID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Amount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Amount　{ get { return EntityRes.GetResource("Amount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DeliveryID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DeliveryID　{ get { return EntityRes.GetResource("DeliveryID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocNo　{ get { return EntityRes.GetResource("SrcDocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DeliveryNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DeliveryNo　{ get { return EntityRes.GetResource("DeliveryNo");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "FeeRecordLinked";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked";　}　}
		
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
			/// 属性: 来源单据类型 的名称
			/// </summary>
			public static string SrcType　{ get { return "SrcType";　}　}
				
			/// <summary>
			/// 属性: 来源单据ID 的名称
			/// </summary>
			public static string SrcDocID　{ get { return "SrcDocID";　}　}
				
			/// <summary>
			/// 属性: 金额 的名称
			/// </summary>
			public static string Amount　{ get { return "Amount";　}　}
				
			/// <summary>
			/// 属性: 配送单ID 的名称
			/// </summary>
			public static string DeliveryID　{ get { return "DeliveryID";　}　}
				
			/// <summary>
			/// 属性: 来源单据号 的名称
			/// </summary>
			public static string SrcDocNo　{ get { return "SrcDocNo";　}　}
				
			/// <summary>
			/// 属性: 配送单号 的名称
			/// </summary>
			public static string DeliveryNo　{ get { return "DeliveryNo";　}　}
		
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
			this.exdMultiLangAttrs.Add("SrcType","SrcType");
			this.exdMultiLangAttrs.Add("SrcDocID","SrcDocID");
			this.exdMultiLangAttrs.Add("Amount","Amount");
			this.exdMultiLangAttrs.Add("DeliveryID","DeliveryID");
			this.exdMultiLangAttrs.Add("SrcDocNo","SrcDocNo");
			this.exdMultiLangAttrs.Add("DeliveryNo","DeliveryNo");
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
		private void DeSerializeKey(FeeRecordLinkedData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			FeeRecordLinkedData data = dto as FeeRecordLinkedData ;
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
		public void FromEntityData(FeeRecordLinkedData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(FeeRecordLinkedData data,IDictionary dict)
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
		
									this.SetTypeValue("SrcType",data.SrcType);
		
								this.SetTypeValue("SrcDocID",data.SrcDocID);
		
								this.SetTypeValue("Amount",data.Amount);
		
								this.SetTypeValue("DeliveryID",data.DeliveryID);
		
								this.SetTypeValue("SrcDocNo",data.SrcDocNo);
		
								this.SetTypeValue("DeliveryNo",data.DeliveryNo);
		
			#endregion 

			#region 组件内属性
	
			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public FeeRecordLinkedData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public FeeRecordLinkedData ToEntityData(FeeRecordLinkedData data, IDictionary dict){
			if (data == null)
				data = new FeeRecordLinkedData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinked"+this.ID.ToString()] = data;
		
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
				object obj = this.GetValue("SrcType") ;
				if (obj != null)
					data.SrcType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("SrcDocID");
				if (obj != null)
					data.SrcDocID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Amount");
				if (obj != null)
					data.Amount=(System.Double)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DeliveryID");
				if (obj != null)
					data.DeliveryID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcDocNo");
				if (obj != null)
					data.SrcDocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DeliveryNo");
				if (obj != null)
					data.DeliveryNo=(System.String)obj;
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