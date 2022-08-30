using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Customer.Relation
{
    public class QueryData
    {
        public string Mobile { get; set; }
        [JsonProperty("is_bind")]
        public long IsBind { get; set; }
        [JsonProperty("nick_name")]
        public long Nickname { get; set; }
        public string Avatar { get; set; }
        [JsonProperty("kdt_id")]
        public long KdtId { get; set; }
        [JsonProperty("alesman_yz_open_id")]
        public long SalesmanYZOpenId { get; set; }
    }
}
