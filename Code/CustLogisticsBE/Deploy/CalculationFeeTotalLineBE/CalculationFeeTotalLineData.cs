
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 费用计算合计行 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLineData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class CalculationFeeTotalLineData : UFSoft.UBF.Business.DataTransObjectBase
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
		public CalculationFeeTotalLineData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     							TotalBulk= 0; 			     							TotalWeight= 0; 			     							RealBulk= 0; 			     							RealWeight= 0; 			     							PickupFee= 0; 			     							DeliveryFee= 0; 			     							DischargeFee= 0; 			     							OtherFee= 0; 			     							TotalFreight= 0; 			     							RealFreight= 0; 		

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
			get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.CalculationFeeTotalLine" ;}
		}
		#endregion


		
		#region Properties Inner Component
	
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 费用计算合计行.Key.ID
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
		/// 费用计算合计行.Sys.创建时间
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
		/// 费用计算合计行.Sys.创建人
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
		/// 费用计算合计行.Sys.修改时间
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
		/// 费用计算合计行.Sys.修改人
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
		/// 费用计算合计行.Sys.事务版本
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
		/// 合计体积
		/// 费用计算合计行.Misc.合计体积
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_totalBulk ;
		public System.Double TotalBulk
		{
			get	
			{	
				return m_totalBulk  ;
			}
			set	
			{	
				m_totalBulk = value ;	
			}
		}
		

				/// <summary>
		/// 合计重量
		/// 费用计算合计行.Misc.合计重量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_totalWeight ;
		public System.Double TotalWeight
		{
			get	
			{	
				return m_totalWeight  ;
			}
			set	
			{	
				m_totalWeight = value ;	
			}
		}
		

				/// <summary>
		/// 实际体积
		/// 费用计算合计行.Misc.实际体积
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_realBulk ;
		public System.Double RealBulk
		{
			get	
			{	
				return m_realBulk  ;
			}
			set	
			{	
				m_realBulk = value ;	
			}
		}
		

				/// <summary>
		/// 实际重量
		/// 费用计算合计行.Misc.实际重量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_realWeight ;
		public System.Double RealWeight
		{
			get	
			{	
				return m_realWeight  ;
			}
			set	
			{	
				m_realWeight = value ;	
			}
		}
		

				/// <summary>
		/// 提货费
		/// 费用计算合计行.Misc.提货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_pickupFee ;
		public System.Double PickupFee
		{
			get	
			{	
				return m_pickupFee  ;
			}
			set	
			{	
				m_pickupFee = value ;	
			}
		}
		

				/// <summary>
		/// 送货费
		/// 费用计算合计行.Misc.送货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_deliveryFee ;
		public System.Double DeliveryFee
		{
			get	
			{	
				return m_deliveryFee  ;
			}
			set	
			{	
				m_deliveryFee = value ;	
			}
		}
		

				/// <summary>
		/// 卸货费
		/// 费用计算合计行.Misc.卸货费
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_dischargeFee ;
		public System.Double DischargeFee
		{
			get	
			{	
				return m_dischargeFee  ;
			}
			set	
			{	
				m_dischargeFee = value ;	
			}
		}
		

				/// <summary>
		/// 其他费用
		/// 费用计算合计行.Misc.其他费用
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_otherFee ;
		public System.Double OtherFee
		{
			get	
			{	
				return m_otherFee  ;
			}
			set	
			{	
				m_otherFee = value ;	
			}
		}
		

				/// <summary>
		/// 合计费用
		/// 费用计算合计行.Misc.合计费用
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_totalFreight ;
		public System.Double TotalFreight
		{
			get	
			{	
				return m_totalFreight  ;
			}
			set	
			{	
				m_totalFreight = value ;	
			}
		}
		

				/// <summary>
		/// 实际费用
		/// 费用计算合计行.Misc.实际费用
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_realFreight ;
		public System.Double RealFreight
		{
			get	
			{	
				return m_realFreight  ;
			}
			set	
			{	
				m_realFreight = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
																
		#endregion 		
	}	

}

