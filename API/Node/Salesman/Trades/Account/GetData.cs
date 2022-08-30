using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Trades.Account
{
    public class GetData
    {
        /// <summary>
        /// 销售员手机号
        /// </summary>
        /// <example>
        /// 13456900***
        /// </example>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

    }
}