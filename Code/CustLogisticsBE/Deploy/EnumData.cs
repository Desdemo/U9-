using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 枚举值: 提货工厂枚举 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum DeliveryFactoryEnumData
	{
		/// <summary>
		/// 黄岛工厂
		/// </summary>
		H1004H = 0,
		/// <summary>
		/// 城阳工厂
		/// </summary>
		C1003C = 1,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 枚举值: 计价方式枚举 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum PricingMethodEnumData
	{
		/// <summary>
		/// 包车
		/// </summary>
		Vehicle = 0,
		/// <summary>
		/// 体积
		/// </summary>
		Volume = 1,
		/// <summary>
		/// 重量
		/// </summary>
		Weight = 2,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 枚举值: 业务类型枚举 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum BusinessTypeEnumData
	{
		/// <summary>
		/// 调拨
		/// </summary>
		Transfer = 0,
		/// <summary>
		/// 正常
		/// </summary>
		Normal = 1,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 枚举值: 单据类型枚举 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum DocTypeEnumData
	{
		/// <summary>
		/// 调出单
		/// </summary>
		TransferOut = 0,
		/// <summary>
		/// 出货计划
		/// </summary>
		ShipPlan = 1,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 枚举值: 动态价格类型枚举 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum DynamicPriceTypeEnumData
	{
		/// <summary>
		/// 阶梯计费
		/// </summary>
		Step = 0,
		/// <summary>
		/// 超额计费
		/// </summary>
		Excess = 1,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 枚举值: 影响字段枚举 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum EffectFieldEnumData
	{
		/// <summary>
		/// 单价
		/// </summary>
		UintPrice = 0,
		/// <summary>
		/// 提货费
		/// </summary>
		DeliveryPickup = 1,
		/// <summary>
		/// 送货费
		/// </summary>
		DeliveryCharges = 2,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
	/// <summary>
	/// 枚举值: 商品类别枚举 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum ProductCategoryEnumData
	{
		/// <summary>
		/// 液袋
		/// </summary>
		Liquid = 0,
		/// <summary>
		/// 配件
		/// </summary>
		Accessories = 1,
		/// <summary>
		/// 液袋+配件
		/// </summary>
		EnumValue = 2,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

