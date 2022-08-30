using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Msg
{
    /// <summary>
    /// trade_TradeBuyerPay
    /// </summary>
    /// <remarks>
    ///  买家付款完成创建消息<br/>
    ///  https://doc.youzanyun.com/detail/MSG/302
    /// </remarks>
    public class TradeTradebuyerpayData
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
        /// 你的client_id
        /// </summary>
        /// <example>
        /// 50535be20334f52771
        /// </example>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        /// <summary>
        /// 连锁总部kdtId，如果非连锁店铺，总部kdtId可能为空
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("head_kdt_id")]
        public long HeadKdtId { get; set; }
        /// <summary>
        /// 业务消息的标识，如果有值返回为为您的订单号
        /// </summary>
        /// <example>
        /// E20210604153031018604175
        /// </example>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// 店铺ID
        /// </summary>
        /// <example>
        /// 63077
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
        /// 默认参数无需关注
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
        /// a1d466ad-f9db-4a58-b805-f2a4dd65fa56
        /// </example>
        [JsonProperty("msg_id")]
        public string MsgId { get; set; }
        /// <summary>
        /// 连锁门店总店ID
        /// </summary>
        /// <example>
        /// 63072
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
        public int? SendCount { get; set; }
        /// <summary>
        /// 防伪签名: MD5(client_id+msg+client_secrect)。不建议使用此字段，可以用请求头中的Event-Sign进行防伪验证
        /// </summary>
        /// <example>
        /// d36a94636ca855e6bf4364afb9586d88
        /// </example>
        [JsonProperty("sign")]
        public string Sign { get; set; }
        /// <summary>
        /// 主订单状态 WAIT_BUYER_PAY （等待买家付款）； TRADE_PAID（订单已支付 ）； WAIT_CONFIRM（待确认，包含待成团、待接单等等。即：买家已付款，等待成团或等待接单）； WAIT_SELLER_SEND_GOODS（等待卖家发货，即：买家已付款）； WAIT_BUYER_CONFIRM_GOODS (等待买家确认收货，即：卖家已发货) ； TRADE_SUCCESS（买家已签收以及订单成功）； TRADE_CLOSED（交易关闭）； PS：TRADE_PAID状态仅代表当前订单已支付成功，表示瞬时状态，稍后会自动修改成后面的状态。如果不关心此状态请再次请求详情接口获取下一个状态。
        /// </summary>
        /// <example>
        /// WAIT_BUYER_PAY
        /// </example>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// 已废弃，开发者无需关注
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
        /// trade_TradeBuyerPay
        /// </example>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 消息版本号,为了解决顺序性的问题,高版本覆盖低版本
        /// </summary>
        /// <example>
        /// 1516245348962
        /// </example>
        [JsonProperty("version")]
        public long Version { get; set; }

    }
}

