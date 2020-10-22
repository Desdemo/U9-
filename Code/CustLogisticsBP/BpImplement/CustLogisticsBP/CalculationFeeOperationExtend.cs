namespace UFIDA.U9.Cust.BLT.CustLogisticsBP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using UFIDA.U9.Base.Contact;
    using UFIDA.U9.CBO.Enums;
    using UFIDA.U9.CBO.FI.BankAccount;
    using UFIDA.U9.CBO.SCM.Item;
    using UFIDA.U9.Cust.BLT.CustLogisticsBE;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Util.Security;

    /// <summary>
    /// CalculationFeeOperation partial 
    /// </summary>	
    public partial class CalculationFeeOperation
    {
        internal BaseStrategy Select()
        {
            return new CalculationFeeOperationImpementStrategy();
        }
    }
    class Cost
    {
        public int Fact; // 工厂枚举值
        public int PricingMethod; // 计价方式
        public double UnitPrice; //单价 
        public double DeliveryPickup; // 提货费
        public double DeliveryCharges; // 送货费
        public double TotalAmount; // 实际运费
        public double RealAmount; // 合计运费
        public double FeePick; // 免提标准
        public double FeeChargs; // 免送标准
        public double Weight;
        public double Bulk;
        public double TotalBulk;
        public double TotalWeight;
    }

    class Info
    {
        public int Fact;
        public double Bulk;
        public double Weight;
        public double TotalBulk;
        public double TotalWeight;
    }
    class LocationInfo
    {
        public long Province;
        public long City;
        public long County;
        public string DescribeLocation;
    }

    #region  implement strategy	
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CalculationFeeOperationImpementStrategy : BaseStrategy
    {
        public CalculationFeeOperationImpementStrategy() { }
        // 错误定义
        Exception NoSup = new Exception("未找到该供应商的价目表，请维护");
        Exception NoPriceList = new Exception("未找到供应商匹配的价目表，请维护后再试");
        Exception UnreasonableWay = new Exception("当表头计价方式不是包车时，行计价方式不应该是包车");

        // 费用赋值
        public CalculationFeeDTO ManualCost(List<Cost> costs)
        {
            CalculationFeeDTO calculation = new CalculationFeeDTO();
            calculation.HuangdaoTotal = new CalculationFeeTotalLine();
            calculation.ChenyangTotal = new CalculationFeeTotalLine();
            foreach (Cost cost in costs)
            {
                calculation.UintPrice += cost.UnitPrice;
                // 黄岛
                if (cost.Fact == 0)
                {
                    // 提送费
                    calculation.HuangdaoTotal.PickupFee += cost.DeliveryPickup;
                    calculation.HuangdaoTotal.DeliveryFee += cost.DeliveryCharges;
                    
                    // 运费合计
                    calculation.HuangdaoTotal.TotalFreight += calculation.HuangdaoTotal.PickupFee + calculation.HuangdaoTotal.DeliveryFee + cost.TotalAmount;
                    calculation.HuangdaoTotal.RealFreight += calculation.HuangdaoTotal.PickupFee + calculation.HuangdaoTotal.DeliveryFee + cost.RealAmount;
                }
                // 城阳
                else
                {
                    calculation.ChenyangTotal.PickupFee += cost.DeliveryPickup;
                    calculation.ChenyangTotal.DeliveryFee += cost.DeliveryCharges;
                    calculation.ChenyangTotal.TotalFreight += calculation.ChenyangTotal.PickupFee + calculation.ChenyangTotal.DeliveryFee + cost.TotalAmount;
                    calculation.ChenyangTotal.RealFreight += calculation.ChenyangTotal.PickupFee + calculation.ChenyangTotal.DeliveryFee + cost.RealAmount;
                }

                calculation.TotalAmount = calculation.HuangdaoTotal.TotalFreight + calculation.ChenyangTotal.TotalFreight;
                calculation.RealAmount = calculation.HuangdaoTotal.RealFreight + calculation.ChenyangTotal.RealFreight;
            }
            return calculation;
        }
        // 费用cost生成
        public Cost PriceCollection(long PriceID, LocationInfo Addre, int Fact, int Method, int HeadMethod, Info info)
        {
            Cost cost = new Cost();
            string query = "LogisticsPricelist = " + PriceID + " and DeliveryFactory = " + Fact + " and PricingMethod =" + Method;

            if (Addre.Province != 0)
            {
                string query_pro = " and Province = " + Addre.Province;
                query = query + query_pro;
            }
            if (Addre.City != 0)
            {
                string query_pro = " and City = " + Addre.City;
                query = query + query_pro;
            }
            if (Addre.County != 0)
            {
                string query_pro = " and County = " + Addre.County;
                query = query + query_pro;
            }
            //if (Addre.DescribeLocation != "")
            //{
            //             string query_pro = " and DescribeAddress = '" + Addre.DescribeLocation+"'";
            //             query = query + query_pro;
            //         }

            //OqlParam oqlParam = new OqlParam("Code", Addre.County);

            LogisticsPricelistLine line = LogisticsPricelistLine.Finder.Find(query + " order by UintPrice asc");

            //LogisticsPricelistLine.EntityList list = LogisticsPricelistLine.Finder.FindAll(query + " ORDER BY UintPrice DESC");

            if (line == null) throw NoPriceList;
            else
            {
                // 包车  // 体积 // 重量
                // 主计价方式与行计价方式相等
                
                // 工厂
                cost.Fact = Fact;
                // 免提标准
                cost.FeeChargs = line.FreeDelivery;
                // 免送标准
                cost.FeePick = line.FreePickup;
                // 重量体积赋值
                cost.Weight = info.Weight;
                cost.Bulk = info.Bulk;
                cost.TotalWeight = info.TotalWeight;
                cost.TotalBulk = info.TotalBulk;
                cost.PricingMethod = Method;
                // 主计价行计价比较
                if (HeadMethod == Method)
                {
                    // 单价
                    cost.UnitPrice = line.UintPrice;
                    // 主体积
                    if (Method == 1 && info.Fact == Fact)
                    {
                        // 动态价格计算
                        if (line.DynamicPrice != null)
                        {
                            cost = DynamicCompute(cost, line.DynamicPrice.ID);
                        }
                        else
                        {
                            if (info.Bulk < line.FreeDelivery) cost.DeliveryCharges = line.DeliveryCharges;
                            if (info.Bulk < line.FreePickup) cost.DeliveryPickup = line.DeliveryPickup;
                        }
                        cost.TotalAmount = cost.UnitPrice * info.TotalBulk;
                        cost.RealAmount = cost.UnitPrice * info.Bulk;
                    }
                    // 主重量
                    else if (Method == 2 && info.Fact == Fact)
                    {
                        // 动态价格计算
                        if (line.DynamicPrice != null)
                        {
                            cost = DynamicCompute(cost, line.DynamicPrice.ID);
                        }
                        else
                        {
                            if (info.Weight < line.FreeDelivery) cost.DeliveryCharges = line.DeliveryCharges;
                            if (info.Weight < line.FreePickup) cost.DeliveryPickup = line.DeliveryPickup;
                        }
                        cost.TotalAmount = cost.UnitPrice * info.TotalWeight;
                        cost.RealAmount = cost.UnitPrice * info.Weight;
                    }
                    // 主包车
                    else
                    {
                        // 包车总价格
                        cost.TotalAmount = line.UintPrice;
                    }
                }
                else
                {
                    // 从计价 体积
                    if (Method == 1)
                    {
                        // 动态价格计算
                        if (line.DynamicPrice != null)
                        {
                            cost = DynamicCompute(cost, line.DynamicPrice.ID);

                        }
                        cost.TotalAmount = line.UintPrice * info.TotalBulk;
                        cost.RealAmount = line.UintPrice * info.Bulk;
                    }
                    else
                    {
                        // 动态价格计算
                        if (line.DynamicPrice != null)
                        {
                            cost = DynamicCompute(cost, line.DynamicPrice.ID);

                        }
                        cost.TotalAmount = line.UintPrice * info.TotalWeight;
                        cost.RealAmount = line.UintPrice * info.Weight;
                    }

                }
                

            }
            return cost;
        }

        // 动态价格计算 
        public Cost DynamicCompute(Cost cost, Int64 dynamiceID)
        {
            DynamicPrice dynamic = DynamicPrice.Finder.FindByID(dynamiceID);
            if (dynamic != null)
            {
                // 判断作用字段和类型
                int field = dynamic.EffectField.Value;
                // 阶梯计费
                if (dynamic.DynamicPriceType.Value == 0)
                {
                    throw new Exception("未添加,请联系管理员");
                }
                // 满减
                else
                {
                    DynamicPriceLine priceLine = new DynamicPriceLine();
                    if (cost.PricingMethod == 1)
                    {
                        priceLine = DynamicPriceLine.Finder.Find("Start < " + cost.Bulk + " and Cutoff >= " + cost.Bulk + " and DynamicPrice = " + dynamiceID);
                    }
                    else if (cost.PricingMethod == 2)
                    {
                        priceLine = DynamicPriceLine.Finder.Find("Start < " + cost.Weight + " and Cutoff >= " + cost.Weight + " and DynamicPrice = " + dynamiceID);
                    }
                    if (priceLine != null)
                    {
                        switch (field)
                        {
                            case 0:
                                cost.UnitPrice = priceLine.UnitPrice;
                                break;
                            case 1:
                                cost.DeliveryPickup = priceLine.UnitPrice;
                                break;
                            case 2:
                                cost.DeliveryCharges = priceLine.UnitPrice;
                                break;
                            default:
                                break;
                        }
                    }
                }

            }
            return cost;
        }

        public Info InitInfo(CalculationFeeTotalLine line, int fact)
        {
            Info info = new Info();
            info.Fact = fact;
            info.Bulk = line.RealBulk;
            info.Weight = line.RealWeight;
            info.TotalWeight = line.TotalWeight;
            info.TotalBulk = line.TotalBulk;
            return info;
        }

        public override object Do(object obj)
        {
            CalculationFeeOperation bpObj = (CalculationFeeOperation)obj;

            //get business operation context is as follows
            //IContext context = ContextManager.Context	

            //auto generating code end,underside is user custom code
            //and if you Implement replace this Exception Code...
            if (bpObj != null)
            {
                LocationInfo address = new LocationInfo();
                if (bpObj.Data.Province != null) address.Province = bpObj.Data.Province.ID;
                if (bpObj.Data.City != null) address.City = bpObj.Data.City.ID;
                if (bpObj.Data.County != null) address.County = bpObj.Data.County.ID;
                address.DescribeLocation = bpObj.Data.DescriLocation;


                // 查找供应商
                long inputsupID = bpObj.Data.Sup.ID;
                string supID;
                CBO.SCM.Supplier.Supplier supplier = CBO.SCM.Supplier.Supplier.Finder.FindByID(inputsupID);
                if (supplier.MasterOrg == null) supID = inputsupID.ToString();
                else
                {
                    CBO.SCM.Supplier.Supplier supplier1 = CBO.SCM.Supplier.Supplier.Finder.Find("Code='" + supplier.Code + "' and Org = " + supplier.MasterOrg.ID);
                    supID = supplier1.ID.ToString();
                }
                // 价目表
                LogisticsPricelist pricelist = LogisticsPricelist.Finder.Find("Sup = " + supID);
                if (pricelist == null) throw NoSup;
                // 提货工厂集合
                List<int> fact = new List<int>();
                // 计价方式集合
                List<int> pricings = new List<int>();
                foreach (CalculationFeeLine calculation in bpObj.Dataline)
                {
                    if (!fact.Contains(calculation.RealDeliveryFactory.Value))
                    {
                        fact.Add(calculation.RealDeliveryFactory.Value);
                    }
                    if (!pricings.Contains(calculation.RealPricingMethod.Value))
                    {
                        pricings.Add(calculation.RealPricingMethod.Value);
                    }
                }
                // 派车数量
                int deliveryNum = bpObj.Data.NumberOfTrucks;
                // 计价方式
                int pricingMethod = bpObj.Data.PricingMethod.Value;
                // 提送费：
                //  1、1工厂  2、2工厂1车  3、 2工厂2车
                // 0 包车 1 体积 2 重量				
                // 送货工厂数量 
                Cost costVehicle = new Cost();
                Cost costWeight = new Cost();
                Cost costBulk = new Cost();
                List<Cost> costs = new List<Cost> { };
                Info info = new Info();
                // 1厂
                if (fact.Count == 1)
                {
                    info.Fact = fact[0];
                    if (fact[0] == 0)
                    {
                        info.Bulk = bpObj.DataH.RealBulk;
                        info.Weight = bpObj.DataH.RealWeight;
                        info.TotalBulk = bpObj.DataH.TotalBulk;
                        info.TotalWeight = bpObj.DataH.TotalWeight;
                    }
                    else
                    {
                        info.Bulk = bpObj.DataC.RealBulk;
                        info.Weight = bpObj.DataC.RealWeight;
                        info.TotalBulk = bpObj.DataC.TotalBulk;
                        info.TotalWeight = bpObj.DataC.TotalWeight;
                    }
                    // 计价依据: 包车
                    if (pricingMethod == 0)
                    {
                        costVehicle = PriceCollection(pricelist.ID, address, fact[0], 0, 0, info);
                        costs.Add(costVehicle);
                        // 判断子行是否存在其他计价方式
                        if (pricings.Count > 1)
                        {
                            // 存在行体积计价
                            if (pricings.Contains(1))
                            {
                                costBulk = PriceCollection(pricelist.ID, address, fact[0], 1, 0, info);
                                costs.Add(costBulk);
                            }
                            // 存在行重量计价
                            if (pricings.Contains(2))
                            {
                                costWeight = PriceCollection(pricelist.ID, address, fact[0], 2, 0, info);
                                costs.Add(costWeight);

                            }
                        }

                    }
                    // 计价依据：体积
                    else if (pricingMethod == 1)
                    {
                        costBulk = PriceCollection(pricelist.ID, address, fact[0], 1, 1, info);
                        costs.Add(costBulk);
                        if (pricings.Count > 1)
                        {
                            // 存在行重量计价
                            if (pricings.Contains(2))
                            {
                                costWeight = PriceCollection(pricelist.ID, address, fact[0], 2, 1, info);
                                costs.Add(costWeight);
                            }
                            else if (pricings.Contains(0))
                            {
                                throw UnreasonableWay;
                            }
                        }
                    }
                    // 计价依据：重量
                    else
                    {
                        costWeight = PriceCollection(pricelist.ID, address, fact[0], 2, 2, info);
                        costs.Add(costWeight);
                        if (pricings.Count > 1)
                        {
                            // 存在行体积计价
                            if (pricings.Contains(1))
                            {
                                costBulk = PriceCollection(pricelist.ID, address, fact[0], 1, 2, info);
                                costs.Add(costBulk);
                            }
                            else if (pricings.Contains(0))
                            {
                                throw UnreasonableWay;
                            }
                        }
                    }
                    return ManualCost(costs);
                }
                // 1车2厂
                else if (fact.Count == 2 && deliveryNum == 1)
                {
                    Info Hinfo = InitInfo(bpObj.DataH, 0);
                    Info Cinfo = InitInfo(bpObj.DataC, 1);
                    info.Bulk = Hinfo.Bulk + Cinfo.Bulk;
                    info.Weight = Cinfo.Weight + Hinfo.Weight;
                    info.TotalBulk = Hinfo.TotalBulk + Cinfo.TotalBulk;
                    info.TotalWeight = Cinfo.TotalWeight + Hinfo.TotalWeight;
                    if (Hinfo.Bulk > Cinfo.Bulk) info.Fact = 0;
                    else info.Fact = 1;
                    // 包车
                    if (pricingMethod == 0)
                    {
                        costVehicle = PriceCollection(pricelist.ID, address, info.Fact, 0, 0, info);
                        costs.Add(costVehicle);
                        // 逻辑 两工厂提货，价格取哪个？ 取量大的，相同的话取黄岛
                        // 判断子行是否存在其他计价方式
                        if (pricings.Count > 1)
                        {
                            // 存在行体积计价
                            if (pricings.Contains(1))
                            {
                                if (Hinfo.Bulk != 0)
                                {
                                    Cost HcostBulk = PriceCollection(pricelist.ID, address, Hinfo.Fact, 1, 0, Hinfo);
                                    costs.Add(HcostBulk);
                                }
                                else
                                {
                                    Cost CcostBulk = PriceCollection(pricelist.ID, address, Cinfo.Fact, 1, 0, Cinfo);
                                    costs.Add(CcostBulk);
                                }
                            }
                            // 存在行重量计价
                            if (pricings.Contains(2))
                            {
                                if (Hinfo.Weight != 0)
                                {
                                    Cost HcostWeight = PriceCollection(pricelist.ID, address, Hinfo.Fact, 2, 0, Hinfo);
                                    costs.Add(HcostWeight);
                                }
                                else
                                {
                                    Cost CcostWeight = PriceCollection(pricelist.ID, address, Cinfo.Fact, 2, 0, Cinfo);
                                    costs.Add(CcostWeight);
                                }
                            }
                        }
                    }
                    // 体积
                    else if (pricingMethod == 1)
                    {
                        // 合计超过免提送，不达选多的工厂	
                        costBulk = PriceCollection(pricelist.ID, address, info.Fact, 1, 1, info);
                        costs.Add(costBulk);
                        if (pricings.Count > 1)
                        {
                            // 存在行重量计价
                            if (pricings.Contains(2))
                            {
                                costWeight = PriceCollection(pricelist.ID, address, info.Fact, 2, 1, info);
                                costs.Add(costWeight);
                            }
                            else if (pricings.Contains(0))
                            {
                                throw UnreasonableWay;
                            }
                        }
                    }
                    // 重量
                    else
                    {
                        costWeight = PriceCollection(pricelist.ID, address, info.Fact, 2, 2, info);
                        costs.Add(costWeight);
                        if (pricings.Count > 1)
                        {
                            // 存在行体积计价
                            if (pricings.Contains(1))
                            {
                                costBulk = PriceCollection(pricelist.ID, address, info.Fact, 1, 2, info);
                                costs.Add(costBulk);
                            }
                            else if (pricings.Contains(0))
                            {
                                throw UnreasonableWay;
                            }
                        }
                    }
                    return ManualCost(costs);
                }
                // 2车2厂
                else if (fact.Count == 2 && deliveryNum == 2)
                {
                    Info Hinfo = InitInfo(bpObj.DataH, 0);
                    Info Cinfo = InitInfo(bpObj.DataC, 1);
                    // 包车
                    if (pricingMethod == 0)
                    {
                        costVehicle = PriceCollection(pricelist.ID, address, info.Fact, 0, 0, info);
                        costs.Add(costVehicle);
                        // 判断子行是否存在其他计价方式
                        if (pricings.Count > 1)
                        {
                            // 存在行体积计价
                            if (pricings.Contains(1))
                            {
                                if (Hinfo.Bulk != 0)
                                {
                                    Cost HcostBulk = PriceCollection(pricelist.ID, address, Hinfo.Fact, 1, 0, Hinfo);
                                    costs.Add(HcostBulk);
                                }
                                else
                                {
                                    Cost CcostBulk = PriceCollection(pricelist.ID, address, Cinfo.Fact, 1, 0, Cinfo);
                                    costs.Add(CcostBulk);
                                }
                            }
                            // 存在行重量计价
                            if (pricings.Contains(2))
                            {
                                if (Hinfo.Weight != 0)
                                {
                                    Cost HcostWeight = PriceCollection(pricelist.ID, address, Hinfo.Fact, 2, 0, Hinfo);
                                    costs.Add(HcostWeight);
                                }
                                else
                                {
                                    Cost CcostWeight = PriceCollection(pricelist.ID, address, Cinfo.Fact, 2, 0, Cinfo);
                                    costs.Add(CcostWeight);
                                }
                            }
                        }
                    }
                    // 体积
                    else if (pricingMethod == 1)
                    {
                        // 分别计价 黄岛
                        Cost HcostBulk = PriceCollection(pricelist.ID, address, Hinfo.Fact, 1, 1, Hinfo);
                        costs.Add(HcostBulk);
                        if (pricings.Count > 1)
                        {
                            // 存在行重量计价
                            if (pricings.Contains(2) && Hinfo.Weight > 0)
                            {
                                Cost HcostWeight = PriceCollection(pricelist.ID, address, Hinfo.Fact, 2, 1, Hinfo);
                                costs.Add(HcostWeight);
                            }
                            else if (pricings.Contains(0))
                            {
                                throw UnreasonableWay;
                            }
                        }
                        // 分别计价 城阳
                        Cost CcostBulk = PriceCollection(pricelist.ID, address, Cinfo.Fact, 1, 1, Cinfo);
                        costs.Add(CcostBulk);
                        if (pricings.Count > 1)
                        {
                            // 存在行重量计价
                            if (pricings.Contains(2) && Cinfo.Weight > 0)
                            {
                                Cost CcostWeight = PriceCollection(pricelist.ID, address, Cinfo.Fact, 2, 1, Cinfo);
                                costs.Add(CcostWeight);
                            }
                            else if (pricings.Contains(0))
                            {
                                throw UnreasonableWay;
                            }
                        }
                    }
                    else
                    {
                        // 分别计价 黄岛
                        Cost HcostWeight = PriceCollection(pricelist.ID, address, Hinfo.Fact, 2, 2, Hinfo);
                        costs.Add(HcostWeight);
                        if (pricings.Count > 1)
                        {
                            // 存在行重量计价
                            if (pricings.Contains(2) && Hinfo.Bulk > 0)
                            {
                                Cost HcostBulk = PriceCollection(pricelist.ID, address, Hinfo.Fact, 1, 2, Hinfo);
                                costs.Add(HcostBulk);
                            }
                            else if (pricings.Contains(0))
                            {
                                throw UnreasonableWay;
                            }
                        }
                        // 分别计价 城阳
                        Cost CcostWeight = PriceCollection(pricelist.ID, address, Cinfo.Fact, 2, 2, Cinfo);
                        costs.Add(CcostWeight);
                        if (pricings.Count > 1)
                        {
                            // 存在行重量计价
                            if (pricings.Contains(2) && Cinfo.Bulk > 0)
                            {
                                Cost CcostBulk = PriceCollection(pricelist.ID, address, Cinfo.Fact, 1, 2, Cinfo);
                                costs.Add(CcostBulk);
                            }
                            else if (pricings.Contains(0))
                            {
                                throw UnreasonableWay;
                            }
                        }
                    }
                    return ManualCost(costs);
                }
            }
            return null;

        }
    }

    #endregion


}