using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Trade.Refund
{
    public class SearchV3Data
    {
        /// <summary>
        /// 退款信息
        /// </summary>
        [JsonProperty("refunds")]
        public List<RefundsModel> Refunds { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("total")]
        public int? Total { get; set; }
        public class RefundsModel
        {
            /// <summary>
            /// 退款申请时间 如 2017-01-01 00:00:01
            /// </summary>
            /// <example>
            /// 2019-03-21 20:50:03
            /// </example>
            [JsonProperty("created")]
            public string Created { get; set; }
            /// <summary>
            /// 退款状态:WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意)，WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货)，WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货)，SELLER_REFUSE_BUYER(卖家拒绝退款)，CLOSED(退款关闭)，SUCCESS(退款成功),CUSTOMER_SERVICE_IN(客满介入),SELLER_REFUSE_BUYER_RETURN_GOODS(卖家拒绝收货，等待买家处理),SELLER_RETURN_GOODS(卖家拒绝收货，等待买家处理)
            /// </summary>
            /// <example>
            /// SUCCESS
            /// </example>
            [JsonProperty("status")]
            public string Status { get; set; }
            /// <summary>
            /// 订单号
            /// </summary>
            /// <example>
            /// E20190321204808058800020
            /// </example>
            [JsonProperty("tid")]
            public string Tid { get; set; }
            /// <summary>
            /// 申请退款的金额 如:0.01元
            /// </summary>
            /// <example>
            /// 0.01
            /// </example>
            [JsonProperty("refund_fee")]
            public string RefundFee { get; set; }
            /// <summary>
            /// 客满介入状态： 1（客满未介入），2（客满介入中）。
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [JsonProperty("cs_status")]
            public int? CsStatus { get; set; }
            /// <summary>
            /// 发货状态：1-未发货，2-已发货
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [JsonProperty("delivery_status")]
            public int? DeliveryStatus { get; set; }
            /// <summary>
            /// 退款申请修改时间 如 2017-01-01 00:00:01
            /// </summary>
            /// <example>
            /// 2019-03-21 20:49:30
            /// </example>
            [JsonProperty("modified")]
            public string Modified { get; set; }
            /// <summary>
            /// 子店kdtId
            /// </summary>
            /// <example>
            /// 670
            /// </example>
            [JsonProperty("node_kdt_id")]
            public long? NodeKdtId { get; set; }
            /// <summary>
            /// 是否退货
            /// </summary>
            /// <example>
            /// false
            /// </example>
            [JsonProperty("return_goods")]
            public bool? ReturnGoods { get; set; }
            /// <summary>
            /// 店铺ID
            /// </summary>
            /// <example>
            /// 18163424
            /// </example>
            [JsonProperty("kdt_id")]
            public long? KdtId { get; set; }
            /// <summary>
            /// 退款ID
            /// </summary>
            /// <example>
            /// 201903221457250000030006
            /// </example>
            [JsonProperty("refund_id")]
            public string RefundId { get; set; }
            /// <summary>
            /// (仅退款-已收到货申请原因) 1: 买/卖双方协商一致;2: 买错/多买/不想要;3: 商品质量问题;4: 未收到货品';5: 其他;11: 质量问题;12: 拍错/多拍/不喜欢;13: 商品描述不符;14: 假货;15: 商家发错货;16: 商品破损/少件;17: 其他;18: 退运费;19: 协商一致退款;20: 快递一直未送达;21: 未按约定时间发货;22: 拍错/不想要;23: 计划有变无法使用;24: 商家降价; (仅退款-未收到货申请原因) 51: 买错/多买/不想要;52: 快递无记录;53: 少货/空包裹;54: 未按约定时间发货;55: 快递一直未送达;56: 其他;57: 拍错/多拍/不喜欢;58: (退货退款-申请原因) 协商一致退款;101: 商品破损/少件;102: 商家发错货;103: 商品描述不符;104: 拍错/多拍/不喜欢;105: 质量问题;106: 假货;107: 其他;108: 做工粗糙/有瑕疵;109: 非正品;110: (系统退款原因) 未按约定时间发货;201: 返现退款;202: 酒店拒单退款;204: 订单关闭退款;205: 代付过期退款;206: 超付退款;207: 外卖拒单退款;208: 拼团未成团退款;209: 团购返现退款;211: 订单少付退款;212: 小程序拼团退款;
            /// </summary>
            /// <example>
            /// 54
            /// </example>
            [JsonProperty("reason")]
            public int? Reason { get; set; }

        }

    }
}
