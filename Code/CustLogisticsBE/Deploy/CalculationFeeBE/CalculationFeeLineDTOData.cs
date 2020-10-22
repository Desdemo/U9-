



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用计算行数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CalculationFeeLineDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                                                                 
            knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Item.ItemMasterData));                          
            knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));                                                    
            knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));                          
            knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));                          
            knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));                          
            knownTypes.Add(typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTOData)); 
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public CalculationFeeLineDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion= 0; 
				
					DocID= 0; 
							LineID= 0; 
				
					Qty= 0; 
				
					RealDeliveryFactory= -1; 
							RealPricingMethod= 0; 
							IBulk= 0; 
				
					Weight= 0; 
				
					PricingQty= 0; 
				
					DocType= 0; 
				

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
	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        			if (this.CalculationFee != null) 
			{
				this.CalculationFee.DoSerializeKeyList(dict);
			}

		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public CalculationFeeLineDTOData(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.String docNo  , System.Int64 docID  , System.Int64 lineID  , UFIDA.U9.CBO.SCM.Item.ItemMasterData item  , System.Double qty  , UFIDA.U9.Base.UOM.UOMData salesUom  , System.Int32 realDeliveryFactory  , System.Int32 realPricingMethod  , System.Double iBulk  , UFIDA.U9.Base.UOM.UOMData bulkUom  , System.Double weight  , UFIDA.U9.Base.UOM.UOMData weightUom  , System.Double pricingQty  , UFIDA.U9.Base.UOM.UOMData pricingUom  , System.Int32 docType  , UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTOData calculationFee  )
		{
			initData();
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.DocNo = docNo;
			this.DocID = docID;
			this.LineID = lineID;
			this.Item = item;
			this.Qty = qty;
			this.SalesUom = salesUom;
			this.RealDeliveryFactory = realDeliveryFactory;
			this.RealPricingMethod = realPricingMethod;
			this.IBulk = iBulk;
			this.BulkUom = bulkUom;
			this.Weight = weight;
			this.WeightUom = weightUom;
			this.PricingQty = pricingQty;
			this.PricingUom = pricingUom;
			this.DocType = docType;
			this.CalculationFee = calculationFee;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// ID
		/// 费用计算行数据传输对象.Key.ID
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
		/// 费用计算行数据传输对象.Sys.创建时间
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
		/// 费用计算行数据传输对象.Sys.创建人
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
		/// 费用计算行数据传输对象.Sys.修改时间
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
		/// 费用计算行数据传输对象.Sys.修改人
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
		/// 费用计算行数据传输对象.Sys.事务版本
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
		/// 单号
		/// 费用计算行数据传输对象.Misc.单号
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
		/// 单号ID
		/// 费用计算行数据传输对象.Misc.单号ID
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
		/// 行ID
		/// 费用计算行数据传输对象.Misc.行ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_lineID ;
		public System.Int64 LineID
		{
			get	
			{	
				return m_lineID ;
			}
			set	
			{	
				m_lineID = value ;	
			}
		}
			
		

		/// <summary>
		/// 料品
		/// 费用计算行数据传输对象.Misc.料品
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.CBO.SCM.Item.ItemMasterData m_item ;
		public UFIDA.U9.CBO.SCM.Item.ItemMasterData Item
		{
			get	
			{	
				return m_item ;
			}
			set	
			{	
				m_item = value ;	
			}
		}
			
		

		/// <summary>
		/// 销售数量
		/// 费用计算行数据传输对象.Misc.销售数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_qty ;
		public System.Double Qty
		{
			get	
			{	
				return m_qty ;
			}
			set	
			{	
				m_qty = value ;	
			}
		}
			
		

		/// <summary>
		/// 销售单位
		/// 费用计算行数据传输对象.Misc.销售单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.UOM.UOMData m_salesUom ;
		public UFIDA.U9.Base.UOM.UOMData SalesUom
		{
			get	
			{	
				return m_salesUom ;
			}
			set	
			{	
				m_salesUom = value ;	
			}
		}
			
		

		/// <summary>
		/// 实际提货工厂
		/// 费用计算行数据传输对象.Misc.实际提货工厂
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_realDeliveryFactory ;
		public System.Int32 RealDeliveryFactory
		{
			get	
			{	
				return m_realDeliveryFactory ;
			}
			set	
			{	
				m_realDeliveryFactory = value ;	
			}
		}
			
		

		/// <summary>
		/// 实际计价方式
		/// 费用计算行数据传输对象.Misc.实际计价方式
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_realPricingMethod ;
		public System.Int32 RealPricingMethod
		{
			get	
			{	
				return m_realPricingMethod ;
			}
			set	
			{	
				m_realPricingMethod = value ;	
			}
		}
			
		

		/// <summary>
		/// 体积
		/// 费用计算行数据传输对象.Misc.体积
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_iBulk ;
		public System.Double IBulk
		{
			get	
			{	
				return m_iBulk ;
			}
			set	
			{	
				m_iBulk = value ;	
			}
		}
			
		

		/// <summary>
		/// 体积单位
		/// 费用计算行数据传输对象.Misc.体积单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.UOM.UOMData m_bulkUom ;
		public UFIDA.U9.Base.UOM.UOMData BulkUom
		{
			get	
			{	
				return m_bulkUom ;
			}
			set	
			{	
				m_bulkUom = value ;	
			}
		}
			
		

		/// <summary>
		/// 重量
		/// 费用计算行数据传输对象.Misc.重量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_weight ;
		public System.Double Weight
		{
			get	
			{	
				return m_weight ;
			}
			set	
			{	
				m_weight = value ;	
			}
		}
			
		

		/// <summary>
		/// 重量单位
		/// 费用计算行数据传输对象.Misc.重量单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.UOM.UOMData m_weightUom ;
		public UFIDA.U9.Base.UOM.UOMData WeightUom
		{
			get	
			{	
				return m_weightUom ;
			}
			set	
			{	
				m_weightUom = value ;	
			}
		}
			
		

		/// <summary>
		/// 计价数量
		/// 费用计算行数据传输对象.Misc.计价数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_pricingQty ;
		public System.Double PricingQty
		{
			get	
			{	
				return m_pricingQty ;
			}
			set	
			{	
				m_pricingQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 计价单位
		/// 费用计算行数据传输对象.Misc.计价单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.UOM.UOMData m_pricingUom ;
		public UFIDA.U9.Base.UOM.UOMData PricingUom
		{
			get	
			{	
				return m_pricingUom ;
			}
			set	
			{	
				m_pricingUom = value ;	
			}
		}
			
		

		/// <summary>
		/// 单据类型
		/// 费用计算行数据传输对象.Misc.单据类型
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
		/// 费用计算
		/// 费用计算行数据传输对象.Misc.费用计算
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTOData m_calculationFee ;
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeDTOData CalculationFee
		{
			get	
			{	
				return m_calculationFee ;
			}
			set	
			{	
				m_calculationFee = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																																												
		#endregion 
	} 	
}

	
