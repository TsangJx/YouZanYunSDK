using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Customer
{
    public class QueryRowItem
    {
        [JsonProperty("kdt_id")]
        public long KdtId { get; set; }
        [JsonProperty("yz_open_id")]
        public long YZOpenId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
    }
}
