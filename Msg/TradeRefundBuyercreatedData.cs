using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Msg
{
    /// <summary>
    /// trade_refund_BuyerCreated
    /// </summary>
    /// <remarks>
    ///  买家申请退款<br/>
    ///  https://doc.youzanyun.com/detail/MSG/209
    /// </remarks>
    public class TradeRefundBuyercreatedData
    {
        /// <summary>
        /// 已废弃，开发者无需关注
        /// </summary>
        /// <example>
        /// 已废弃，开发者无需关注
        /// </example>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
        /// <summary>
        /// 客户端标识
        /// </summary>
        /// <example>
        /// 1212313
        /// </example>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        /// <summary>
        /// 业务消息的标识
        /// </summary>
        /// <example>
        /// 213123
        /// </example>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// 门店ID
        /// </summary>
        /// <example>
        /// 12
        /// </example>
        [JsonProperty("kdt_id")]
        public long KdtId { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        /// <example>
        /// 小店的名称
        /// </example>
        [JsonProperty("kdt_name")]
        public string KdtName { get; set; }
        /// <summary>
        /// 模式
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("mode")]
        public int? Mode { get; set; }
        /// <summary>
        /// 经过UrlEncode(UTF-8)编码,需要解码
        /// </summary>
        /// <example>
        /// 消息体内容
        /// </example>
        [JsonProperty("msg")]
        public string Msg { get; set; }
        /// <summary>
        /// 消息唯一标示
        /// </summary>
        /// <example>
        /// 12321123
        /// </example>
        [JsonProperty("msg_id")]
        public string MsgId { get; set; }
        /// <summary>
        /// 连锁门店总店ID
        /// </summary>
        /// <example>
        /// 243
        /// </example>
        [JsonProperty("root_kdt_id")]
        public long? RootKdtId { get; set; }
        /// <summary>
        /// 重发的次数
        /// </summary>
        /// <example>
        /// 3
        /// </example>
        [JsonProperty("sendCount")]
        public int? SendCount { get; set; }
        /// <summary>
        /// 防伪签名: MD5(client_id+msg+client_secrect)。不建议使用此字段，可以用请求头中的Event-Sign进行防伪验证
        /// </summary>
        /// <example>
        /// 1423432
        /// </example>
        [JsonProperty("sign")]
        public string Sign { get; set; }
        /// <summary>
        /// 已废弃，开发者无需关注
        /// </summary>
        /// <example>
        /// 已废弃
        /// </example>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// 已废弃，开发者无需关注
        /// </summary>
        /// <example>
        /// 已废弃
        /// </example>
        [JsonProperty("test")]
        public bool? Test { get; set; }
        /// <summary>
        /// 消息业务类型
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 消息版本号,为了解决顺序性的问题,高版本覆盖低版本
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("version")]
        public long Version { get; set; }

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

