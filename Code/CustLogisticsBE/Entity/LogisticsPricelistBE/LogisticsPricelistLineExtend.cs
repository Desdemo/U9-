

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.BLT.CustLogisticsBE {

	public partial class LogisticsPricelistLine{

		#region Custom Constructor

		#endregion

		#region before & after CUD V 
		/*	实体提交的事件顺序示例(QHELP) 主实体A 组合 非主实体B .
		/ (新增A和B两个实例)A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnInserting ->B.OnInserting ->产生提交SQL ->B.OnInserted ->A.OnInserted
		/ (仅修改B,A也会被修改))A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnUpdating ->B.OnUpdating ->产生提交SQL ->B.OnUpdated ->A.OnUpdated
		/ (删除A,B会被级联删除))A.OnDeleting ->B.OnDeleting ->产生提交SQL ->B.OnDeleted ->A.OnDeleted
		/	产生提交SQL顺序则看其外键，增修一对多先A后B，一对一先B后A。　删除一对多先B后A，一对一先A后B .
		*/	
		/// <summary>
		/// 设置默认值
		/// </summary>
		protected override void OnSetDefaultValue()
		{
			base.OnSetDefaultValue();
			if (this.OriginalData.FormatAddress != this.FormatAddress)
			{
                String location = this.FormatAddress;
                AddressParser.AddressPareser.Loca loca = AddressParser.AddressPareser.AddresPare(location);
                if (loca != null)
                {
                    if (loca.provinceCode != "")
                    {
                        this.Province = UFIDA.U9.Base.Location.Province.FindByCode(loca.provinceCode);
                    }
                    if (loca.cityCode != "")
                    {
                        this.City = UFIDA.U9.Base.Location.City.FindByCode(loca.cityCode);
                    }

                    if (loca.countyCode != "")
                    {
                        this.County = UFIDA.U9.Base.Location.County.FindByCode(loca.countyCode);
                    }
                    this.DescribeAddress = loca.street + loca.address;

                }
                else
                {
                    throw new Exception("地址解析失败，请检查！");
                }
            } 
        }
        public static bool Con(string code, List<string> conditons)
        {
            if (conditons.Count > 0)
            {
                foreach (string conditon in conditons)
                {
                    if (code.Contains(conditon))
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        /// <summary>
        /// before Insert
        /// </summary>
        protected override void OnInserting() {
			base.OnInserting();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Insert
		/// </summary>
		protected override void OnInserted() {
			base.OnInserted();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// before Update
		/// </summary>
		protected override void OnUpdating() {
			base.OnUpdating();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Update
		/// </summary>
		protected override void OnUpdated() {
			base.OnUpdated();
			// TO DO: write your business code here...
		}


		/// <summary>
		/// before Delete
		/// </summary>
		protected override void OnDeleting() {
			base.OnDeleting();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Delete
		/// </summary>
		protected override void OnDeleted() {
			base.OnDeleted();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// on Validate
		/// </summary>
		protected override void OnValidate() {
			base.OnValidate();
			this.SelfEntityValidator();
			// TO DO: write your business code here...
		}
		#endregion
		
		#region 异常处理，开发人员可以重新封装异常
		public override void  DealException(Exception e)
        	{
          		base.DealException(e);
          		throw e;
        	}
		#endregion

		#region  扩展属性代码区
		
		#endregion

		#region CreateDefault
		
		private  static LogisticsPricelistLine CreateDefault_Extend(UFIDA.U9.Cust.BLT.CustLogisticsBE.LogisticsPricelist parentEntity) {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
	    		
		#endregion 






		#region Model Methods
		#endregion		
	}
}
