using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Guide.Relation.Query.UseridV2ArgsModels
{
    public class RequestModel
    {
        /// <summary>
        /// 客户有赞openId
        /// </summary>
        /// <example>
        /// UbaDkD1Y572477541529440256
        /// </example>
        [Required]
        [JsonProperty("cust_yz_open_id")]
        public string CustYzOpenId { get; set; }

    }
}