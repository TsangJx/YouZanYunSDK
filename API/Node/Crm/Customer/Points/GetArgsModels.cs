using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Crm.Customer.Points.GetArgsModels
{
    public class UserModel
    {
        /// <summary>
        /// 帐号类型（支持的用户账号类型 1-有赞粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id) ; 2-手机号; 3-三方帐号(原open_user_id:三方App用户ID，该参数仅限购买App开店插件的商家使用) ;5-yzOpenId，用户在有赞的唯一id。推荐使用）
        /// </summary>
        /// <example>
        /// 2
        /// </example>
        [Required]
        [JsonProperty("account_type")]
        public int AccountType { get; set; }
        /// <summary>
        /// 帐号ID
        /// </summary>
        /// <example>
        /// 18972515558
        /// </example>
        [Required]
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

    }
}