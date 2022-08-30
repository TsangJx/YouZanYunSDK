using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Msg
{
    /// <summary>
    /// trade_TradeClose
    /// </summary>
    /// <remarks>
    ///  买家或卖家取消订单、订单全额退款<br/>
    ///  https://doc.youzanyun.com/detail/MSG/200
    /// </remarks>
    public class TradeTradecloseData
    {
        /// <summary>
        /// 已废弃字段，不返回
        /// </summary>
        /// <example>
        /// null
        /// </example>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
        /// <summary>
        /// 您的client_id
        /// </summary>
        /// <example>
        /// 96cfe7cb390c983252
        /// </example>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        /// <summary>
        /// 业务消息的标识，交易订单号的值
        /// </summary>
        /// <example>
        /// E20200525201253074004153
        /// </example>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// 店铺id
        /// </summary>
        /// <example>
        /// 56232
        /// </example>
        [JsonProperty("kdt_id")]
        public long KdtId { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        /// <example>
        /// 有赞的店
        /// </example>
        [JsonProperty("kdt_name")]
        public string KdtName { get; set; }
        /// <summary>
        /// 已废弃字段，无需关注
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
        /// 消息集合
        /// </example>
        [JsonProperty("msg")]
        public string Msg { get; set; }
        /// <summary>
        /// 消息唯一标示
        /// </summary>
        /// <example>
        /// 6dc15f0b-8682-4812-b635-ab66e199f330
        /// </example>
        [JsonProperty("msg_id")]
        public string MsgId { get; set; }
        /// <summary>
        /// 连锁门店总店ID
        /// </summary>
        /// <example>
        /// 74234
        /// </example>
        [JsonProperty("root_kdt_id")]
        public long RootKdtId { get; set; }
        /// <summary>
        /// 重发的次数，最多重推4次，每次推送间隔为5s, 5m20s, 21m20s, 2h。
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
        /// beefa391ad73a8d3f456570d6608791f
        /// </example>
        [JsonProperty("sign")]
        public string Sign { get; set; }
        /// <summary>
        /// 订单状态，TRADE_CLOSED-交易关闭
        /// </summary>
        /// <example>
        /// TRADE_CLOSED
        /// </example>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// 已废弃，无需关注
        /// </summary>
        /// <example>
        /// 已废弃
        /// </example>
        [JsonProperty("test")]
        public string Test { get; set; }
        /// <summary>
        /// 消息业务类型，trade_TradeClose-交易关闭
        /// </summary>
        /// <example>
        /// trade_TradeClose
        /// </example>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 消息版本号,为了解决顺序性的问题,高版本覆盖低版本
        /// </summary>
        /// <example>
        /// 1621946649
        /// </example>
        [JsonProperty("version")]
        public long Version { get; set; }

    }
}

