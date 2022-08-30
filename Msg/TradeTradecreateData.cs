using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Msg
{
    /// <summary>
    /// trade_TradeCreate
    /// </summary>
    /// <remarks>
    ///  交易创建消息，当一笔订单创建时通知<br/>
    ///  https://doc.youzanyun.com/detail/MSG/300
    /// </remarks>
    public class TradeTradecreateData
    {
        /// <summary>
        /// 应用id
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
        /// <summary>
        ///   client_id
        /// </summary>
        /// <example>
        /// 4e96eb2fbc4f24f26f
        /// </example>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        /// <summary>
        /// 业务消息的标识
        /// </summary>
        /// <example>
        /// E20201216171450086900211
        /// </example>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// 门店ID
        /// </summary>
        /// <example>
        /// 90731021
        /// </example>
        [JsonProperty("kdt_id")]
        public long KdtId { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        /// <example>
        /// 云测试店铺vCY6J191010191128200711
        /// </example>
        [JsonProperty("kdt_name")]
        public string KdtName { get; set; }
        /// <summary>
        ///   推送模式
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("mode")]
        public string Mode { get; set; }
        /// <summary>
        /// 经过UrlEncode(UTF-8)编码,需要解码
        /// </summary>
        /// <example>
        ///   信息集合
        /// </example>
        [JsonProperty("msg")]
        public string Msg { get; set; }
        /// <summary>
        /// 消息唯一标示
        /// </summary>
        /// <example>
        /// 1d2ba0ac-e08a-4979-bcdb-72b091088d3e
        /// </example>
        [JsonProperty("msg_id")]
        public string MsgId { get; set; }
        /// <summary>
        /// 连锁门店总店ID
        /// </summary>
        /// <example>
        /// 43387399
        /// </example>
        [JsonProperty("root_kdt_id")]
        public long RootKdtId { get; set; }
        /// <summary>
        /// 重发的次数
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("sendCount")]
        public int SendCount { get; set; }
        /// <summary>
        /// 防伪签名: MD5(client_id+msg+client_secrect)。不建议使用此字段，可以用请求头中的Event-Sign进行防伪验证
        /// </summary>
        /// <example>
        /// f48688ad0acc750383545b08f6893764
        /// </example>
        [JsonProperty("sign")]
        public string Sign { get; set; }
        /// <summary>
        /// 交易状态
        /// </summary>
        /// <example>
        /// WAIT_BUYER_PAY
        /// </example>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// false-非测试消息，true-测试消息
        /// </summary>
        /// <example>
        /// false  
        /// </example>
        [JsonProperty("test")]
        public bool? Test { get; set; }
        /// <summary>
        /// 消息业务类型
        /// </summary>
        /// <example>
        /// trade_TradeCreate
        /// </example>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 消息版本号；version用于相同的type,用于判断相同type消息的顺序性的问题,高版本覆盖低版本。注意：消息推送是无序的，多条消息type不同，不可以根据version判断顺序。
        /// </summary>
        /// <example>
        /// 1608186739
        /// </example>
        [JsonProperty("version")]
        public long Version { get; set; }

    }
}

