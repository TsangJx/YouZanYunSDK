using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.ShoppingGuide.Query
{
    public class AchievementsData
    {
        /// <summary>
        /// 操作返回的list
        /// </summary>
        [JsonProperty("achievement_list")]
        public List<AchievementListModel> AchievementList { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        /// <example>
        /// 30
        /// </example>
        [JsonProperty("total_results")]
        public long TotalResults { get; set; }
        /// <summary>
        /// 当前页条数
        /// </summary>
        /// <example>
        /// 20
        /// </example>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 当前页码
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("page_no")]
        public int PageNo { get; set; }
        public class AchievementListModel
        {
            /// <summary>
            /// 导购手机号
            /// </summary>
            /// <example>
            /// 13711111111
            /// </example>
            [JsonProperty("mobile")]
            public string Mobile { get; set; }
            /// <summary>
            /// 导购员提成详情，（一笔订单可能会有两笔业绩就会存在两个提成），触发返回多条记录。场景说明：1、客户与导购员A（门店A）存在专属关系。 1）导购员A关联的业绩方案（给专属导购业绩）。 2）导购员B关联的业绩方案（给销售导购业绩）。 2、客户在门店B通过导购员B进行下单，此时门店B产生的订单会有两笔业绩，分别是导购员A的专属业绩和导购员B的销售业绩
            /// </summary>
            [JsonProperty("commissions")]
            public List<CommissionsModel> Commissions { get; set; }
            /// <summary>
            /// 导购员订单业绩详情（一笔订单可能会有两笔业绩），触发返回多条记录。场景说明：1、客户与导购员A（门店A）存在专属关系。 1）导购员A关联的业绩方案（给专属导购业绩）。 2）导购员B关联的业绩方案（给销售导购业绩）。 2、客户在门店B通过导购员B进行下单，此时门店B产生的订单会有两笔业绩，分别是导购员A的专属业绩和导购员B的销售业绩
            /// </summary>
            [JsonProperty("achievements")]
            public List<AchievementsModel> Achievements { get; set; }
            /// <summary>
            /// 订单金额,单位：元，最大支持小数点后两位。
            /// </summary>
            /// <example>
            /// 73.80
            /// </example>
            [JsonProperty("order_money")]
            public string OrderMoney { get; set; }
            /// <summary>
            /// 导购ID
            /// </summary>
            /// <example>
            /// 8888
            /// </example>
            [JsonProperty("yz_open_id")]
            public string YzOpenId { get; set; }
            /// <summary>
            /// 退款状态：0-"未退款"，1-"部分退款中"，2-"部分退款成功"，11-"全额退款中"，12-"全额退款成功"
            /// </summary>
            /// <example>
            /// 0
            /// </example>
            [JsonProperty("refund_state")]
            public int? RefundState { get; set; }
            /// <summary>
            /// 有赞订单号，E开头+年月日时分秒+随机数，长度24位字母和数字组合
            /// </summary>
            /// <example>
            /// E20190312105415047400001
            /// </example>
            [JsonProperty("tid")]
            public string Tid { get; set; }
            /// <summary>
            /// 支付金额（不减退款），单位：元，最大支持小数点后两位。
            /// </summary>
            /// <example>
            /// 73.80
            /// </example>
            [JsonProperty("pay_money")]
            public string PayMoney { get; set; }
            /// <summary>
            /// 退款时间（时间格式：yyyy-MM-dd HH:mm:ss）
            /// </summary>
            /// <example>
            /// 2021-05-01 10:36:16
            /// </example>
            [JsonProperty("refund_at")]
            public DateTime? RefundAt { get; set; }
            /// <summary>
            /// 订单状态：5-付款成功,7-取消订单,100-交易完成
            /// </summary>
            /// <example>
            /// 100
            /// </example>
            [JsonProperty("order_state")]
            public int? OrderState { get; set; }
            /// <summary>
            /// 订单创建时间
            /// </summary>
            /// <example>
            /// 2021-05-07 10:36:16
            /// </example>
            [JsonProperty("order_time")]
            public DateTime? OrderTime { get; set; }
            /// <summary>
            /// 退款金额,单位：元，最大支持小数点后两位。
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("refund_money")]
            public string RefundMoney { get; set; }
            public class CommissionsModel
            {
                /// <summary>
                /// 提成类型：0-比例，1-固定金额, 2-mix 
                /// </summary>
                /// <example>
                /// 0
                /// </example>
                [JsonProperty("cps_type")]
                public int? CpsType { get; set; }
                /// <summary>
                /// 提成金额，单位：元，最大支持小数点后两位。
                /// </summary>
                /// <example>
                /// 73.80
                /// </example>
                [JsonProperty("commission_amount")]
                public string CommissionAmount { get; set; }
                /// <summary>
                /// 结算类型：0-人工结算，1-自动结算
                /// </summary>
                /// <example>
                /// 1
                /// </example>
                [JsonProperty("settle_type")]
                public int? SettleType { get; set; }
                /// <summary>
                /// 导购类型 ：10-销售导购  30-专属导购
                /// </summary>
                /// <example>
                /// 10
                /// </example>
                [JsonProperty("shopping_guide_type")]
                public int? ShoppingGuideType { get; set; }
                /// <summary>
                /// 结算状态：10待结算，11-待认证后结算，12-结算中，13-延时结算，20-结算失败等待重试，30-已结算
                /// </summary>
                /// <example>
                /// 30
                /// </example>
                [JsonProperty("settle_state")]
                public int? SettleState { get; set; }

            }
            public class AchievementsModel
            {
                /// <summary>
                /// 导购类型 ：10-销售导购  30-专属导购
                /// </summary>
                /// <example>
                /// 10
                /// </example>
                [JsonProperty("shopping_guide_type")]
                public int? ShoppingGuideType { get; set; }
                /// <summary>
                /// 扣除业绩金额，单位：元，最大支持小数点后两位。
                /// </summary>
                /// <example>
                /// 0.00
                /// </example>
                [JsonProperty("refund_achievement_amount")]
                public string RefundAchievementAmount { get; set; }
                /// <summary>
                /// 初始业绩金额，单位：元，最大支持小数点后两位。
                /// </summary>
                /// <example>
                /// 0.00
                /// </example>
                [JsonProperty("origin_achievement_amount")]
                public string OriginAchievementAmount { get; set; }
                /// <summary>
                /// 实际业绩金额，单位：元，最大支持小数点后两位。
                /// </summary>
                /// <example>
                /// 0.00
                /// </example>
                [JsonProperty("achievement_amount")]
                public string AchievementAmount { get; set; }

            }

        }

    }
}

