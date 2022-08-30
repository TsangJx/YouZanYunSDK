using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Scrm.Customer.Points.Rule
{
    public class ListData
    {
        /// <summary>
        /// 规则数组
        /// </summary>
        [JsonProperty("rules")]
        public List<RulesModel> Rules { get; set; }
        public class RulesModel
        {
            /// <summary>
            /// 积分奖励分值
            /// </summary>
            /// <example>
            /// 2
            /// </example>
            [JsonProperty("give_points")]
            public long? GivePoints { get; set; }
            /// <summary>
            /// 是否需要关注公众号，1:是，0:否
            /// </summary>
            /// <example>
            /// 0
            /// </example>
            [JsonProperty("fans_follow")]
            public int? FansFollow { get; set; }
            /// <summary>
            /// 交易次数达到trade_limit次才发放积分
            /// </summary>
            /// <example>
            /// 0
            /// </example>
            [JsonProperty("trade_limit")]
            public int? TradeLimit { get; set; }
            /// <summary>
            /// 规则名称
            /// </summary>
            /// <example>
            /// 每购买金额2.00元
            /// </example>
            [JsonProperty("rule_name")]
            public string RuleName { get; set; }
            /// <summary>
            /// 交易金额达到amount_limit（元)才发放积分
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("amount_limit")]
            public string AmountLimit { get; set; }
            /// <summary>
            /// 规则id
            /// </summary>
            /// <example>
            /// 1151400
            /// </example>
            [JsonProperty("rule_id")]
            public long? RuleId { get; set; }
            /// <summary>
            /// 是否给客户发送获得了积分的通知（以微信模版消息的方式），1:是，0:否
            /// </summary>
            /// <example>
            /// 0
            /// </example>
            [JsonProperty("is_send_notice")]
            public int? IsSendNotice { get; set; }
            /// <summary>
            /// 若为部分商品参与的规则，才会返回参与商品id列表
            /// </summary>
            /// <example>
            /// [936498790, 937966368]
            /// </example>
            [JsonProperty("item_ids")]
            public List<long> ItemIds { get; set; }

        }

    }
}
