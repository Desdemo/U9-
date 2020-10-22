using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UFIDA.U9.Cust.BLT.CustLogisticsBP.CustLogisticsBP
{
    class AddressPareser
    {
        public static string HttpPost(string url, string body)
        {
            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";

            byte[] buffer = encoding.GetBytes(body);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        // 传入参数
        public class Root
        {
            /// <summary>
            /// 新疆阿克苏温宿县博孜墩柯尔克孜族乡吾斯塘博村一组306号 150-3569-6956 马云
            /// </summary>
            public string address { get; set; }

        }
        // 返回值
        public class Loca
        {
            /// <summary>
            /// 新疆维吾尔自治区
            /// </summary>
            public string province { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string provinceCode { get; set; }
            /// <summary>
            /// 阿克苏地区
            /// </summary>
            public string city { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string cityCode { get; set; }
            /// <summary>
            /// 温宿县
            /// </summary>
            public string county { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string countyCode { get; set; }
            /// <summary>
            /// 博孜墩柯尔克孜族乡
            /// </summary>
            public string street { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string streetCode { get; set; }
            /// <summary>
            /// 吾斯塘博村一组306号
            /// </summary>
            public string address { get; set; }
            /// <summary>
            /// 马云
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string phone { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int requestNumber { get; set; }
            /// <summary>
            /// 
            /// </summary>

        }


        public static Loca AddresPare(string address)
        {
            Root root = new Root {};
            root.address = address;
            string strJson = JsonConvert.SerializeObject(root);
            string result = HttpPost("http://192.168.0.38:10081", strJson);
            if (result != "")
            {
                Loca model = JsonConvert.DeserializeObject<Loca>(result);
                if(model != null)
                {
                    return model;
                }
                return null;
            }
            else
            {
                throw new Exception("地址解析失败，请检查！");
            }
        }

    }

    

}
