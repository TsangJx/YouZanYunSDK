using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Msg
{
    /// <summary>
    /// trade_refund_RefundSuccess
    /// </summary>
    /// <remarks>
    ///  卖家同意退货消息<br/>
    ///  https://doc.youzanyun.com/detail/MSG/201
    /// </remarks>
    public class TradeRefundRefundSuccessData
    {
        /// <summary>
        ///  您的应用appid
        /// </summary>
        /// <example>
        /// 45671
        /// </example>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
        /// <summary>
        /// 您的应用的client_id
        /// </summary>
        /// <example>
        /// cc939cb8063622a84d
        /// </example>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        /// <summary>
        /// 业务消息的标识
        /// </summary>
        /// <example>
        /// E20211123144258072900153
        /// </example>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// 店铺id
        /// </summary>
        /// <example>
        /// 98523
        /// </example>
        [JsonProperty("kdt_id")]
        public long? KdtId { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [JsonProperty("kdt_name")]
        public string KdtName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [JsonProperty("mode")]
        public int? Mode { get; set; }
        /// <summary>
        /// 经过UrlEncode(UTF-8)编码,需要解码
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [JsonProperty("msg")]
        public string Msg { get; set; }
        /// <summary>
        /// 消息唯一标示
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [JsonProperty("msg_id")]
        public string MsgId { get; set; }
        /// <summary>
        /// 连锁门店总店ID
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [JsonProperty("root_kdt_id")]
        public long? RootKdtId { get; set; }
        /// <summary>
        /// 重发的次数
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [JsonProperty("sendCount")]
        public int? SendCount { get; set; }
        /// <summary>
        /// 防伪签名: MD5(client_id+msg+client_secrect)。不建议使用此字段，可以用请求头中的Event-Sign进行防伪验证
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [JsonProperty("sign")]
        public string Sign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// false-非测试消息，true-测试消息
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [JsonProperty("test")]
        public bool? Test { get; set; }
        /// <summary>
        /// 消息业务类型
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 消息版本号,为了解决顺序性的问题,高版本覆盖低版本
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [JsonProperty("version")]
        public long? Version { get; set; }

        TradeRefundMsg _msgObj;
        public TradeRefundMsg MsgObj
        {
            get
            {
                if (_msgObj == null)
                {
                    _msgObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TradeRefundMsg>(System.Web.HttpUtility.UrlDecode(Msg));
                }
                return _msgObj;
            }
        }

    }
}

