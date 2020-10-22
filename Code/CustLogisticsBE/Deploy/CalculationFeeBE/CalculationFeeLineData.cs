
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用计算行 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLineData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class CalculationFeeLineData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Item.ItemMasterData));
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.UOM.UOMData));
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public CalculationFeeLineData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     							DocID= 0; 			     							LineID= 0; 			     			
	     							Qty= 0; 			     			
	     							RealDeliveryFactory= -1; 			     							RealPricingMethod= 0; 			     							IBulk= 0; 			     			
	     							Weight= 0; 			     			
	     							PricingQty= 0; 			     			
	     							DocType= 0; 			     			


			//设置组合的集合属性为List<>对象. -目前直接在属性上处理.
			
			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}		
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
        
		#region System Fields
		///<summary>
		/// 实体类型. 
		/// </summary>
		[DataMember(IsRequired=false)]
		public override string SysEntityType
		{
			get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeLine" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 实际提货工厂
		/// 费用计算行.Misc.实际提货工厂
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_realDeliveryFactory;
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
		/// 费用计算行.Misc.实际计价方式
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_realPricingMethod;
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
		/// 单据类型
		/// 费用计算行.Misc.单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_docType;
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

			        			
			private UFSoft.UBF.Business.BusinessEntity.EntityKey m_calculationFee_SKey ;
			/// <summary>
			/// 费用计算 序列化Key属性。（传递跨组织序列列字段）
			/// 费用计算行.Misc.费用计算
			/// </summary>
			[DataMember(IsRequired=false)]
			public UFSoft.UBF.Business.BusinessEntity.EntityKey CalculationFee_SKey
			{
				get 
				{
					return m_calculationFee_SKey ;					
				}
				set
				{
					m_calculationFee_SKey = value ;	
				}
			}
		/// <summary>
		/// 费用计算
		/// 费用计算行.Misc.费用计算
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData m_calculationFee;
		public UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeData CalculationFee
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

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 费用计算行.Key.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD  ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
		

				/// <summary>
		/// 创建时间
		/// 费用计算行.Sys.创建时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_createdOn ;
		public System.DateTime CreatedOn
		{
			get	
			{	
				return m_createdOn  ;
			}
			set	
			{	
				m_createdOn = value ;	
			}
		}
		

				/// <summary>
		/// 创建人
		/// 费用计算行.Sys.创建人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_createdBy ;
		public System.String CreatedBy
		{
			get	
			{	
				return m_createdBy  ;
			}
			set	
			{	
				m_createdBy = value ;	
			}
		}
		

				/// <summary>
		/// 修改时间
		/// 费用计算行.Sys.修改时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_modifiedOn ;
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return m_modifiedOn  ;
			}
			set	
			{	
				m_modifiedOn = value ;	
			}
		}
		

				/// <summary>
		/// 修改人
		/// 费用计算行.Sys.修改人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_modifiedBy ;
		public System.String ModifiedBy
		{
			get	
			{	
				return m_modifiedBy  ;
			}
			set	
			{	
				m_modifiedBy = value ;	
			}
		}
		

				/// <summary>
		/// 事务版本
		/// 费用计算行.Sys.事务版本
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sysVersion ;
		public System.Int64 SysVersion
		{
			get	
			{	
				return m_sysVersion  ;
			}
			set	
			{	
				m_sysVersion = value ;	
			}
		}
		

				/// <summary>
		/// 单号
		/// 费用计算行.Misc.单号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_docNo ;
		public System.String DocNo
		{
			get	
			{	
				return m_docNo  ;
			}
			set	
			{	
				m_docNo = value ;	
			}
		}
		

				/// <summary>
		/// 单号ID
		/// 费用计算行.Misc.单号ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_docID ;
		public System.Int64 DocID
		{
			get	
			{	
				return m_docID  ;
			}
			set	
			{	
				m_docID = value ;	
			}
		}
		

				/// <summary>
		/// 行ID
		/// 费用计算行.Misc.行ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_lineID ;
		public System.Int64 LineID
		{
			get	
			{	
				return m_lineID  ;
			}
			set	
			{	
				m_lineID = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_item_SKey ;
		/// <summary>
		/// 料品 序列化Key属性。（传递跨组织序列列字段）
		/// 费用计算行.Misc.料品
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Item_SKey
		{
			get 
			{
				return m_item_SKey ;					
			}
			set
			{
				 m_item_SKey = value ;	
			}
		}
		/// <summary>
		/// 料品
		/// 费用计算行.Misc.料品
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Item
		{
			get	
			{	
				if (Item_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Item_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Item_SKey = null ;
				else
				{
					if (Item_SKey == null )
						Item_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Item.ItemMaster") ;
					else
						Item_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 销售数量
		/// 费用计算行.Misc.销售数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_qty ;
		public System.Double Qty
		{
			get	
			{	
				return m_qty  ;
			}
			set	
			{	
				m_qty = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_salesUom_SKey ;
		/// <summary>
		/// 销售单位 序列化Key属性。（传递跨组织序列列字段）
		/// 费用计算行.Misc.销售单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey SalesUom_SKey
		{
			get 
			{
				return m_salesUom_SKey ;					
			}
			set
			{
				 m_salesUom_SKey = value ;	
			}
		}
		/// <summary>
		/// 销售单位
		/// 费用计算行.Misc.销售单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 SalesUom
		{
			get	
			{	
				if (SalesUom_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return SalesUom_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					SalesUom_SKey = null ;
				else
				{
					if (SalesUom_SKey == null )
						SalesUom_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.UOM.UOM") ;
					else
						SalesUom_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 体积
		/// 费用计算行.Misc.体积
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_iBulk ;
		public System.Double IBulk
		{
			get	
			{	
				return m_iBulk  ;
			}
			set	
			{	
				m_iBulk = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_bulkUom_SKey ;
		/// <summary>
		/// 体积单位 序列化Key属性。（传递跨组织序列列字段）
		/// 费用计算行.Misc.体积单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey BulkUom_SKey
		{
			get 
			{
				return m_bulkUom_SKey ;					
			}
			set
			{
				 m_bulkUom_SKey = value ;	
			}
		}
		/// <summary>
		/// 体积单位
		/// 费用计算行.Misc.体积单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 BulkUom
		{
			get	
			{	
				if (BulkUom_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return BulkUom_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					BulkUom_SKey = null ;
				else
				{
					if (BulkUom_SKey == null )
						BulkUom_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.UOM.UOM") ;
					else
						BulkUom_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 重量
		/// 费用计算行.Misc.重量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_weight ;
		public System.Double Weight
		{
			get	
			{	
				return m_weight  ;
			}
			set	
			{	
				m_weight = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_weightUom_SKey ;
		/// <summary>
		/// 重量单位 序列化Key属性。（传递跨组织序列列字段）
		/// 费用计算行.Misc.重量单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey WeightUom_SKey
		{
			get 
			{
				return m_weightUom_SKey ;					
			}
			set
			{
				 m_weightUom_SKey = value ;	
			}
		}
		/// <summary>
		/// 重量单位
		/// 费用计算行.Misc.重量单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 WeightUom
		{
			get	
			{	
				if (WeightUom_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return WeightUom_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					WeightUom_SKey = null ;
				else
				{
					if (WeightUom_SKey == null )
						WeightUom_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.UOM.UOM") ;
					else
						WeightUom_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 计价数量
		/// 费用计算行.Misc.计价数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_pricingQty ;
		public System.Double PricingQty
		{
			get	
			{	
				return m_pricingQty  ;
			}
			set	
			{	
				m_pricingQty = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_pricingUom_SKey ;
		/// <summary>
		/// 计价单位 序列化Key属性。（传递跨组织序列列字段）
		/// 费用计算行.Misc.计价单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey PricingUom_SKey
		{
			get 
			{
				return m_pricingUom_SKey ;					
			}
			set
			{
				 m_pricingUom_SKey = value ;	
			}
		}
		/// <summary>
		/// 计价单位
		/// 费用计算行.Misc.计价单位
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 PricingUom
		{
			get	
			{	
				if (PricingUom_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return PricingUom_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					PricingUom_SKey = null ;
				else
				{
					if (PricingUom_SKey == null )
						PricingUom_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.UOM.UOM") ;
					else
						PricingUom_SKey.ID = value ;
				}
			}
		}
		
		#endregion	

		#region Multi_Fields
																						
		#endregion 		
	}	

}

