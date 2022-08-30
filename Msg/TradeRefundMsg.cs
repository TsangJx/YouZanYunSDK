using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZanYun.Msg
{
    public class TradeRefundMsg
    {
        /// <summary>
        /// 交易明细id
        /// </summary>
        [JsonProperty("oids")]
        public string OIds { get; set; }
        [JsonProperty("refunded_fee")]
        public decimal RefundedFee { get; set; }
        [JsonProperty("refund_id")]
        public string RefundId { get; set; }
        [JsonProperty("refund_reason")]
        public string RefundReason { get; set; }
        [JsonProperty("refund_reason_desc")]
        public string RefundReasonDesc { get; set; }
        [JsonProperty("refund_type")]
        public string RefundType { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("tid")]
        public string TId { get; set; }
        [JsonProperty("update_time")]
        public DateTime UpdateTime { get; set; }
    }
}
