using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Crm.Customer.Points
{
    public class GetData
    {
        /// <summary>
        /// 当前积分值
        /// </summary>
        /// <example>
        /// 24
        /// </example>
        [JsonProperty("point")]
        public long? Point { get; set; }

    }
}