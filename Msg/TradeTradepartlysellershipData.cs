using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Msg
{
    /// <summary>
    /// trade_TradePartlySellerShip
    /// </summary>
    /// <remarks>
    ///  卖家部分发货消息<br/>
    ///  https://doc.youzanyun.com/detail/MSG/198
    /// </remarks>
    public class TradeTradepartlysellershipData
    {
        /// <summary>
        /// 您的应用id，非应用clientid
        /// </summary>
        /// <example>
        /// 41823
        /// </example>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
        /// <summary>
        /// 您的应用clientid
        /// </summary>
        /// <example>
        /// cbb85341d4cbb09f7d
        /// </example>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        /// <summary>
        /// 业务消息的标识，返回值为订单号
        /// </summary>
        /// <example>
        /// E20200614172200048204177
        /// </example>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// 触发消息的店铺id
        /// </summary>
        /// <example>
        /// 75632
        /// </example>
        [JsonProperty("kdt_id")]
        public long KdtId { get; set; }
        /// <summary>
        /// 触发消息的店铺名称
        /// </summary>
        /// <example>
        /// 有赞的店
        /// </example>
        [JsonProperty("kdt_name")]
        public string KdtName { get; set; }
        /// <summary>
        /// 已废弃字段无需关注
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
        /// 经过UrlEncode(UTF-8)编码,需要解码
        /// </example>
        [JsonProperty("msg")]
        public string Msg { get; set; }
        /// <summary>
        /// 消息唯一标示
        /// </summary>
        /// <example>
        /// b01afca7-898f-4dca-9b2a-25cd2aaea77c
        /// </example>
        [JsonProperty("msg_id")]
        public string MsgId { get; set; }
        /// <summary>
        /// 重发的次数，当推送没有成功返回会进入自动重推，最多重推4次，每次推送间隔为5s, 5m20s, 21m20s, 2h
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
        /// 5f8f123fe6233aeeaa2d7b6a7f95e4b9
        /// </example>
        [JsonProperty("sign")]
        public string Sign { get; set; }
        /// <summary>
        /// 该消息返回该字段为null，无需关注
        /// </summary>
        /// <example>
        /// null
        /// </example>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// 已废弃字段无需关注
        /// </summary>
        /// <example>
        /// 已废弃
        /// </example>
        [JsonProperty("test")]
        public bool? Test { get; set; }
        /// <summary>
        /// 消息业务类型，部分发货-trade_TradePartlySellerShip
        /// </summary>
        /// <example>
        /// trade_TradePartlySellerShip
        /// </example>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 消息版本号,为了解决顺序性的问题,高版本覆盖低版本
        /// </summary>
        /// <example>
        /// 1623833567
        /// </example>
        [JsonProperty("version")]
        public long Version { get; set; }

    }
}

