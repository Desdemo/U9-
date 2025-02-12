﻿using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
    /// <summary>
    /// 可扩展枚举: 影响字段枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class EffectFieldEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum");
        #region ctor & cctor 
        static EffectFieldEnum()
        {
            InitData();
        }
        private EffectFieldEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private EffectFieldEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,EffectFieldEnum>();
            uintPrice = new EffectFieldEnum(0,"UintPrice") ;
            innerEnums.Add(0,uintPrice) ;
            deliveryPickup = new EffectFieldEnum(1,"DeliveryPickup") ;
            innerEnums.Add(1,deliveryPickup) ;
            deliveryCharges = new EffectFieldEnum(2,"DeliveryCharges") ;
            innerEnums.Add(2,deliveryCharges) ;
            empty = new EffectFieldEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static EffectFieldEnum empty;
        public static EffectFieldEnum Empty
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
        			case "UintPrice":
        				return this.Res_UintPrice; 
        			case "DeliveryPickup":
        				return this.Res_DeliveryPickup; 
        			case "DeliveryCharges":
        				return this.Res_DeliveryCharges; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static EffectFieldEnum uintPrice ;
        /// <summary>
        /// 枚举值: 单价  Value:0  
        /// 影响字段枚举.Misc.单价
        /// </summary>
        public static EffectFieldEnum UintPrice
        {
            get
            {
                return  uintPrice ;
            }
        }
        private static EffectFieldEnum deliveryPickup ;
        /// <summary>
        /// 枚举值: 提货费  Value:1  
        /// 影响字段枚举.Misc.提货费
        /// </summary>
        public static EffectFieldEnum DeliveryPickup
        {
            get
            {
                return  deliveryPickup ;
            }
        }
        private static EffectFieldEnum deliveryCharges ;
        /// <summary>
        /// 枚举值: 送货费  Value:2  
        /// 影响字段枚举.Misc.送货费
        /// </summary>
        public static EffectFieldEnum DeliveryCharges
        {
            get
            {
                return  deliveryCharges ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, EffectFieldEnum> innerEnums;
        /// <summary>
        /// Get EffectFieldEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<EffectFieldEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get EffectFieldEnum By Value 
        /// </summary>
        public static EffectFieldEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						EffectFieldEnum newValue = new EffectFieldEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get EffectFieldEnum By Value 
        /// </summary>
        public static EffectFieldEnum GetFromValue(object value)
        {
			if (value == null)
				return EffectFieldEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get EffectFieldEnum By Name 
        /// </summary>
        public static EffectFieldEnum GetFromName(string name)
        {
            foreach (EffectFieldEnum obj in innerEnums.Values)
            {
                if (obj.Name == name)
                    return obj;
            }
            //don't need modify to return a Default Value .
            return null;
        }
        #endregion 

		/// <summary>
		/// 可扩展枚举管理器
		/// </summary>
		[System.Obsolete("不再使用,枚举增删改接口由元数据服务提供.")]
        public static class ExtendManager
        {
            #region Common Method Operator ...
            /// <summary>
            /// 添加新枚举项
            /// </summary>
            [System.Obsolete("不再使用,新接口待提供.")]
            public static void NewValue(string name, Int32 value, string displayName, string description)
            {
                //EnumValue newValue = innerExtendableEnum.NewValue(name, value.ToString(), displayName, description);
                ////处理枚举项已经存在的情况下,比如自动创建的无name枚举项.
                //if (innerEnums.ContainsKey(value))
                //{
                //    innerEnums[value].currentValue.Name = name;
                //    innerEnums[value].currentValue.DisplayName = displayName;
                //    innerEnums[value].currentValue.Description = description;
                //}
                //else
                //    innerEnums.Add(value, new EffectFieldEnum(newValue));
            }

            /// <summary>
            /// 删除枚举项
            /// </summary>
            [System.Obsolete("不再使用,新接口待提供.")]
            public static void DeleteValue(EffectFieldEnum value)
            {
                //innerExtendableEnum.DeleteValue(value.Name);
                //innerEnums.Remove(value.Value);
            }
            #endregion
        }

		#region ModelResource
		/// <summary>
		/// 影响字段枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 影响字段枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_UintPrice　{ get {return EnumRes.GetResource("UintPrice");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_DeliveryPickup　{ get {return EnumRes.GetResource("DeliveryPickup");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_DeliveryCharges　{ get {return EnumRes.GetResource("DeliveryCharges");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum";　}　}

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