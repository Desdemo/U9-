



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
	/// <summary>
	/// 费用分摊DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBP.CostsharingDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CostsharingDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public CostsharingDTOData()
		{
			initData();
		}
		private void initData()
		{
					DocID= 0; 
							DocType= 0; 
				
					Amount= 0; 
		
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
		public CostsharingDTOData(  System.Int64 docID  , System.Int32 docType  , System.String docNo  , System.Double amount  )
		{
			initData();
			this.DocID = docID;
			this.DocType = docType;
			this.DocNo = docNo;
			this.Amount = amount;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 单据ID
		/// 费用分摊DTO.Misc.单据ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_docID ;
		public System.Int64 DocID
		{
			get	
			{	
				return m_docID ;
			}
			set	
			{	
				m_docID = value ;	
			}
		}
			
		

		/// <summary>
		/// 单据类型
		/// 费用分摊DTO.Misc.单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_docType ;
		public System.Int32 DocType
		{
			get	
			{	
				return m_docType ;
			}
			set	
			{	
				m_docType = value ;	
			}
		}
			
		

		/// <summary>
		/// 单号
		/// 费用分摊DTO.Misc.单号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_docNo ;
		public System.String DocNo
		{
			get	
			{	
				return m_docNo ;
			}
			set	
			{	
				m_docNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 金额
		/// 费用分摊DTO.Misc.金额
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
			
		#endregion	

		#region Multi_Fields
								
		#endregion 
	} 	
}

	
