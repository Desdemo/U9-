



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用记录关联数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.FeeRecordLinkedDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class FeeRecordLinkedDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                                                                                            
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public FeeRecordLinkedDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion= 0; 
							SrcType= 0; 
							SrcDocID= 0; 
							Amount= 0; 
							DeliveryID= 0; 
							SrcDocNo="0";
					DeliveryNo="0";

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
		public FeeRecordLinkedDTOData(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.Int32 srcType  , System.Int64 srcDocID  , System.Double amount  , System.Int64 deliveryID  , System.String srcDocNo  , System.String deliveryNo  )
		{
			initData();
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.SrcType = srcType;
			this.SrcDocID = srcDocID;
			this.Amount = amount;
			this.DeliveryID = deliveryID;
			this.SrcDocNo = srcDocNo;
			this.DeliveryNo = deliveryNo;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// ID
		/// 费用记录关联数据传输对象.Key.ID
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
		/// 费用记录关联数据传输对象.Sys.创建时间
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
		/// 费用记录关联数据传输对象.Sys.创建人
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
		/// 费用记录关联数据传输对象.Sys.修改时间
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
		/// 费用记录关联数据传输对象.Sys.修改人
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
		/// 费用记录关联数据传输对象.Sys.事务版本
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
		/// 来源单据类型
		/// 费用记录关联数据传输对象.Misc.来源单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_srcType ;
		public System.Int32 SrcType
		{
			get	
			{	
				return m_srcType ;
			}
			set	
			{	
				m_srcType = value ;	
			}
		}
			
		

		/// <summary>
		/// 来源单据ID
		/// 费用记录关联数据传输对象.Misc.来源单据ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_srcDocID ;
		public System.Int64 SrcDocID
		{
			get	
			{	
				return m_srcDocID ;
			}
			set	
			{	
				m_srcDocID = value ;	
			}
		}
			
		

		/// <summary>
		/// 金额
		/// 费用记录关联数据传输对象.Misc.金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_amount ;
		public System.Double Amount
		{
			get	
			{	
				return m_amount ;
			}
			set	
			{	
				m_amount = value ;	
			}
		}
			
		

		/// <summary>
		/// 配送单ID
		/// 费用记录关联数据传输对象.Misc.配送单ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_deliveryID ;
		public System.Int64 DeliveryID
		{
			get	
			{	
				return m_deliveryID ;
			}
			set	
			{	
				m_deliveryID = value ;	
			}
		}
			
		

		/// <summary>
		/// 来源单据号
		/// 费用记录关联数据传输对象.Misc.来源单据号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_srcDocNo ;
		public System.String SrcDocNo
		{
			get	
			{	
				return m_srcDocNo ;
			}
			set	
			{	
				m_srcDocNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 配送单号
		/// 费用记录关联数据传输对象.Misc.配送单号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_deliveryNo ;
		public System.String DeliveryNo
		{
			get	
			{	
				return m_deliveryNo ;
			}
			set	
			{	
				m_deliveryNo = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																								
		#endregion 
	} 	
}

	
