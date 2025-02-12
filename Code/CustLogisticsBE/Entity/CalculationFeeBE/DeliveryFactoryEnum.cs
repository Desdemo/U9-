﻿using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.BLT.CustLogisticsBE
{
    /// <summary>
    /// 可扩展枚举: 提货工厂枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class DeliveryFactoryEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum");
        #region ctor & cctor 
        static DeliveryFactoryEnum()
        {
            InitData();
        }
        private DeliveryFactoryEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private DeliveryFactoryEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,DeliveryFactoryEnum>();
            h1004H = new DeliveryFactoryEnum(0,"H1004H") ;
            innerEnums.Add(0,h1004H) ;
            c1003C = new DeliveryFactoryEnum(1,"C1003C") ;
            innerEnums.Add(1,c1003C) ;
            empty = new DeliveryFactoryEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static DeliveryFactoryEnum empty;
        public static DeliveryFactoryEnum Empty
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
        			case "H1004H":
        				return this.Res_H1004H; 
        			case "C1003C":
        				return this.Res_C1003C; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static DeliveryFactoryEnum h1004H ;
        /// <summary>
        /// 枚举值: 黄岛工厂  Value:0  
        /// 提货工厂枚举.Misc.黄岛工厂
        /// </summary>
        public static DeliveryFactoryEnum H1004H
        {
            get
            {
                return  h1004H ;
            }
        }
        private static DeliveryFactoryEnum c1003C ;
        /// <summary>
        /// 枚举值: 城阳工厂  Value:1  
        /// 提货工厂枚举.Misc.城阳工厂
        /// </summary>
        public static DeliveryFactoryEnum C1003C
        {
            get
            {
                return  c1003C ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, DeliveryFactoryEnum> innerEnums;
        /// <summary>
        /// Get DeliveryFactoryEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<DeliveryFactoryEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get DeliveryFactoryEnum By Value 
        /// </summary>
        public static DeliveryFactoryEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						DeliveryFactoryEnum newValue = new DeliveryFactoryEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get DeliveryFactoryEnum By Value 
        /// </summary>
        public static DeliveryFactoryEnum GetFromValue(object value)
        {
			if (value == null)
				return DeliveryFactoryEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get DeliveryFactoryEnum By Name 
        /// </summary>
        public static DeliveryFactoryEnum GetFromName(string name)
        {
            foreach (DeliveryFactoryEnum obj in innerEnums.Values)
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
                //    innerEnums.Add(value, new DeliveryFactoryEnum(newValue));
            }

            /// <summary>
            /// 删除枚举项
            /// </summary>
            [System.Obsolete("不再使用,新接口待提供.")]
            public static void DeleteValue(DeliveryFactoryEnum value)
            {
                //innerExtendableEnum.DeleteValue(value.Name);
                //innerEnums.Remove(value.Value);
            }
            #endregion
        }

		#region ModelResource
		/// <summary>
		/// 提货工厂枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 提货工厂枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_H1004H　{ get {return EnumRes.GetResource("H1004H");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_C1003C　{ get {return EnumRes.GetResource("C1003C");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum";　}　}

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