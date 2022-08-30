using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Crm.Customer.Points.DecreaseV4ArgsModels
{
    public class ParamsModel
    {
        /// <summary>
        /// 积分变动原因
        /// </summary>
        /// <example>
        /// 删帖扣除积分
        /// </example>
        [Required]
        [JsonProperty("reason")]
        public string Reason { get; set; }
        /// <summary>
        /// 请确保业务唯一标识唯一性，相同唯一标识，接口只会进行一次扣减。
        /// </summary>
        /// <example>
        /// DE20190820001
        /// </example>
        [JsonProperty("biz_value")]
        public string BizValue { get; set; }
        /// <summary>
        /// 是否检验客户信息 默认false
        /// </summary>
        /// <example>
        /// true
        /// </example>
        [JsonProperty("check_customer")]
        public bool? CheckCustomer { get; set; }
        /// <summary>
        /// 积分变动值
        /// </summary>
        /// <example>
        /// 10
        /// </example>
        [Required]
        [JsonProperty("points")]
        public int Points { get; set; }
        /// <summary>
        /// 是否需要走扩展点，默认：true(false走内部逻辑)
        /// </summary>
        /// <example>
        /// true
        /// </example>
        [JsonProperty("is_do_ext_point")]
        public bool? IsDoExtPoint { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        [Required]
        [JsonProperty("user")]
        public UserModel User { get; set; }
        public class UserModel
        {
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
            /// 1245
            /// </example>
            [Required]
            [JsonProperty("account_id")]
            public string AccountId { get; set; }

        }

    }
}