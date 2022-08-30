using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Guide.Relation.Query
{
    public class UseridV2Data
    {
        /// <summary>
        /// 导购员用户Id
        /// </summary>
        /// <example>
        /// UbaDkD1Y572477541529440256
        /// </example>
        [JsonProperty("guide_yz_open_id")]
        public string GuideYzOpenId { get; set; }
        /// <summary>
        /// 是否有效;true:有效，false：无效
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("is_valid")]
        public bool? IsValid { get; set; }
        /// <summary>
        /// 绑定时间
        /// </summary>
        /// <example>
        /// 1650297600000
        /// </example>
        [JsonProperty("bind_at")]
        public DateTime? BindAt { get; set; }
        /// <summary>
        /// 客户用户Id
        /// </summary>
        /// <example>
        /// UbaDkD1Y572477541529440256
        /// </example>
        [JsonProperty("cust_yz_open_id")]
        public string CustYzOpenId { get; set; }
        /// <summary>
        /// 剩余有效期(天)。永久返回Integer.MAX_VALUE
        /// </summary>
        /// <example>
        /// 1650297600000
        /// </example>
        [JsonProperty("last_valid_time")]
        public int? LastValidTime { get; set; }
        /// <summary>
        /// 有赞连锁总部店铺id，仅供有赞连锁场景下使用。有赞平台生成，在有赞平台唯一，用于判断信息属于哪一个总部
        /// </summary>
        /// <example>
        /// 232423
        /// </example>
        [JsonProperty("root_kdt_id")]
        public long? RootKdtId { get; set; }
        /// <summary>
        /// 失效时间
        /// </summary>
        /// <example>
        /// 1650297600000
        /// </example>
        [JsonProperty("invalid_at")]
        public DateTime? InvalidAt { get; set; }
        /// <summary>
        /// 客户关系更新时间
        /// </summary>
        /// <example>
        /// 1650297600000
        /// </example>
        [JsonProperty("refresh_at")]
        public DateTime? RefreshAt { get; set; }
        /// <summary>
        /// 2pos导购，1:付费导购
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("guide_type")]
        public int? GuideType { get; set; }

    }
}