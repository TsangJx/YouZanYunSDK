using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Trades.Get
{
    public class PaymentData
    {
        /// <summary>
        /// 付款信息
        /// </summary>
        [JsonProperty("payment_info")]
        public PaymentInfoModel PaymentInfo { get; set; }
        /// <summary>
        /// 支付时间 格式: yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>
        /// 2021-06-02 13:42:09
        /// </example>
        [JsonProperty("pay_time")]
        public string PayTime { get; set; }
        /// <summary>
        /// 订单发货时间 格式: yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>
        /// 2021-06-05 12:49:07
        /// </example>
        [JsonProperty("express_time")]
        public string ExpressTime { get; set; }
        /// <summary>
        /// 买家订单号，E开头+年月日时分秒+随机数，长度24位字母和数字组合
        /// </summary>
        /// <example>
        /// E20190312105415047400001
        /// </example>
        [JsonProperty("tid")]
        public string Tid { get; set; }
        /// <summary>
        /// 订单关闭时间 格式: yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>
        /// 2021-06-04 12:49:07
        /// </example>
        [JsonProperty("close_time")]
        public string CloseTime { get; set; }
        /// <summary>
        /// 下单时间 格式: yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>
        /// 2021-06-02 12:49:07
        /// </example>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }
        /// <summary>
        /// 订单完成时间 格式: yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>
        /// 2021-06-03 09:00:14
        /// </example>
        [JsonProperty("success_time")]
        public string SuccessTime { get; set; }
        public class PaymentInfoModel
        {
            /// <summary>
            /// 推广佣金 单位:元
            /// </summary>
            /// <example>
            /// 7.00
            /// </example>
            [JsonProperty("fx_rebate_fee")]
            public string FxRebateFee { get; set; }
            /// <summary>
            /// 实付金额 单位:元
            /// </summary>
            /// <example>
            /// 15.00
            /// </example>
            [JsonProperty("real_pay")]
            public string RealPay { get; set; }
            /// <summary>
            /// 支付方式
            /// </summary>
            /// <example>
            /// 店铺余额支付
            /// </example>
            [JsonProperty("pay_way_desc")]
            public string PayWayDesc { get; set; }

        }

    }
}

