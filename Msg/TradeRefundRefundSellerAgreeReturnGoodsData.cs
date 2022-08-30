using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Msg
{
    /// <summary>
    /// trade_refund_RefundSellerAgreeReturnGoods
    /// </summary>
    /// <remarks>
    ///  卖家同意退款退货消息<br/>
    ///  https://doc.youzanyun.com/detail/MSG/205
    /// </remarks>
    public class TradeRefundRefundSellerAgreeReturnGoodsData
    {
        /// <summary>
        /// 您的应用appid
        /// </summary>
        /// <example>
        /// 423532
        /// </example>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
        /// <summary>
        /// 您的应用client_id
        /// </summary>
        /// <example>
        /// 9c9e66718d65c09998
        /// </example>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        /// <summary>
        /// 业务消息的标识，一般为订单号
        /// </summary>
        /// <example>
        /// E2018123456789
        /// </example>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// 店铺ID
        /// </summary>
        /// <example>
        /// 67892
        /// </example>
        [JsonProperty("kdt_id")]
        public long? KdtId { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        /// <example>
        /// 有赞的店
        /// </example>
        [JsonProperty("kdt_name")]
        public string KdtName { get; set; }
        /// <summary>
        /// 已废弃
        /// </summary>
        /// <example>
        /// 已废弃
        /// </example>
        [JsonProperty("mode")]
        public int? Mode { get; set; }
        /// <summary>
        /// 经过UrlEncode(UTF-8)编码,需要解码
        /// </summary>
        /// <example>
        /// 消息集合
        /// </example>
        [JsonProperty("msg")]
        public string Msg { get; set; }
        /// <summary>
        /// 消息唯一标示
        /// </summary>
        /// <example>
        /// 29391381-78e5-4966-9d7e-28c325292b0d
        /// </example>
        [JsonProperty("msg_id")]
        public string MsgId { get; set; }
        /// <summary>
        /// 连锁门店总店ID
        /// </summary>
        /// <example>
        /// 975523
        /// </example>
        [JsonProperty("root_kdt_id")]
        public long? RootKdtId { get; set; }
        /// <summary>
        /// 重发的次数
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("sendCount")]
        public int? SendCount { get; set; }
        /// <summary>
        /// 防伪签名: MD5(client_id+msg+client_secrect)。不建议使用此字段，可以用请求头中的Event-Sign进行防伪验证
        /// </summary>
        /// <example>
        /// 61fb6c24c0cf7cf3ddce605f6b937253
        /// </example>
        [JsonProperty("sign")]
        public string Sign { get; set; }
        /// <summary>
        /// 已废弃
        /// </summary>
        /// <example>
        /// 已废弃
        /// </example>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// 已废弃
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
        /// trade_refund_RefundSellerAgreeReturnGoods
        /// </example>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 消息版本号,为了解决顺序性的问题,高版本覆盖低版本
        /// </summary>
        /// <example>
        /// 1621946259
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

