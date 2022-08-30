using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Scrm.Customer
{
    public class CreateData
    {
        /// <summary>
        /// 帐号ID
        /// </summary>
        /// <example>
        /// 888888
        /// </example>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        /// <summary>
        /// 有赞yz_open_id
        /// </summary>
        /// <example>
        /// 22323sdf-dfsdFFYmk68NpA-yI8
        /// </example>
        [JsonProperty("yz_open_id")]
        public string YzOpenId { get; set; }
        /// <summary>
        /// 帐号类型。目前支持以下选项（只支持传一种）： FansID：自有粉丝ID， Mobile：手机号， YouZanAccount：有赞账号
        /// </summary>
        /// <example>
        /// YouZanAccount
        /// </example>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

    }
}
