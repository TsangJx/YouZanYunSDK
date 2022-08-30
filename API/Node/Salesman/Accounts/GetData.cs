using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Accounts
{
    public class GetData
    {
        /// <summary>
        /// 所有销售员分组信息
        /// </summary>
        public List<AccountInfo> Accounts { get; set; }
        [JsonProperty("total_results")]
        public long TotalResults { get; set; }
        public class AccountInfo : EntityOperateTime
        {
            [JsonProperty("from_buyer_mobile")]
            public string FromBuyerMobile { get; set; }
            [JsonProperty("group_name")]
            public string GroupName { get; set; }
            [JsonProperty("yz_open_id")]
            public string YZOpenId { get; set; }
            public string Seller { get; set; }
            public string Mobile { get; set; }
            public int Level { get; set; }
            [JsonProperty("order_num")]
            public int OrderNum { get; set; }
            [JsonProperty("kdt_id")]
            public int KdtId { get; set; }
            public string Money { get; set; }
            [JsonProperty("fans_id")]
            public int FansId { get; set; }
            public string Nickname { get; set; }
        }
    }
}
