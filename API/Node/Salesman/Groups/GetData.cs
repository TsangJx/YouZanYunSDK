using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Groups
{
    public class GetData
    {
        /// <summary>
        /// 所有销售员分组信息
        /// </summary>
        public List<GroupInfo> Groups { get; set; }
        [JsonProperty("total_results")]
        public long TotalResults { get; set; }
        public class GroupInfo : EntityOperateTime
        {
            [JsonProperty("kdt_id")]
            public long KdtId { get; set; }
            [JsonProperty("group_id")]
            public long GroupId { get; set; }
            [JsonProperty("last_operator")]
            public string LastOperator { get; set; }
            [JsonProperty("group_name")]
            public string GroupName { get; set; }
        }
    }
}
