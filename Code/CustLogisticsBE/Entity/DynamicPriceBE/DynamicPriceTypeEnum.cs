using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
    /// <summary>
    /// 可扩展枚举: 动态价格类型枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class DynamicPriceTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum");
        #region ctor & cctor 
        static DynamicPriceTypeEnum()
        {
            InitData();
        }
        private DynamicPriceTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private DynamicPriceTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,DynamicPriceTypeEnum>();
            step = new DynamicPriceTypeEnum(0,"Step") ;
            innerEnums.Add(0,step) ;
            excess = new DynamicPriceTypeEnum(1,"Excess") ;
            innerEnums.Add(1,excess) ;
            empty = new DynamicPriceTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static DynamicPriceTypeEnum empty;
        public static DynamicPriceTypeEnum Empty
        {
            get
            {
                return empty;
            }
        }
        #endregion 

        #region Intstance Propertites 
        private int currentValue;
        public System.Int32 Value
        {
            get
            {
				return currentValue ;         
            }
        }
        private string  name ;
        public string  Name 
        {
            get
            {
                return name;
            }
        }
        [System.Obsolete("已经废弃,请用EnumRes.GetResource(name)方式来获取显示名称. ")]
        public string Res_Name
        {
        	get 
        	{
        		switch ( this.Name )
        		{
        			case "Step":
        				return this.Res_Step; 
        			case "Excess":
        				return this.Res_Excess; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static DynamicPriceTypeEnum step ;
        /// <summary>
        /// 枚举值: 阶梯计费  Value:0  
        /// 动态价格类型枚举.Misc.阶梯计费
        /// </summary>
        public static DynamicPriceTypeEnum Step
        {
            get
            {
                return  step ;
            }
        }
        private static DynamicPriceTypeEnum excess ;
        /// <summary>
        /// 枚举值: 超额计费  Value:1  
        /// 动态价格类型枚举.Misc.超额计费
        /// </summary>
        public static DynamicPriceTypeEnum Excess
        {
            get
            {
                return  excess ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, DynamicPriceTypeEnum> innerEnums;
        /// <summary>
        /// Get DynamicPriceTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<DynamicPriceTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get DynamicPriceTypeEnum By Value 
        /// </summary>
        public static DynamicPriceTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						DynamicPriceTypeEnum newValue = new DynamicPriceTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get DynamicPriceTypeEnum By Value 
        /// </summary>
        public static DynamicPriceTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return DynamicPriceTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get DynamicPriceTypeEnum By Name 
        /// </summary>
        public static DynamicPriceTypeEnum GetFromName(string name)
        {
            foreach (DynamicPriceTypeEnum obj in innerEnums.Values)
            {
                if (obj.Name == name)
                    return obj;
            }
            //don't need modify to return a Default Value .
            return null;
        }
        #endregion 


		#region ModelResource
		/// <summary>
		/// 动态价格类型枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 动态价格类型枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Step　{ get {return EnumRes.GetResource("Step");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Excess　{ get {return EnumRes.GetResource("Excess");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum";　}　}

			/// <summary>
			///  获取资源接口,直接传了枚举对象.Name 就可.
			/// </summary>
			public static string GetResource(String attrName)
			{
				if (attrName== Enum_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName);
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName, attrName);
			}
			/// <summary>
			///  获取资源接口,直接传了枚举对象.Value 或Int32值 就可.
			/// </summary>
			public static string GetResourceByValue(Int32 value)
			{
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetNameForEnumValue(Enum_FullName, value);
			}
		}
		#endregion 
    }
}