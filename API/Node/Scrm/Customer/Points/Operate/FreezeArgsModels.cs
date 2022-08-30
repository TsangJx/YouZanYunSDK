using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Scrm.Customer.Points.Operate.FreezeArgsModels
{
    public class ParamsModel
    {
        /// <summary>
        /// 用户
        /// </summary>
        [JsonProperty("user")]
        public UserModel User { get; set; }
        /// <summary>
        /// 积分变动原因
        /// </summary>
        /// <example>
        /// 积分变动原因
        /// </example>
        [JsonProperty("reason")]
        public string Reason { get; set; }
        /// <summary>
        /// 业务唯一标示，如订单号
        /// </summary>
        /// <example>
        /// E333
        /// </example>
        [Required]
        [JsonProperty("biz_value")]
        public string BizValue { get; set; }
        /// <summary>
        /// 冻结积分值
        /// </summary>
        /// <example>
        /// 2
        /// </example>
        [Required]
        [JsonProperty("points")]
        public int Points { get; set; }
        /// <summary>
        /// 二级唯一索引，如传入，则与bizValue共同唯一决定一次积分操作
        /// </summary>
        /// <example>
        /// 123
        /// </example>
        [JsonProperty("biz_token")]
        public string BizToken { get; set; }
        /// <summary>
        /// 消费类型: 100：积分商城，101：退款，102：积分抵现，103：营销逆向退积分，201：外部系统
        /// </summary>
        /// <example>
        /// 102
        /// </example>
        [Required]
        [JsonProperty("consume_type")]
        public int ConsumeType { get; set; }
        public class UserModel
        {
            /// <summary>
            /// 操作人名字，可选字段
            /// </summary>
            /// <example>
            /// 小明
            /// </example>
            [JsonProperty("operator_name")]
            public string OperatorName { get; set; }
            /// <summary>
            /// 帐号类型（支持的用户账号类型 1-有赞粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id) ; 2-手机号; 3-三方帐号(原open_user_id:三方App用户ID，该参数仅限购买App开店插件的商家使用) ;5-有赞用户id，用户在有赞的唯一id。推荐使用）
            /// </summary>
            /// <example>
            /// 5
            /// </example>
            [Required]
            [JsonProperty("account_type")]
            public int AccountType { get; set; }
            /// <summary>
            /// 帐号ID
            /// </summary>
            /// <example>
            /// 123
            /// </example>
            [Required]
            [JsonProperty("account_id")]
            public string AccountId { get; set; }

        }

    }
}
