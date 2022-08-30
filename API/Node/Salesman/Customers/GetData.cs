using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Customers
{
    public class GetData
    {
        /// <summary>
        /// 所有销售员分组信息
        /// </summary>
        public List<CustomerInfo> Customers { get; set; }
        [JsonProperty("total_results")]
        public long TotalResults { get; set; }
        public class CustomerInfo
        {
            public string Nickname { get; set; }
            [JsonProperty("ct_uid")]
            public long CtUid { get; set; }
            [JsonProperty("is_valid")]
            public bool IsValid { get; set; }
            [JsonProperty("invalid_reason")]
            public string InvalidReason { get; set; }
            [JsonProperty("avatar")]
            public string Avatar { get; set; }
            [JsonProperty("ct_yz_open_id")]
            public string CtYZOpenId { get; set; }
            [JsonProperty("relation_id")]
            public long RelationId { get; set; }
            [JsonProperty("all_channel_name")]
            public List<string> AllChannelName { get; set; }
        }
    }
}
