using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Account.Score
{
    public class SearchData
    {
        /// <summary>
        /// 分销员业绩统计项
        /// </summary>
        [JsonProperty("accumulations")]
        public List<AccumulationsModel> Accumulations { get; set; }
        /// <summary>
        /// 记录总数
        /// </summary>
        /// <example>
        /// 1234
        /// </example>
        [JsonProperty("total_results")]
        public long? TotalResults { get; set; }
        public class AccumulationsModel
        {
            /// <summary>
            /// 人工待结算佣金
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("manual_wait_settle_money")]
            public string ManualWaitSettleMoney { get; set; }
            /// <summary>
            /// 待结算人工结算邀请奖励
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("manual_wait_bonus_money")]
            public string ManualWaitBonusMoney { get; set; }
            /// <summary>
            /// 已结算推广奖励
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("cps_money")]
            public string CpsMoney { get; set; }
            /// <summary>
            /// 待结算邀请奖励金额
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("wait_bonus_money")]
            public string WaitBonusMoney { get; set; }
            /// <summary>
            /// 已结算邀请奖励金额
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("bonus_money")]
            public string BonusMoney { get; set; }
            /// <summary>
            /// 自动结算推广订单数
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [JsonProperty("auto_settle_order_num")]
            public int? AutoSettleOrderNum { get; set; }
            /// <summary>
            /// 昵称
            /// </summary>
            /// <example>
            /// wf测试
            /// </example>
            [JsonProperty("nickname")]
            public string Nickname { get; set; }
            /// <summary>
            /// 待结算推广奖励
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("wait_cps_money")]
            public string WaitCpsMoney { get; set; }
            /// <summary>
            /// 有效邀请人数
            /// </summary>
            /// <example>
            /// 22
            /// </example>
            [JsonProperty("invite_num")]
            public int? InviteNum { get; set; }
            /// <summary>
            /// 销售员手机号
            /// </summary>
            /// <example>
            /// 12345675432
            /// </example>
            [JsonProperty("mobile")]
            public string Mobile { get; set; }
            /// <summary>
            /// 人工结算推广订单数
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [JsonProperty("manual_settle_order_num")]
            public int? ManualSettleOrderNum { get; set; }
            /// <summary>
            /// 已结算佣金
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("settle_money")]
            public string SettleMoney { get; set; }
            /// <summary>
            /// 已结算人工结算推广奖励
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("manual_cps_money")]
            public string ManualCpsMoney { get; set; }
            /// <summary>
            /// 自动结算推广订单金额
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("auto_settle_order_amount")]
            public string AutoSettleOrderAmount { get; set; }
            /// <summary>
            /// 人工结算推广订单金额
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("manual_settle_order_amount")]
            public string ManualSettleOrderAmount { get; set; }
            /// <summary>
            /// 已结算人工结算邀请奖励
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("manual_bonus_money")]
            public string ManualBonusMoney { get; set; }
            /// <summary>
            /// 待结算佣金
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("wait_settle_money")]
            public string WaitSettleMoney { get; set; }
            /// <summary>
            /// 人工已结算佣金
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("manual_settle_money")]
            public string ManualSettleMoney { get; set; }
            /// <summary>
            /// 待结算人工结算推广奖励
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("manual_wait_cps_money")]
            public string ManualWaitCpsMoney { get; set; }
            /// <summary>
            /// 客户关系数量
            /// </summary>
            /// <example>
            /// 11
            /// </example>
            [JsonProperty("customer_num")]
            public int? CustomerNum { get; set; }

        }

    }
}

