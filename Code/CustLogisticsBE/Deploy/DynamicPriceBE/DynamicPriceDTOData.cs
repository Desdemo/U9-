



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 动态价格数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class DynamicPriceDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                                       
            knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));                          
            knownTypes.Add(typeof(List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData>));              
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public DynamicPriceDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion= 0; 
				
		
		
		
					DynamicPriceType= 0; 
		
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
	        	        	        	        	        	        	        	        	        	        			if (this.DynamicPriceLine!=null)
			{
				foreach(UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData objdata in this.DynamicPriceLine)
				{
					objdata.DoSerializeKeyList(dict);
				}
			}
				        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public DynamicPriceDTOData(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.String code  , UFIDA.U9.Base.UOM.UOMData uom  , System.String remark  , List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData> dynamicPriceLine  , System.Int32 dynamicPriceType  )
		{
			initData();
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.Code = code;
			this.Uom = uom;
			this.Remark = remark;
			this.DynamicPriceLine = dynamicPriceLine;
			this.DynamicPriceType = dynamicPriceType;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// ID
		/// 动态价格数据传输对象.Key.ID
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
		/// 动态价格数据传输对象.Sys.创建时间
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
		/// 动态价格数据传输对象.Sys.创建人
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
		/// 动态价格数据传输对象.Sys.修改时间
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
		/// 动态价格数据传输对象.Sys.修改人
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
		/// 动态价格数据传输对象.Sys.事务版本
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
		/// 编码
		/// 动态价格数据传输对象.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_code ;
		public System.String Code
		{
			get	
			{	
				return m_code ;
			}
			set	
			{	
				m_code = value ;	
			}
		}
			
		

		/// <summary>
		/// 单位
		/// 动态价格数据传输对象.Misc.单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.UOM.UOMData m_uom ;
		public UFIDA.U9.Base.UOM.UOMData Uom
		{
			get	
			{	
				return m_uom ;
			}
			set	
			{	
				m_uom = value ;	
			}
		}
			
		

		/// <summary>
		/// 备注
		/// 动态价格数据传输对象.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_remark ;
		public System.String Remark
		{
			get	
			{	
				return m_remark ;
			}
			set	
			{	
				m_remark = value ;	
			}
		}
			
		

		/// <summary>
		/// 动态价格行
		/// 动态价格数据传输对象.Misc.动态价格行
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData> m_dynamicPriceLine ;
		public List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData> DynamicPriceLine
		{
			get	
			{	
				if (m_dynamicPriceLine == null )
				{
					List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData> n_m_list = new List<UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceLineDTOData>() ;
					m_dynamicPriceLine = n_m_list ;
				}
				return m_dynamicPriceLine ;
			}
			set	
			{	
				m_dynamicPriceLine = value ;	
			}
		}
			
		

		/// <summary>
		/// 动态价格类型
		/// 动态价格数据传输对象.Misc.动态价格类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_dynamicPriceType ;
		public System.Int32 DynamicPriceType
		{
			get	
			{	
				return m_dynamicPriceType ;
			}
			set	
			{	
				m_dynamicPriceType = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																						
		#endregion 
	} 	
}

	
